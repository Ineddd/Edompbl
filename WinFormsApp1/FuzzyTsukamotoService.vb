Imports System
Imports System.Collections.Generic

''' <summary>
''' Layanan Implementasi Fuzzy Tsukamoto Bertingkat (Hierarchical Fuzzy) Murni
''' Tanpa menggunakan library fuzzy eksternal sama sekali.
''' Dibuat khusus untuk evaluasi dosen oleh mahasiswa (EDOM).
''' </summary>
Public Class FuzzyTsukamotoService

    Public Class FuzzyHasil
        Public Property SkorPedagogik As Double
        Public Property SkorProfesional As Double
        Public Property SkorKepribadian As Double
        Public Property SkorSosial As Double
        Public Property NilaiAkhir As Double
        Public Property Predikat As String
        Public Property KeteranganDetail As String
    End Class

    Private Enum TingkatKategori
        Kurang
        Cukup
        Baik
    End Enum

    ' =========================================================================
    ' 1. FUNGSI KEANGGOTAAN FUZZY (FUZZIFIKASI) - SKALA 1.0 SAMPAI 5.0
    ' =========================================================================

    ''' <summary>
    ''' Kurva Linier Turun: Kurang (1.0 sampai 3.0)
    ''' </summary>
    Public Shared Function MuKurang(x As Double) As Double
        If x <= 1.0 Then Return 1.0
        If x >= 3.0 Then Return 0.0
        Return (3.0 - x) / (3.0 - 1.0)
    End Function

    ''' <summary>
    ''' Kurva Segitiga: Cukup (2.0 sampai 4.0, puncak di 3.0)
    ''' </summary>
    Public Shared Function MuCukup(x As Double) As Double
        If x <= 2.0 OrElse x >= 4.0 Then Return 0.0
        If x <= 3.0 Then Return (x - 2.0) / (3.0 - 2.0)
        Return (4.0 - x) / (4.0 - 3.0)
    End Function

    ''' <summary>
    ''' Kurva Linier Naik: Baik (3.0 sampai 5.0)
    ''' </summary>
    Public Shared Function MuBaik(x As Double) As Double
        If x <= 3.0 Then Return 0.0
        If x >= 5.0 Then Return 1.0
        Return (x - 3.0) / (5.0 - 3.0)
    End Function

    ' =========================================================================
    ' 2. DEFUZZIFIKASI TSUKAMOTO (RATA-RATA TERBOBOT / WEIGHTED AVERAGE)
    ' =========================================================================
    Public Shared Function Defuzzifikasi(alphas As List(Of Double), zs As List(Of Double), Optional defaultVal As Double = 3.0) As Double
        Dim sumAlphaZ As Double = 0.0
        Dim sumAlpha As Double = 0.0

        For i As Integer = 0 To alphas.Count - 1
            If alphas(i) > 0.0001 Then
                sumAlphaZ += alphas(i) * zs(i)
                sumAlpha += alphas(i)
            End If
        Next

        If sumAlpha <= 0.0001 Then
            Return defaultVal
        End If

        Return Math.Round(sumAlphaZ / sumAlpha, 2)
    End Function

    ' =========================================================================
    ' 3. TAHAP 1: FUZZY PER KATEGORI
    ' =========================================================================

    ''' <summary>
    ''' Tahap 1.A - Fuzzy Pedagogik (9 Pertanyaan -> 3 Sub-Indikator -> 27 Rules)
    ''' Sub 1: Pelaksanaan Kelas (Q1, Q2, Q3)
    ''' Sub 2: Penyampaian & Media (Q4, Q5)
    ''' Sub 3: Penilaian & Umpan Balik (Q6, Q7, Q8, Q9)
    ''' </summary>
    Public Shared Function HitungPedagogik(jawaban As Dictionary(Of Integer, Integer)) As Double
        Dim in1 As Double = (jawaban(1) + jawaban(2) + jawaban(3)) / 3.0
        Dim in2 As Double = (jawaban(4) + jawaban(5)) / 2.0
        Dim in3 As Double = (jawaban(6) + jawaban(7) + jawaban(8) + jawaban(9)) / 4.0

        Dim uK1 As Double = MuKurang(in1), uC1 As Double = MuCukup(in1), uB1 As Double = MuBaik(in1)
        Dim uK2 As Double = MuKurang(in2), uC2 As Double = MuCukup(in2), uB2 As Double = MuBaik(in2)
        Dim uK3 As Double = MuKurang(in3), uC3 As Double = MuCukup(in3), uB3 As Double = MuBaik(in3)

        Dim alphas As New List(Of Double)
        Dim zs As New List(Of Double)

        ' Kombinasi 3 x 3 x 3 = 27 Aturan
        Dim sets1 = {Tuple.Create(TingkatKategori.Kurang, uK1), Tuple.Create(TingkatKategori.Cukup, uC1), Tuple.Create(TingkatKategori.Baik, uB1)}
        Dim sets2 = {Tuple.Create(TingkatKategori.Kurang, uK2), Tuple.Create(TingkatKategori.Cukup, uC2), Tuple.Create(TingkatKategori.Baik, uB2)}
        Dim sets3 = {Tuple.Create(TingkatKategori.Kurang, uK3), Tuple.Create(TingkatKategori.Cukup, uC3), Tuple.Create(TingkatKategori.Baik, uB3)}

        For Each s1 In sets1
            For Each s2 In sets2
                For Each s3 In sets3
                    Dim alpha As Double = Math.Min(s1.Item2, Math.Min(s2.Item2, s3.Item2))
                    If alpha > 0 Then
                        Dim jumlahBaik As Integer = 0
                        Dim jumlahKurang As Integer = 0

                        If s1.Item1 = TingkatKategori.Baik Then jumlahBaik += 1
                        If s2.Item1 = TingkatKategori.Baik Then jumlahBaik += 1
                        If s3.Item1 = TingkatKategori.Baik Then jumlahBaik += 1

                        If s1.Item1 = TingkatKategori.Kurang Then jumlahKurang += 1
                        If s2.Item1 = TingkatKategori.Kurang Then jumlahKurang += 1
                        If s3.Item1 = TingkatKategori.Kurang Then jumlahKurang += 1

                        Dim z As Double
                        If jumlahBaik >= 2 Then
                            ' Output Tinggi: z = 3.0 + alpha * 2.0
                            z = 3.0 + (alpha * 2.0)
                        ElseIf jumlahKurang >= 2 Then
                            ' Output Rendah: z = 3.0 - alpha * 2.0
                            z = 3.0 - (alpha * 2.0)
                        Else
                            ' Output Sedang: titik tengah 3.0
                            z = 3.0
                        End If

                        alphas.Add(alpha)
                        zs.Add(z)
                    End If
                Next
            Next
        Next

        Dim avgMentah As Double = (in1 + in2 + in3) / 3.0
        Return Defuzzifikasi(alphas, zs, avgMentah)
    End Function

    ''' <summary>
    ''' Tahap 1.B - Fuzzy Profesional (8 Pertanyaan -> 2 Sub-Indikator -> 9 Rules)
    ''' Sub 1: Penguasaan Materi (Q10, Q11, Q12, Q13)
    ''' Sub 2: Kemutakhiran & Riset (Q14, Q15, Q16, Q17)
    ''' </summary>
    Public Shared Function HitungProfesional(jawaban As Dictionary(Of Integer, Integer)) As Double
        Dim in1 As Double = (jawaban(10) + jawaban(11) + jawaban(12) + jawaban(13)) / 4.0
        Dim in2 As Double = (jawaban(14) + jawaban(15) + jawaban(16) + jawaban(17)) / 4.0

        Return EvaluasiFuzzy2Input(in1, in2)
    End Function

    ''' <summary>
    ''' Tahap 1.C - Fuzzy Kepribadian (6 Pertanyaan -> 2 Sub-Indikator -> 9 Rules)
    ''' Sub 1: Kewibawaan & Keteladanan (Q18, Q19, Q20)
    ''' Sub 2: Pengendalian Diri & Keadilan (Q21, Q22, Q23)
    ''' </summary>
    Public Shared Function HitungKepribadian(jawaban As Dictionary(Of Integer, Integer)) As Double
        Dim in1 As Double = (jawaban(18) + jawaban(19) + jawaban(20)) / 3.0
        Dim in2 As Double = (jawaban(21) + jawaban(22) + jawaban(23)) / 3.0

        Return EvaluasiFuzzy2Input(in1, in2)
    End Function

    ''' <summary>
    ''' Tahap 1.D - Fuzzy Sosial (4 Pertanyaan -> 2 Sub-Indikator -> 9 Rules)
    ''' Sub 1: Komunikasi & Keterbukaan (Q24, Q25)
    ''' Sub 2: Hubungan & Toleransi (Q26, Q27)
    ''' </summary>
    Public Shared Function HitungSosial(jawaban As Dictionary(Of Integer, Integer)) As Double
        Dim in1 As Double = (jawaban(24) + jawaban(25)) / 2.0
        Dim in2 As Double = (jawaban(26) + jawaban(27)) / 2.0

        Return EvaluasiFuzzy2Input(in1, in2)
    End Function

    ''' <summary>
    ''' Mesin Inferensi Tsukamoto untuk 2 Input (9 Rules)
    ''' Digunakan oleh Profesional, Kepribadian, dan Sosial
    ''' </summary>
    Private Shared Function EvaluasiFuzzy2Input(in1 As Double, in2 As Double) As Double
        Dim uK1 As Double = MuKurang(in1), uC1 As Double = MuCukup(in1), uB1 As Double = MuBaik(in1)
        Dim uK2 As Double = MuKurang(in2), uC2 As Double = MuCukup(in2), uB2 As Double = MuBaik(in2)

        Dim alphas As New List(Of Double)
        Dim zs As New List(Of Double)

        ' Tabel 9 Aturan Tsukamoto:
        ' R1: IF K AND K THEN Rendah
        ' R2: IF K AND C THEN Rendah
        ' R3: IF K AND B THEN Sedang
        ' R4: IF C AND K THEN Rendah
        ' R5: IF C AND C THEN Sedang
        ' R6: IF C AND B THEN Tinggi
        ' R7: IF B AND K THEN Sedang
        ' R8: IF B AND C THEN Tinggi
        ' R9: IF B AND B THEN Tinggi

        Dim rules = {
            (uK1, uK2, "Rendah"),
            (uK1, uC2, "Rendah"),
            (uK1, uB2, "Sedang"),
            (uC1, uK2, "Rendah"),
            (uC1, uC2, "Sedang"),
            (uC1, uB2, "Tinggi"),
            (uB1, uK2, "Sedang"),
            (uB1, uC2, "Tinggi"),
            (uB1, uB2, "Tinggi")
        }

        For Each r In rules
            Dim alpha As Double = Math.Min(r.Item1, r.Item2)
            If alpha > 0 Then
                Dim z As Double
                Select Case r.Item3
                    Case "Tinggi"
                        z = 3.0 + (alpha * 2.0)
                    Case "Rendah"
                        z = 3.0 - (alpha * 2.0)
                    Case Else
                        z = 3.0
                End Select
                alphas.Add(alpha)
                zs.Add(z)
            End If
        Next

        Dim avgMentah As Double = (in1 + in2) / 2.0
        Return Defuzzifikasi(alphas, zs, avgMentah)
    End Function

    ' =========================================================================
    ' 4. TAHAP 2: FUZZY EVALUASI AKHIR (MENGGABUNGKAN 4 KATEGORI)
    ' =========================================================================

    ''' <summary>
    ''' Tahap 2: Menerima 4 Skor Kategori dari Tahap 1,
    ''' melakukan inferensi Tsukamoto gabungan, dan menghasilkan Nilai Akhir Kinerja Dosen.
    ''' </summary>
    Public Shared Function HitungFuzzyAkhir(skorPedagogik As Double, skorProfesional As Double, skorKepribadian As Double, skorSosial As Double) As Double
        Dim uKP As Double = MuKurang(skorPedagogik), uCP As Double = MuCukup(skorPedagogik), uBP As Double = MuBaik(skorPedagogik)
        Dim uKPr As Double = MuKurang(skorProfesional), uCPr As Double = MuCukup(skorProfesional), uBPr As Double = MuBaik(skorProfesional)
        Dim uKK As Double = MuKurang(skorKepribadian), uCK As Double = MuCukup(skorKepribadian), uBK As Double = MuBaik(skorKepribadian)
        Dim uKS As Double = MuKurang(skorSosial), uCS As Double = MuCukup(skorSosial), uBS As Double = MuBaik(skorSosial)

        Dim alphas As New List(Of Double)
        Dim zs As New List(Of Double)

        ' Basis Aturan Evaluasi Akhir:
        ' R1: IF semua Baik THEN Sangat Baik (z: 4.0 - 5.0)
        Dim a1 As Double = Math.Min(Math.Min(uBP, uBPr), Math.Min(uBK, uBS))
        If a1 > 0 Then
            alphas.Add(a1)
            zs.Add(4.0 + (a1 * 1.0))
        End If

        ' R2: IF Pedagogik Baik AND Profesional Baik AND Kepribadian Baik AND Sosial Cukup THEN Sangat Baik
        Dim a2 As Double = Math.Min(Math.Min(uBP, uBPr), Math.Min(uBK, uCS))
        If a2 > 0 Then
            alphas.Add(a2)
            zs.Add(4.0 + (a2 * 0.8))
        End If

        ' R3: IF Pedagogik Baik AND Profesional Baik AND Kepribadian Cukup AND Sosial Baik THEN Sangat Baik
        Dim a3 As Double = Math.Min(Math.Min(uBP, uBPr), Math.Min(uCK, uBS))
        If a3 > 0 Then
            alphas.Add(a3)
            zs.Add(4.0 + (a3 * 0.8))
        End If

        ' R4: IF minimal 2 Baik dan lainnya Cukup THEN Baik (z: 3.5 - 4.2)
        Dim a4 As Double = Math.Min(Math.Min(uBP, uBPr), Math.Min(uCK, uCS))
        If a4 > 0 Then
            alphas.Add(a4)
            zs.Add(3.5 + (a4 * 0.7))
        End If

        Dim a4b As Double = Math.Min(Math.Min(uBP, uCPr), Math.Min(uBK, uCS))
        If a4b > 0 Then
            alphas.Add(a4b)
            zs.Add(3.5 + (a4b * 0.7))
        End If

        ' R5: IF 1 Baik dan 3 Cukup THEN Baik
        Dim a5 As Double = Math.Min(Math.Min(uBP, uCPr), Math.Min(uCK, uCS))
        If a5 > 0 Then
            alphas.Add(a5)
            zs.Add(3.2 + (a5 * 0.5))
        End If

        ' R6: IF semua Cukup THEN Cukup (z: 3.0)
        Dim a6 As Double = Math.Min(Math.Min(uCP, uCPr), Math.Min(uCK, uCS))
        If a6 > 0 Then
            alphas.Add(a6)
            zs.Add(3.0)
        End If

        ' R7: IF Cukup dan ada Kurang THEN Kurang (z: 2.0 - 2.8)
        Dim a7 As Double = Math.Min(Math.Min(uCP, uCPr), Math.Min(uKK, uKS))
        If a7 > 0 Then
            alphas.Add(a7)
            zs.Add(2.8 - (a7 * 0.8))
        End If

        ' R8: IF minimal 2 Kurang THEN Kurang
        Dim a8 As Double = Math.Min(Math.Min(uKP, uKPr), Math.Min(uCK, uCS))
        If a8 > 0 Then
            alphas.Add(a8)
            zs.Add(2.8 - (a8 * 0.8))
        End If

        ' R9: IF 3 Kurang dan 1 Cukup THEN Sangat Kurang (z: 1.0 - 2.0)
        Dim a9 As Double = Math.Min(Math.Min(uKP, uKPr), Math.Min(uKK, uCS))
        If a9 > 0 Then
            alphas.Add(a9)
            zs.Add(2.0 - (a9 * 1.0))
        End If

        ' R10: IF semua Kurang THEN Sangat Kurang (z: 1.0)
        Dim a10 As Double = Math.Min(Math.Min(uKP, uKPr), Math.Min(uKK, uKS))
        If a10 > 0 Then
            alphas.Add(a10)
            zs.Add(2.0 - (a10 * 1.0))
        End If

        Dim avgMentah As Double = (skorPedagogik + skorProfesional + skorKepribadian + skorSosial) / 4.0
        Return Defuzzifikasi(alphas, zs, avgMentah)
    End Function

    ' =========================================================================
    ' 5. FUNGSI UTAMA: MENERIMA 27 JAWABAN DAN MENGHASILKAN FUZZY HASIL
    ' =========================================================================
    Public Shared Function HitungEdom(jawaban As Dictionary(Of Integer, Integer)) As FuzzyHasil
        ' 1. Validasi 27 Pertanyaan
        For i As Integer = 1 To 27
            If Not jawaban.ContainsKey(i) OrElse jawaban(i) < 1 OrElse jawaban(i) > 5 Then
                Throw New ArgumentException($"Pertanyaan nomor {i} belum memiliki nilai valid (skala 1-5).")
            End If
        Next

        ' 2. Hitung Tahap 1 (Fuzzy per Kategori)
        Dim skorPedagogik As Double = HitungPedagogik(jawaban)
        Dim skorProfesional As Double = HitungProfesional(jawaban)
        Dim skorKepribadian As Double = HitungKepribadian(jawaban)
        Dim skorSosial As Double = HitungSosial(jawaban)

        ' 3. Hitung Tahap 2 (Fuzzy Evaluasi Akhir)
        Dim nilaiAkhir As Double = HitungFuzzyAkhir(skorPedagogik, skorProfesional, skorKepribadian, skorSosial)

        ' 4. Tentukan Predikat Kualitatif
        Dim predikat As String
        If nilaiAkhir >= 4.2 Then
            predikat = "Sangat Baik"
        ElseIf nilaiAkhir >= 3.4 Then
            predikat = "Baik"
        ElseIf nilaiAkhir >= 2.6 Then
            predikat = "Cukup"
        ElseIf nilaiAkhir >= 1.8 Then
            predikat = "Kurang"
        Else
            predikat = "Sangat Kurang"
        End If

        Dim detail As String =
            $"HASIL PERHITUNGAN FUZZY TSUKAMOTO BERTINGKAT:" & vbCrLf &
            $"--------------------------------------------" & vbCrLf &
            $"• Tahap 1 - Skor Kompetensi Pedagogik   : {skorPedagogik:F2}" & vbCrLf &
            $"• Tahap 1 - Skor Kompetensi Profesional : {skorProfesional:F2}" & vbCrLf &
            $"• Tahap 1 - Skor Kompetensi Kepribadian : {skorKepribadian:F2}" & vbCrLf &
            $"• Tahap 1 - Skor Kompetensi Sosial      : {skorSosial:F2}" & vbCrLf &
            $"--------------------------------------------" & vbCrLf &
            $"• Tahap 2 - Nilai Akhir Kinerja Dosen   : {nilaiAkhir:F2}" & vbCrLf &
            $"• Kategori / Predikat                   : {predikat}"

        Return New FuzzyHasil With {
            .SkorPedagogik = skorPedagogik,
            .SkorProfesional = skorProfesional,
            .SkorKepribadian = skorKepribadian,
            .SkorSosial = skorSosial,
            .NilaiAkhir = nilaiAkhir,
            .Predikat = predikat,
            .KeteranganDetail = detail
        }
    End Function

End Class

