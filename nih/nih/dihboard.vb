Public Class dihboard

    Private Sub dihboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Text = "Dashboard Mahasiswa"
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub dihboard_FormClosed(
        sender As Object,
        e As FormClosedEventArgs
    ) Handles MyBase.FormClosed

        Application.Exit()
    End Sub

End Class