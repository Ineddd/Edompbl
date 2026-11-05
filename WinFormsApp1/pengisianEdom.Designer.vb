<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pengisianEdom
    Inherits System.Windows.Forms.Form

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        sidebar = New Panel()
        Button1 = New Button()
        btnLogout = New Button()
        btnDashboard = New Button()
        lblBrandSubtitle = New Label()
        lblBrand = New Label()
        content = New Panel()
        cardDosen4 = New Panel()
        btnEval4 = New Button()
        lblStatusDosen4 = New Label()
        lblMatkulDosen4 = New Label()
        lblNamaDosen4 = New Label()
        cardDosen3 = New Panel()
        btnEval3 = New Button()
        lblStatusDosen3 = New Label()
        lblMatkulDosen3 = New Label()
        lblNamaDosen3 = New Label()
        cardDosen2 = New Panel()
        btnEval2 = New Button()
        lblStatusDosen2 = New Label()
        lblMatkulDosen2 = New Label()
        lblNamaDosen2 = New Label()
        cardDosen1 = New Panel()
        btnEval1 = New Button()
        lblStatusDosen1 = New Label()
        lblMatkulDosen1 = New Label()
        lblNamaDosen1 = New Label()
        lblListTitle = New Label()
        sidebar.SuspendLayout()
        content.SuspendLayout()
        cardDosen4.SuspendLayout()
        cardDosen3.SuspendLayout()
        cardDosen2.SuspendLayout()
        cardDosen1.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidebar
        ' 
        sidebar.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        sidebar.BorderStyle = BorderStyle.Fixed3D
        sidebar.Controls.Add(Button1)
        sidebar.Controls.Add(btnLogout)
        sidebar.Controls.Add(btnDashboard)
        sidebar.Controls.Add(lblBrandSubtitle)
        sidebar.Controls.Add(lblBrand)
        sidebar.Dock = DockStyle.Left
        sidebar.Location = New Point(0, 0)
        sidebar.Margin = New Padding(3, 4, 3, 4)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(274, 960)
        sidebar.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-2, 255)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(274, 56)
        Button1.TabIndex = 9
        Button1.Text = "    Pengisian EDOM"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(35), CByte(51))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(29, 860)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(217, 56)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(-2, 187)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(274, 56)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "    Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblBrandSubtitle
        ' 
        lblBrandSubtitle.AutoSize = True
        lblBrandSubtitle.Font = New Font("Segoe UI", 8.5F)
        lblBrandSubtitle.ForeColor = Color.FromArgb(CByte(190), CByte(205), CByte(220))
        lblBrandSubtitle.Location = New Point(34, 93)
        lblBrandSubtitle.Name = "lblBrandSubtitle"
        lblBrandSubtitle.Size = New Size(189, 20)
        lblBrandSubtitle.TabIndex = 1
        lblBrandSubtitle.Text = "Sistem Informasi Akademik"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(31, 33)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(158, 50)
        lblBrand.TabIndex = 0
        lblBrand.Text = "SIAKAD"
        ' 
        ' content
        ' 
        content.AutoScroll = True
        content.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        content.Controls.Add(cardDosen4)
        content.Controls.Add(cardDosen3)
        content.Controls.Add(cardDosen2)
        content.Controls.Add(cardDosen1)
        content.Controls.Add(lblListTitle)
        content.Dock = DockStyle.Fill
        content.Location = New Point(274, 0)
        content.Margin = New Padding(3, 4, 3, 4)
        content.Name = "content"
        content.Padding = New Padding(40, 33, 40, 33)
        content.Size = New Size(1193, 960)
        content.TabIndex = 2
        ' 
        ' cardDosen4
        ' 
        cardDosen4.BackColor = Color.White
        cardDosen4.Controls.Add(btnEval4)
        cardDosen4.Controls.Add(lblStatusDosen4)
        cardDosen4.Controls.Add(lblMatkulDosen4)
        cardDosen4.Controls.Add(lblNamaDosen4)
        cardDosen4.Location = New Point(62, 518)
        cardDosen4.Name = "cardDosen4"
        cardDosen4.Size = New Size(1068, 110)
        cardDosen4.TabIndex = 13
        ' 
        ' btnEval4
        ' 
        btnEval4.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnEval4.Cursor = Cursors.Hand
        btnEval4.FlatAppearance.BorderSize = 0
        btnEval4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnEval4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnEval4.FlatStyle = FlatStyle.Flat
        btnEval4.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnEval4.ForeColor = Color.White
        btnEval4.Location = New Point(838, 29)
        btnEval4.Name = "btnEval4"
        btnEval4.Size = New Size(200, 52)
        btnEval4.TabIndex = 3
        btnEval4.Text = "Isi Evaluasi"
        btnEval4.UseVisualStyleBackColor = False
        ' 
        ' lblStatusDosen4
        ' 
        lblStatusDosen4.AutoSize = True
        lblStatusDosen4.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusDosen4.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        lblStatusDosen4.Location = New Point(650, 44)
        lblStatusDosen4.Name = "lblStatusDosen4"
        lblStatusDosen4.Size = New Size(132, 21)
        lblStatusDosen4.TabIndex = 2
        lblStatusDosen4.Text = "Belum Dievaluasi"
        ' 
        ' lblMatkulDosen4
        ' 
        lblMatkulDosen4.AutoSize = True
        lblMatkulDosen4.Font = New Font("Segoe UI", 9.5F)
        lblMatkulDosen4.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblMatkulDosen4.Location = New Point(28, 58)
        lblMatkulDosen4.Name = "lblMatkulDosen4"
        lblMatkulDosen4.Size = New Size(403, 21)
        lblMatkulDosen4.TabIndex = 1
        lblMatkulDosen4.Text = "Mata Kuliah: Rekayasa Perangkat Lunak  |  Ruang AA 205"
        ' 
        ' lblNamaDosen4
        ' 
        lblNamaDosen4.AutoSize = True
        lblNamaDosen4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNamaDosen4.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblNamaDosen4.Location = New Point(28, 22)
        lblNamaDosen4.Name = "lblNamaDosen4"
        lblNamaDosen4.Size = New Size(248, 28)
        lblNamaDosen4.TabIndex = 0
        lblNamaDosen4.Text = "Dr. Hendra Pratama, M.T."
        ' 
        ' cardDosen3
        ' 
        cardDosen3.BackColor = Color.White
        cardDosen3.Controls.Add(btnEval3)
        cardDosen3.Controls.Add(lblStatusDosen3)
        cardDosen3.Controls.Add(lblMatkulDosen3)
        cardDosen3.Controls.Add(lblNamaDosen3)
        cardDosen3.Location = New Point(62, 377)
        cardDosen3.Name = "cardDosen3"
        cardDosen3.Size = New Size(1068, 110)
        cardDosen3.TabIndex = 12
        ' 
        ' btnEval3
        ' 
        btnEval3.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnEval3.Cursor = Cursors.Hand
        btnEval3.FlatAppearance.BorderSize = 0
        btnEval3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnEval3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnEval3.FlatStyle = FlatStyle.Flat
        btnEval3.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnEval3.ForeColor = Color.White
        btnEval3.Location = New Point(838, 29)
        btnEval3.Name = "btnEval3"
        btnEval3.Size = New Size(200, 52)
        btnEval3.TabIndex = 3
        btnEval3.Text = "Isi Evaluasi"
        btnEval3.UseVisualStyleBackColor = False
        ' 
        ' lblStatusDosen3
        ' 
        lblStatusDosen3.AutoSize = True
        lblStatusDosen3.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusDosen3.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        lblStatusDosen3.Location = New Point(650, 44)
        lblStatusDosen3.Name = "lblStatusDosen3"
        lblStatusDosen3.Size = New Size(132, 21)
        lblStatusDosen3.TabIndex = 2
        lblStatusDosen3.Text = "Belum Dievaluasi"
        ' 
        ' lblMatkulDosen3
        ' 
        lblMatkulDosen3.AutoSize = True
        lblMatkulDosen3.Font = New Font("Segoe UI", 9.5F)
        lblMatkulDosen3.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblMatkulDosen3.Location = New Point(28, 58)
        lblMatkulDosen3.Name = "lblMatkulDosen3"
        lblMatkulDosen3.Size = New Size(331, 21)
        lblMatkulDosen3.TabIndex = 1
        lblMatkulDosen3.Text = "Mata Kuliah: Analisis Sistem  |  Ruang PUT 301"
        ' 
        ' lblNamaDosen3
        ' 
        lblNamaDosen3.AutoSize = True
        lblNamaDosen3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNamaDosen3.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblNamaDosen3.Location = New Point(28, 22)
        lblNamaDosen3.Name = "lblNamaDosen3"
        lblNamaDosen3.Size = New Size(223, 28)
        lblNamaDosen3.TabIndex = 0
        lblNamaDosen3.Text = "Bagus Wijaya, M.Kom."
        ' 
        ' cardDosen2
        ' 
        cardDosen2.BackColor = Color.White
        cardDosen2.Controls.Add(btnEval2)
        cardDosen2.Controls.Add(lblStatusDosen2)
        cardDosen2.Controls.Add(lblMatkulDosen2)
        cardDosen2.Controls.Add(lblNamaDosen2)
        cardDosen2.Location = New Point(62, 237)
        cardDosen2.Name = "cardDosen2"
        cardDosen2.Size = New Size(1068, 110)
        cardDosen2.TabIndex = 11
        ' 
        ' btnEval2
        ' 
        btnEval2.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnEval2.Cursor = Cursors.Hand
        btnEval2.FlatAppearance.BorderSize = 0
        btnEval2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnEval2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnEval2.FlatStyle = FlatStyle.Flat
        btnEval2.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnEval2.ForeColor = Color.White
        btnEval2.Location = New Point(838, 29)
        btnEval2.Name = "btnEval2"
        btnEval2.Size = New Size(200, 52)
        btnEval2.TabIndex = 3
        btnEval2.Text = "Isi Evaluasi"
        btnEval2.UseVisualStyleBackColor = False
        ' 
        ' lblStatusDosen2
        ' 
        lblStatusDosen2.AutoSize = True
        lblStatusDosen2.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusDosen2.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        lblStatusDosen2.Location = New Point(650, 44)
        lblStatusDosen2.Name = "lblStatusDosen2"
        lblStatusDosen2.Size = New Size(132, 21)
        lblStatusDosen2.TabIndex = 2
        lblStatusDosen2.Text = "Belum Dievaluasi"
        ' 
        ' lblMatkulDosen2
        ' 
        lblMatkulDosen2.AutoSize = True
        lblMatkulDosen2.Font = New Font("Segoe UI", 9.5F)
        lblMatkulDosen2.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblMatkulDosen2.Location = New Point(28, 58)
        lblMatkulDosen2.Name = "lblMatkulDosen2"
        lblMatkulDosen2.Size = New Size(404, 21)
        lblMatkulDosen2.TabIndex = 1
        lblMatkulDosen2.Text = "Mata Kuliah: Pemrograman Basis Data  |  Ruang GSG 204"
        ' 
        ' lblNamaDosen2
        ' 
        lblNamaDosen2.AutoSize = True
        lblNamaDosen2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNamaDosen2.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblNamaDosen2.Location = New Point(28, 22)
        lblNamaDosen2.Name = "lblNamaDosen2"
        lblNamaDosen2.Size = New Size(188, 28)
        lblNamaDosen2.TabIndex = 0
        lblNamaDosen2.Text = "Risna Sari, M.Kom."
        ' 
        ' cardDosen1
        ' 
        cardDosen1.BackColor = Color.White
        cardDosen1.Controls.Add(btnEval1)
        cardDosen1.Controls.Add(lblStatusDosen1)
        cardDosen1.Controls.Add(lblMatkulDosen1)
        cardDosen1.Controls.Add(lblNamaDosen1)
        cardDosen1.Location = New Point(62, 95)
        cardDosen1.Name = "cardDosen1"
        cardDosen1.Size = New Size(1068, 110)
        cardDosen1.TabIndex = 10
        ' 
        ' btnEval1
        ' 
        btnEval1.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnEval1.Cursor = Cursors.Hand
        btnEval1.FlatAppearance.BorderSize = 0
        btnEval1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnEval1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnEval1.FlatStyle = FlatStyle.Flat
        btnEval1.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnEval1.ForeColor = Color.White
        btnEval1.Location = New Point(838, 29)
        btnEval1.Name = "btnEval1"
        btnEval1.Size = New Size(200, 52)
        btnEval1.TabIndex = 3
        btnEval1.Text = "Isi Evaluasi"
        btnEval1.UseVisualStyleBackColor = False
        ' 
        ' lblStatusDosen1
        ' 
        lblStatusDosen1.AutoSize = True
        lblStatusDosen1.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusDosen1.ForeColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        lblStatusDosen1.Location = New Point(650, 44)
        lblStatusDosen1.Name = "lblStatusDosen1"
        lblStatusDosen1.Size = New Size(132, 21)
        lblStatusDosen1.TabIndex = 2
        lblStatusDosen1.Text = "Belum Dievaluasi"
        ' 
        ' lblMatkulDosen1
        ' 
        lblMatkulDosen1.AutoSize = True
        lblMatkulDosen1.Font = New Font("Segoe UI", 9.5F)
        lblMatkulDosen1.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblMatkulDosen1.Location = New Point(28, 58)
        lblMatkulDosen1.Name = "lblMatkulDosen1"
        lblMatkulDosen1.Size = New Size(400, 21)
        lblMatkulDosen1.TabIndex = 1
        lblMatkulDosen1.Text = "Mata Kuliah: Pemrograman Web Lanjut  |  Ruang AA 301"
        ' 
        ' lblNamaDosen1
        ' 
        lblNamaDosen1.AutoSize = True
        lblNamaDosen1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNamaDosen1.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblNamaDosen1.Location = New Point(28, 22)
        lblNamaDosen1.Name = "lblNamaDosen1"
        lblNamaDosen1.Size = New Size(206, 28)
        lblNamaDosen1.TabIndex = 0
        lblNamaDosen1.Text = "Asep Taufik, M.Kom."
        ' 
        ' lblListTitle
        ' 
        lblListTitle.AutoSize = True
        lblListTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblListTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblListTitle.Location = New Point(62, 50)
        lblListTitle.Name = "lblListTitle"
        lblListTitle.Size = New Size(419, 32)
        lblListTitle.TabIndex = 9
        lblListTitle.Text = "Daftar Dosen yang Ingin Dievaluasi"
        ' 
        ' pengisianEdom
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1467, 960)
        Controls.Add(content)
        Controls.Add(sidebar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1255, 918)
        Name = "pengisianEdom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pengisian EDOM"
        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        content.ResumeLayout(False)
        content.PerformLayout()
        cardDosen4.ResumeLayout(False)
        cardDosen4.PerformLayout()
        cardDosen3.ResumeLayout(False)
        cardDosen3.PerformLayout()
        cardDosen2.ResumeLayout(False)
        cardDosen2.PerformLayout()
        cardDosen1.ResumeLayout(False)
        cardDosen1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents content As Panel
    Friend WithEvents cardDosen4 As Panel
    Friend WithEvents btnEval4 As Button
    Friend WithEvents lblStatusDosen4 As Label
    Friend WithEvents lblMatkulDosen4 As Label
    Friend WithEvents lblNamaDosen4 As Label
    Friend WithEvents cardDosen3 As Panel
    Friend WithEvents btnEval3 As Button
    Friend WithEvents lblStatusDosen3 As Label
    Friend WithEvents lblMatkulDosen3 As Label
    Friend WithEvents lblNamaDosen3 As Label
    Friend WithEvents cardDosen2 As Panel
    Friend WithEvents btnEval2 As Button
    Friend WithEvents lblStatusDosen2 As Label
    Friend WithEvents lblMatkulDosen2 As Label
    Friend WithEvents lblNamaDosen2 As Label
    Friend WithEvents cardDosen1 As Panel
    Friend WithEvents btnEval1 As Button
    Friend WithEvents lblStatusDosen1 As Label
    Friend WithEvents lblMatkulDosen1 As Label
    Friend WithEvents lblNamaDosen1 As Label
    Friend WithEvents lblListTitle As Label

End Class
