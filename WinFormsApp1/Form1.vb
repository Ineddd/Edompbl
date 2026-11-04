Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fokus langsung ke input username saat form dibuka
        Me.ActiveControl = txtUsername
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' 1. Validasi jika kolom username kosong
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Silakan masukkan username terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        ' 2. Validasi jika kolom password kosong
        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Silakan masukkan password terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' 3. Cek kredensial login (contoh kredensial default)
        If (username.Equals("admin", StringComparison.OrdinalIgnoreCase) AndAlso password = "admin") OrElse
           (username.Equals("user", StringComparison.OrdinalIgnoreCase) AndAlso password = "12345") Then

            MessageBox.Show($"Selamat datang, {username}!" & vbCrLf & "Login berhasil.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Contoh jika ada Form utama / Dashboard yang ingin dibuka:
            ' Dim frmMain As New FormUtama()
            ' frmMain.Show()
            ' Me.Hide()

        Else
            MessageBox.Show("Username atau Password salah! Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ' Mengosongkan form login
        txtUsername.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle sembunyikan/tampilkan password
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

End Class
