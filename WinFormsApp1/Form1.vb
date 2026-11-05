Imports MySql.Data.MySqlClient

Public Class Form1

    Private ReadOnly BorderIdle As Color = Color.FromArgb(138, 133, 122)
    Private ReadOnly BorderFocus As Color = Color.FromArgb(30, 59, 51)
    Private ReadOnly BorderError As Color = Color.FromArgb(180, 35, 24)

    Private _nimInvalid As Boolean
    Private _passwordInvalid As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNim.Focus()
    End Sub

    ' Input box border: idle, focused, or invalid.
    Private Sub InputBox_Paint(sender As Object, e As PaintEventArgs) _
        Handles pnlNimBox.Paint, pnlPasswordBox.Paint

        Dim box As Panel = DirectCast(sender, Panel)
        Dim input As TextBox = If(box Is pnlNimBox, txtNim, txtPassword)
        Dim invalid As Boolean = If(box Is pnlNimBox, _nimInvalid, _passwordInvalid)

        Dim color As Color = BorderIdle
        Dim width As Integer = 1

        If invalid Then
            color = BorderError
            width = 2
        ElseIf input.Focused Then
            color = BorderFocus
            width = 2
        End If

        Using pen As New Pen(color, width)
            pen.Alignment = Drawing2D.PenAlignment.Inset
            e.Graphics.DrawRectangle(pen, 0, 0, box.Width - 1, box.Height - 1)
        End Using
    End Sub

    Private Sub Input_FocusChanged(sender As Object, e As EventArgs) _
        Handles txtNim.Enter, txtNim.Leave, txtPassword.Enter, txtPassword.Leave

        pnlNimBox.Invalidate()
        pnlPasswordBox.Invalidate()
    End Sub

    Private Sub InputBox_Click(sender As Object, e As EventArgs) _
        Handles pnlNimBox.Click, pnlPasswordBox.Click

        If sender Is pnlNimBox Then
            txtNim.Focus()
        Else
            txtPassword.Focus()
        End If
    End Sub

    'Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
    '    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) _
        Handles txtNim.TextChanged, txtPassword.TextChanged

        If lblError.Visible Then
            ClearError()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub lnkForgotPassword_LinkClicked(
        sender As Object,
        e As LinkLabelLinkClickedEventArgs
    ) Handles lnkForgotPassword.LinkClicked

        MessageBox.Show(
            "Fitur pemulihan password belum tersedia. Silakan hubungi bagian akademik program studi.",
            "Lupa Password",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ClearError()

        Dim nim As String = txtNim.Text.Trim()
        Dim password As String = txtPassword.Text

        If nim.Length = 0 Then
            ShowError("NIM belum diisi.", nimInvalid:=True, passwordInvalid:=False)
            txtNim.Focus()
            Return
        End If

        If password.Length = 0 Then
            ShowError("Password belum diisi.", nimInvalid:=False, passwordInvalid:=True)
            txtPassword.Focus()
            Return
        End If

        SetBusy(True)

        Dim success As Boolean = Await Task.Run(Function()
                                                    Try
                                                        Return DatabaseHelper.Login(nim, password)
                                                    Catch
                                                        Return False
                                                    End Try
                                                End Function)

        SetBusy(False)

        If Not success Then
            ShowError("Username atau password salah.", nimInvalid:=True, passwordInvalid:=True)
            txtPassword.SelectAll()
            txtPassword.Focus()
            Return
        End If

        OpenDashboard(nim)
    End Sub

    Private Sub OpenDashboard(nim As String)
        txtPassword.Clear()
        chkShowPassword.Checked = False
        ClearError()

        Dim dashboard As New Dashboard With {
            .Username = nim,
            .LoginForm = Me
        }

        Hide()
        dashboard.Show()
    End Sub

    Private Sub SetBusy(busy As Boolean)
        btnLogin.Enabled = Not busy
        btnLogin.Text = If(busy, "Memeriksa akun...", "Masuk ke EDOM")
        btnLogin.BackColor = If(busy, Color.FromArgb(92, 112, 105), Color.FromArgb(30, 59, 51))
        txtNim.ReadOnly = busy
        txtPassword.ReadOnly = busy
        UseWaitCursor = busy
    End Sub

    Private Sub ShowError(message As String, nimInvalid As Boolean, passwordInvalid As Boolean)
        lblError.Text = message
        lblError.Visible = True
        _nimInvalid = nimInvalid
        _passwordInvalid = passwordInvalid
        pnlNimBox.Invalidate()
        pnlPasswordBox.Invalidate()
    End Sub

    Private Sub ClearError()
        lblError.Text = ""
        lblError.Visible = False
        _nimInvalid = False
        _passwordInvalid = False
        pnlNimBox.Invalidate()
        pnlPasswordBox.Invalidate()
    End Sub

End Class