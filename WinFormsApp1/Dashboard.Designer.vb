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
        cardSks = New Panel()
        lblSksNote = New Label()
        lblSksValue = New Label()
        lblSksTitle = New Label()
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
        cardSks.SuspendLayout()
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
        sidebar.Margin = New Padding(3, 4, 3, 4)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(274, 960)
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
        btnDashboard.BackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
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
        ' header
        ' 
        header.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        header.BorderStyle = BorderStyle.Fixed3D
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
        lblInfo.Font = New Font("Segoe UI", 9.5F)
        lblInfo.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblInfo.Location = New Point(42, 73)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(412, 21)
        lblInfo.TabIndex = 1
        lblInfo.Text = "Ringkasan akademik dan jadwal perkuliahan semester aktif"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(40, 24)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(401, 41)
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
        content.Location = New Point(274, 120)
        content.Margin = New Padding(3, 4, 3, 4)
        content.Name = "content"
        content.Padding = New Padding(40, 28, 40, 33)
        content.Size = New Size(1193, 840)
        content.TabIndex = 2
        ' 
        ' lblAnnouncement
        ' 
        lblAnnouncement.BackColor = Color.White
        lblAnnouncement.Dock = DockStyle.Top
        lblAnnouncement.Font = New Font("Segoe UI", 10.0F)
        lblAnnouncement.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        lblAnnouncement.Location = New Point(40, 567)
        lblAnnouncement.Name = "lblAnnouncement"
        lblAnnouncement.Padding = New Padding(22, 18, 22, 18)
        lblAnnouncement.Size = New Size(1113, 110)
        lblAnnouncement.TabIndex = 8
        lblAnnouncement.Text = "• Batas akhir pengisian EDOM semester ini: 12 Januari 2026." & vbCrLf & "• Kartu Hasil Studi (Marksheet) dapat diunduh setelah seluruh evaluasi dosen selesai diisi."
        ' 
        ' lblAnnouncementTitle
        ' 
        lblAnnouncementTitle.Dock = DockStyle.Top
        lblAnnouncementTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblAnnouncementTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblAnnouncementTitle.Location = New Point(40, 509)
        lblAnnouncementTitle.Name = "lblAnnouncementTitle"
        lblAnnouncementTitle.Padding = New Padding(0, 20, 0, 0)
        lblAnnouncementTitle.Size = New Size(1113, 58)
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
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        DataGridViewCellStyle2.Padding = New Padding(14, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        dgvSchedule.DefaultCellStyle = DataGridViewCellStyle2
        dgvSchedule.Dock = DockStyle.Top
        dgvSchedule.EnableHeadersVisualStyles = False
        dgvSchedule.GridColor = Color.FromArgb(CByte(230), CByte(228), CByte(222))
        dgvSchedule.Location = New Point(40, 289)
        dgvSchedule.Margin = New Padding(3, 4, 3, 4)
        dgvSchedule.MultiSelect = False
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.ReadOnly = True
        dgvSchedule.RowHeadersVisible = False
        dgvSchedule.RowHeadersWidth = 51
        dgvSchedule.RowTemplate.Height = 46
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSchedule.Size = New Size(1113, 220)
        dgvSchedule.TabIndex = 6
        ' 
        ' colJam
        ' 
        colJam.FillWeight = 20.0F
        colJam.HeaderText = "Jam Perkuliahan"
        colJam.MinimumWidth = 6
        colJam.Name = "colJam"
        colJam.ReadOnly = True
        ' 
        ' colMataKuliah
        ' 
        colMataKuliah.FillWeight = 34.0F
        colMataKuliah.HeaderText = "Mata Kuliah"
        colMataKuliah.MinimumWidth = 6
        colMataKuliah.Name = "colMataKuliah"
        colMataKuliah.ReadOnly = True
        ' 
        ' colDosen
        ' 
        colDosen.FillWeight = 30.0F
        colDosen.HeaderText = "Dosen Pengampu"
        colDosen.MinimumWidth = 6
        colDosen.Name = "colDosen"
        colDosen.ReadOnly = True
        ' 
        ' colRuangan
        ' 
        colRuangan.FillWeight = 16.0F
        colRuangan.HeaderText = "Ruangan"
        colRuangan.MinimumWidth = 6
        colRuangan.Name = "colRuangan"
        colRuangan.ReadOnly = True
        ' 
        ' lblScheduleTitle
        ' 
        lblScheduleTitle.Dock = DockStyle.Top
        lblScheduleTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblScheduleTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblScheduleTitle.Location = New Point(40, 231)
        lblScheduleTitle.Name = "lblScheduleTitle"
        lblScheduleTitle.Padding = New Padding(0, 20, 0, 0)
        lblScheduleTitle.Size = New Size(1113, 58)
        lblScheduleTitle.TabIndex = 5
        lblScheduleTitle.Text = "Jadwal Kuliah Hari Ini"
        ' 
        ' pnlSummaryCards
        ' 
        pnlSummaryCards.ColumnCount = 4
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlSummaryCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlSummaryCards.Controls.Add(cardIpk, 0, 0)
        pnlSummaryCards.Controls.Add(cardSks, 1, 0)
        pnlSummaryCards.Controls.Add(cardSemester, 2, 0)
        pnlSummaryCards.Controls.Add(cardCourse, 3, 0)
        pnlSummaryCards.Dock = DockStyle.Top
        pnlSummaryCards.Location = New Point(40, 74)
        pnlSummaryCards.Margin = New Padding(0)
        pnlSummaryCards.Name = "pnlSummaryCards"
        pnlSummaryCards.RowCount = 1
        pnlSummaryCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        pnlSummaryCards.Size = New Size(1113, 157)
        pnlSummaryCards.TabIndex = 4
        ' 
        ' cardIpk
        ' 
        cardIpk.BackColor = Color.White
        cardIpk.Controls.Add(lblIpkNote)
        cardIpk.Controls.Add(lblIpkValue)
        cardIpk.Controls.Add(lblIpkTitle)
        cardIpk.Dock = DockStyle.Fill
        cardIpk.Location = New Point(0, 4)
        cardIpk.Margin = New Padding(0, 4, 12, 4)
        cardIpk.Name = "cardIpk"
        cardIpk.Size = New Size(266, 149)
        cardIpk.TabIndex = 1
        ' 
        ' lblIpkNote
        ' 
        lblIpkNote.AutoSize = True
        lblIpkNote.Font = New Font("Segoe UI", 8.5F)
        lblIpkNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblIpkNote.Location = New Point(22, 112)
        lblIpkNote.Name = "lblIpkNote"
        lblIpkNote.Size = New Size(135, 20)
        lblIpkNote.TabIndex = 2
        lblIpkNote.Text = "Skala 4.00 semester berjalan"
        ' 
        ' lblIpkValue
        ' 
        lblIpkValue.AutoSize = True
        lblIpkValue.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblIpkValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblIpkValue.Location = New Point(20, 52)
        lblIpkValue.Name = "lblIpkValue"
        lblIpkValue.Size = New Size(98, 50)
        lblIpkValue.TabIndex = 1
        lblIpkValue.Text = "3.75"
        ' 
        ' lblIpkTitle
        ' 
        lblIpkTitle.AutoSize = True
        lblIpkTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblIpkTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblIpkTitle.Location = New Point(22, 20)
        lblIpkTitle.Name = "lblIpkTitle"
        lblIpkTitle.Size = New Size(105, 21)
        lblIpkTitle.TabIndex = 0
        lblIpkTitle.Text = "IPK Kumulatif"
        ' 
        ' cardSks
        ' 
        cardSks.BackColor = Color.White
        cardSks.Controls.Add(lblSksNote)
        cardSks.Controls.Add(lblSksValue)
        cardSks.Controls.Add(lblSksTitle)
        cardSks.Dock = DockStyle.Fill
        cardSks.Location = New Point(284, 4)
        cardSks.Margin = New Padding(6, 4, 6, 4)
        cardSks.Name = "cardSks"
        cardSks.Size = New Size(266, 149)
        cardSks.TabIndex = 2
        ' 
        ' lblSksNote
        ' 
        lblSksNote.AutoSize = True
        lblSksNote.Font = New Font("Segoe UI", 8.5F)
        lblSksNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblSksNote.Location = New Point(22, 112)
        lblSksNote.Name = "lblSksNote"
        lblSksNote.Size = New Size(141, 20)
        lblSksNote.TabIndex = 2
        lblSksNote.Text = "Lulus dari target 144 SKS"
        ' 
        ' lblSksValue
        ' 
        lblSksValue.AutoSize = True
        lblSksValue.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblSksValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblSksValue.Location = New Point(20, 52)
        lblSksValue.Name = "lblSksValue"
        lblSksValue.Size = New Size(141, 50)
        lblSksValue.TabIndex = 1
        lblSksValue.Text = "96 SKS"
        ' 
        ' lblSksTitle
        ' 
        lblSksTitle.AutoSize = True
        lblSksTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSksTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblSksTitle.Location = New Point(22, 20)
        lblSksTitle.Name = "lblSksTitle"
        lblSksTitle.Size = New Size(75, 21)
        lblSksTitle.TabIndex = 0
        lblSksTitle.Text = "Total SKS"
        ' 
        ' cardSemester
        ' 
        cardSemester.BackColor = Color.White
        cardSemester.Controls.Add(lblSemesterNote)
        cardSemester.Controls.Add(lblSemesterValue)
        cardSemester.Controls.Add(lblSemesterTitle)
        cardSemester.Dock = DockStyle.Fill
        cardSemester.Location = New Point(562, 4)
        cardSemester.Margin = New Padding(6, 4, 6, 4)
        cardSemester.Name = "cardSemester"
        cardSemester.Size = New Size(266, 149)
        cardSemester.TabIndex = 3
        ' 
        ' lblSemesterNote
        ' 
        lblSemesterNote.AutoSize = True
        lblSemesterNote.Font = New Font("Segoe UI", 8.5F)
        lblSemesterNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblSemesterNote.Location = New Point(22, 112)
        lblSemesterNote.Name = "lblSemesterNote"
        lblSemesterNote.Size = New Size(158, 20)
        lblSemesterNote.TabIndex = 2
        lblSemesterNote.Text = "Tahun Akademik 2025/2026"
        ' 
        ' lblSemesterValue
        ' 
        lblSemesterValue.AutoSize = True
        lblSemesterValue.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblSemesterValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblSemesterValue.Location = New Point(20, 52)
        lblSemesterValue.Name = "lblSemesterValue"
        lblSemesterValue.Size = New Size(43, 50)
        lblSemesterValue.TabIndex = 1
        lblSemesterValue.Text = "6"
        ' 
        ' lblSemesterTitle
        ' 
        lblSemesterTitle.AutoSize = True
        lblSemesterTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblSemesterTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblSemesterTitle.Location = New Point(22, 20)
        lblSemesterTitle.Name = "lblSemesterTitle"
        lblSemesterTitle.Size = New Size(112, 21)
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
        cardCourse.Location = New Point(846, 4)
        cardCourse.Margin = New Padding(12, 4, 0, 4)
        cardCourse.Name = "cardCourse"
        cardCourse.Size = New Size(267, 149)
        cardCourse.TabIndex = 4
        ' 
        ' lblCourseNote
        ' 
        lblCourseNote.AutoSize = True
        lblCourseNote.Font = New Font("Segoe UI", 8.5F)
        lblCourseNote.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblCourseNote.Location = New Point(22, 112)
        lblCourseNote.Name = "lblCourseNote"
        lblCourseNote.Size = New Size(148, 20)
        lblCourseNote.TabIndex = 2
        lblCourseNote.Text = "Diambil pada KRS semester 6"
        ' 
        ' lblCourseValue
        ' 
        lblCourseValue.AutoSize = True
        lblCourseValue.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblCourseValue.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblCourseValue.Location = New Point(20, 52)
        lblCourseValue.Name = "lblCourseValue"
        lblCourseValue.Size = New Size(43, 50)
        lblCourseValue.TabIndex = 1
        lblCourseValue.Text = "8"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblCourseTitle.Location = New Point(22, 20)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(94, 21)
        lblCourseTitle.TabIndex = 0
        lblCourseTitle.Text = "Mata Kuliah"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.Dock = DockStyle.Top
        lblSummaryTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblSummaryTitle.Location = New Point(40, 28)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Padding = New Padding(0, 4, 0, 0)
        lblSummaryTitle.Size = New Size(1113, 46)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "Ringkasan Akademik"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1467, 960)
        Controls.Add(content)
        Controls.Add(header)
        Controls.Add(sidebar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1255, 918)
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
        cardSks.ResumeLayout(False)
        cardSks.PerformLayout()
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
    Friend WithEvents cardSks As Panel
    Friend WithEvents cardSemester As Panel
    Friend WithEvents cardCourse As Panel
    Friend WithEvents lblIpkTitle As Label
    Friend WithEvents lblIpkValue As Label
    Friend WithEvents lblIpkNote As Label
    Friend WithEvents lblSksTitle As Label
    Friend WithEvents lblSksValue As Label
    Friend WithEvents lblSksNote As Label
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
