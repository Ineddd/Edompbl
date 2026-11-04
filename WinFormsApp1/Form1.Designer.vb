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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Controls.Add(Me.lblSubtitle)
        Me.pnlCard.Controls.Add(Me.lblUsername)
        Me.pnlCard.Controls.Add(Me.txtUsername)
        Me.pnlCard.Controls.Add(Me.lblPassword)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.chkShowPassword)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Controls.Add(Me.btnBatal)
        Me.pnlCard.Controls.Add(Me.lblFooter)
        Me.pnlCard.Location = New System.Drawing.Point(30, 25)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(380, 430)
        Me.pnlCard.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblTitle.Location = New System.Drawing.Point(15, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(350, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "HALAMAN LOGIN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblSubtitle.Location = New System.Drawing.Point(15, 60)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(350, 22)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Masukkan username dan password Anda"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64)
        Me.lblUsername.Location = New System.Drawing.Point(35, 100)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(69, 17)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(35, 122)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(310, 27)
        Me.txtUsername.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64)
        Me.lblPassword.Location = New System.Drawing.Point(35, 165)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 17)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(35, 187)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(310, 27)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
        Me.chkShowPassword.Location = New System.Drawing.Point(35, 224)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(129, 19)
        Me.chkShowPassword.TabIndex = 6
        Me.chkShowPassword.Text = "Tampilkan Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(13, 110, 253)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(35, 260)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(310, 40)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(233, 236, 239)
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
        Me.btnBatal.Location = New System.Drawing.Point(35, 310)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(310, 36)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Reset / Bersihkan"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'lblFooter
        '
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblFooter.Location = New System.Drawing.Point(15, 365)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(350, 40)
        Me.lblFooter.TabIndex = 9
        Me.lblFooter.Text = "Default akun:" & vbCrLf & "Username: admin | Password: admin"
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 244, 248)
        Me.CancelButton = Me.btnBatal
        Me.ClientSize = New System.Drawing.Size(440, 480)
        Me.Controls.Add(Me.pnlCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Sistem"
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label

End Class
