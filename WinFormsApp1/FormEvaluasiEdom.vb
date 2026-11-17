Imports System.Windows.Forms

Public Class FormEvaluasiEdom

    Private ReadOnly _username As String
    Private ReadOnly _item As EdomMahasiswaItem

    Private ReadOnly WarnaUtama As Color = Color.FromArgb(30, 59, 51)
    Private ReadOnly WarnaTeks As Color = Color.FromArgb(33, 37, 41)
    Private ReadOnly WarnaRedup As Color = Color.FromArgb(108, 117, 125)
    Private ReadOnly WarnaSukses As Color = Color.FromArgb(25, 135, 84)
    Private ReadOnly WarnaError As Color = Color.FromArgb(176, 42, 55)
    Private ReadOnly WarnaBarisKosong As Color = Color.FromArgb(251, 234, 234)
    Private ReadOnly WarnaGaris As Color = Color.FromArgb(222, 226, 230)

    Private ReadOnly LabelSkala As String() = {"", "Sangat Kurang", "Kurang", "Cukup", "Baik", "Sangat Baik"}

    Private _pertanyaan As New List(Of PertanyaanEdomItem)
    Private ReadOnly _barisPerPertanyaan As New Dictionary(Of Integer, Panel)
    Private ReadOnly _opsiPerPertanyaan As New Dictionary(Of Integer, List(Of RadioButton))
    Private txtSaran As TextBox

    Public Sub New(username As String, item As EdomMahasiswaItem)
        InitializeComponent()

        _username = If(String.IsNullOrWhiteSpace(username), "Mahasiswa", username.Trim())
        _item = item
    End Sub

    Private Async Sub FormEvaluasiEdom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _item IsNot Nothing Then
            Dim nidnPart As String = If(String.IsNullOrWhiteSpace(_item.DosenNidn), "", $" ({_item.DosenNidn})")
            lblDosen.Text = $"Dosen: {_item.DosenNama}{nidnPart}"

            Dim ruangPart As String = If(String.IsNullOrWhiteSpace(_item.Ruang), "-", _item.Ruang)
            lblMatkul.Text = $"Mata Kuliah: {_item.MataKuliahNama}  |  Ruang {ruangPart}"
        End If

        btnSimpan.Text = If(_item IsNot Nothing AndAlso _item.SudahDievaluasi, "Perbarui Evaluasi", "Kirim Evaluasi")
        btnSimpan.Enabled = False
        flpIsi.Visible = False
        lblMemuat.Visible = True
        lblMemuat.ForeColor = WarnaRedup
        lblMemuat.Text = "Memuat butir pertanyaan EDOM..."
        lblStatusInfo.Text = ""

        If _item Is Nothing OrElse Not _item.MataKuliahId.HasValue Then
            TampilkanPesanMuat("Mata kuliah belum valid untuk dievaluasi.", True)
            Return
        End If

        Dim mkId As Integer = _item.MataKuliahId.Value
        Dim sudahDievaluasi As Boolean = _item.SudahDievaluasi
        Dim jawabanLama As New Dictionary(Of Integer, Integer)

        Try
            Await Task.Run(Sub()
                               _pertanyaan = DatabaseHelper.GetPertanyaanEdom()
                               If sudahDievaluasi Then
                                   jawabanLama = DatabaseHelper.GetJawabanEdom(_username, mkId)
                               End If
                           End Sub)
        Catch ex As Exception
            TampilkanPesanMuat(DatabaseHelper.DescribeError(ex) & Environment.NewLine & "Tutup formulir ini lalu coba lagi.", True)
            Return
        End Try

        If IsDisposed Then Return

        If _pertanyaan.Count = 0 Then
            TampilkanPesanMuat(
                "Belum ada butir pertanyaan EDOM di database." & Environment.NewLine &
                "Jalankan database\winforms_login.sql atau hubungi admin.", True)
            Return
        End If

        BangunFormulir(sudahDievaluasi, jawabanLama)

        lblMemuat.Visible = False
        flpIsi.Visible = True
        btnSimpan.Enabled = True
        PerbaruiProgres()
    End Sub

    Private Sub TampilkanPesanMuat(pesan As String, isError As Boolean)
        lblMemuat.Text = pesan
        lblMemuat.ForeColor = If(isError, WarnaError, WarnaRedup)
        lblMemuat.Visible = True
        flpIsi.Visible = False
        btnSimpan.Enabled = False
    End Sub

    ' ---------- Pembangunan formulir dari tabel edom_pertanyaan ----------

    Private Sub BangunFormulir(sudahDievaluasi As Boolean, jawabanLama As Dictionary(Of Integer, Integer))
        Dim lebar As Integer = pnlBody.ClientSize.Width - pnlBody.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth

        flpIsi.SuspendLayout()
        flpIsi.Controls.Clear()
        _barisPerPertanyaan.Clear()
        _opsiPerPertanyaan.Clear()

        flpIsi.Controls.Add(BuatLabel(
            $"Berikan penilaian untuk setiap butir ({_pertanyaan.Count} butir, semuanya wajib diisi). " &
            "Skala: 1 Sangat Kurang, 2 Kurang, 3 Cukup, 4 Baik, 5 Sangat Baik.",
            New Font("Segoe UI", 9.0F), WarnaRedup, lebar, New Padding(0, 0, 0, 10)))

        If sudahDievaluasi Then
            Dim catatan As String = If(jawabanLama.Count > 0,
                "Anda sudah pernah mengisi evaluasi ini. Nilai sebelumnya sudah dimuat; menyimpan akan memperbarui data Anda.",
                "Anda sudah pernah mengisi evaluasi ini dengan formulir versi lama. Silakan nilai ulang setiap butir; menyimpan akan memperbarui data Anda.")
            flpIsi.Controls.Add(BuatLabel(catatan, New Font("Segoe UI Semibold", 8.5F, FontStyle.Italic), WarnaSukses, lebar, New Padding(0, 0, 0, 10)))
        End If

        Dim kompetensiSebelumnya As String = Nothing
        For Each p In _pertanyaan
            If Not String.Equals(p.Kompetensi, kompetensiSebelumnya, StringComparison.OrdinalIgnoreCase) Then
                flpIsi.Controls.Add(BuatLabel(
                    DatabaseHelper.JudulKompetensi(p.Kompetensi),
                    New Font("Segoe UI", 11.0F, FontStyle.Bold), WarnaUtama, lebar, New Padding(0, 10, 0, 8)))
                kompetensiSebelumnya = p.Kompetensi
            End If

            Dim nilaiLama As Integer = 0
            jawabanLama.TryGetValue(p.Id, nilaiLama)
            flpIsi.Controls.Add(BuatBarisPertanyaan(p, lebar, nilaiLama))
        Next

        flpIsi.Controls.Add(BuatLabel(
            "Kritik, Saran & Masukan (Opsional)",
            New Font("Segoe UI", 11.0F, FontStyle.Bold), WarnaUtama, lebar, New Padding(0, 14, 0, 4)))
        flpIsi.Controls.Add(BuatLabel(
            "Berikan masukan konstruktif untuk peningkatan proses perkuliahan dosen.",
            New Font("Segoe UI", 8.5F), WarnaRedup, lebar, New Padding(0, 0, 0, 6)))

        txtSaran = New TextBox With {
            .Font = New Font("Segoe UI", 9.5F),
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .MaxLength = 2000,
            .Size = New Size(lebar, 90),
            .Margin = New Padding(0),
            .Text = If(sudahDievaluasi, If(_item.Saran, ""), "")
        }
        flpIsi.Controls.Add(txtSaran)

        flpIsi.ResumeLayout(True)
    End Sub

    Private Function BuatLabel(teks As String, font As Font, warna As Color, lebar As Integer, margin As Padding) As Label
        Return New Label With {
            .AutoSize = True,
            .MaximumSize = New Size(lebar, 0),
            .Font = font,
            .ForeColor = warna,
            .Margin = margin,
            .UseMnemonic = False,
            .Text = teks
        }
    End Function

    Private Function BuatBarisPertanyaan(p As PertanyaanEdomItem, lebar As Integer, nilaiLama As Integer) As Panel
        Const PaddingDalam As Integer = 16
        Dim lebarIsi As Integer = lebar - (PaddingDalam * 2)

        Dim baris As New Panel With {
            .BackColor = Color.White,
            .Width = lebar,
            .Margin = New Padding(0, 0, 0, 8),
            .Tag = p.Id
        }
        AddHandler baris.Paint, AddressOf Baris_Paint

        Dim lblPertanyaan As New Label With {
            .AutoSize = True,
            .MaximumSize = New Size(lebarIsi, 0),
            .Font = New Font("Segoe UI Semibold", 9.5F),
            .ForeColor = WarnaTeks,
            .Location = New Point(PaddingDalam, 12),
            .UseMnemonic = False,
            .Text = $"{p.Nomor}. {p.Pertanyaan}"
        }
        baris.Controls.Add(lblPertanyaan)

        Dim opsiPanel As New FlowLayoutPanel With {
            .WrapContents = True,
            .FlowDirection = FlowDirection.LeftToRight,
            .Margin = Padding.Empty,
            .Padding = Padding.Empty,
            .BackColor = Color.Transparent
        }

        Dim opsi As New List(Of RadioButton)
        For skor As Integer = 1 To 5
            Dim rb As New RadioButton With {
                .AutoSize = True,
                .Font = New Font("Segoe UI", 9.0F),
                .ForeColor = WarnaTeks,
                .Text = $"{skor}  {LabelSkala(skor)}",
                .Tag = skor,
                .Cursor = Cursors.Hand,
                .Margin = New Padding(0, 2, 18, 2),
                .Checked = (skor = nilaiLama)
            }
            AddHandler rb.CheckedChanged, AddressOf Opsi_CheckedChanged
            opsi.Add(rb)
            opsiPanel.Controls.Add(rb)
        Next

        Dim ukuranOpsi As Size = opsiPanel.GetPreferredSize(New Size(lebarIsi, 0))
        opsiPanel.Size = New Size(lebarIsi, ukuranOpsi.Height)
        opsiPanel.Location = New Point(PaddingDalam - 2, lblPertanyaan.Bottom + 8)
        baris.Controls.Add(opsiPanel)

        baris.Height = opsiPanel.Bottom + 12

        _barisPerPertanyaan(p.Id) = baris
        _opsiPerPertanyaan(p.Id) = opsi
        Return baris
    End Function

    Private Sub Baris_Paint(sender As Object, e As PaintEventArgs)
        Dim baris As Panel = DirectCast(sender, Panel)
        Using pen As New Pen(WarnaGaris)
            e.Graphics.DrawRectangle(pen, 0, 0, baris.Width - 1, baris.Height - 1)
        End Using
    End Sub

    Private Sub Opsi_CheckedChanged(sender As Object, e As EventArgs)
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If Not rb.Checked Then Return

        Dim baris As Panel = TryCast(rb.Parent?.Parent, Panel)
        If baris IsNot Nothing Then baris.BackColor = Color.White

        PerbaruiProgres()
    End Sub

    ' ---------- Status & penyimpanan ----------

    Private Function AmbilJawaban() As Dictionary(Of Integer, Integer)
        Dim jawaban As New Dictionary(Of Integer, Integer)
        For Each kv In _opsiPerPertanyaan
            Dim terpilih As RadioButton = kv.Value.FirstOrDefault(Function(r) r.Checked)
            If terpilih IsNot Nothing Then
                jawaban(kv.Key) = CInt(terpilih.Tag)
            End If
        Next
        Return jawaban
    End Function

    Private Sub PerbaruiProgres()
        Dim terjawab As Integer = AmbilJawaban().Count
        lblStatusInfo.ForeColor = If(terjawab = _pertanyaan.Count, WarnaSukses, WarnaRedup)
        lblStatusInfo.Text = $"Terjawab {terjawab} dari {_pertanyaan.Count} butir."
    End Sub

    Private Async Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If _item Is Nothing OrElse Not _item.MataKuliahId.HasValue Then
            TampilkanStatusError("Mata kuliah belum valid untuk dievaluasi.")
            Return
        End If

        Dim jawaban As Dictionary(Of Integer, Integer) = AmbilJawaban()
        Dim belumDijawab As List(Of PertanyaanEdomItem) = _pertanyaan.Where(Function(p) Not jawaban.ContainsKey(p.Id)).ToList()

        If belumDijawab.Count > 0 Then
            For Each p In belumDijawab
                _barisPerPertanyaan(p.Id).BackColor = WarnaBarisKosong
            Next
            pnlBody.ScrollControlIntoView(_barisPerPertanyaan(belumDijawab(0).Id))
            TampilkanStatusError($"Masih ada {belumDijawab.Count} butir yang belum dinilai (mulai nomor {belumDijawab(0).Nomor}).")
            Return
        End If

        Dim saran As String = txtSaran.Text.Trim()
        Dim mkId As Integer = _item.MataKuliahId.Value

        SetBusy(True)

        Try
            Await Task.Run(Sub() DatabaseHelper.SimpanPengisianEdom(_username, mkId, jawaban, saran))

            MessageBox.Show(
                "Terima kasih! Evaluasi Anda untuk dosen pengampu berhasil disimpan ke sistem.",
                "Evaluasi Tersimpan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            DialogResult = DialogResult.OK
            Close()
        Catch ex As ArgumentException
            TampilkanStatusError(ex.Message)
        Catch ex As Exception
            TampilkanStatusError(DatabaseHelper.DescribeError(ex))
        Finally
            If Not IsDisposed Then SetBusy(False)
        End Try
    End Sub

    Private Sub TampilkanStatusError(pesan As String)
        lblStatusInfo.ForeColor = WarnaError
        lblStatusInfo.Text = pesan
    End Sub

    Private Sub SetBusy(busy As Boolean)
        btnSimpan.Enabled = Not busy
        btnBatal.Enabled = Not busy
        For Each opsi In _opsiPerPertanyaan.Values
            For Each rb In opsi
                rb.Enabled = Not busy
            Next
        Next
        If txtSaran IsNot Nothing Then txtSaran.ReadOnly = busy
        UseWaitCursor = busy
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class
