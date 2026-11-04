Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show(
                "Username harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show(
                "Password harus diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Focus()
            Return
        End If

        Try
            Dim loginBerhasil As Boolean =
                DatabaseHelper.Login(username, password)

            If loginBerhasil Then
                txtPassword.Clear()

                Dim dashboard As New Dashboard With {
                    .Username = username,
                    .LoginForm = Me
                }

                Hide()
                dashboard.Show()
            Else
                MessageBox.Show(
                    "Username atau password salah.",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As MySqlException
            MessageBox.Show(
                "Tidak dapat terhubung ke database MySQL." &
                Environment.NewLine &
                "Pastikan MySQL XAMPP sedang berjalan." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Kesalahan Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnBatal_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBatal.Click

        txtUsername.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked
    End Sub

End Class