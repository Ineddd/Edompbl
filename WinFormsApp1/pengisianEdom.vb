Imports System.Drawing
Imports System.Windows.Forms

Public Class pengisianEdom

    Private ReadOnly ActiveMenuColor As Color = Color.FromArgb(114, 142, 109)
    Private ReadOnly InactiveMenuColor As Color = Color.FromArgb(46, 82, 72)

    Public Property Username As String
    Public Property LoginForm As Form
    Public Property DashboardForm As Dashboard

    Private loggingOut As Boolean
    Private navigatingBack As Boolean
    Private loadingData As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub pengisianEdom_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetActiveMenuButton(Button1)
        Await LoadEdomListAsync()
    End Sub

    Public Async Function LoadEdomListAsync() As Task
        If loadingData Then Return
        loadingData = True
        btnRefresh.Enabled = False

        ShowState("Memuat daftar dosen dan mata kuliah...", showRetry:=False)

        Try
            Dim uname As String = If(String.IsNullOrWhiteSpace(Username), "Mahasiswa", Username.Trim())
            Dim items As List(Of EdomMahasiswaItem) = Await Task.Run(Function() DatabaseHelper.GetEdomMahasiswa(uname))
            RenderCards(items)
        Catch ex As Exception
            ShowState(DatabaseHelper.DescribeError(ex), showRetry:=True)
        Finally
            loadingData = False
            btnRefresh.Enabled = True
        End Try
    End Function

    Private Sub RenderCards(items As List(Of EdomMahasiswaItem))
        pnlCardContainer.SuspendLayout()
        pnlCardContainer.Controls.Clear()

        If items Is Nothing OrElse items.Count = 0 Then
            ShowState("Belum ada data dosen atau mata kuliah yang tersedia untuk dievaluasi.", showRetry:=False)
            pnlCardContainer.ResumeLayout(True)
            Return
        End If

        pnlState.Visible = False
        pnlCardContainer.Visible = True

        Dim cardWidth As Integer = Math.Max(700, pnlCardContainer.ClientSize.Width - 30)

        For Each item In items
            Dim card As Panel = CreateDosenCard(item, cardWidth)
            pnlCardContainer.Controls.Add(card)
        Next

        pnlCardContainer.ResumeLayout(True)
    End Sub

    Private Function CreateDosenCard(item As EdomMahasiswaItem, cardWidth As Integer) As Panel
        Dim card As New Panel With {
            .BackColor = Color.White,
            .Size = New Size(cardWidth, 110),
            .Margin = New Padding(0, 0, 0, 16),
            .Tag = item
        }

        Dim nidnText As String = If(String.IsNullOrWhiteSpace(item.DosenNidn), "", $" ({item.DosenNidn})")
        Dim lblNama As New Label With {
            .Text = $"{item.DosenNama}{nidnText}",
            .Font = New Font("Segoe UI", 12.0F, FontStyle.Bold),
            .ForeColor = Color.FromArgb(30, 59, 51),
            .Location = New Point(28, 22),
            .AutoSize = True
        }

        Dim matkulText As String
        If item.MataKuliahId.HasValue Then
            Dim ruangText As String = If(String.IsNullOrWhiteSpace(item.Ruang), "-", item.Ruang)
            matkulText = $"Mata Kuliah: {item.MataKuliahNama}  |  Ruang {ruangText}"
        Else
            matkulText = "Belum ada mata kuliah yang diampu"
        End If

        Dim lblMatkul As New Label With {
            .Text = matkulText,
            .Font = New Font("Segoe UI", 9.5F),
            .ForeColor = Color.FromArgb(108, 117, 125),
            .Location = New Point(28, 58),
            .AutoSize = True
        }

        Dim btnEval As New Button With {
            .Size = New Size(190, 48),
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
            .Cursor = Cursors.Hand,
            .Tag = item
        }
        btnEval.FlatAppearance.BorderSize = 0

        Dim lblStatus As New Label With {
            .Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
            .AutoSize = True,
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right
        }

        If Not item.MataKuliahId.HasValue Then
            lblStatus.Text = "Belum Ada Matkul"
            lblStatus.ForeColor = Color.FromArgb(108, 117, 125)
            btnEval.Text = "Belum Ada Matkul"
            btnEval.BackColor = Color.FromArgb(236, 236, 236)
            btnEval.ForeColor = Color.FromArgb(140, 140, 140)
            btnEval.Enabled = False
            btnEval.Cursor = Cursors.Default
        ElseIf item.SudahDievaluasi Then
            lblStatus.Text = $"✓ Sudah Dievaluasi ({item.NilaiRataRata:0.00})"
            lblStatus.ForeColor = Color.FromArgb(25, 135, 84)
            btnEval.Text = "Lihat / Ubah Evaluasi"
            btnEval.BackColor = Color.FromArgb(236, 241, 234)
            btnEval.ForeColor = Color.FromArgb(30, 59, 51)
            btnEval.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 226, 220)
            btnEval.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 234, 228)
            AddHandler btnEval.Click, AddressOf BtnEval_Click
        Else
            lblStatus.Text = "Belum Dievaluasi"
            lblStatus.ForeColor = Color.FromArgb(220, 53, 69)
            btnEval.Text = "Isi Evaluasi"
            btnEval.BackColor = Color.FromArgb(30, 59, 51)
            btnEval.ForeColor = Color.White
            btnEval.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 142, 109)
            btnEval.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 82, 72)
            AddHandler btnEval.Click, AddressOf BtnEval_Click
        End If

        btnEval.Location = New Point(cardWidth - btnEval.Width - 28, 31)
        lblStatus.Location = New Point(btnEval.Left - lblStatus.PreferredWidth - 25, 44)

        card.Controls.Add(lblNama)
        card.Controls.Add(lblMatkul)
        card.Controls.Add(lblStatus)
        card.Controls.Add(btnEval)

        Return card
    End Function

    Private Async Sub BtnEval_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim item As EdomMahasiswaItem = DirectCast(btn.Tag, EdomMahasiswaItem)

        Using dlg As New FormEvaluasiEdom(Username, item)
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                Await LoadEdomListAsync()
            End If
        End Using
    End Sub

    Private Sub ShowState(message As String, showRetry As Boolean)
        lblStateMessage.Text = message
        btnRetry.Visible = showRetry
        pnlCardContainer.Visible = False
        pnlState.Visible = True
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadEdomListAsync()
    End Sub

    Private Async Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Await LoadEdomListAsync()
    End Sub

    Private Sub pnlCardContainer_Resize(sender As Object, e As EventArgs) Handles pnlCardContainer.Resize
        Dim cardWidth As Integer = Math.Max(700, pnlCardContainer.ClientSize.Width - 30)
        pnlCardContainer.SuspendLayout()
        For Each ctrl As Control In pnlCardContainer.Controls
            ctrl.Width = cardWidth
        Next
        pnlCardContainer.ResumeLayout(False)
    End Sub

    Private Sub SetActiveMenuButton(activeButton As Button)
        btnDashboard.BackColor = If(activeButton Is btnDashboard, ActiveMenuColor, InactiveMenuColor)
        Button1.BackColor = If(activeButton Is Button1, ActiveMenuColor, InactiveMenuColor)
    End Sub

    Private Sub btnDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDashboard.Click

        SetActiveMenuButton(btnDashboard)
        navigatingBack = True

        If DashboardForm IsNot Nothing Then
            DashboardForm.Location = Location
            DashboardForm.Size = Size
            DashboardForm.WindowState = WindowState
            DashboardForm.SetActiveMenuButton(DashboardForm.btnDashboard)
            DashboardForm.Show()
        Else
            Dim dash As New Dashboard With {
                .Username = Username,
                .LoginForm = LoginForm,
                .StartPosition = FormStartPosition.Manual,
                .Location = Location,
                .Size = Size,
                .WindowState = WindowState
            }
            dash.Show()
        End If

        Close()
    End Sub

    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        SetActiveMenuButton(Button1)
    End Sub

    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        btnLogout.BackColor = Color.FromArgb(176, 42, 55)

        Dim result As DialogResult =
            MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If result <> DialogResult.Yes Then
            btnLogout.BackColor = Color.FromArgb(220, 53, 69)
            Return
        End If

        loggingOut = True

        If DashboardForm IsNot Nothing Then
            DashboardForm.Close()
        End If

        If LoginForm IsNot Nothing Then
            LoginForm.Show()
        End If

        Close()
    End Sub

    Private Sub pengisianEdom_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        If Not loggingOut AndAlso Not navigatingBack Then
            Application.Exit()
        End If
    End Sub

End Class