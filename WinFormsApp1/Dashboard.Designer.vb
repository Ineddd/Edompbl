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
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.lblBrandSubtitle = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.content = New System.Windows.Forms.Panel()
        Me.lblAnnouncement = New System.Windows.Forms.Label()
        Me.lblAnnouncementTitle = New System.Windows.Forms.Label()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.colJam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMataKuliah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDosen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRuangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblScheduleTitle = New System.Windows.Forms.Label()
        Me.cardCourse = New System.Windows.Forms.Panel()
        Me.lblCourseValue = New System.Windows.Forms.Label()
        Me.lblCourseTitle = New System.Windows.Forms.Label()
        Me.cardSemester = New System.Windows.Forms.Panel()
        Me.lblSemesterValue = New System.Windows.Forms.Label()
        Me.lblSemesterTitle = New System.Windows.Forms.Label()
        Me.cardSks = New System.Windows.Forms.Panel()
        Me.lblSksValue = New System.Windows.Forms.Label()
        Me.lblSksTitle = New System.Windows.Forms.Label()
        Me.cardIpk = New System.Windows.Forms.Panel()
        Me.lblIpkValue = New System.Windows.Forms.Label()
        Me.lblIpkTitle = New System.Windows.Forms.Label()
        Me.lblSummaryTitle = New System.Windows.Forms.Label()
        Me.sidebar.SuspendLayout()
        Me.header.SuspendLayout()
        Me.content.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cardCourse.SuspendLayout()
        Me.cardSemester.SuspendLayout()
        Me.cardSks.SuspendLayout()
        Me.cardIpk.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(25, 45, 78)
        Me.sidebar.Controls.Add(Me.btnLogout)
        Me.sidebar.Controls.Add(Me.btnDashboard)
        Me.sidebar.Controls.Add(Me.lblBrandSubtitle)
        Me.sidebar.Controls.Add(Me.lblBrand)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(240, 720)
        Me.sidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(25, 645)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(190, 42)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Keluar"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(13, 110, 253)
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(15, 140)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(210, 42)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "    Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'lblBrandSubtitle
        '
        Me.lblBrandSubtitle.AutoSize = True
        Me.lblBrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(190, 205, 220)
        Me.lblBrandSubtitle.Location = New System.Drawing.Point(30, 70)
        Me.lblBrandSubtitle.Name = "lblBrandSubtitle"
        Me.lblBrandSubtitle.Size = New System.Drawing.Size(148, 15)
        Me.lblBrandSubtitle.TabIndex = 1
        Me.lblBrandSubtitle.Text = "Sistem Informasi Akademik"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(27, 25)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(111, 41)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "SIAKAD"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.White
        Me.header.Controls.Add(Me.lblInfo)
        Me.header.Controls.Add(Me.lblWelcome)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(240, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1044, 90)
        Me.header.TabIndex = 1
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblInfo.Location = New System.Drawing.Point(37, 55)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(259, 15)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Kelola aktivitas akademik Anda dengan mudah"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblWelcome.Location = New System.Drawing.Point(35, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(275, 32)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Selamat datang, Mahasiswa"
        '
        'content
        '
        Me.content.AutoScroll = True
        Me.content.BackColor = System.Drawing.Color.FromArgb(245, 247, 251)
        Me.content.Controls.Add(Me.lblAnnouncement)
        Me.content.Controls.Add(Me.lblAnnouncementTitle)
        Me.content.Controls.Add(Me.dgvSchedule)
        Me.content.Controls.Add(Me.lblScheduleTitle)
        Me.content.Controls.Add(Me.cardCourse)
        Me.content.Controls.Add(Me.cardSemester)
        Me.content.Controls.Add(Me.cardSks)
        Me.content.Controls.Add(Me.cardIpk)
        Me.content.Controls.Add(Me.lblSummaryTitle)
        Me.content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.content.Location = New System.Drawing.Point(240, 90)
        Me.content.Name = "content"
        Me.content.Padding = New System.Windows.Forms.Padding(35, 25, 35, 25)
        Me.content.Size = New System.Drawing.Size(1044, 630)
        Me.content.TabIndex = 2
        '
        'lblAnnouncement
        '
        Me.lblAnnouncement.BackColor = System.Drawing.Color.White
        Me.lblAnnouncement.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAnnouncement.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAnnouncement.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87)
        Me.lblAnnouncement.Location = New System.Drawing.Point(35, 545)
        Me.lblAnnouncement.Name = "lblAnnouncement"
        Me.lblAnnouncement.Padding = New System.Windows.Forms.Padding(15)
        Me.lblAnnouncement.Size = New System.Drawing.Size(974, 90)
        Me.lblAnnouncement.TabIndex = 8
        Me.lblAnnouncement.Text = "• Pengisian KRS semester berikutnya dimulai tanggal 15 Juli." &
            vbCrLf & "• Pembayaran UKT terakhir tanggal 20 Juli." &
            vbCrLf & "• Ujian akhir semester dilaksanakan pada bulan Agustus."
        '
        'lblAnnouncementTitle
        '
        Me.lblAnnouncementTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAnnouncementTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAnnouncementTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblAnnouncementTitle.Location = New System.Drawing.Point(35, 500)
        Me.lblAnnouncementTitle.Name = "lblAnnouncementTitle"
        Me.lblAnnouncementTitle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.lblAnnouncementTitle.Size = New System.Drawing.Size(974, 45)
        Me.lblAnnouncementTitle.TabIndex = 7
        Me.lblAnnouncementTitle.Text = "Pengumuman Akademik"
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.colJam,
            Me.colMataKuliah,
            Me.colDosen,
            Me.colRuangan})
        Me.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvSchedule.Location = New System.Drawing.Point(35, 320)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        Me.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedule.Size = New System.Drawing.Size(974, 180)
        Me.dgvSchedule.TabIndex = 6
        '
        'colJam
        '
        Me.colJam.HeaderText = "Jam"
        Me.colJam.Name = "colJam"
        Me.colJam.ReadOnly = True
        '
        'colMataKuliah
        '
        Me.colMataKuliah.HeaderText = "Mata Kuliah"
        Me.colMataKuliah.Name = "colMataKuliah"
        Me.colMataKuliah.ReadOnly = True
        '
        'colDosen
        '
        Me.colDosen.HeaderText = "Dosen"
        Me.colDosen.Name = "colDosen"
        Me.colDosen.ReadOnly = True
        '
        'colRuangan
        '
        Me.colRuangan.HeaderText = "Ruangan"
        Me.colRuangan.Name = "colRuangan"
        Me.colRuangan.ReadOnly = True
        '
        'lblScheduleTitle
        '
        Me.lblScheduleTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblScheduleTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblScheduleTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblScheduleTitle.Location = New System.Drawing.Point(35, 275)
        Me.lblScheduleTitle.Name = "lblScheduleTitle"
        Me.lblScheduleTitle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.lblScheduleTitle.Size = New System.Drawing.Size(974, 45)
        Me.lblScheduleTitle.TabIndex = 5
        Me.lblScheduleTitle.Text = "Jadwal Kuliah Hari Ini"
        '
        'cardCourse
        '
        Me.cardCourse.BackColor = System.Drawing.Color.White
        Me.cardCourse.Controls.Add(Me.lblCourseValue)
        Me.cardCourse.Controls.Add(Me.lblCourseTitle)
        Me.cardCourse.Location = New System.Drawing.Point(770, 70)
        Me.cardCourse.Name = "cardCourse"
        Me.cardCourse.Size = New System.Drawing.Size(205, 100)
        Me.cardCourse.TabIndex = 4
        '
        'lblCourseValue
        '
        Me.lblCourseValue.AutoSize = True
        Me.lblCourseValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblCourseValue.ForeColor = System.Drawing.Color.FromArgb(111, 66, 193)
        Me.lblCourseValue.Location = New System.Drawing.Point(20, 45)
        Me.lblCourseValue.Name = "lblCourseValue"
        Me.lblCourseValue.Size = New System.Drawing.Size(29, 37)
        Me.lblCourseValue.TabIndex = 1
        Me.lblCourseValue.Text = "8"
        '
        'lblCourseTitle
        '
        Me.lblCourseTitle.AutoSize = True
        Me.lblCourseTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCourseTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblCourseTitle.Location = New System.Drawing.Point(20, 17)
        Me.lblCourseTitle.Name = "lblCourseTitle"
        Me.lblCourseTitle.Size = New System.Drawing.Size(92, 15)
        Me.lblCourseTitle.TabIndex = 0
        Me.lblCourseTitle.Text = "Mata Kuliah"
        '
        'cardSemester
        '
        Me.cardSemester.BackColor = System.Drawing.Color.White
        Me.cardSemester.Controls.Add(Me.lblSemesterValue)
        Me.cardSemester.Controls.Add(Me.lblSemesterTitle)
        Me.cardSemester.Location = New System.Drawing.Point(550, 70)
        Me.cardSemester.Name = "cardSemester"
        Me.cardSemester.Size = New System.Drawing.Size(205, 100)
        Me.cardSemester.TabIndex = 3
        '
        'lblSemesterValue
        '
        Me.lblSemesterValue.AutoSize = True
        Me.lblSemesterValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSemesterValue.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7)
        Me.lblSemesterValue.Location = New System.Drawing.Point(20, 45)
        Me.lblSemesterValue.Name = "lblSemesterValue"
        Me.lblSemesterValue.Size = New System.Drawing.Size(26, 37)
        Me.lblSemesterValue.TabIndex = 1
        Me.lblSemesterValue.Text = "6"
        '
        'lblSemesterTitle
        '
        Me.lblSemesterTitle.AutoSize = True
        Me.lblSemesterTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSemesterTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblSemesterTitle.Location = New System.Drawing.Point(20, 17)
        Me.lblSemesterTitle.Name = "lblSemesterTitle"
        Me.lblSemesterTitle.Size = New System.Drawing.Size(87, 15)
        Me.lblSemesterTitle.TabIndex = 0
        Me.lblSemesterTitle.Text = "Semester Aktif"
        '
        'cardSks
        '
        Me.cardSks.BackColor = System.Drawing.Color.White
        Me.cardSks.Controls.Add(Me.lblSksValue)
        Me.cardSks.Controls.Add(Me.lblSksTitle)
        Me.cardSks.Location = New System.Drawing.Point(330, 70)
        Me.cardSks.Name = "cardSks"
        Me.cardSks.Size = New System.Drawing.Size(205, 100)
        Me.cardSks.TabIndex = 2
        '
        'lblSksValue
        '
        Me.lblSksValue.AutoSize = True
        Me.lblSksValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSksValue.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84)
        Me.lblSksValue.Location = New System.Drawing.Point(20, 45)
        Me.lblSksValue.Name = "lblSksValue"
        Me.lblSksValue.Size = New System.Drawing.Size(86, 37)
        Me.lblSksValue.TabIndex = 1
        Me.lblSksValue.Text = "96 SKS"
        '
        'lblSksTitle
        '
        Me.lblSksTitle.AutoSize = True
        Me.lblSksTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSksTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblSksTitle.Location = New System.Drawing.Point(20, 17)
        Me.lblSksTitle.Name = "lblSksTitle"
        Me.lblSksTitle.Size = New System.Drawing.Size(62, 15)
        Me.lblSksTitle.TabIndex = 0
        Me.lblSksTitle.Text = "Total SKS"
        '
        'cardIpk
        '
        Me.cardIpk.BackColor = System.Drawing.Color.White
        Me.cardIpk.Controls.Add(Me.lblIpkValue)
        Me.cardIpk.Controls.Add(Me.lblIpkTitle)
        Me.cardIpk.Location = New System.Drawing.Point(110, 70)
        Me.cardIpk.Name = "cardIpk"
        Me.cardIpk.Size = New System.Drawing.Size(205, 100)
        Me.cardIpk.TabIndex = 1
        '
        'lblIpkValue
        '
        Me.lblIpkValue.AutoSize = True
        Me.lblIpkValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblIpkValue.ForeColor = System.Drawing.Color.FromArgb(13, 110, 253)
        Me.lblIpkValue.Location = New System.Drawing.Point(20, 45)
        Me.lblIpkValue.Name = "lblIpkValue"
        Me.lblIpkValue.Size = New System.Drawing.Size(59, 37)
        Me.lblIpkValue.TabIndex = 1
        Me.lblIpkValue.Text = "3.75"
        '
        'lblIpkTitle
        '
        Me.lblIpkTitle.AutoSize = True
        Me.lblIpkTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIpkTitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.lblIpkTitle.Location = New System.Drawing.Point(20, 17)
        Me.lblIpkTitle.Name = "lblIpkTitle"
        Me.lblIpkTitle.Size = New System.Drawing.Size(84, 15)
        Me.lblIpkTitle.TabIndex = 0
        Me.lblIpkTitle.Text = "IPK Kumulatif"
        '
        'lblSummaryTitle
        '
        Me.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSummaryTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41)
        Me.lblSummaryTitle.Location = New System.Drawing.Point(35, 25)
        Me.lblSummaryTitle.Name = "lblSummaryTitle"
        Me.lblSummaryTitle.Size = New System.Drawing.Size(974, 45)
        Me.lblSummaryTitle.TabIndex = 0
        Me.lblSummaryTitle.Text = "Ringkasan Akademik"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 720)
        Me.Controls.Add(Me.content)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidebar)
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard Akademik"
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.content.ResumeLayout(False)
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cardCourse.ResumeLayout(False)
        Me.cardCourse.PerformLayout()
        Me.cardSemester.ResumeLayout(False)
        Me.cardSemester.PerformLayout()
        Me.cardSks.ResumeLayout(False)
        Me.cardSks.PerformLayout()
        Me.cardIpk.ResumeLayout(False)
        Me.cardIpk.PerformLayout()
        Me.ResumeLayout(False)

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
