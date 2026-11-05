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

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub pengisianEdom_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetActiveMenuButton(Button1)
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