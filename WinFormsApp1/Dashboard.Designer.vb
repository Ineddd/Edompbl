<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        btnLogout = New Button()
        btnDashboard = New Button()
        lblBrandSubtitle = New Label()
        lblBrand = New Label()
        header = New Panel()
        lblInfo = New Label()
        lblWelcome = New Label()
        content = New Panel()
        lblAnnouncement = New Label()
        lblAnnouncementTitle = New Label()
        dgvSchedule = New DataGridView()
        colJam = New DataGridViewTextBoxColumn()
        colMataKuliah = New DataGridViewTextBoxColumn()
        colDosen = New DataGridViewTextBoxColumn()
        colRuangan = New DataGridViewTextBoxColumn()
        lblScheduleTitle = New Label()
        cardCourse = New Panel()
        lblCourseValue = New Label()
        lblCourseTitle = New Label()
        cardSemester = New Panel()
        lblSemesterValue = New Label()
        lblSemesterTitle = New Label()
        cardSks = New Panel()
        lblSksValue = New Label()
        lblSksTitle = New Label()
        cardIpk = New Panel()
        lblIpkValue = New Label()
        lblIpkTitle = New Label()
        lblSummaryTitle = New Label()
        sidebar.SuspendLayout()
        header.SuspendLayout()
        content.SuspendLayout()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).BeginInit()
        cardCourse.SuspendLayout()
        cardSemester.SuspendLayout()
        cardSks.SuspendLayout()
        cardIpk.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidebar
        ' 
        sidebar.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
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
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(29, 860)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(217, 56)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Keluar"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Yellow
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(17, 187)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(240, 56)
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
        lblBrand.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(31, 33)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(158, 50)
        lblBrand.TabIndex = 0
        lblBrand.Text = "SIAKAD"
        ' 
        ' header
        ' 
        header.BackColor = Color.White
        header.Controls.Add(lblInfo)
        header.Controls.Add(lblWelcome)
        header.Dock = DockStyle.Top
        header.Location = New Point(274, 0)
        header.Margin = New Padding(3, 4, 3, 4)
        header.Name = "header"
        header.Size = New Size(1193, 120)
        header.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9F)
        lblInfo.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblInfo.Location = New Point(42, 73)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(320, 20)
        lblInfo.TabIndex = 1
        lblInfo.Text = "Kelola aktivitas akademik Anda dengan mudah"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblWelcome.Location = New Point(40, 24)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(409, 41)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Selamat datang, Mahasiswa"
        ' 
        ' content
        ' 
        content.AutoScroll = True
        content.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(251))
        content.Controls.Add(lblAnnouncement)
        content.Controls.Add(lblAnnouncementTitle)
        content.Controls.Add(dgvSchedule)
        content.Controls.Add(lblScheduleTitle)
        content.Controls.Add(cardCourse)
        content.Controls.Add(cardSemester)
        content.Controls.Add(cardSks)
        content.Controls.Add(cardIpk)
        content.Controls.Add(lblSummaryTitle)
        content.Dock = DockStyle.Fill
        content.Location = New Point(274, 120)
        content.Margin = New Padding(3, 4, 3, 4)
        content.Name = "content"
        content.Padding = New Padding(40, 33, 40, 33)
        content.Size = New Size(1193, 840)
        content.TabIndex = 2
        ' 
        ' lblAnnouncement
        ' 
        lblAnnouncement.BackColor = Color.White
        lblAnnouncement.Dock = DockStyle.Top
        lblAnnouncement.Font = New Font("Segoe UI", 10F)
        lblAnnouncement.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblAnnouncement.Location = New Point(40, 453)
        lblAnnouncement.Name = "lblAnnouncement"
        lblAnnouncement.Padding = New Padding(17, 20, 17, 20)
        lblAnnouncement.Size = New Size(1113, 120)
        lblAnnouncement.TabIndex = 8
        lblAnnouncement.Text = "• Pengisian Edom terakhir 12 Januari" & vbCrLf & "• Marksheet dibagikan  setelah pengisian Edom" & vbCrLf & " "
        ' 
        ' lblAnnouncementTitle
        ' 
        lblAnnouncementTitle.Dock = DockStyle.Top
        lblAnnouncementTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblAnnouncementTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblAnnouncementTitle.Location = New Point(40, 393)
        lblAnnouncementTitle.Name = "lblAnnouncementTitle"
        lblAnnouncementTitle.Padding = New Padding(0, 16, 0, 0)
        lblAnnouncementTitle.Size = New Size(1113, 60)
        lblAnnouncementTitle.TabIndex = 7
        lblAnnouncementTitle.Text = "Pengumuman Akademik"
        ' 
        ' dgvSchedule
        ' 
        dgvSchedule.AllowUserToAddRows = False
        dgvSchedule.AllowUserToDeleteRows = False
        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSchedule.BackgroundColor = Color.White
        dgvSchedule.BorderStyle = BorderStyle.None
        dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchedule.Columns.AddRange(New DataGridViewColumn() {colJam, colMataKuliah, colDosen, colRuangan})
        dgvSchedule.Dock = DockStyle.Top
        dgvSchedule.Location = New Point(40, 153)
        dgvSchedule.Margin = New Padding(3, 4, 3, 4)
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.ReadOnly = True
        dgvSchedule.RowHeadersVisible = False
        dgvSchedule.RowHeadersWidth = 51
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchedule.Size = New Size(1113, 240)
        dgvSchedule.TabIndex = 6
        ' 
        ' colJam
        ' 
        colJam.HeaderText = "Jam"
        colJam.MinimumWidth = 6
        colJam.Name = "colJam"
        colJam.ReadOnly = True
        ' 
        ' colMataKuliah
        ' 
        colMataKuliah.HeaderText = "Mata Kuliah"
        colMataKuliah.MinimumWidth = 6
        colMataKuliah.Name = "colMataKuliah"
        colMataKuliah.ReadOnly = True
        ' 
        ' colDosen
        ' 
        colDosen.HeaderText = "Dosen"
        colDosen.MinimumWidth = 6
        colDosen.Name = "colDosen"
        colDosen.ReadOnly = True
        ' 
        ' colRuangan
        ' 
        colRuangan.HeaderText = "Ruangan"
        colRuangan.MinimumWidth = 6
        colRuangan.Name = "colRuangan"
        colRuangan.ReadOnly = True
        ' 
        ' lblScheduleTitle
        ' 
        lblScheduleTitle.Dock = DockStyle.Top
        lblScheduleTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblScheduleTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblScheduleTitle.Location = New Point(40, 93)
        lblScheduleTitle.Name = "lblScheduleTitle"
        lblScheduleTitle.Padding = New Padding(0, 16, 0, 0)
        lblScheduleTitle.Size = New Size(1113, 60)
        lblScheduleTitle.TabIndex = 5
        lblScheduleTitle.Text = "Jadwal Kuliah Hari Ini"
        ' 
        ' cardCourse
        ' 
        cardCourse.BackColor = Color.White
        cardCourse.Controls.Add(lblCourseValue)
        cardCourse.Controls.Add(lblCourseTitle)
        cardCourse.Location = New Point(880, 93)
        cardCourse.Margin = New Padding(3, 4, 3, 4)
        cardCourse.Name = "cardCourse"
        cardCourse.Size = New Size(234, 133)
        cardCourse.TabIndex = 4
        ' 
        ' lblCourseValue
        ' 
        lblCourseValue.AutoSize = True
        lblCourseValue.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblCourseValue.ForeColor = Color.FromArgb(CByte(111), CByte(66), CByte(193))
        lblCourseValue.Location = New Point(23, 60)
        lblCourseValue.Name = "lblCourseValue"
        lblCourseValue.Size = New Size(40, 46)
        lblCourseValue.TabIndex = 1
        lblCourseValue.Text = "8"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI", 9F)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblCourseTitle.Location = New Point(23, 23)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(88, 20)
        lblCourseTitle.TabIndex = 0
        lblCourseTitle.Text = "Mata Kuliah"
        ' 
        ' cardSemester
        ' 
        cardSemester.BackColor = Color.White
        cardSemester.Controls.Add(lblSemesterValue)
        cardSemester.Controls.Add(lblSemesterTitle)
        cardSemester.Location = New Point(629, 93)
        cardSemester.Margin = New Padding(3, 4, 3, 4)
        cardSemester.Name = "cardSemester"
        cardSemester.Size = New Size(234, 133)
        cardSemester.TabIndex = 3
        ' 
        ' lblSemesterValue
        ' 
        lblSemesterValue.AutoSize = True
        lblSemesterValue.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblSemesterValue.ForeColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        lblSemesterValue.Location = New Point(23, 60)
        lblSemesterValue.Name = "lblSemesterValue"
        lblSemesterValue.Size = New Size(40, 46)
        lblSemesterValue.TabIndex = 1
        lblSemesterValue.Text = "6"
        ' 
        ' lblSemesterTitle
        ' 
        lblSemesterTitle.AutoSize = True
        lblSemesterTitle.Font = New Font("Segoe UI", 9F)
        lblSemesterTitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblSemesterTitle.Location = New Point(23, 23)
        lblSemesterTitle.Name = "lblSemesterTitle"
        lblSemesterTitle.Size = New Size(105, 20)
        lblSemesterTitle.TabIndex = 0
        lblSemesterTitle.Text = "Semester Aktif"
        ' 
        ' cardSks
        ' 
        cardSks.BackColor = Color.White
        cardSks.Controls.Add(lblSksValue)
        cardSks.Controls.Add(lblSksTitle)
        cardSks.Location = New Point(377, 93)
        cardSks.Margin = New Padding(3, 4, 3, 4)
        cardSks.Name = "cardSks"
        cardSks.Size = New Size(234, 133)
        cardSks.TabIndex = 2
        ' 
        ' lblSksValue
        ' 
        lblSksValue.AutoSize = True
        lblSksValue.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblSksValue.ForeColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
        lblSksValue.Location = New Point(23, 60)
        lblSksValue.Name = "lblSksValue"
        lblSksValue.Size = New Size(129, 46)
        lblSksValue.TabIndex = 1
        lblSksValue.Text = "96 SKS"
        ' 
        ' lblSksTitle
        ' 
        lblSksTitle.AutoSize = True
        lblSksTitle.Font = New Font("Segoe UI", 9F)
        lblSksTitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblSksTitle.Location = New Point(23, 23)
        lblSksTitle.Name = "lblSksTitle"
        lblSksTitle.Size = New Size(71, 20)
        lblSksTitle.TabIndex = 0
        lblSksTitle.Text = "Total SKS"
        ' 
        ' cardIpk
        ' 
        cardIpk.BackColor = Color.White
        cardIpk.Controls.Add(lblIpkValue)
        cardIpk.Controls.Add(lblIpkTitle)
        cardIpk.Location = New Point(126, 93)
        cardIpk.Margin = New Padding(3, 4, 3, 4)
        cardIpk.Name = "cardIpk"
        cardIpk.Size = New Size(234, 133)
        cardIpk.TabIndex = 1
        ' 
        ' lblIpkValue
        ' 
        lblIpkValue.AutoSize = True
        lblIpkValue.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblIpkValue.ForeColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        lblIpkValue.Location = New Point(23, 60)
        lblIpkValue.Name = "lblIpkValue"
        lblIpkValue.Size = New Size(89, 46)
        lblIpkValue.TabIndex = 1
        lblIpkValue.Text = "3.75"
        ' 
        ' lblIpkTitle
        ' 
        lblIpkTitle.AutoSize = True
        lblIpkTitle.Font = New Font("Segoe UI", 9F)
        lblIpkTitle.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblIpkTitle.Location = New Point(23, 23)
        lblIpkTitle.Name = "lblIpkTitle"
        lblIpkTitle.Size = New Size(98, 20)
        lblIpkTitle.TabIndex = 0
        lblIpkTitle.Text = "IPK Kumulatif"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.Dock = DockStyle.Top
        lblSummaryTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblSummaryTitle.Location = New Point(40, 33)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(1113, 60)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "Ringkasan Akademik"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1467, 960)
        Controls.Add(content)
        Controls.Add(header)
        Controls.Add(sidebar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1255, 918)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Akademik"
        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        header.ResumeLayout(False)
        header.PerformLayout()
        content.ResumeLayout(False)
        CType(dgvSchedule, ComponentModel.ISupportInitialize).EndInit()
        cardCourse.ResumeLayout(False)
        cardCourse.PerformLayout()
        cardSemester.ResumeLayout(False)
        cardSemester.PerformLayout()
        cardSks.ResumeLayout(False)
        cardSks.PerformLayout()
        cardIpk.ResumeLayout(False)
        cardIpk.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnKRS As Button
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnKHS As Button
    Friend WithEvents btnTranscript As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents header As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents content As Panel
    Friend WithEvents lblSummaryTitle As Label
    Friend WithEvents cardIpk As Panel
    Friend WithEvents cardSks As Panel
    Friend WithEvents cardSemester As Panel
    Friend WithEvents cardCourse As Panel
    Friend WithEvents lblIpkTitle As Label
    Friend WithEvents lblIpkValue As Label
    Friend WithEvents lblSksTitle As Label
    Friend WithEvents lblSksValue As Label
    Friend WithEvents lblSemesterTitle As Label
    Friend WithEvents lblSemesterValue As Label
    Friend WithEvents lblCourseTitle As Label
    Friend WithEvents lblCourseValue As Label
    Friend WithEvents lblScheduleTitle As Label
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents colJam As DataGridViewTextBoxColumn
    Friend WithEvents colMataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents colDosen As DataGridViewTextBoxColumn
    Friend WithEvents colRuangan As DataGridViewTextBoxColumn
    Friend WithEvents lblAnnouncementTitle As Label
    Friend WithEvents lblAnnouncement As Label

End Class
