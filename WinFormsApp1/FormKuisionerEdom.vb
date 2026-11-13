Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormKuisionerEdom

    Public Property Username As String
    Public Property MataKuliahId As Integer
    Public Property MataKuliahNama As String
    Public Property DosenNama As String
    Public Property Ruang As String

    ' Menyimpan referensi radio button per butir pertanyaan (1 sampai 27)
    Private ReadOnly radioMap As New Dictionary(Of Integer, RadioButton())
    Private txtSaran As TextBox

    Public Class PertanyaanItem
        Public Property Nomor As Integer
        Public Property Kategori As String
        Public Property Teks As String

        Public Sub New(no As Integer, kat As String, t As String)
            Nomor = no
            Kategori = kat
            Teks = t
        End Sub
    End Class

    Private Function InisialisasiDaftarPertanyaan() As List(Of PertanyaanItem)
        Dim list As New List(Of PertanyaanItem)

        ' A. Kompetensi Pedagogik (1 - 9)
        list.Add(New PertanyaanItem(1, "A. Kompetensi Pedagogik", "Kesiapan memberikan kuliah dan/atau praktek/praktikum"))
        list.Add(New PertanyaanItem(2, "A. Kompetensi Pedagogik", "Keteraturan dan ketertiban penyelenggaraan perkuliahan"))
        list.Add(New PertanyaanItem(3, "A. Kompetensi Pedagogik", "Kemampuan menghidupkan suasana kelas"))
        list.Add(New PertanyaanItem(4, "A. Kompetensi Pedagogik", "Kejelasan penyampaian materi dan jawaban terhadap pertanyaan di kelas"))
        list.Add(New PertanyaanItem(5, "A. Kompetensi Pedagogik", "Pemanfaatan media dan teknologi pembelajaran"))
        list.Add(New PertanyaanItem(6, "A. Kompetensi Pedagogik", "Keanekaragaman cara pengukuran/penilaian hasil belajar"))
        list.Add(New PertanyaanItem(7, "A. Kompetensi Pedagogik", "Pemberian umpan balik terhadap tugas/penilaian"))
        list.Add(New PertanyaanItem(8, "A. Kompetensi Pedagogik", "Kesesuaian materi ujian dan/atau tugas dengan tujuan mata kuliah"))
        list.Add(New PertanyaanItem(9, "A. Kompetensi Pedagogik", "Kesesuaian nilai yang diberikan dengan hasil belajar"))

        ' B. Kompetensi Profesional (10 - 17)
        list.Add(New PertanyaanItem(10, "B. Kompetensi Profesional", "Kemampuan menjelaskan pokok bahasan/topik secara tepat sesuai Garis-garis Besar Pengajaran (GBPP) dan Satuan Acara Pengajaran (SAP)"))
        list.Add(New PertanyaanItem(11, "B. Kompetensi Profesional", "Kemampuan memberi contoh relevan dari konsep yang diajarkan berdasarkan Program Studi"))
        list.Add(New PertanyaanItem(12, "B. Kompetensi Profesional", "Kemampuan menjelaskan keterkaitan bidang/topik yang diajarkan dengan bidang/topik lain"))
        list.Add(New PertanyaanItem(13, "B. Kompetensi Profesional", "Kemampuan menjeleaskan keterkaitan bidang/topik yang diajarkan dengan konteks kehidupan"))
        list.Add(New PertanyaanItem(14, "B. Kompetensi Profesional", "Penguasaan akan isu-isu mutakhir dalam bidang yang diajarkan (kemutakhiran bahan/referensi kuliah)"))
        list.Add(New PertanyaanItem(15, "B. Kompetensi Profesional", "Penggunaan hasil-hasil penelitian untuk meningkatkan kualitas perkuliahan"))
        list.Add(New PertanyaanItem(16, "B. Kompetensi Profesional", "Pelibatan mahasiswa dalam penelitian/kajian dan atau pengembangan/rekayasa/desain yang dilakukan dosen"))
        list.Add(New PertanyaanItem(17, "B. Kompetensi Profesional", "Kemampuan menggunakan beragam teknologi komunikasi"))

        ' C. Kompetensi Kepribadian (18 - 23)
        list.Add(New PertanyaanItem(18, "C. Kompetensi Kepribadian", "Kewibaan sebagai pribadi dosen"))
        list.Add(New PertanyaanItem(19, "C. Kompetensi Kepribadian", "Kearifan dalam mengambil keputusan"))
        list.Add(New PertanyaanItem(20, "C. Kompetensi Kepribadian", "Menjadi contoh dalam bersikap dan berperilaku"))
        list.Add(New PertanyaanItem(21, "C. Kompetensi Kepribadian", "Satu kata dan tindakan"))
        list.Add(New PertanyaanItem(22, "C. Kompetensi Kepribadian", "Kemampuan mengendalikan diri dalam berbagai situasi dan kondisi"))
        list.Add(New PertanyaanItem(23, "C. Kompetensi Kepribadian", "Adil dalam memperlakukan mahasiswa"))

        ' D. Kompetensi Sosial (24 - 27)
        list.Add(New PertanyaanItem(24, "D. Kompetensi Sosial", "Kemampuan menyampaikan pendapat"))
        list.Add(New PertanyaanItem(25, "D. Kompetensi Sosial", "Kemampuan menerima kritik, saran, dan pendapat dari mahasiswa"))
        list.Add(New PertanyaanItem(26, "D. Kompetensi Sosial", "Mengenal dengan baik mahasiswa yang mengikuti kuliahnya"))
        list.Add(New PertanyaanItem(27, "D. Kompetensi Sosial", "Toleransi terhadap keberagaman mahasiswa"))

        Return list
    End Function

    Private Sub FormKuisionerEdom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSubHeader.Text = $"Dosen: {DosenNama}   |   Mata Kuliah: {MataKuliahNama} ({If(String.IsNullOrWhiteSpace(Ruang), "-", Ruang)})   |   Mahasiswa: {Username}"
        BuildKuisionerUi()
    End Sub

    Private Sub BuildKuisionerUi()
        pnlContainer.SuspendLayout()
        pnlContainer.Controls.Clear()
        radioMap.Clear()

        Dim daftarPertanyaan = InisialisasiDaftarPertanyaan()

        Dim currentY As Integer = 10
        Dim containerWidth As Integer = pnlContainer.ClientSize.Width - 60
        If containerWidth < 800 Then containerWidth = 800

        ' 1. Panel Petunjuk Pengisian
        Dim pnlPetunjuk As New Panel With {
            .Location = New Point(10, currentY),
            .Size = New Size(containerWidth, 80),
            .BackColor = Color.FromArgb(235, 245, 238),
            .BorderStyle = BorderStyle.FixedSingle
        }
        Dim lblPetunjukTitle As New Label With {
            .Text = "PETUNJUK PENILAIAN EDOM:",
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .ForeColor = Color.FromArgb(30, 59, 51),
            .Location = New Point(15, 12),
            .AutoSize = True
        }
        Dim lblPetunjukDesc As New Label With {
            .Text = "Pilihlah salah satu opsi skala Likert pada setiap butir pernyataan di bawah ini:" & vbCrLf &
                    "1 = Sangat Kurang   |   2 = Kurang   |   3 = Cukup   |   4 = Baik   |   5 = Sangat Baik",
            .Font = New Font("Segoe UI", 9.0F),
            .ForeColor = Color.FromArgb(46, 82, 72),
            .Location = New Point(15, 36),
            .AutoSize = True
        }
        pnlPetunjuk.Controls.Add(lblPetunjukTitle)
        pnlPetunjuk.Controls.Add(lblPetunjukDesc)
        pnlContainer.Controls.Add(pnlPetunjuk)
        currentY += 95

        ' 2. Susun Pertanyaan per Kategori
        Dim lastKategori As String = ""
        Dim skalaLabels = {"1 (Sangat Kurang)", "2 (Kurang)", "3 (Cukup)", "4 (Baik)", "5 (Sangat Baik)"}

        For Each item In daftarPertanyaan
            ' Tambahkan Header Kategori jika berganti kategori
            If item.Kategori <> lastKategori Then
                lastKategori = item.Kategori

                Dim pnlKatHeader As New Panel With {
                    .Location = New Point(10, currentY),
                    .Size = New Size(containerWidth, 42),
                    .BackColor = Color.FromArgb(46, 82, 72)
                }
                Dim lblKat As New Label With {
                    .Text = item.Kategori.ToUpper(),
                    .Font = New Font("Segoe UI", 10.5F, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Location = New Point(15, 9),
                    .AutoSize = True
                }
                pnlKatHeader.Controls.Add(lblKat)
                pnlContainer.Controls.Add(pnlKatHeader)
                currentY += 48
            End If

            ' Card Pertanyaan
            Dim cardItem As New Panel With {
                .Location = New Point(10, currentY),
                .Size = New Size(containerWidth, 95),
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle
            }

            ' Label Pertanyaan
            Dim lblTeks As New Label With {
                .Text = $"{item.Nomor}. {item.Teks}",
                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .ForeColor = Color.FromArgb(33, 37, 41),
                .Location = New Point(15, 10),
                .Size = New Size(containerWidth - 30, 42)
            }
            cardItem.Controls.Add(lblTeks)

            ' Group 5 RadioButton
            Dim pnlRadioGroup As New Panel With {
                .Location = New Point(15, 54),
                .Size = New Size(containerWidth - 30, 32),
                .BackColor = Color.Transparent
            }

            Dim radios(4) As RadioButton
            Dim startX As Integer = 0
            Dim rbWidth As Integer = (containerWidth - 30) \ 5

            For val As Integer = 1 To 5
                Dim rb As New RadioButton With {
                    .Text = skalaLabels(val - 1),
                    .Tag = val,
                    .Location = New Point(startX, 0),
                    .Size = New Size(rbWidth, 28),
                    .Font = New Font("Segoe UI", 9.0F),
                    .ForeColor = Color.FromArgb(60, 60, 60),
                    .Cursor = Cursors.Hand
                }
                pnlRadioGroup.Controls.Add(rb)
                radios(val - 1) = rb
                startX += rbWidth
            Next

            radioMap.Add(item.Nomor, radios)
            cardItem.Controls.Add(pnlRadioGroup)
            pnlContainer.Controls.Add(cardItem)
            currentY += 105
        Next

        ' 3. Bagian Saran / Komentar
        Dim pnlSaran As New Panel With {
            .Location = New Point(10, currentY),
            .Size = New Size(containerWidth, 140),
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle
        }
        Dim lblSaranTitle As New Label With {
            .Text = "Saran dan Masukan untuk Dosen (Opsional):",
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .ForeColor = Color.FromArgb(30, 59, 51),
            .Location = New Point(15, 12),
            .AutoSize = True
        }
        txtSaran = New TextBox With {
            .Location = New Point(15, 38),
            .Size = New Size(containerWidth - 30, 85),
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Font = New Font("Segoe UI", 9.5F),
            .PlaceholderText = "Tuliskan kritik, apresiasi, atau saran untuk kemajuan perkuliahan..."
        }
        pnlSaran.Controls.Add(lblSaranTitle)
        pnlSaran.Controls.Add(txtSaran)
        pnlContainer.Controls.Add(pnlSaran)

        currentY += 160
        pnlContainer.AutoScrollMinSize = New Size(containerWidth, currentY)
        pnlContainer.ResumeLayout()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Ambil dan validasi seluruh 27 jawaban
        Dim jawaban As New Dictionary(Of Integer, Integer)

        For i As Integer = 1 To 27
            Dim selectedVal As Integer = 0
            If radioMap.ContainsKey(i) Then
                For Each rb In radioMap(i)
                    If rb.Checked Then
                        selectedVal = CInt(rb.Tag)
                        Exit For
                    End If
                Next
            End If

            If selectedVal = 0 Then
                MessageBox.Show(
                    $"Pernyataan nomor {i} belum diisi.{vbCrLf}Harap lengkapi penilaian untuk seluruh pernyataan sebelum menyimpan.",
                    "Kuisioner Belum Lengkap",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
                Return
            End If

            jawaban(i) = selectedVal
        Next

        ' 2. Konfirmasi Penyimpanan
        Dim tanya = MessageBox.Show(
            $"Apakah Anda yakin ingin menyelesaikan dan menghitung evaluasi untuk dosen {DosenNama}?",
            "Konfirmasi Pengisian EDOM",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If tanya <> DialogResult.Yes Then Return

        ' 3. Proses Perhitungan Fuzzy Tsukamoto Bertingkat
        Try
            Dim hasil = FuzzyTsukamotoService.HitungEdom(jawaban)

            ' 4. Simpan ke Database
            Dim saranText As String = If(txtSaran IsNot Nothing, txtSaran.Text.Trim(), "")
            Dim success As Boolean = DatabaseHelper.SimpanPengisianEdom(
                Username,
                MataKuliahId,
                hasil.SkorPedagogik,
                hasil.SkorProfesional,
                hasil.SkorKepribadian,
                hasil.SkorSosial,
                hasil.NilaiAkhir,
                saranText
            )

            If success Then
                MessageBox.Show(
                    $"{hasil.KeteranganDetail}{vbCrLf}{vbCrLf}Data evaluasi berhasil disimpan ke sistem!",
                    "Evaluasi Berhasil Diproses (Fuzzy Tsukamoto)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Gagal menyimpan hasil evaluasi ke database.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Terjadi kesalahan saat memproses evaluasi: {ex.Message}", "Error Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim tanya = MessageBox.Show(
            "Apakah Anda yakin ingin membatalkan pengisian? Jawaban yang belum disimpan akan hilang.",
            "Konfirmasi Batal",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If tanya = DialogResult.Yes Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

End Class
