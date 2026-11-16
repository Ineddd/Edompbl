Imports System.Drawing
Imports System.Windows.Forms

Public Class Dashboard

    Private ReadOnly ActiveMenuColor As Color = Color.FromArgb(114, 142, 109)
    Private ReadOnly InactiveMenuColor As Color = Color.FromArgb(46, 82, 72)

    Public Property Username As String
    Public Property LoginForm As Form

    Private loggingOut As Boolean
    Private navigating As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub Dashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If String.IsNullOrWhiteSpace(Username) Then
            Username = "Mahasiswa"
        End If

        lblWelcome.Text = $"Selamat datang, {Username}"
        SetActiveMenuButton(btnDashboard)

        dgvSchedule.Rows.Clear()

        Try
            Dim courses As List(Of MataKuliahItem) = Await Task.Run(AddressOf DatabaseHelper.GetMataKuliah)
            If courses IsNot Nothing AndAlso courses.Count > 0 Then
                Dim defaultTimes() As String = {
                    "08:00 - 09:40", "10:00 - 11:40", "13:00 - 14:40", "15:00 - 16:40", "16:40 - 18:20"
                }
                Dim idx As Integer = 0
                For Each c In courses
                    Dim timeStr As String = defaultTimes(idx Mod defaultTimes.Length)
                    dgvSchedule.Rows.Add(
                        timeStr,
                        c.Nama,
                        c.DosenNama,
                        If(String.IsNullOrWhiteSpace(c.Ruang), "-", c.Ruang)
                    )
                    idx += 1
                Next
                lblCourseValue.Text = courses.Count.ToString()
            Else
                LoadFallbackSchedule()
            End If
        Catch
            LoadFallbackSchedule()
        End Try

        dgvSchedule.ClearSelection()
    End Sub

    Private Sub LoadFallbackSchedule()
        dgvSchedule.Rows.Clear()

        dgvSchedule.Rows.Add(
            "08:00 - 09:40",
            "Pemrograman Web Lanjut",
            "Asep Taufik, M.Kom.",
            "AA 301"
        )

        dgvSchedule.Rows.Add(
            "10:00 - 11:40",
            "Pemrograman Basis Data",
            "Risna Sari, M.Kom.",
            "GSG 204"
        )

        dgvSchedule.Rows.Add(
            "13:00 - 14:40",
            "Analisis Sistem",
            "Bagus Wijaya, M.Kom.",
            "PUT 301"
        )
    End Sub

    Public Sub SetActiveMenuButton(activeButton As Button)
        navigating = False
        btnDashboard.BackColor = If(activeButton Is btnDashboard, ActiveMenuColor, InactiveMenuColor)
        Button1.BackColor = If(activeButton Is Button1, ActiveMenuColor, InactiveMenuColor)
    End Sub

    Private Sub btnDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDashboard.Click

        SetActiveMenuButton(btnDashboard)
    End Sub

    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click

        SetActiveMenuButton(Button1)

        Dim edomForm As New pengisianEdom With {
            .Username = Username,
            .LoginForm = LoginForm,
            .DashboardForm = Me,
            .StartPosition = FormStartPosition.Manual,
            .Location = Location,
            .Size = Size,
            .WindowState = WindowState
        }

        navigating = True
        Hide()
        edomForm.Show()
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

        If LoginForm IsNot Nothing Then
            LoginForm.Show()
        End If

        Close()
    End Sub

    Private Sub Dashboard_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        If Not loggingOut AndAlso Not navigating Then
            Application.Exit()
        End If
    End Sub

End Class