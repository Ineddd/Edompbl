Imports System.Drawing
Imports System.Windows.Forms

Public Class Dashboard

    Public Property Username As String
    Public Property LoginForm As Form

    Private loggingOut As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Dashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If String.IsNullOrWhiteSpace(Username) Then
            Username = "Mahasiswa"
        End If

        lblWelcome.Text = $"Selamat datang, {Username}"

        dgvSchedule.Rows.Clear()

        dgvSchedule.Rows.Add(
            "08:00 - 09:40",
            "Pemrograman Web",
            "Dr. Budi Santoso",
            "Lab Komputer 1"
        )

        dgvSchedule.Rows.Add(
            "10:00 - 11:40",
            "Basis Data",
            "Siti Rahma, M.Kom.",
            "Ruang 204"
        )

        dgvSchedule.Rows.Add(
            "13:00 - 14:40",
            "Analisis Sistem",
            "Andi Wijaya, M.Kom.",
            "Ruang 301"
        )
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

        If result <> DialogResult.Yes Then
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

        If Not loggingOut Then
            Application.Exit()
        End If
    End Sub

End Class