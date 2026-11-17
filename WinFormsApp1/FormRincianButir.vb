Imports System.Windows.Forms

' Rata-rata nilai setiap butir instrumen EDOM untuk satu dosen, dikelompokkan per kompetensi.
Public Class FormRincianButir

    Private ReadOnly _dosen As DosenItem
    Private ReadOnly _mataKuliahId As Integer?
    Private ReadOnly _cakupan As String

    Private ReadOnly WarnaUtama As Color = Color.FromArgb(30, 59, 51)
    Private ReadOnly WarnaBarisKompetensi As Color = Color.FromArgb(236, 241, 234)
    Private ReadOnly WarnaError As Color = Color.FromArgb(176, 42, 55)
    Private ReadOnly WarnaRedup As Color = Color.FromArgb(108, 117, 125)

    Public Sub New(dosen As DosenItem, mataKuliahId As Integer?, cakupan As String)
        InitializeComponent()

        _dosen = dosen
        _mataKuliahId = mataKuliahId
        _cakupan = cakupan

        dashboard_dosen.StyleGrid(dgvButir)
        dgvButir.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        colButir.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        colButir.DefaultCellStyle.Padding = New Padding(10, 8, 10, 8)
        For Each col As DataGridViewColumn In {colNo, colResponden, colRataRata}
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Async Sub FormRincianButir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nidnPart As String = If(String.IsNullOrWhiteSpace(_dosen.Nidn), "", $" ({_dosen.Nidn})")
        lblDosen.Text = $"Dosen: {_dosen.Nama}{nidnPart}"
        lblCakupan.Text = $"Cakupan: {_cakupan}"

        lblRingkasan.Text = "Memuat rata-rata nilai per butir..."
        dgvButir.Visible = False

        Dim hasil As List(Of RataRataButirItem)
        Try
            Dim dosenId As Integer = _dosen.Id
            Dim mkId As Integer? = _mataKuliahId
            hasil = Await Task.Run(Function() DatabaseHelper.GetRataRataPerButir(dosenId, mkId))
        Catch ex As Exception
            TampilkanKosong(DatabaseHelper.DescribeError(ex), isError:=True)
            lblRingkasan.Text = "Data tidak dapat dimuat."
            Return
        End Try

        If IsDisposed Then Return
        Render(hasil)
    End Sub

    Private Sub Render(hasil As List(Of RataRataButirItem))
        Dim totalJawaban As Integer = hasil.Sum(Function(b) b.Responden)

        If hasil.Count = 0 Then
            lblRingkasan.Text = "Belum ada butir pertanyaan EDOM di database."
            TampilkanKosong("Jalankan database\winforms_login.sql atau hubungi admin untuk mengisi butir instrumen.", isError:=False)
            Return
        End If

        If totalJawaban = 0 Then
            lblRingkasan.Text = "Belum ada jawaban per butir untuk cakupan ini."
            TampilkanKosong(
                "Nilai per butir akan muncul setelah mahasiswa mengisi formulir EDOM 27 butir." & Environment.NewLine &
                "Pengisian lama hanya menyimpan skor per kompetensi, jadi hanya tampil di kartu Indeks Kinerja.", isError:=False)
            Return
        End If

        Dim responden As Integer = hasil.Max(Function(b) b.Responden)
        Dim rataKeseluruhan As Double = RataRataTertimbang(hasil)
        Dim terjawab = hasil.Where(Function(b) b.Responden > 0).ToList()
        Dim terendah As RataRataButirItem = terjawab.OrderBy(Function(b) b.RataRata).ThenBy(Function(b) b.Nomor).First()
        Dim tertinggi As RataRataButirItem = terjawab.OrderByDescending(Function(b) b.RataRata).ThenBy(Function(b) b.Nomor).First()

        lblRingkasan.Text =
            $"Rata-rata seluruh butir {rataKeseluruhan:0.00} ({PredikatSkor(rataKeseluruhan)}) dari {responden} responden.   " &
            $"Tertinggi: butir {tertinggi.Nomor} ({tertinggi.RataRata:0.00}).   Terendah: butir {terendah.Nomor} ({terendah.RataRata:0.00})."

        dgvButir.SuspendLayout()
        dgvButir.Rows.Clear()

        For Each grup In hasil.GroupBy(Function(b) b.Kompetensi.Trim().ToLowerInvariant())
            Dim rataKompetensi As Double = RataRataTertimbang(grup)
            Dim idxKompetensi As Integer = dgvButir.Rows.Add(
                "",
                DatabaseHelper.JudulKompetensi(grup.Key),
                "",
                If(rataKompetensi > 0, rataKompetensi.ToString("0.00"), "-"),
                PredikatSkor(rataKompetensi))

            With dgvButir.Rows(idxKompetensi).DefaultCellStyle
                .BackColor = WarnaBarisKompetensi
                .SelectionBackColor = WarnaBarisKompetensi
                .ForeColor = WarnaUtama
                .SelectionForeColor = WarnaUtama
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            End With

            For Each butir In grup
                Dim idx As Integer = dgvButir.Rows.Add(
                    butir.Nomor,
                    butir.Pertanyaan,
                    butir.Responden,
                    If(butir.Responden > 0, butir.RataRata.ToString("0.00"), "-"),
                    PredikatSkor(If(butir.Responden > 0, butir.RataRata, 0)))

                If butir.Responden > 0 AndAlso butir.RataRata < 3.0 Then
                    For Each kolom In {colRataRata.Index, colPredikat.Index}
                        dgvButir.Rows(idx).Cells(kolom).Style.ForeColor = WarnaError
                        dgvButir.Rows(idx).Cells(kolom).Style.SelectionForeColor = WarnaError
                    Next
                End If
            Next
        Next

        dgvButir.ResumeLayout()
        dgvButir.ClearSelection()
        lblKosong.Visible = False
        dgvButir.Visible = True
    End Sub

    ' Rata-rata dari semua jawaban (bukan rata-rata dari rata-rata), sehingga butir dengan responden lebih banyak berbobot sesuai.
    Private Shared Function RataRataTertimbang(butir As IEnumerable(Of RataRataButirItem)) As Double
        Dim totalResponden As Integer = butir.Sum(Function(b) b.Responden)
        If totalResponden = 0 Then Return 0
        Return Math.Round(butir.Sum(Function(b) b.RataRata * b.Responden) / totalResponden, 2)
    End Function

    Private Shared Function PredikatSkor(skor As Double) As String
        If skor >= 4.5 Then Return "Sangat Baik"
        If skor >= 3.75 Then Return "Baik"
        If skor >= 3.0 Then Return "Cukup"
        If skor > 0 Then Return "Perlu Evaluasi"
        Return "-"
    End Function

    Private Sub TampilkanKosong(pesan As String, isError As Boolean)
        lblKosong.Text = pesan
        lblKosong.ForeColor = If(isError, WarnaError, WarnaRedup)
        lblKosong.Visible = True
        dgvButir.Visible = False
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

End Class
