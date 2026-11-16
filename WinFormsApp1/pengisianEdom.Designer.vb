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
        pnlCardContainer = New FlowLayoutPanel()
        pnlState = New Panel()
        btnRetry = New Button()
        lblStateMessage = New Label()
        btnRefresh = New Button()
        lblListSubtitle = New Label()
        lblListTitle = New Label()
        sidebar.SuspendLayout()
        content.SuspendLayout()
        pnlState.SuspendLayout()
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
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
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
        content.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        content.Controls.Add(pnlCardContainer)
        content.Controls.Add(pnlState)
        content.Controls.Add(btnRefresh)
        content.Controls.Add(lblListSubtitle)
        content.Controls.Add(lblListTitle)
        content.Dock = DockStyle.Fill
        content.Location = New Point(274, 0)
        content.Margin = New Padding(3, 4, 3, 4)
        content.Name = "content"
        content.Padding = New Padding(40, 33, 40, 33)
        content.Size = New Size(1193, 960)
        content.TabIndex = 2
        ' 
        ' pnlCardContainer
        ' 
        pnlCardContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCardContainer.AutoScroll = True
        pnlCardContainer.BackColor = Color.Transparent
        pnlCardContainer.FlowDirection = FlowDirection.TopDown
        pnlCardContainer.Location = New Point(40, 130)
        pnlCardContainer.Name = "pnlCardContainer"
        pnlCardContainer.Size = New Size(1113, 797)
        pnlCardContainer.TabIndex = 14
        pnlCardContainer.WrapContents = False
        ' 
        ' pnlState
        ' 
        pnlState.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlState.BackColor = Color.White
        pnlState.Controls.Add(btnRetry)
        pnlState.Controls.Add(lblStateMessage)
        pnlState.Location = New Point(40, 130)
        pnlState.Name = "pnlState"
        pnlState.Size = New Size(1113, 200)
        pnlState.TabIndex = 15
        pnlState.Visible = False
        ' 
        ' btnRetry
        ' 
        btnRetry.Anchor = AnchorStyles.None
        btnRetry.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnRetry.Cursor = Cursors.Hand
        btnRetry.FlatAppearance.BorderSize = 0
        btnRetry.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnRetry.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnRetry.FlatStyle = FlatStyle.Flat
        btnRetry.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnRetry.ForeColor = Color.White
        btnRetry.Location = New Point(486, 120)
        btnRetry.Name = "btnRetry"
        btnRetry.Size = New Size(140, 42)
        btnRetry.TabIndex = 1
        btnRetry.Text = "Coba Lagi"
        btnRetry.UseVisualStyleBackColor = False
        btnRetry.Visible = False
        ' 
        ' lblStateMessage
        ' 
        lblStateMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStateMessage.Font = New Font("Segoe UI", 11.0F)
        lblStateMessage.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblStateMessage.Location = New Point(20, 40)
        lblStateMessage.Name = "lblStateMessage"
        lblStateMessage.Size = New Size(1073, 60)
        lblStateMessage.TabIndex = 0
        lblStateMessage.Text = "Memuat daftar dosen..."
        lblStateMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(98), CByte(128), CByte(94))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(993, 40)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(160, 46)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "Segarkan Data"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblListSubtitle
        ' 
        lblListSubtitle.AutoSize = True
        lblListSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblListSubtitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblListSubtitle.Location = New Point(40, 80)
        lblListSubtitle.Name = "lblListSubtitle"
        lblListSubtitle.Size = New Size(620, 23)
        lblListSubtitle.TabIndex = 10
        lblListSubtitle.Text = "Pilih dosen dan mata kuliah di bawah ini untuk mengisi instrumen evaluasi dosen (EDOM)."
        ' 
        ' lblListTitle
        ' 
        lblListTitle.AutoSize = True
        lblListTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblListTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblListTitle.Location = New Point(38, 38)
        lblListTitle.Name = "lblListTitle"
        lblListTitle.Size = New Size(458, 37)
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
        pnlState.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents content As Panel
    Friend WithEvents lblListTitle As Label
    Friend WithEvents lblListSubtitle As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlCardContainer As FlowLayoutPanel
    Friend WithEvents pnlState As Panel
    Friend WithEvents lblStateMessage As Label
    Friend WithEvents btnRetry As Button

End Class
