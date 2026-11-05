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
    Friend WithEvents lblBrandSub As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents lblScaleTitle As Label
    Friend WithEvents lblScale1 As Label
    Friend WithEvents lblScale2 As Label
    Friend WithEvents lblScale3 As Label
    Friend WithEvents lblScale4 As Label
    Friend WithEvents lblScale5 As Label
    Friend WithEvents lblScaleLow As Label
    Friend WithEvents lblScaleHigh As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHint As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents pnlNimBox As Panel
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents pnlPasswordBox As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents lblError As Label
    Friend WithEvents btnLogin As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlLeft = New Panel()
        lblBrand = New Label()
        lblBrandSub = New Label()
        lblIntro = New Label()
        lblScaleTitle = New Label()
        lblScale1 = New Label()
        lblScale2 = New Label()
        lblScale3 = New Label()
        lblScale4 = New Label()
        lblScale5 = New Label()
        lblScaleLow = New Label()
        lblScaleHigh = New Label()
        pnlLogin = New Panel()
        lblTitle = New Label()
        lblHint = New Label()
        lblNim = New Label()
        pnlNimBox = New Panel()
        txtNim = New TextBox()
        lblPassword = New Label()
        pnlPasswordBox = New Panel()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        lnkForgotPassword = New LinkLabel()
        lblError = New Label()
        btnLogin = New Button()
        pnlLeft.SuspendLayout()
        pnlLogin.SuspendLayout()
        pnlNimBox.SuspendLayout()
        pnlPasswordBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        pnlLeft.Controls.Add(lblBrand)
        pnlLeft.Controls.Add(lblBrandSub)
        pnlLeft.Controls.Add(lblIntro)
        pnlLeft.Controls.Add(lblScaleTitle)
        pnlLeft.Controls.Add(lblScale1)
        pnlLeft.Controls.Add(lblScale2)
        pnlLeft.Controls.Add(lblScale3)
        pnlLeft.Controls.Add(lblScale4)
        pnlLeft.Controls.Add(lblScale5)
        pnlLeft.Controls.Add(lblScaleLow)
        pnlLeft.Controls.Add(lblScaleHigh)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Margin = New Padding(3, 4, 3, 4)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(411, 747)
        pnlLeft.TabIndex = 1
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Georgia", 30F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(46, 75)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(238, 58)
        lblBrand.TabIndex = 0
        lblBrand.Text = "SIAKAD"
        ' 
        ' lblBrandSub
        ' 
        lblBrandSub.AutoSize = True
        lblBrandSub.Font = New Font("Segoe UI", 11F)
        lblBrandSub.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblBrandSub.Location = New Point(50, 147)
        lblBrandSub.Name = "lblBrandSub"
        lblBrandSub.Size = New Size(238, 25)
        lblBrandSub.TabIndex = 1
        lblBrandSub.Text = "Sistem Informasi Akademik"
        ' 
        ' lblIntro
        ' 
        lblIntro.Font = New Font("Segoe UI", 10.5F)
        lblIntro.ForeColor = Color.White
        lblIntro.Location = New Point(50, 261)
        lblIntro.Name = "lblIntro"
        lblIntro.Size = New Size(320, 120)
        lblIntro.TabIndex = 2
        lblIntro.Text = "Masuk dengan NIM untuk mengisi evaluasi setiap dosen pengampu mata kuliah Anda semester ini."
        ' 
        ' lblScaleTitle
        ' 
        lblScaleTitle.AutoSize = True
        lblScaleTitle.Font = New Font("Segoe UI", 9F)
        lblScaleTitle.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblScaleTitle.Location = New Point(50, 525)
        lblScaleTitle.Name = "lblScaleTitle"
        lblScaleTitle.Size = New Size(198, 20)
        lblScaleTitle.TabIndex = 3
        lblScaleTitle.Text = "Skala penilaian yang dipakai"
        ' 
        ' lblScale1
        ' 
        lblScale1.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        lblScale1.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblScale1.ForeColor = Color.White
        lblScale1.Location = New Point(50, 560)
        lblScale1.Name = "lblScale1"
        lblScale1.Size = New Size(50, 59)
        lblScale1.TabIndex = 4
        lblScale1.Text = "1"
        lblScale1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScale2
        ' 
        lblScale2.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        lblScale2.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblScale2.ForeColor = Color.White
        lblScale2.Location = New Point(110, 560)
        lblScale2.Name = "lblScale2"
        lblScale2.Size = New Size(50, 59)
        lblScale2.TabIndex = 5
        lblScale2.Text = "2"
        lblScale2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScale3
        ' 
        lblScale3.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        lblScale3.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblScale3.ForeColor = Color.White
        lblScale3.Location = New Point(169, 560)
        lblScale3.Name = "lblScale3"
        lblScale3.Size = New Size(50, 59)
        lblScale3.TabIndex = 6
        lblScale3.Text = "3"
        lblScale3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScale4
        ' 
        lblScale4.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        lblScale4.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblScale4.ForeColor = Color.White
        lblScale4.Location = New Point(229, 560)
        lblScale4.Name = "lblScale4"
        lblScale4.Size = New Size(50, 59)
        lblScale4.TabIndex = 7
        lblScale4.Text = "4"
        lblScale4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScale5
        ' 
        lblScale5.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        lblScale5.Font = New Font("Georgia", 12F, FontStyle.Bold)
        lblScale5.ForeColor = Color.White
        lblScale5.Location = New Point(288, 560)
        lblScale5.Name = "lblScale5"
        lblScale5.Size = New Size(50, 59)
        lblScale5.TabIndex = 8
        lblScale5.Text = "5"
        lblScale5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScaleLow
        ' 
        lblScaleLow.AutoSize = True
        lblScaleLow.Font = New Font("Segoe UI", 8.5F)
        lblScaleLow.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblScaleLow.Location = New Point(48, 629)
        lblScaleLow.Name = "lblScaleLow"
        lblScaleLow.Size = New Size(104, 20)
        lblScaleLow.TabIndex = 9
        lblScaleLow.Text = "Sangat kurang"
        ' 
        ' lblScaleHigh
        ' 
        lblScaleHigh.AutoSize = True
        lblScaleHigh.Font = New Font("Segoe UI", 8.5F)
        lblScaleHigh.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblScaleHigh.Location = New Point(270, 629)
        lblScaleHigh.Name = "lblScaleHigh"
        lblScaleHigh.Size = New Size(87, 20)
        lblScaleHigh.TabIndex = 10
        lblScaleHigh.Text = "Sangat baik"
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlLogin.Controls.Add(lblTitle)
        pnlLogin.Controls.Add(lblHint)
        pnlLogin.Controls.Add(lblNim)
        pnlLogin.Controls.Add(pnlNimBox)
        pnlLogin.Controls.Add(lblPassword)
        pnlLogin.Controls.Add(pnlPasswordBox)
        pnlLogin.Controls.Add(chkShowPassword)
        pnlLogin.Controls.Add(lnkForgotPassword)
        pnlLogin.Controls.Add(lblError)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(411, 0)
        pnlLogin.Margin = New Padding(3, 4, 3, 4)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(618, 747)
        pnlLogin.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 22F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        lblTitle.Location = New Point(75, 128)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(146, 43)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Masuk"
        ' 
        ' lblHint
        ' 
        lblHint.AutoSize = True
        lblHint.Font = New Font("Segoe UI", 10F)
        lblHint.ForeColor = Color.FromArgb(CByte(84), CByte(90), CByte(86))
        lblHint.Location = New Point(80, 192)
        lblHint.Name = "lblHint"
        lblHint.Size = New Size(394, 23)
        lblHint.TabIndex = 1
        lblHint.Text = "Gunakan NIM dan password akun akademik Anda."
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblNim.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        lblNim.Location = New Point(80, 261)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(44, 23)
        lblNim.TabIndex = 2
        lblNim.Text = "NIM"
        ' 
        ' pnlNimBox
        ' 
        pnlNimBox.BackColor = Color.White
        pnlNimBox.Controls.Add(txtNim)
        pnlNimBox.Cursor = Cursors.IBeam
        pnlNimBox.Location = New Point(80, 293)
        pnlNimBox.Margin = New Padding(3, 4, 3, 4)
        pnlNimBox.Name = "pnlNimBox"
        pnlNimBox.Padding = New Padding(14, 12, 14, 0)
        pnlNimBox.Size = New Size(457, 53)
        pnlNimBox.TabIndex = 3
        ' 
        ' txtNim
        ' 
        txtNim.BackColor = Color.White
        txtNim.BorderStyle = BorderStyle.None
        txtNim.Dock = DockStyle.Top
        txtNim.Font = New Font("Segoe UI", 11F)
        txtNim.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        txtNim.Location = New Point(14, 12)
        txtNim.Margin = New Padding(3, 4, 3, 4)
        txtNim.MaxLength = 15
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(429, 25)
        txtNim.TabIndex = 0
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        lblPassword.Location = New Point(80, 371)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(82, 23)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' pnlPasswordBox
        ' 
        pnlPasswordBox.BackColor = Color.White
        pnlPasswordBox.Controls.Add(txtPassword)
        pnlPasswordBox.Cursor = Cursors.IBeam
        pnlPasswordBox.Location = New Point(80, 403)
        pnlPasswordBox.Margin = New Padding(3, 4, 3, 4)
        pnlPasswordBox.Name = "pnlPasswordBox"
        pnlPasswordBox.Padding = New Padding(14, 12, 14, 0)
        pnlPasswordBox.Size = New Size(457, 53)
        pnlPasswordBox.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Dock = DockStyle.Top
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        txtPassword.Location = New Point(14, 12)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(429, 25)
        txtPassword.TabIndex = 1
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Cursor = Cursors.Hand
        chkShowPassword.Font = New Font("Segoe UI", 9.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(84), CByte(90), CByte(86))
        chkShowPassword.Location = New Point(80, 469)
        chkShowPassword.Margin = New Padding(3, 4, 3, 4)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(173, 25)
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Tampilkan password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lnkForgotPassword
        ' 
        lnkForgotPassword.ActiveLinkColor = Color.FromArgb(CByte(14), CByte(31), CByte(27))
        lnkForgotPassword.AutoSize = True
        lnkForgotPassword.Font = New Font("Segoe UI", 9.5F)
        lnkForgotPassword.LinkColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lnkForgotPassword.Location = New Point(427, 472)
        lnkForgotPassword.Name = "lnkForgotPassword"
        lnkForgotPassword.Size = New Size(122, 21)
        lnkForgotPassword.TabIndex = 3
        lnkForgotPassword.TabStop = True
        lnkForgotPassword.Text = "Lupa password?"
        ' 
        ' lblError
        ' 
        lblError.Font = New Font("Segoe UI", 9.5F)
        lblError.ForeColor = Color.FromArgb(CByte(180), CByte(35), CByte(24))
        lblError.Location = New Point(80, 512)
        lblError.Name = "lblError"
        lblError.Size = New Size(457, 53)
        lblError.TabIndex = 6
        lblError.Visible = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(14), CByte(31), CByte(27))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(45), CByte(39))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(80, 571)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(457, 61)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Masuk ke EDOM"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        ClientSize = New Size(1029, 747)
        Controls.Add(pnlLogin)
        Controls.Add(pnlLeft)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIAKAD - Login"
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        pnlNimBox.ResumeLayout(False)
        pnlNimBox.PerformLayout()
        pnlPasswordBox.ResumeLayout(False)
        pnlPasswordBox.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
