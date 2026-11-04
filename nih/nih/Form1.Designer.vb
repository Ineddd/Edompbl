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
    Friend WithEvents lblError As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblHelp As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.pnlLeft = New Panel()
        Me.pnlLogin = New Panel()
        Me.lblBrand = New Label()
        Me.lblBrandSub = New Label()
        Me.lblIntro = New Label()
        Me.lblScaleTitle = New Label()
        Me.lblScale1 = New Label()
        Me.lblScale2 = New Label()
        Me.lblScale3 = New Label()
        Me.lblScale4 = New Label()
        Me.lblScale5 = New Label()
        Me.lblScaleLow = New Label()
        Me.lblScaleHigh = New Label()
        Me.lblTitle = New Label()
        Me.lblHint = New Label()
        Me.lblNim = New Label()
        Me.pnlNimBox = New Panel()
        Me.txtNim = New TextBox()
        Me.lblPassword = New Label()
        Me.pnlPasswordBox = New Panel()
        Me.txtPassword = New TextBox()
        Me.chkShowPassword = New CheckBox()
        Me.lblError = New Label()
        Me.btnLogin = New Button()
        Me.lblHelp = New Label()

        Me.pnlLeft.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.pnlNimBox.SuspendLayout()
        Me.pnlPasswordBox.SuspendLayout()
        Me.SuspendLayout()

        ' pnlLeft
        Me.pnlLeft.BackColor = Color.FromArgb(30, 59, 51)
        Me.pnlLeft.Dock = DockStyle.Left
        Me.pnlLeft.Size = New Size(360, 560)
        Me.pnlLeft.Name = "pnlLeft"

        ' lblBrand
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New Font("Georgia", 30.0F, FontStyle.Bold)
        Me.lblBrand.ForeColor = Color.White
        Me.lblBrand.Location = New Point(40, 56)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Text = "EDOM"

        ' lblBrandSub
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.Font = New Font("Segoe UI", 11.0F)
        Me.lblBrandSub.ForeColor = Color.FromArgb(214, 226, 220)
        Me.lblBrandSub.Location = New Point(44, 110)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Text = "Evaluasi Dosen oleh Mahasiswa"

        ' lblIntro
        Me.lblIntro.AutoSize = False
        Me.lblIntro.Font = New Font("Segoe UI", 10.5F)
        Me.lblIntro.ForeColor = Color.White
        Me.lblIntro.Location = New Point(44, 196)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New Size(280, 90)
        Me.lblIntro.Text = "Masuk dengan NIM untuk mengisi evaluasi setiap dosen pengampu mata kuliah Anda semester ini."

        ' lblScaleTitle
        Me.lblScaleTitle.AutoSize = True
        Me.lblScaleTitle.Font = New Font("Segoe UI", 9.0F)
        Me.lblScaleTitle.ForeColor = Color.FromArgb(214, 226, 220)
        Me.lblScaleTitle.Location = New Point(44, 394)
        Me.lblScaleTitle.Name = "lblScaleTitle"
        Me.lblScaleTitle.Text = "Skala penilaian yang dipakai"

        ' lblScale1
        Me.lblScale1.BackColor = Color.FromArgb(46, 82, 72)
        Me.lblScale1.Font = New Font("Georgia", 12.0F, FontStyle.Bold)
        Me.lblScale1.ForeColor = Color.White
        Me.lblScale1.Location = New Point(44, 420)
        Me.lblScale1.Name = "lblScale1"
        Me.lblScale1.Size = New Size(44, 44)
        Me.lblScale1.Text = "1"
        Me.lblScale1.TextAlign = ContentAlignment.MiddleCenter

        ' lblScale2
        Me.lblScale2.BackColor = Color.FromArgb(46, 82, 72)
        Me.lblScale2.Font = New Font("Georgia", 12.0F, FontStyle.Bold)
        Me.lblScale2.ForeColor = Color.White
        Me.lblScale2.Location = New Point(96, 420)
        Me.lblScale2.Name = "lblScale2"
        Me.lblScale2.Size = New Size(44, 44)
        Me.lblScale2.Text = "2"
        Me.lblScale2.TextAlign = ContentAlignment.MiddleCenter

        ' lblScale3
        Me.lblScale3.BackColor = Color.FromArgb(46, 82, 72)
        Me.lblScale3.Font = New Font("Georgia", 12.0F, FontStyle.Bold)
        Me.lblScale3.ForeColor = Color.White
        Me.lblScale3.Location = New Point(148, 420)
        Me.lblScale3.Name = "lblScale3"
        Me.lblScale3.Size = New Size(44, 44)
        Me.lblScale3.Text = "3"
        Me.lblScale3.TextAlign = ContentAlignment.MiddleCenter

        ' lblScale4
        Me.lblScale4.BackColor = Color.FromArgb(46, 82, 72)
        Me.lblScale4.Font = New Font("Georgia", 12.0F, FontStyle.Bold)
        Me.lblScale4.ForeColor = Color.White
        Me.lblScale4.Location = New Point(200, 420)
        Me.lblScale4.Name = "lblScale4"
        Me.lblScale4.Size = New Size(44, 44)
        Me.lblScale4.Text = "4"
        Me.lblScale4.TextAlign = ContentAlignment.MiddleCenter

        ' lblScale5
        Me.lblScale5.BackColor = Color.FromArgb(46, 82, 72)
        Me.lblScale5.Font = New Font("Georgia", 12.0F, FontStyle.Bold)
        Me.lblScale5.ForeColor = Color.White
        Me.lblScale5.Location = New Point(252, 420)
        Me.lblScale5.Name = "lblScale5"
        Me.lblScale5.Size = New Size(44, 44)
        Me.lblScale5.Text = "5"
        Me.lblScale5.TextAlign = ContentAlignment.MiddleCenter

        ' lblScaleLow
        Me.lblScaleLow.AutoSize = True
        Me.lblScaleLow.Font = New Font("Segoe UI", 8.5F)
        Me.lblScaleLow.ForeColor = Color.FromArgb(214, 226, 220)
        Me.lblScaleLow.Location = New Point(42, 472)
        Me.lblScaleLow.Name = "lblScaleLow"
        Me.lblScaleLow.Text = "Sangat kurang"

        ' lblScaleHigh
        Me.lblScaleHigh.AutoSize = True
        Me.lblScaleHigh.Font = New Font("Segoe UI", 8.5F)
        Me.lblScaleHigh.ForeColor = Color.FromArgb(214, 226, 220)
        Me.lblScaleHigh.Location = New Point(236, 472)
        Me.lblScaleHigh.Name = "lblScaleHigh"
        Me.lblScaleHigh.Text = "Sangat baik"

        ' pnlLogin
        Me.pnlLogin.BackColor = Color.FromArgb(250, 248, 243)
        Me.pnlLogin.Dock = DockStyle.Fill
        Me.pnlLogin.Name = "pnlLogin"

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Georgia", 22.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(31, 36, 33)
        Me.lblTitle.Location = New Point(66, 96)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "Masuk"

        ' lblHint
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New Font("Segoe UI", 10.0F)
        Me.lblHint.ForeColor = Color.FromArgb(84, 90, 86)
        Me.lblHint.Location = New Point(70, 144)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Text = "Gunakan NIM dan password akun akademik Anda."

        ' lblNim
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Me.lblNim.ForeColor = Color.FromArgb(31, 36, 33)
        Me.lblNim.Location = New Point(70, 196)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Text = "NIM"

        ' pnlNimBox
        Me.pnlNimBox.BackColor = Color.White
        Me.pnlNimBox.Location = New Point(70, 220)
        Me.pnlNimBox.Name = "pnlNimBox"
        Me.pnlNimBox.Padding = New Padding(12, 9, 12, 0)
        Me.pnlNimBox.Size = New Size(400, 40)
        Me.pnlNimBox.Cursor = Cursors.IBeam

        ' txtNim
        Me.txtNim.BackColor = Color.White
        Me.txtNim.BorderStyle = BorderStyle.None
        Me.txtNim.Dock = DockStyle.Top
        Me.txtNim.Font = New Font("Segoe UI", 11.0F)
        Me.txtNim.ForeColor = Color.FromArgb(31, 36, 33)
        Me.txtNim.MaxLength = 15
        Me.txtNim.Name = "txtNim"
        Me.txtNim.TabIndex = 0

        ' lblPassword
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Me.lblPassword.ForeColor = Color.FromArgb(31, 36, 33)
        Me.lblPassword.Location = New Point(70, 278)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "Password"

        ' pnlPasswordBox
        Me.pnlPasswordBox.BackColor = Color.White
        Me.pnlPasswordBox.Location = New Point(70, 302)
        Me.pnlPasswordBox.Name = "pnlPasswordBox"
        Me.pnlPasswordBox.Padding = New Padding(12, 9, 12, 0)
        Me.pnlPasswordBox.Size = New Size(400, 40)
        Me.pnlPasswordBox.Cursor = Cursors.IBeam

        ' txtPassword
        Me.txtPassword.BackColor = Color.White
        Me.txtPassword.BorderStyle = BorderStyle.None
        Me.txtPassword.Dock = DockStyle.Top
        Me.txtPassword.Font = New Font("Segoe UI", 11.0F)
        Me.txtPassword.ForeColor = Color.FromArgb(31, 36, 33)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.TabIndex = 1

        ' chkShowPassword
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Cursor = Cursors.Hand
        Me.chkShowPassword.Font = New Font("Segoe UI", 9.5F)
        Me.chkShowPassword.ForeColor = Color.FromArgb(84, 90, 86)
        Me.chkShowPassword.Location = New Point(70, 352)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Text = "Tampilkan password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        Me.chkShowPassword.TabIndex = 2

        ' lblError
        Me.lblError.AutoSize = False
        Me.lblError.Font = New Font("Segoe UI", 9.5F)
        Me.lblError.ForeColor = Color.FromArgb(180, 35, 24)
        Me.lblError.Location = New Point(70, 384)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New Size(400, 40)
        Me.lblError.Text = ""
        Me.lblError.Visible = False

        ' btnLogin
        Me.btnLogin.BackColor = Color.FromArgb(30, 59, 51)
        Me.btnLogin.Cursor = Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(22, 45, 39)
        Me.btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 31, 27)
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.Location = New Point(70, 428)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New Size(400, 46)
        Me.btnLogin.Text = "Masuk ke EDOM"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.TabIndex = 3

        ' lblHelp
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New Font("Segoe UI", 9.0F)
        Me.lblHelp.ForeColor = Color.FromArgb(84, 90, 86)
        Me.lblHelp.Location = New Point(70, 492)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Text = "Lupa password? Hubungi bagian akademik program studi."

        Me.pnlNimBox.Controls.Add(Me.txtNim)
        Me.pnlPasswordBox.Controls.Add(Me.txtPassword)

        Me.pnlLogin.Controls.Add(Me.lblTitle)
        Me.pnlLogin.Controls.Add(Me.lblHint)
        Me.pnlLogin.Controls.Add(Me.lblNim)
        Me.pnlLogin.Controls.Add(Me.pnlNimBox)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.pnlPasswordBox)
        Me.pnlLogin.Controls.Add(Me.chkShowPassword)
        Me.pnlLogin.Controls.Add(Me.lblError)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lblHelp)

        Me.pnlLeft.Controls.Add(Me.lblBrand)
        Me.pnlLeft.Controls.Add(Me.lblBrandSub)
        Me.pnlLeft.Controls.Add(Me.lblIntro)
        Me.pnlLeft.Controls.Add(Me.lblScaleTitle)
        Me.pnlLeft.Controls.Add(Me.lblScale1)
        Me.pnlLeft.Controls.Add(Me.lblScale2)
        Me.pnlLeft.Controls.Add(Me.lblScale3)
        Me.pnlLeft.Controls.Add(Me.lblScale4)
        Me.pnlLeft.Controls.Add(Me.lblScale5)
        Me.pnlLeft.Controls.Add(Me.lblScaleLow)
        Me.pnlLeft.Controls.Add(Me.lblScaleHigh)

        ' Form1
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(250, 248, 243)
        Me.ClientSize = New Size(900, 560)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "EDOM - Masuk"

        Me.pnlNimBox.ResumeLayout(False)
        Me.pnlNimBox.PerformLayout()
        Me.pnlPasswordBox.ResumeLayout(False)
        Me.pnlPasswordBox.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
End Class
