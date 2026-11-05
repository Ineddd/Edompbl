<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dihboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlEmpty As Panel
    Friend WithEvents lblEmptyTitle As Label
    Friend WithEvents lblEmptyBody As Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblBrand = New Label()
        lblUser = New Label()
        btnLogout = New Button()
        pnlBody = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        pnlEmpty = New Panel()
        lblEmptyTitle = New Label()
        lblEmptyBody = New Label()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlEmpty.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        pnlHeader.Controls.Add(lblBrand)
        pnlHeader.Controls.Add(lblUser)
        pnlHeader.Controls.Add(btnLogout)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1097, 85)
        pnlHeader.TabIndex = 1
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Georgia", 16.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(37, 24)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(106, 31)
        lblBrand.TabIndex = 0
        lblBrand.Text = "EDOM"
        ' 
        ' lblUser
        ' 
        lblUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUser.Font = New Font("Segoe UI", 10.0F)
        lblUser.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblUser.Location = New Point(640, 27)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(297, 32)
        lblUser.TabIndex = 1
        lblUser.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(22), CByte(45), CByte(39))
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.5F)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(955, 19)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(110, 48)
        btnLogout.TabIndex = 0
        btnLogout.Text = "Keluar"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlBody.Controls.Add(lblTitle)
        pnlBody.Controls.Add(lblSubtitle)
        pnlBody.Controls.Add(pnlEmpty)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 85)
        pnlBody.Margin = New Padding(3, 4, 3, 4)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(37, 43, 37, 43)
        pnlBody.Size = New Size(1097, 715)
        pnlBody.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Georgia", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        lblTitle.Location = New Point(34, 43)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(388, 39)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Evaluasi semester ini"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(84), CByte(90), CByte(86))
        lblSubtitle.Location = New Point(39, 101)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(429, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Nilai setiap dosen pengampu dengan skala 1 sampai 5."
        ' 
        ' pnlEmpty
        ' 
        pnlEmpty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEmpty.BackColor = Color.White
        pnlEmpty.BorderStyle = BorderStyle.FixedSingle
        pnlEmpty.Controls.Add(lblEmptyTitle)
        pnlEmpty.Controls.Add(lblEmptyBody)
        pnlEmpty.Location = New Point(39, 165)
        pnlEmpty.Margin = New Padding(3, 4, 3, 4)
        pnlEmpty.Name = "pnlEmpty"
        pnlEmpty.Size = New Size(1887, 175)
        pnlEmpty.TabIndex = 2
        ' 
        ' lblEmptyTitle
        ' 
        lblEmptyTitle.AutoSize = True
        lblEmptyTitle.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblEmptyTitle.ForeColor = Color.FromArgb(CByte(31), CByte(36), CByte(33))
        lblEmptyTitle.Location = New Point(27, 37)
        lblEmptyTitle.Name = "lblEmptyTitle"
        lblEmptyTitle.Size = New Size(349, 25)
        lblEmptyTitle.TabIndex = 0
        lblEmptyTitle.Text = "Belum ada dosen yang perlu dievaluasi."
        ' 
        ' lblEmptyBody
        ' 
        lblEmptyBody.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblEmptyBody.Font = New Font("Segoe UI", 10.0F)
        lblEmptyBody.ForeColor = Color.FromArgb(CByte(84), CByte(90), CByte(86))
        lblEmptyBody.Location = New Point(27, 77)
        lblEmptyBody.Name = "lblEmptyBody"
        lblEmptyBody.Size = New Size(1828, 64)
        lblEmptyBody.TabIndex = 1
        lblEmptyBody.Text = "Daftar dosen dan mata kuliah akan muncul di sini setelah data perkuliahan Anda dimasukkan ke database."
        ' 
        ' dihboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        ClientSize = New Size(1097, 800)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(866, 624)
        Name = "dihboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EDOM - Dashboard Mahasiswa"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlEmpty.ResumeLayout(False)
        pnlEmpty.PerformLayout()
        ResumeLayout(False)
    End Sub
End Class
