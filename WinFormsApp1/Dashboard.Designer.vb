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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        sidebar = New Panel()
        Button1 = New Button()
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
        pnlSummaryCards = New TableLayoutPanel()
        cardIpk = New Panel()
        lblIpkNote = New Label()
        lblIpkValue = New Label()
        lblIpkTitle = New Label()
        cardSemester = New Panel()
        lblSemesterNote = New Label()
        lblSemesterValue = New Label()
        lblSemesterTitle = New Label()
        cardCourse = New Panel()
        lblCourseNote = New Label()
        lblCourseValue = New Label()
        lblCourseTitle = New Label()
        lblSummaryTitle = New Label()
        sidebar.SuspendLayout()
        header.SuspendLayout()
        content.SuspendLayout()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummaryCards.SuspendLayout()
        cardIpk.SuspendLayout()
        cardSemester.SuspendLayout()
        cardCourse.SuspendLayout()
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
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(240, 562)
        sidebar.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-2, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 42)
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
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(25, 486)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(190, 42)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(-2, 140)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(240, 42)
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
        lblBrandSubtitle.Location = New Point(30, 70)
        lblBrandSubtitle.Name = "lblBrandSubtitle"
        lblBrandSubtitle.Size = New Size(151, 15)
        lblBrandSubtitle.TabIndex = 1
        lblBrandSubtitle.Text = "Sistem Informasi Akademik"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblBrand.ForeColor = Color.White
        lblBrand.Location = New Point(27, 25)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(128, 41)
        lblBrand.TabIndex = 0
        lblBrand.Text = "SIAKAD"
        ' 
        ' header
        ' 
        header.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        header.BorderStyle = BorderStyle.Fixed3D
        header.Controls.Add(lblInfo)
        header.Controls.Add(lblWelcome)
        header.Dock = DockStyle.Top
        header.Location = New Point(240, 0)
        header.Name = "header"
        header.Size = New Size(959, 91)
        header.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.5F)
        lblInfo.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblInfo.Location = New Point(37, 55)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(349, 17)
        lblInfo.TabIndex = 1
        lblInfo.Text = "Ringkasan akademik dan jadwal perkuliahan semester aktif"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(35, 18)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(322, 32)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Selamat datang Mahasiswa"
        ' 
        ' content
        ' 
        content.AutoScroll = True
        content.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        content.Controls.Add(lblAnnouncement)
        content.Controls.Add(lblAnnouncementTitle)
        content.Controls.Add(dgvSchedule)
        content.Controls.Add(lblScheduleTitle)
        content.Controls.Add(pnlSummaryCards)
        content.Controls.Add(lblSummaryTitle)
        content.Dock = DockStyle.Fill
        content.Location = New Point(240, 91)
        content.Name = "content"
        content.Padding = New Padding(35, 21, 35, 25)
        content.Size = New Size(959, 471)
        content.TabIndex = 2
        ' 
        ' lblAnnouncement
        ' 
        lblAnnouncement.BackColor = Color.White
        lblAnnouncement.Dock = DockStyle.Top
        lblAnnouncement.Font = New Font("Segoe UI", 10F)
        lblAnnouncement.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        lblAnnouncement.Location = New Point(35, 426)
        lblAnnouncement.Name = "lblAnnouncement"
        lblAnnouncement.Padding = New Padding(19, 14, 19, 14)
        lblAnnouncement.Size = New Size(872, 82)
        lblAnnouncement.TabIndex = 8
        lblAnnouncement.Text = "• Batas akhir pengisian EDOM semester ini: 12 Januari 2026." & vbCrLf & "• Kartu Hasil Studi (Marksheet) dapat diunduh setelah seluruh evaluasi dosen selesai diisi."
        ' 
        ' lblAnnouncementTitle
        ' 
        lblAnnouncementTitle.Dock = DockStyle.Top
        lblAnnouncementTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblAnnouncementTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblAnnouncementTitle.Location = New Point(35, 382)
        lblAnnouncementTitle.Name = "lblAnnouncementTitle"
        lblAnnouncementTitle.Padding = New Padding(0, 15, 0, 0)
        lblAnnouncementTitle.Size = New Size(872, 44)
        lblAnnouncementTitle.TabIndex = 7
        lblAnnouncementTitle.Text = "Pengumuman Akademik"
        ' 
        ' dgvSchedule
        ' 
        dgvSchedule.AllowUserToAddRows = False
        dgvSchedule.AllowUserToDeleteRows = False
        dgvSchedule.AllowUserToResizeRows = False
        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSchedule.BackgroundColor = Color.White
        dgvSchedule.BorderStyle = BorderStyle.None
        dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(232))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        DataGridViewCellStyle1.Padding = New Padding(14, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(241), CByte(239), CByte(232))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSchedule.ColumnHeadersHeight = 44
        dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSchedule.Columns.AddRange(New DataGridViewColumn() {colJam, colMataKuliah, colDosen, colRuangan})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle2.Padding = New Padding(14, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSchedule.DefaultCellStyle = DataGridViewCellStyle2
        dgvSchedule.Dock = DockStyle.Top
        dgvSchedule.EnableHeadersVisualStyles = False
        dgvSchedule.GridColor = Color.FromArgb(CByte(230), CByte(228), CByte(222))
        dgvSchedule.Location = New Point(35, 217)
        dgvSchedule.MultiSelect = False
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.ReadOnly = True
        dgvSchedule.RowHeadersVisible = False
        dgvSchedule.RowHeadersWidth = 51
        dgvSchedule.RowTemplate.Height = 46
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchedule.Size = New Size(872, 165)
        dgvSchedule.TabIndex = 6
        ' 
        ' colJam
        ' 
        colJam.FillWeight = 20F
        colJam.HeaderText = "Jam Perkuliahan"
        colJam.MinimumWidth = 6
        colJam.Name = "colJam"
        colJam.ReadOnly = True
        ' 
        ' colMataKuliah
        ' 
        colMataKuliah.FillWeight = 34F
        colMataKuliah.HeaderText = "Mata Kuliah"
        colMataKuliah.MinimumWidth = 6
        colMataKuliah.Name = "colMataKuliah"
        colMataKuliah.ReadOnly = True
        ' 
        ' colDosen
        ' 
        colDosen.FillWeight = 30F
        colDosen.HeaderText = "Dosen Pengampu"
        colDosen.MinimumWidth = 6
        colDosen.Name = "colDosen"
        colDosen.ReadOnly = True
        ' 
        ' colRuangan
        ' 
        colRuangan.FillWeight = 16F
        colRuangan.HeaderText = "Ruangan"
        colRuangan.MinimumWidth = 6
        colRuangan.Name = "colRuangan"
        colRuangan.ReadOnly = True
        ' 
        ' lblScheduleTitle
        ' 
        lblScheduleTitle.Dock = DockStyle.Top
        lblScheduleTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblScheduleTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblScheduleTitle.Location = New Point(35, 173)
        lblScheduleTitle.Name = "lblScheduleTitle"
        lblScheduleTitle.Padding = New Padding(0, 15, 0, 0)
        lblScheduleTitle.Size = New Size(872, 44)
        lblScheduleTitle.TabIndex = 5
        lblScheduleTitle.Text = "Jadwal Kuliah Hari Ini"
        ' 
        ' pnlSummaryCards
        ' 
        pnlSummaryCards.ColumnCount = 3
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        pnlSummaryCards.Controls.Add(cardIpk, 0, 0)
        pnlSummaryCards.Controls.Add(cardSemester, 1, 0)
        pnlSummaryCards.Controls.Add(cardCourse, 2, 0)
        pnlSummaryCards.Dock = DockStyle.Top
        pnlSummaryCards.Location = New Point(35, 55)
        pnlSummaryCards.Margin = New Padding(0)
        pnlSummaryCards.Name = "pnlSummaryCards"
        pnlSummaryCards.RowCount = 1
        pnlSummaryCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        pnlSummaryCards.Size = New Size(872, 118)
        pnlSummaryCards.TabIndex = 4
        ' 
        ' cardIpk
        ' 
        cardIpk.BackColor = Color.White
        cardIpk.Controls.Add(lblIpkNote)
        cardIpk.Controls.Add(lblIpkValue)
        cardIpk.Controls.Add(lblIpkTitle)
        cardIpk.Dock = DockStyle.Fill
        cardIpk.Location = New Point(0, 3)
        cardIpk.Margin = New Padding(0, 3, 10, 3)
        cardIpk.Name = "cardIpk"
        cardIpk.Size = New Size(280, 112)
        cardIpk.TabIndex = 1
        ' 
        ' lblIpkNote
        ' 
        lblIpkNote.AutoSize = True
        lblIpkNote.Font = New Font("Segoe UI", 8.5F)
        lblIpkNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblIpkNote.Location = New Point(19, 84)
        lblIpkNote.Name = "lblIpkNote"
        lblIpkNote.Size = New Size(153, 15)
        lblIpkNote.TabIndex = 2
        lblIpkNote.Text = "Skala 4.00 semester berjalan"
        ' 
        ' lblIpkValue
        ' 
        lblIpkValue.AutoSize = True
        lblIpkValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblIpkValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblIpkValue.Location = New Point(18, 39)
        lblIpkValue.Name = "lblIpkValue"
        lblIpkValue.Size = New Size(77, 41)
        lblIpkValue.TabIndex = 1
        lblIpkValue.Text = "3.75"
        ' 
        ' lblIpkTitle
        ' 
        lblIpkTitle.AutoSize = True
        lblIpkTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblIpkTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblIpkTitle.Location = New Point(19, 15)
        lblIpkTitle.Name = "lblIpkTitle"
        lblIpkTitle.Size = New Size(90, 17)
        lblIpkTitle.TabIndex = 0
        lblIpkTitle.Text = "IPK Kumulatif"
        ' 
        ' cardSemester
        ' 
        cardSemester.BackColor = Color.White
        cardSemester.Controls.Add(lblSemesterNote)
        cardSemester.Controls.Add(lblSemesterValue)
        cardSemester.Controls.Add(lblSemesterTitle)
        cardSemester.Dock = DockStyle.Fill
        cardSemester.Location = New Point(295, 3)
        cardSemester.Margin = New Padding(5, 3, 5, 3)
        cardSemester.Name = "cardSemester"
        cardSemester.Size = New Size(280, 112)
        cardSemester.TabIndex = 3
        ' 
        ' lblSemesterNote
        ' 
        lblSemesterNote.AutoSize = True
        lblSemesterNote.Font = New Font("Segoe UI", 8.5F)
        lblSemesterNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblSemesterNote.Location = New Point(19, 84)
        lblSemesterNote.Name = "lblSemesterNote"
        lblSemesterNote.Size = New Size(152, 15)
        lblSemesterNote.TabIndex = 2
        lblSemesterNote.Text = "Tahun Akademik 2025/2026"
        ' 
        ' lblSemesterValue
        ' 
        lblSemesterValue.AutoSize = True
        lblSemesterValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblSemesterValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblSemesterValue.Location = New Point(18, 39)
        lblSemesterValue.Name = "lblSemesterValue"
        lblSemesterValue.Size = New Size(35, 41)
        lblSemesterValue.TabIndex = 1
        lblSemesterValue.Text = "6"
        ' 
        ' lblSemesterTitle
        ' 
        lblSemesterTitle.AutoSize = True
        lblSemesterTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSemesterTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblSemesterTitle.Location = New Point(19, 15)
        lblSemesterTitle.Name = "lblSemesterTitle"
        lblSemesterTitle.Size = New Size(96, 17)
        lblSemesterTitle.TabIndex = 0
        lblSemesterTitle.Text = "Semester Aktif"
        ' 
        ' cardCourse
        ' 
        cardCourse.BackColor = Color.White
        cardCourse.Controls.Add(lblCourseNote)
        cardCourse.Controls.Add(lblCourseValue)
        cardCourse.Controls.Add(lblCourseTitle)
        cardCourse.Dock = DockStyle.Fill
        cardCourse.Location = New Point(590, 3)
        cardCourse.Margin = New Padding(10, 3, 0, 3)
        cardCourse.Name = "cardCourse"
        cardCourse.Size = New Size(282, 112)
        cardCourse.TabIndex = 4
        ' 
        ' lblCourseNote
        ' 
        lblCourseNote.AutoSize = True
        lblCourseNote.Font = New Font("Segoe UI", 8.5F)
        lblCourseNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblCourseNote.Location = New Point(19, 84)
        lblCourseNote.Name = "lblCourseNote"
        lblCourseNote.Size = New Size(159, 15)
        lblCourseNote.TabIndex = 2
        lblCourseNote.Text = "Diambil pada KRS semester 6"
        ' 
        ' lblCourseValue
        ' 
        lblCourseValue.AutoSize = True
        lblCourseValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCourseValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblCourseValue.Location = New Point(18, 39)
        lblCourseValue.Name = "lblCourseValue"
        lblCourseValue.Size = New Size(35, 41)
        lblCourseValue.TabIndex = 1
        lblCourseValue.Text = "8"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblCourseTitle.Location = New Point(19, 15)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(80, 17)
        lblCourseTitle.TabIndex = 0
        lblCourseTitle.Text = "Mata Kuliah"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.Dock = DockStyle.Top
        lblSummaryTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblSummaryTitle.Location = New Point(35, 21)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Padding = New Padding(0, 3, 0, 0)
        lblSummaryTitle.Size = New Size(872, 34)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "Ringkasan Akademik"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 562)
        Controls.Add(content)
        Controls.Add(header)
        Controls.Add(sidebar)
        MinimumSize = New Size(1100, 548)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIAKAD - Dashboard Akademik"
        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        header.ResumeLayout(False)
        header.PerformLayout()
        content.ResumeLayout(False)
        CType(dgvSchedule, ComponentModel.ISupportInitialize).EndInit()
        pnlSummaryCards.ResumeLayout(False)
        cardIpk.ResumeLayout(False)
        cardIpk.PerformLayout()
        cardSemester.ResumeLayout(False)
        cardSemester.PerformLayout()
        cardCourse.ResumeLayout(False)
        cardCourse.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents header As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents content As Panel
    Friend WithEvents lblSummaryTitle As Label
    Friend WithEvents pnlSummaryCards As TableLayoutPanel
    Friend WithEvents cardIpk As Panel
    Friend WithEvents cardSemester As Panel
    Friend WithEvents cardCourse As Panel
    Friend WithEvents lblIpkTitle As Label
    Friend WithEvents lblIpkValue As Label
    Friend WithEvents lblIpkNote As Label
    Friend WithEvents lblSemesterTitle As Label
    Friend WithEvents lblSemesterValue As Label
    Friend WithEvents lblSemesterNote As Label
    Friend WithEvents lblCourseTitle As Label
    Friend WithEvents lblCourseValue As Label
    Friend WithEvents lblCourseNote As Label
    Friend WithEvents lblScheduleTitle As Label
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents colJam As DataGridViewTextBoxColumn
    Friend WithEvents colMataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents colDosen As DataGridViewTextBoxColumn
    Friend WithEvents colRuangan As DataGridViewTextBoxColumn
    Friend WithEvents lblAnnouncementTitle As Label
    Friend WithEvents lblAnnouncement As Label
    Friend WithEvents Button1 As Button

End Class
