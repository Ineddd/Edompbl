Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Public Class pengisianEdom

    Private ReadOnly ActiveMenuColor As Color = Color.FromArgb(114, 142, 109)
    Private ReadOnly InactiveMenuColor As Color = Color.FromArgb(46, 82, 72)

    Public Property Username As String
    Public Property LoginForm As Form
    Public Property DashboardForm As Dashboard

    Private loggingOut As Boolean
    Private navigatingBack As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub pengisianEdom_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetActiveMenuButton(Button1)
        MuatStatusPengisian()
    End Sub

    Public Sub MuatStatusPengisian()
        Try
            Dim courses = DatabaseHelper.GetMataKuliah()
            Dim sudahDiisi = DatabaseHelper.GetStatusPengisianMahasiswa(Username)

            ' Card 1: Pemrograman Web Lanjut
            UpdateCardState(
                courses.FirstOrDefault(Function(c) c.Nama.Contains("Web Lanjut", StringComparison.OrdinalIgnoreCase)),
                "Asep Taufik, M.Kom.",
                "Pemrograman Web Lanjut",
                "AA 301",
                lblNamaDosen1, lblMatkulDosen1, lblStatusDosen1, btnEval1, sudahDiisi
            )

            ' Card 2: Pemrograman Basis Data
            UpdateCardState(
                courses.FirstOrDefault(Function(c) c.Nama.Contains("Basis Data", StringComparison.OrdinalIgnoreCase)),
                "Risna Sari, M.Kom.",
                "Pemrograman Basis Data",
                "GSG 204",
                lblNamaDosen2, lblMatkulDosen2, lblStatusDosen2, btnEval2, sudahDiisi
            )

            ' Card 3: Analisis Sistem
            UpdateCardState(
                courses.FirstOrDefault(Function(c) c.Nama.Contains("Analisis Sistem", StringComparison.OrdinalIgnoreCase)),
                "Bagus Wijaya, M.Kom.",
                "Analisis Sistem",
                "PUT 301",
                lblNamaDosen3, lblMatkulDosen3, lblStatusDosen3, btnEval3, sudahDiisi
            )

            ' Card 4: Rekayasa Perangkat Lunak
            UpdateCardState(
                courses.FirstOrDefault(Function(c) c.Nama.Contains("Perangkat Lunak", StringComparison.OrdinalIgnoreCase)),
                "Dr. Hendra Pratama, M.T.",
                "Rekayasa Perangkat Lunak",
                "AA 205",
                lblNamaDosen4, lblMatkulDosen4, lblStatusDosen4, btnEval4, sudahDiisi
            )

        Catch ex As Exception
            ' Tetap tampilkan kartu dengan graceful error
        End Try
    End Sub

    Private Sub UpdateCardState(
        mk As MataKuliahItem,
        defaultDosen As String,
        defaultMatkul As String,
        defaultRuang As String,
        lblNama As Label,
        lblMatkul As Label,
        lblStatus As Label,
        btnEval As Button,
        sudahDiisi As HashSet(Of Integer)
    )
        Dim mkNama = If(mk IsNot Nothing, mk.Nama, defaultMatkul)
        Dim dosenNama = If(mk IsNot Nothing, mk.DosenNama, defaultDosen)
        Dim ruang = If(mk IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(mk.Ruang), mk.Ruang, defaultRuang)
        Dim isEvaluated As Boolean = (mk IsNot Nothing AndAlso sudahDiisi.Contains(mk.Id))

        lblNama.Text = dosenNama
        lblMatkul.Text = $"Mata Kuliah: {mkNama}  |  Ruang {ruang}"

        If isEvaluated Then
            lblStatus.Text = "Sudah Dievaluasi"
            lblStatus.ForeColor = Color.FromArgb(25, 135, 84) ' Hijau
            btnEval.Text = "Evaluasi Selesai"
            btnEval.Enabled = False
            btnEval.BackColor = Color.FromArgb(108, 117, 125)
        Else
            lblStatus.Text = "Belum Dievaluasi"
            lblStatus.ForeColor = Color.FromArgb(220, 53, 69) ' Merah
            btnEval.Text = "Isi Evaluasi"
            btnEval.Enabled = True
            btnEval.BackColor = Color.FromArgb(30, 59, 51)
        End If
    End Sub

    Private Sub BukaKuisioner(keywordMk As String, defaultDosen As String, defaultMatkul As String, defaultRuang As String)
        Dim mkId As Integer = 1
        Dim mkNama As String = defaultMatkul
        Dim dosenNama As String = defaultDosen
        Dim ruang As String = defaultRuang

        Try
            Dim courses = DatabaseHelper.GetMataKuliah()
            Dim found = courses.FirstOrDefault(Function(c) c.Nama.Contains(keywordMk, StringComparison.OrdinalIgnoreCase))
            If found IsNot Nothing Then
                mkId = found.Id
                mkNama = found.Nama
                dosenNama = found.DosenNama
                ruang = If(String.IsNullOrWhiteSpace(found.Ruang), defaultRuang, found.Ruang)
            End If
        Catch
        End Try

        Using kuis As New FormKuisionerEdom With {
            .Username = Username,
            .MataKuliahId = mkId,
            .MataKuliahNama = mkNama,
            .DosenNama = dosenNama,
            .Ruang = ruang
        }
            If kuis.ShowDialog(Me) = DialogResult.OK Then
                MuatStatusPengisian()
            End If
        End Using
    End Sub

    Private Sub btnEval1_Click(sender As Object, e As EventArgs) Handles btnEval1.Click
        BukaKuisioner("Web Lanjut", "Asep Taufik, M.Kom.", "Pemrograman Web Lanjut", "AA 301")
    End Sub

    Private Sub btnEval2_Click(sender As Object, e As EventArgs) Handles btnEval2.Click
        BukaKuisioner("Basis Data", "Risna Sari, M.Kom.", "Pemrograman Basis Data", "GSG 204")
    End Sub

    Private Sub btnEval3_Click(sender As Object, e As EventArgs) Handles btnEval3.Click
        BukaKuisioner("Analisis Sistem", "Bagus Wijaya, M.Kom.", "Analisis Sistem", "PUT 301")
    End Sub

    Private Sub btnEval4_Click(sender As Object, e As EventArgs) Handles btnEval4.Click
        BukaKuisioner("Perangkat Lunak", "Dr. Hendra Pratama, M.T.", "Rekayasa Perangkat Lunak", "AA 205")
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