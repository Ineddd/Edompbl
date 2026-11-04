<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents lblFooter As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.pnlLeft = New Panel()
        Me.pnlLogin = New Panel()
        Me.lblBrand = New Label()
        Me.lblWelcome = New Label()
        Me.lblSubtitle = New Label()
        Me.lblUsername = New Label()
        Me.lblPassword = New Label()
        Me.txtUsername = New TextBox()
        Me.txtPassword = New TextBox()
        Me.chkShowPassword = New CheckBox()
        Me.btnLogin = New Button()
        Me.lnkForgotPassword = New LinkLabel()
        Me.lblFooter = New Label()

        Me.SuspendLayout()

        ' Form1
        Me.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New Size(900, 560)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Login - Student Portal"

        ' pnlLeft
        Me.pnlLeft.BackColor = Color.FromArgb(30, 64, 175)
        Me.pnlLeft.Dock = DockStyle.Left
        Me.pnlLeft.Size = New Size(380, 560)

        ' lblBrand
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        Me.lblBrand.ForeColor = Color.White
        Me.lblBrand.Location = New Point(48, 76)
        Me.lblBrand.Text = "STUDENT PORTAL"

        ' lblWelcome
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        Me.lblWelcome.ForeColor = Color.White
        Me.lblWelcome.Location = New Point(48, 190)
        Me.lblWelcome.Text = "Selamat Datang!"

        ' lblSubtitle
        Me.lblSubtitle.AutoSize = False
        Me.lblSubtitle.Font = New Font("Segoe UI", 11.0F)
        Me.lblSubtitle.ForeColor = Color.FromArgb(219, 234, 254)
        Me.lblSubtitle.Location = New Point(52, 250)
        Me.lblSubtitle.Size = New Size(275, 80)
        Me.lblSubtitle.Text = "Kelola aktivitas akademik Anda dengan mudah dan aman."
        Me.lblSubtitle.TextAlign = ContentAlignment.TopLeft

        ' pnlLogin
        Me.pnlLogin.BackColor = Color.White
        Me.pnlLogin.Location = New Point(380, 0)
        Me.pnlLogin.Size = New Size(520, 560)

        ' lblUsername
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Me.lblUsername.ForeColor = Color.FromArgb(31, 41, 55)
        Me.lblUsername.Location = New Point(70, 145)
        Me.lblUsername.Text = "Username atau Email"

        ' txtUsername
        Me.txtUsername.BorderStyle = BorderStyle.FixedSingle
        Me.txtUsername.Font = New Font("Segoe UI", 11.0F)
        Me.txtUsername.Location = New Point(70, 171)
        Me.txtUsername.Size = New Size(380, 27)
        Me.txtUsername.TabIndex = 0

        ' lblPassword
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Me.lblPassword.ForeColor = Color.FromArgb(31, 41, 55)
        Me.lblPassword.Location = New Point(70, 220)
        Me.lblPassword.Text = "Password"

        ' txtPassword
        Me.txtPassword.BorderStyle = BorderStyle.FixedSingle
        Me.txtPassword.Font = New Font("Segoe UI", 11.0F)
        Me.txtPassword.Location = New Point(70, 246)
        Me.txtPassword.Size = New Size(380, 27)
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.TabIndex = 1

        ' chkShowPassword
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New Font("Segoe UI", 9.0F)
        Me.chkShowPassword.ForeColor = Color.FromArgb(75, 85, 99)
        Me.chkShowPassword.Location = New Point(70, 286)
        Me.chkShowPassword.Text = "Tampilkan password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        Me.chkShowPassword.TabIndex = 2

        ' lnkForgotPassword
        Me.lnkForgotPassword.AutoSize = True
        Me.lnkForgotPassword.Font = New Font("Segoe UI", 9.0F)
        Me.lnkForgotPassword.LinkColor = Color.FromArgb(37, 99, 235)
        Me.lnkForgotPassword.Location = New Point(326, 288)
        Me.lnkForgotPassword.Text = "Lupa password?"
        Me.lnkForgotPassword.TabIndex = 3

        ' btnLogin
        Me.btnLogin.BackColor = Color.FromArgb(37, 99, 235)
        Me.btnLogin.Cursor = Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.Location = New Point(70, 335)
        Me.btnLogin.Size = New Size(380, 45)
        Me.btnLogin.Text = "MASUK"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.TabIndex = 4

        ' lblFooter
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Font = New Font("Segoe UI", 8.5F)
        Me.lblFooter.ForeColor = Color.FromArgb(107, 114, 128)
        Me.lblFooter.Location = New Point(145, 495)
        Me.lblFooter.Text = "© 2026 Student Portal"

        Me.pnlLogin.Controls.Add(Me.lblUsername)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.chkShowPassword)
        Me.pnlLogin.Controls.Add(Me.lnkForgotPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lblFooter)

        Me.pnlLeft.Controls.Add(Me.lblBrand)
        Me.pnlLeft.Controls.Add(Me.lblWelcome)
        Me.pnlLeft.Controls.Add(Me.lblSubtitle)

        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlLeft)

        Me.ResumeLayout(False)
    End Sub
End Class
