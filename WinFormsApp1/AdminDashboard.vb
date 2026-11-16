Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Private ReadOnly ActiveMenuColor As Color = Color.FromArgb(114, 142, 109)
    Private ReadOnly InactiveMenuColor As Color = Color.FromArgb(46, 82, 72)
    Private ReadOnly LowProgressColor As Color = Color.FromArgb(176, 42, 55)

    Public Property Username As String
    Public Property LoginForm As Form

    Private loggingOut As Boolean
    Private loadingProgres As Boolean
    Private populatingGrids As Boolean
    Private selectedDosenId As Integer?
    Private selectedMkId As Integer?

    Public Sub New()
        InitializeComponent()

        StyleGrid(dgvProgres)
        StyleGrid(dgvDosen)
        StyleGrid(dgvMk)
    End Sub

    Private Async Sub AdminDashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblRole.Text = If(String.IsNullOrWhiteSpace(Username), "Admin", $"Admin: {Username}")
        Await ShowSectionAsync(btnProgres)
    End Sub

    ' ---------- Navigation ----------

    Private Async Sub SidebarMenu_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnProgres.Click, btnKelola.Click

        Await ShowSectionAsync(DirectCast(sender, Button))
    End Sub

    Private Async Function ShowSectionAsync(menu As Button) As Task
        btnProgres.BackColor = If(menu Is btnProgres, ActiveMenuColor, InactiveMenuColor)
        btnKelola.BackColor = If(menu Is btnKelola, ActiveMenuColor, InactiveMenuColor)

        pnlProgres.Visible = menu Is btnProgres
        pnlKelola.Visible = menu Is btnKelola

        If menu Is btnProgres Then
            Await LoadProgresAsync()
        Else
            Await LoadKelolaAsync()
        End If
    End Function

    ' ---------- Progres EDOM ----------

    Private Async Function LoadProgresAsync() As Task
        If loadingProgres Then Return
        loadingProgres = True
        btnRefresh.Enabled = False

        lblProgresSummary.Text = "Memuat data..."
        ShowProgresState("Memuat progres EDOM...", showRetry:=False)

        Try
            Dim ringkasan As RingkasanProgres = Await Task.Run(AddressOf DatabaseHelper.GetRingkasanProgres)
            RenderProgres(ringkasan)
            lblLastUpdated.Text = $"Diperbarui pukul {DateTime.Now:HH.mm}"
        Catch ex As Exception
            lblProgresSummary.Text = "Progres belum bisa ditampilkan."
            ShowProgresState(DatabaseHelper.DescribeError(ex), showRetry:=True)
        Finally
            loadingProgres = False
            btnRefresh.Enabled = True
        End Try
    End Function

    Private Sub RenderProgres(ringkasan As RingkasanProgres)
        dgvProgres.Rows.Clear()

        If ringkasan.PerMataKuliah.Count = 0 Then
            lblProgresSummary.Text = "Belum ada mata kuliah yang bisa dievaluasi."
            ShowProgresState(
                "Tambahkan dosen dan mata kuliah lewat menu Dosen & Mata Kuliah. Progres muncul di sini setelah mahasiswa mulai mengisi.",
                showRetry:=False)
            Return
        End If

        Dim total As Integer = ringkasan.TotalMahasiswa

        If total = 0 Then
            lblProgresSummary.Text = "Belum ada akun mahasiswa, jadi persentase belum bisa dihitung."
        Else
            lblProgresSummary.Text =
                $"{ringkasan.MahasiswaSelesai} dari {total} mahasiswa sudah menyelesaikan semua evaluasi."
        End If

        For Each item As ProgresMataKuliah In ringkasan.PerMataKuliah
            Dim belum As Integer = Math.Max(0, total - item.Sudah)
            Dim persenText As String = "-"
            Dim persen As Double = 0

            If total > 0 Then
                persen = item.Sudah / total * 100
                persenText = $"{persen:0}%"
            End If

            Dim rowIndex As Integer = dgvProgres.Rows.Add(item.Nama, item.Dosen, item.Sudah, belum, persenText)

            ' Flag courses where fewer than half the students have filled it in.
            If total > 0 AndAlso persen < 50 Then
                Dim cell As DataGridViewCell = dgvProgres.Rows(rowIndex).Cells(colPPersen.Index)
                cell.Style.ForeColor = LowProgressColor
                cell.Style.SelectionForeColor = LowProgressColor
                cell.Style.Font = New Font(dgvProgres.Font, FontStyle.Bold)
            End If
        Next

        pnlProgresState.Visible = False
        dgvProgres.Visible = True
        dgvProgres.ClearSelection()
    End Sub

    Private Sub ShowProgresState(message As String, showRetry As Boolean)
        lblProgresState.Text = message
        btnProgresRetry.Visible = showRetry
        dgvProgres.Visible = False
        pnlProgresState.Visible = True
    End Sub

    Private Async Sub ProgresReload_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click, btnProgresRetry.Click

        Await LoadProgresAsync()
    End Sub

    ' ---------- Dosen & Mata Kuliah ----------

    Private Async Function LoadKelolaAsync() As Task
        lblKelolaError.Visible = False
        pnlDosenForm.Enabled = False
        pnlMkForm.Enabled = False

        Try
            Dim dosen As List(Of DosenItem) = Await Task.Run(AddressOf DatabaseHelper.GetDosen)
            Dim mataKuliah As List(Of MataKuliahItem) = Await Task.Run(AddressOf DatabaseHelper.GetMataKuliah)

            RenderKelola(dosen, mataKuliah)
            pnlDosenForm.Enabled = True
            pnlMkForm.Enabled = True
        Catch ex As Exception
            lblKelolaError.Text = DatabaseHelper.DescribeError(ex)
            lblKelolaError.Visible = True
        End Try
    End Function

    Private Sub RenderKelola(dosen As List(Of DosenItem), mataKuliah As List(Of MataKuliahItem))
        populatingGrids = True

        dgvDosen.Rows.Clear()
        For Each item As DosenItem In dosen
            Dim rowIndex As Integer = dgvDosen.Rows.Add(item.Nama, item.Nidn)
            dgvDosen.Rows(rowIndex).Tag = item
        Next

        dgvMk.Rows.Clear()
        For Each item As MataKuliahItem In mataKuliah
            Dim rowIndex As Integer = dgvMk.Rows.Add(item.Nama, item.DosenNama, item.Ruang)
            dgvMk.Rows(rowIndex).Tag = item
        Next

        cmbMkDosen.Items.Clear()
        cmbMkDosen.Items.AddRange(dosen.ToArray())

        dgvDosen.ClearSelection()
        dgvMk.ClearSelection()
        populatingGrids = False

        ClearDosenForm()
        ClearMkForm()
    End Sub

    ' Empty grids explain what to do instead of showing a blank box.
    Private Sub Grid_Paint(
        sender As Object,
        e As PaintEventArgs
    ) Handles dgvDosen.Paint, dgvMk.Paint

        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        If grid.Rows.Count > 0 OrElse Not pnlDosenForm.Enabled Then Return

        Dim message As String =
            If(grid Is dgvDosen,
               "Belum ada dosen. Isi nama di atas, lalu klik Tambah dosen.",
               "Belum ada mata kuliah. Tambahkan dosen dulu, lalu isi form di atas.")

        Dim area As New Rectangle(16, grid.ColumnHeadersHeight + 16, grid.Width - 32, 60)
        TextRenderer.DrawText(
            e.Graphics, message, grid.Font, area,
            Color.FromArgb(108, 117, 125),
            TextFormatFlags.WordBreak Or TextFormatFlags.Left)
    End Sub

    ' ----- Dosen -----

    Private Sub dgvDosen_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvDosen.SelectionChanged

        If populatingGrids Then Return

        Dim item As DosenItem = Nothing
        If dgvDosen.SelectedRows.Count > 0 Then
            item = TryCast(dgvDosen.SelectedRows(0).Tag, DosenItem)
        End If

        If item Is Nothing Then
            ClearDosenForm()
            Return
        End If

        selectedDosenId = item.Id
        txtDosenNama.Text = item.Nama
        txtDosenNidn.Text = item.Nidn
        lblDosenError.Text = ""
        btnDosenSimpan.Enabled = True
        btnDosenHapus.Enabled = True
    End Sub

    Private Async Sub btnDosenTambah_Click(sender As Object, e As EventArgs) Handles btnDosenTambah.Click
        If Not ValidateDosen() Then Return

        Dim nama As String = txtDosenNama.Text.Trim()
        Dim nidn As String = txtDosenNidn.Text.Trim()

        Await RunDosenActionAsync(Sub() DatabaseHelper.AddDosen(nama, nidn))
    End Sub

    Private Async Sub btnDosenSimpan_Click(sender As Object, e As EventArgs) Handles btnDosenSimpan.Click
        If Not selectedDosenId.HasValue OrElse Not ValidateDosen() Then Return

        Dim id As Integer = selectedDosenId.Value
        Dim nama As String = txtDosenNama.Text.Trim()
        Dim nidn As String = txtDosenNidn.Text.Trim()

        Await RunDosenActionAsync(Sub() DatabaseHelper.UpdateDosen(id, nama, nidn))
    End Sub

    Private Async Sub btnDosenHapus_Click(sender As Object, e As EventArgs) Handles btnDosenHapus.Click
        If Not selectedDosenId.HasValue Then Return

        Dim namaDosen As String = txtDosenNama.Text.Trim()
        Dim confirm As DialogResult = MessageBox.Show(
            $"Hapus dosen {namaDosen}? Seluruh mata kuliah yang diampu dan data pengisian EDOM terkait juga akan ikut terhapus.",
            "Konfirmasi Hapus Dosen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Return

        Dim id As Integer = selectedDosenId.Value
        Await RunDosenActionAsync(Sub() DatabaseHelper.DeleteDosen(id))
    End Sub

    Private Function ValidateDosen() As Boolean
        If txtDosenNama.Text.Trim().Length = 0 Then
            lblDosenError.Text = "Nama dosen belum diisi."
            txtDosenNama.Focus()
            Return False
        End If

        lblDosenError.Text = ""
        Return True
    End Function

    Private Async Function RunDosenActionAsync(action As Action) As Task
        pnlDosenForm.Enabled = False
        lblDosenError.Text = ""

        Try
            Await Task.Run(action)
            Await LoadKelolaAsync()
        Catch ex As Exception
            Dim sqlEx As MySqlException = TryCast(ex, MySqlException)
            If sqlEx Is Nothing AndAlso ex.InnerException IsNot Nothing Then
                sqlEx = TryCast(ex.InnerException, MySqlException)
            End If

            If sqlEx IsNot Nothing Then
                If sqlEx.Number = 1451 OrElse sqlEx.Number = 1217 Then
                    lblDosenError.Text = "Dosen ini masih terhubung dengan data lain di sistem."
                ElseIf sqlEx.Number = 1062 Then
                    lblDosenError.Text = "NIDN ini sudah dipakai dosen lain."
                Else
                    lblDosenError.Text = DatabaseHelper.DescribeError(ex)
                End If
            Else
                lblDosenError.Text = DatabaseHelper.DescribeError(ex)
            End If
        Finally
            pnlDosenForm.Enabled = True
        End Try
    End Function

    Private Sub ClearDosenForm()
        selectedDosenId = Nothing
        txtDosenNama.Clear()
        txtDosenNidn.Clear()
        lblDosenError.Text = ""
        btnDosenSimpan.Enabled = False
        btnDosenHapus.Enabled = False
    End Sub

    ' ----- Mata kuliah -----

    Private Sub dgvMk_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvMk.SelectionChanged

        If populatingGrids Then Return

        Dim item As MataKuliahItem = Nothing
        If dgvMk.SelectedRows.Count > 0 Then
            item = TryCast(dgvMk.SelectedRows(0).Tag, MataKuliahItem)
        End If

        If item Is Nothing Then
            ClearMkForm()
            Return
        End If

        selectedMkId = item.Id
        txtMkNama.Text = item.Nama
        txtMkRuang.Text = item.Ruang
        cmbMkDosen.SelectedItem =
            cmbMkDosen.Items.Cast(Of DosenItem)().FirstOrDefault(Function(d) d.Id = item.DosenId)
        lblMkError.Text = ""
        btnMkSimpan.Enabled = True
        btnMkHapus.Enabled = True
    End Sub

    Private Async Sub btnMkTambah_Click(sender As Object, e As EventArgs) Handles btnMkTambah.Click
        If Not ValidateMk() Then Return

        Dim nama As String = txtMkNama.Text.Trim()
        Dim ruang As String = txtMkRuang.Text.Trim()
        Dim dosenId As Integer = DirectCast(cmbMkDosen.SelectedItem, DosenItem).Id

        Await RunMkActionAsync(Sub() DatabaseHelper.AddMataKuliah(nama, ruang, dosenId))
    End Sub

    Private Async Sub btnMkSimpan_Click(sender As Object, e As EventArgs) Handles btnMkSimpan.Click
        If Not selectedMkId.HasValue OrElse Not ValidateMk() Then Return

        Dim id As Integer = selectedMkId.Value
        Dim nama As String = txtMkNama.Text.Trim()
        Dim ruang As String = txtMkRuang.Text.Trim()
        Dim dosenId As Integer = DirectCast(cmbMkDosen.SelectedItem, DosenItem).Id

        Await RunMkActionAsync(Sub() DatabaseHelper.UpdateMataKuliah(id, nama, ruang, dosenId))
    End Sub

    Private Async Sub btnMkHapus_Click(sender As Object, e As EventArgs) Handles btnMkHapus.Click
        If Not selectedMkId.HasValue Then Return

        Dim confirm As DialogResult = MessageBox.Show(
            $"Hapus mata kuliah {txtMkNama.Text.Trim()}? Data pengisian EDOM untuk mata kuliah ini ikut terhapus.",
            "Hapus Mata Kuliah",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Return

        Dim id As Integer = selectedMkId.Value
        Await RunMkActionAsync(Sub() DatabaseHelper.DeleteMataKuliah(id))
    End Sub

    Private Function ValidateMk() As Boolean
        If txtMkNama.Text.Trim().Length = 0 Then
            lblMkError.Text = "Nama mata kuliah belum diisi."
            txtMkNama.Focus()
            Return False
        End If

        If cmbMkDosen.SelectedItem Is Nothing Then
            lblMkError.Text =
                If(cmbMkDosen.Items.Count = 0,
                   "Belum ada dosen. Tambahkan dosen di sebelah kiri dulu.",
                   "Pilih dosen pengampu.")
            cmbMkDosen.Focus()
            Return False
        End If

        lblMkError.Text = ""
        Return True
    End Function

    Private Async Function RunMkActionAsync(action As Action) As Task
        pnlMkForm.Enabled = False
        lblMkError.Text = ""

        Try
            Await Task.Run(action)
            Await LoadKelolaAsync()
        Catch ex As Exception
            lblMkError.Text = DatabaseHelper.DescribeError(ex)
        Finally
            pnlMkForm.Enabled = True
        End Try
    End Function

    Private Sub ClearMkForm()
        selectedMkId = Nothing
        txtMkNama.Clear()
        txtMkRuang.Clear()
        cmbMkDosen.SelectedIndex = -1
        lblMkError.Text = ""
        btnMkSimpan.Enabled = False
        btnMkHapus.Enabled = False
    End Sub

    ' ---------- Shared ----------

    Private Shared Sub StyleGrid(grid As DataGridView)
        Dim ink As Color = Color.FromArgb(33, 37, 41)

        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.AllowUserToResizeRows = False
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.None
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grid.GridColor = Color.FromArgb(230, 228, 222)
        grid.MultiSelect = False
        grid.ReadOnly = True
        grid.RowHeadersVisible = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.RowTemplate.Height = 40

        grid.EnableHeadersVisualStyles = False
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grid.ColumnHeadersHeight = 42
        With grid.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(241, 239, 232)
            .ForeColor = ink
            .SelectionBackColor = Color.FromArgb(241, 239, 232)
            .SelectionForeColor = ink
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            .Padding = New Padding(10, 0, 0, 0)
        End With

        With grid.DefaultCellStyle
            .BackColor = Color.White
            .ForeColor = ink
            .SelectionBackColor = Color.FromArgb(236, 241, 234)
            .SelectionForeColor = ink
            .Font = New Font("Segoe UI", 10.0F)
            .Padding = New Padding(10, 0, 0, 0)
        End With
    End Sub

    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        Dim result As DialogResult =
            MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If result <> DialogResult.Yes Then Return

        loggingOut = True

        If LoginForm IsNot Nothing Then
            LoginForm.Show()
        End If

        Close()
    End Sub

    Private Sub AdminDashboard_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        If Not loggingOut Then
            Application.Exit()
        End If
    End Sub

End Class

