<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard_dosen
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

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblDosenName As Label
    Friend WithEvents lblDosenNidn As Label
    Friend WithEvents btnMenuStatistik As Button
    Friend WithEvents btnMenuMataKuliah As Button
    Friend WithEvents btnLogout As Button

    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents pnlFilterCard As Panel
    Friend WithEvents lblFilterLabel As Label
    Friend WithEvents cmbMataKuliah As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblLastUpdated As Label

    Friend WithEvents pnlStatistikView As Panel
    Friend WithEvents tblMetricCards As TableLayoutPanel
    Friend WithEvents cardTotal As Panel
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotalMahasiswa As Label
    Friend WithEvents lblTotalSub As Label
    Friend WithEvents cardSudah As Panel
    Friend WithEvents lblSudahTitle As Label
    Friend WithEvents lblSudahMengisi As Label
    Friend WithEvents lblSudahSub As Label
    Friend WithEvents cardBelum As Panel
    Friend WithEvents lblBelumTitle As Label
    Friend WithEvents lblBelumMengisi As Label
    Friend WithEvents lblBelumSub As Label
    Friend WithEvents cardPersen As Panel
    Friend WithEvents lblPersenTitle As Label
    Friend WithEvents lblPersentase As Label
    Friend WithEvents lblPersenSub As Label

    Friend WithEvents pnlScoreCard As Panel
    Friend WithEvents lblScoreCardTitle As Label
    Friend WithEvents lblRataRataSkor As Label
    Friend WithEvents lblScoreScale As Label
    Friend WithEvents lblPredikatBadge As Label
    Friend WithEvents pnlAspects As TableLayoutPanel
    Friend WithEvents lblPedagogikTitle As Label
    Friend WithEvents lblPedagogikVal As Label
    Friend WithEvents lblProfesionalTitle As Label
    Friend WithEvents lblProfesionalVal As Label
    Friend WithEvents lblKepribadianTitle As Label
    Friend WithEvents lblKepribadianVal As Label
    Friend WithEvents lblSosialTitle As Label
    Friend WithEvents lblSosialVal As Label

    Friend WithEvents pnlFeedbackSection As Panel
    Friend WithEvents lblFeedbackTitle As Label
    Friend WithEvents btnRincianButir As Button
    Friend WithEvents lblFeedbackSub As Label
    Friend WithEvents dgvFeedback As DataGridView
    Friend WithEvents colFNo As DataGridViewTextBoxColumn
    Friend WithEvents colFMataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents colFMahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents colFWaktu As DataGridViewTextBoxColumn
    Friend WithEvents colFSkor As DataGridViewTextBoxColumn
    Friend WithEvents colFSaran As DataGridViewTextBoxColumn

    Friend WithEvents pnlMataKuliahView As Panel
    Friend WithEvents pnlMkHeader As Panel
    Friend WithEvents lblMkViewTitle As Label
    Friend WithEvents lblMkViewSub As Label
    Friend WithEvents dgvMataKuliahDiajar As DataGridView
    Friend WithEvents colMkNo As DataGridViewTextBoxColumn
    Friend WithEvents colMkNama As DataGridViewTextBoxColumn
    Friend WithEvents colMkRuang As DataGridViewTextBoxColumn
    Friend WithEvents colMkMahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents colMkSudah As DataGridViewTextBoxColumn
    Friend WithEvents colMkBelum As DataGridViewTextBoxColumn
    Friend WithEvents colMkPersen As DataGridViewTextBoxColumn
    Friend WithEvents colMkSkor As DataGridViewTextBoxColumn
    Friend WithEvents colMkStatus As DataGridViewTextBoxColumn

    Friend WithEvents pnlState As Panel
    Friend WithEvents lblStateMessage As Label
    Friend WithEvents btnRetry As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim dgvFeedbackStyle1 As New DataGridViewCellStyle()
        Dim dgvFeedbackStyle2 As New DataGridViewCellStyle()
        Dim dgvMkStyle1 As New DataGridViewCellStyle()
        Dim dgvMkStyle2 As New DataGridViewCellStyle()

        sidebar = New Panel()
        lblBrand = New Label()
        lblBrandSubtitle = New Label()
        lblRole = New Label()
        lblDosenName = New Label()
        lblDosenNidn = New Label()
        btnMenuStatistik = New Button()
        btnMenuMataKuliah = New Button()
        btnLogout = New Button()

        pnlMainContent = New Panel()
        pnlTopBar = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSubtitle = New Label()
        pnlFilterCard = New Panel()
        lblFilterLabel = New Label()
        cmbMataKuliah = New ComboBox()
        btnRefresh = New Button()
        lblLastUpdated = New Label()

        pnlStatistikView = New Panel()
        tblMetricCards = New TableLayoutPanel()
        cardTotal = New Panel()
        lblTotalTitle = New Label()
        lblTotalMahasiswa = New Label()
        lblTotalSub = New Label()
        cardSudah = New Panel()
        lblSudahTitle = New Label()
        lblSudahMengisi = New Label()
        lblSudahSub = New Label()
        cardBelum = New Panel()
        lblBelumTitle = New Label()
        lblBelumMengisi = New Label()
        lblBelumSub = New Label()
        cardPersen = New Panel()
        lblPersenTitle = New Label()
        lblPersentase = New Label()
        lblPersenSub = New Label()

        pnlScoreCard = New Panel()
        lblScoreCardTitle = New Label()
        lblRataRataSkor = New Label()
        lblScoreScale = New Label()
        lblPredikatBadge = New Label()
        pnlAspects = New TableLayoutPanel()
        lblPedagogikTitle = New Label()
        lblPedagogikVal = New Label()
        lblProfesionalTitle = New Label()
        lblProfesionalVal = New Label()
        lblKepribadianTitle = New Label()
        lblKepribadianVal = New Label()
        lblSosialTitle = New Label()
        lblSosialVal = New Label()

        pnlFeedbackSection = New Panel()
        lblFeedbackTitle = New Label()
        btnRincianButir = New Button()
        lblFeedbackSub = New Label()
        dgvFeedback = New DataGridView()
        colFNo = New DataGridViewTextBoxColumn()
        colFMataKuliah = New DataGridViewTextBoxColumn()
        colFMahasiswa = New DataGridViewTextBoxColumn()
        colFWaktu = New DataGridViewTextBoxColumn()
        colFSkor = New DataGridViewTextBoxColumn()
        colFSaran = New DataGridViewTextBoxColumn()

        pnlMataKuliahView = New Panel()
        pnlMkHeader = New Panel()
        lblMkViewTitle = New Label()
        lblMkViewSub = New Label()
        dgvMataKuliahDiajar = New DataGridView()
        colMkNo = New DataGridViewTextBoxColumn()
        colMkNama = New DataGridViewTextBoxColumn()
        colMkRuang = New DataGridViewTextBoxColumn()
        colMkMahasiswa = New DataGridViewTextBoxColumn()
        colMkSudah = New DataGridViewTextBoxColumn()
        colMkBelum = New DataGridViewTextBoxColumn()
        colMkPersen = New DataGridViewTextBoxColumn()
        colMkSkor = New DataGridViewTextBoxColumn()
        colMkStatus = New DataGridViewTextBoxColumn()

        pnlState = New Panel()
        lblStateMessage = New Label()
        btnRetry = New Button()

        sidebar.SuspendLayout()
        pnlMainContent.SuspendLayout()
        pnlTopBar.SuspendLayout()
        pnlFilterCard.SuspendLayout()
        pnlStatistikView.SuspendLayout()
        tblMetricCards.SuspendLayout()
        cardTotal.SuspendLayout()
        cardSudah.SuspendLayout()
        cardBelum.SuspendLayout()
        cardPersen.SuspendLayout()
        pnlScoreCard.SuspendLayout()
        pnlAspects.SuspendLayout()
        pnlFeedbackSection.SuspendLayout()
        CType(dgvFeedback, ComponentModel.ISupportInitialize).BeginInit()
        pnlMataKuliahView.SuspendLayout()
        pnlMkHeader.SuspendLayout()
        CType(dgvMataKuliahDiajar, ComponentModel.ISupportInitialize).BeginInit()
        pnlState.SuspendLayout()
        SuspendLayout()

        ' 
        ' sidebar
        ' 
        sidebar.BackColor = Color.FromArgb(30, 59, 51)
        sidebar.BorderStyle = BorderStyle.Fixed3D
        sidebar.Controls.Add(lblBrand)
        sidebar.Controls.Add(lblBrandSubtitle)
        sidebar.Controls.Add(lblRole)
        sidebar.Controls.Add(lblDosenName)
        sidebar.Controls.Add(lblDosenNidn)
        sidebar.Controls.Add(btnMenuStatistik)
        sidebar.Controls.Add(btnMenuMataKuliah)
        sidebar.Controls.Add(btnLogout)
        sidebar.Dock = DockStyle.Left
        sidebar.Location = New Point(0, 0)
        sidebar.Margin = New Padding(3, 4, 3, 4)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(274, 960)
        sidebar.TabIndex = 0

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
        ' lblBrandSubtitle
        ' 
        lblBrandSubtitle.AutoSize = True
        lblBrandSubtitle.Font = New Font("Segoe UI", 8.5F)
        lblBrandSubtitle.ForeColor = Color.FromArgb(190, 205, 220)
        lblBrandSubtitle.Location = New Point(34, 88)
        lblBrandSubtitle.Name = "lblBrandSubtitle"
        lblBrandSubtitle.Size = New Size(189, 20)
        lblBrandSubtitle.TabIndex = 1
        lblBrandSubtitle.Text = "Sistem Informasi Akademik"

        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblRole.ForeColor = Color.FromArgb(214, 226, 206)
        lblRole.Location = New Point(34, 120)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(110, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "PORTAL DOSEN"

        ' 
        ' lblDosenName
        ' 
        lblDosenName.AutoEllipsis = True
        lblDosenName.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDosenName.ForeColor = Color.White
        lblDosenName.Location = New Point(34, 144)
        lblDosenName.Name = "lblDosenName"
        lblDosenName.Size = New Size(220, 48)
        lblDosenName.TabIndex = 3
        lblDosenName.Text = "Nama Dosen"

        ' 
        ' lblDosenNidn
        ' 
        lblDosenNidn.AutoSize = True
        lblDosenNidn.Font = New Font("Segoe UI", 8.5F)
        lblDosenNidn.ForeColor = Color.FromArgb(190, 205, 220)
        lblDosenNidn.Location = New Point(34, 194)
        lblDosenNidn.Name = "lblDosenNidn"
        lblDosenNidn.Size = New Size(100, 20)
        lblDosenNidn.TabIndex = 4
        lblDosenNidn.Text = "NIDN: -"

        ' 
        ' btnMenuStatistik
        ' 
        btnMenuStatistik.BackColor = Color.FromArgb(114, 142, 109)
        btnMenuStatistik.Cursor = Cursors.Hand
        btnMenuStatistik.FlatAppearance.BorderSize = 0
        btnMenuStatistik.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 142, 109)
        btnMenuStatistik.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 118, 84)
        btnMenuStatistik.FlatStyle = FlatStyle.Flat
        btnMenuStatistik.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnMenuStatistik.ForeColor = Color.White
        btnMenuStatistik.Location = New Point(-2, 240)
        btnMenuStatistik.Margin = New Padding(3, 4, 3, 4)
        btnMenuStatistik.Name = "btnMenuStatistik"
        btnMenuStatistik.Size = New Size(274, 56)
        btnMenuStatistik.TabIndex = 5
        btnMenuStatistik.Text = "    Statistik Hasil EDOM"
        btnMenuStatistik.TextAlign = ContentAlignment.MiddleLeft
        btnMenuStatistik.UseVisualStyleBackColor = False

        ' 
        ' btnMenuMataKuliah
        ' 
        btnMenuMataKuliah.BackColor = Color.FromArgb(46, 82, 72)
        btnMenuMataKuliah.Cursor = Cursors.Hand
        btnMenuMataKuliah.FlatAppearance.BorderSize = 0
        btnMenuMataKuliah.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 142, 109)
        btnMenuMataKuliah.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 118, 84)
        btnMenuMataKuliah.FlatStyle = FlatStyle.Flat
        btnMenuMataKuliah.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnMenuMataKuliah.ForeColor = Color.White
        btnMenuMataKuliah.Location = New Point(-2, 305)
        btnMenuMataKuliah.Margin = New Padding(3, 4, 3, 4)
        btnMenuMataKuliah.Name = "btnMenuMataKuliah"
        btnMenuMataKuliah.Size = New Size(274, 56)
        btnMenuMataKuliah.TabIndex = 6
        btnMenuMataKuliah.Text = "    Mata Kuliah Diajar"
        btnMenuMataKuliah.TextAlign = ContentAlignment.MiddleLeft
        btnMenuMataKuliah.UseVisualStyleBackColor = False

        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.FromArgb(220, 53, 69)
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 42, 55)
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(28, 875)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(217, 56)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False

        ' 
        ' pnlMainContent
        ' 
        pnlMainContent.AutoScroll = True
        pnlMainContent.BackColor = Color.FromArgb(250, 248, 243)
        pnlMainContent.Controls.Add(pnlStatistikView)
        pnlMainContent.Controls.Add(pnlMataKuliahView)
        pnlMainContent.Controls.Add(pnlState)
        pnlMainContent.Controls.Add(pnlFilterCard)
        pnlMainContent.Controls.Add(pnlTopBar)
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.Location = New Point(274, 0)
        pnlMainContent.Margin = New Padding(3, 4, 3, 4)
        pnlMainContent.Name = "pnlMainContent"
        pnlMainContent.Padding = New Padding(32, 24, 32, 24)
        pnlMainContent.Size = New Size(1193, 960)
        pnlMainContent.TabIndex = 1

        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.Controls.Add(lblHeaderTitle)
        pnlTopBar.Controls.Add(lblHeaderSubtitle)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(32, 24)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1129, 64)
        pnlTopBar.TabIndex = 0

        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(30, 59, 51)
        lblHeaderTitle.Location = New Point(0, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(540, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Statistik Hasil Evaluasi Dosen (EDOM)"

        ' 
        ' lblHeaderSubtitle
        ' 
        lblHeaderSubtitle.AutoSize = True
        lblHeaderSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblHeaderSubtitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblHeaderSubtitle.Location = New Point(2, 38)
        lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        lblHeaderSubtitle.Size = New Size(550, 21)
        lblHeaderSubtitle.TabIndex = 1
        lblHeaderSubtitle.Text = "Rekapitulasi partisipasi dan evaluasi pembelajaran oleh mahasiswa semester ini"

        ' 
        ' pnlFilterCard
        ' 
        pnlFilterCard.BackColor = Color.White
        pnlFilterCard.Controls.Add(lblFilterLabel)
        pnlFilterCard.Controls.Add(cmbMataKuliah)
        pnlFilterCard.Controls.Add(btnRefresh)
        pnlFilterCard.Controls.Add(lblLastUpdated)
        pnlFilterCard.Dock = DockStyle.Top
        pnlFilterCard.Location = New Point(32, 88)
        pnlFilterCard.Name = "pnlFilterCard"
        pnlFilterCard.Padding = New Padding(20, 16, 20, 16)
        pnlFilterCard.Size = New Size(1129, 76)
        pnlFilterCard.TabIndex = 1

        ' 
        ' lblFilterLabel
        ' 
        lblFilterLabel.AutoSize = True
        lblFilterLabel.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblFilterLabel.ForeColor = Color.FromArgb(30, 59, 51)
        lblFilterLabel.Location = New Point(20, 26)
        lblFilterLabel.Name = "lblFilterLabel"
        lblFilterLabel.Size = New Size(207, 23)
        lblFilterLabel.TabIndex = 0
        lblFilterLabel.Text = "Mata Kuliah yang Diajar:"

        ' 
        ' cmbMataKuliah
        ' 
        cmbMataKuliah.Cursor = Cursors.Hand
        cmbMataKuliah.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMataKuliah.Font = New Font("Segoe UI", 10.0F)
        cmbMataKuliah.FormattingEnabled = True
        cmbMataKuliah.Location = New Point(235, 23)
        cmbMataKuliah.Name = "cmbMataKuliah"
        cmbMataKuliah.Size = New Size(420, 31)
        cmbMataKuliah.TabIndex = 1

        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(46, 82, 72)
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 59, 51)
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 105, 93)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(670, 20)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(120, 36)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Segarkan"
        btnRefresh.UseVisualStyleBackColor = False

        ' 
        ' lblLastUpdated
        ' 
        lblLastUpdated.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblLastUpdated.Font = New Font("Segoe UI", 9.0F)
        lblLastUpdated.ForeColor = Color.FromArgb(108, 117, 125)
        lblLastUpdated.Location = New Point(800, 27)
        lblLastUpdated.Name = "lblLastUpdated"
        lblLastUpdated.Size = New Size(309, 23)
        lblLastUpdated.TabIndex = 3
        lblLastUpdated.Text = "Diperbarui: -"
        lblLastUpdated.TextAlign = ContentAlignment.MiddleRight

        ' 
        ' pnlStatistikView
        ' 
        pnlStatistikView.Controls.Add(pnlFeedbackSection)
        pnlStatistikView.Controls.Add(pnlScoreCard)
        pnlStatistikView.Controls.Add(tblMetricCards)
        pnlStatistikView.Dock = DockStyle.Fill
        pnlStatistikView.Location = New Point(32, 164)
        pnlStatistikView.Name = "pnlStatistikView"
        pnlStatistikView.Padding = New Padding(0, 16, 0, 16)
        pnlStatistikView.Size = New Size(1129, 772)
        pnlStatistikView.TabIndex = 2

        ' 
        ' tblMetricCards
        ' 
        tblMetricCards.ColumnCount = 4
        tblMetricCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tblMetricCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tblMetricCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tblMetricCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tblMetricCards.Controls.Add(cardTotal, 0, 0)
        tblMetricCards.Controls.Add(cardSudah, 1, 0)
        tblMetricCards.Controls.Add(cardBelum, 2, 0)
        tblMetricCards.Controls.Add(cardPersen, 3, 0)
        tblMetricCards.Dock = DockStyle.Top
        tblMetricCards.Location = New Point(0, 16)
        tblMetricCards.Name = "tblMetricCards"
        tblMetricCards.RowCount = 1
        tblMetricCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tblMetricCards.Size = New Size(1129, 110)
        tblMetricCards.TabIndex = 0

        ' 
        ' cardTotal
        ' 
        cardTotal.BackColor = Color.White
        cardTotal.Controls.Add(lblTotalTitle)
        cardTotal.Controls.Add(lblTotalMahasiswa)
        cardTotal.Controls.Add(lblTotalSub)
        cardTotal.Dock = DockStyle.Fill
        cardTotal.Location = New Point(0, 0)
        cardTotal.Margin = New Padding(0, 0, 10, 0)
        cardTotal.Name = "cardTotal"
        cardTotal.Padding = New Padding(16, 12, 16, 12)
        cardTotal.Size = New Size(272, 110)
        cardTotal.TabIndex = 0

        ' 
        ' lblTotalTitle
        ' 
        lblTotalTitle.AutoSize = True
        lblTotalTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblTotalTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblTotalTitle.Location = New Point(16, 12)
        lblTotalTitle.Name = "lblTotalTitle"
        lblTotalTitle.Size = New Size(137, 19)
        lblTotalTitle.TabIndex = 0
        lblTotalTitle.Text = "TOTAL MAHASISWA"

        ' 
        ' lblTotalMahasiswa
        ' 
        lblTotalMahasiswa.AutoSize = True
        lblTotalMahasiswa.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTotalMahasiswa.ForeColor = Color.FromArgb(30, 59, 51)
        lblTotalMahasiswa.Location = New Point(14, 34)
        lblTotalMahasiswa.Name = "lblTotalMahasiswa"
        lblTotalMahasiswa.Size = New Size(40, 46)
        lblTotalMahasiswa.TabIndex = 1
        lblTotalMahasiswa.Text = "0"

        ' 
        ' lblTotalSub
        ' 
        lblTotalSub.AutoSize = True
        lblTotalSub.Font = New Font("Segoe UI", 8.0F)
        lblTotalSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblTotalSub.Location = New Point(16, 80)
        lblTotalSub.Name = "lblTotalSub"
        lblTotalSub.Size = New Size(170, 19)
        lblTotalSub.TabIndex = 2
        lblTotalSub.Text = "Target responden terdaftar"

        ' 
        ' cardSudah
        ' 
        cardSudah.BackColor = Color.White
        cardSudah.Controls.Add(lblSudahTitle)
        cardSudah.Controls.Add(lblSudahMengisi)
        cardSudah.Controls.Add(lblSudahSub)
        cardSudah.Dock = DockStyle.Fill
        cardSudah.Location = New Point(282, 0)
        cardSudah.Margin = New Padding(10, 0, 10, 0)
        cardSudah.Name = "cardSudah"
        cardSudah.Padding = New Padding(16, 12, 16, 12)
        cardSudah.Size = New Size(262, 110)
        cardSudah.TabIndex = 1

        ' 
        ' lblSudahTitle
        ' 
        lblSudahTitle.AutoSize = True
        lblSudahTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblSudahTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblSudahTitle.Location = New Point(16, 12)
        lblSudahTitle.Name = "lblSudahTitle"
        lblSudahTitle.Size = New Size(160, 19)
        lblSudahTitle.TabIndex = 0
        lblSudahTitle.Text = "SUDAH MENGISI EDOM"

        ' 
        ' lblSudahMengisi
        ' 
        lblSudahMengisi.AutoSize = True
        lblSudahMengisi.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblSudahMengisi.ForeColor = Color.FromArgb(25, 135, 84)
        lblSudahMengisi.Location = New Point(14, 34)
        lblSudahMengisi.Name = "lblSudahMengisi"
        lblSudahMengisi.Size = New Size(40, 46)
        lblSudahMengisi.TabIndex = 1
        lblSudahMengisi.Text = "0"

        ' 
        ' lblSudahSub
        ' 
        lblSudahSub.AutoSize = True
        lblSudahSub.Font = New Font("Segoe UI", 8.0F)
        lblSudahSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblSudahSub.Location = New Point(16, 80)
        lblSudahSub.Name = "lblSudahSub"
        lblSudahSub.Size = New Size(144, 19)
        lblSudahSub.TabIndex = 2
        lblSudahSub.Text = "Evaluasi telah diterima"

        ' 
        ' cardBelum
        ' 
        cardBelum.BackColor = Color.White
        cardBelum.Controls.Add(lblBelumTitle)
        cardBelum.Controls.Add(lblBelumMengisi)
        cardBelum.Controls.Add(lblBelumSub)
        cardBelum.Dock = DockStyle.Fill
        cardBelum.Location = New Point(564, 0)
        cardBelum.Margin = New Padding(10, 0, 10, 0)
        cardBelum.Name = "cardBelum"
        cardBelum.Padding = New Padding(16, 12, 16, 12)
        cardBelum.Size = New Size(262, 110)
        cardBelum.TabIndex = 2

        ' 
        ' lblBelumTitle
        ' 
        lblBelumTitle.AutoSize = True
        lblBelumTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblBelumTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblBelumTitle.Location = New Point(16, 12)
        lblBelumTitle.Name = "lblBelumTitle"
        lblBelumTitle.Size = New Size(111, 19)
        lblBelumTitle.TabIndex = 0
        lblBelumTitle.Text = "BELUM MENGISI"

        ' 
        ' lblBelumMengisi
        ' 
        lblBelumMengisi.AutoSize = True
        lblBelumMengisi.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblBelumMengisi.ForeColor = Color.FromArgb(176, 42, 55)
        lblBelumMengisi.Location = New Point(14, 34)
        lblBelumMengisi.Name = "lblBelumMengisi"
        lblBelumMengisi.Size = New Size(40, 46)
        lblBelumMengisi.TabIndex = 1
        lblBelumMengisi.Text = "0"

        ' 
        ' lblBelumSub
        ' 
        lblBelumSub.AutoSize = True
        lblBelumSub.Font = New Font("Segoe UI", 8.0F)
        lblBelumSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblBelumSub.Location = New Point(16, 80)
        lblBelumSub.Name = "lblBelumSub"
        lblBelumSub.Size = New Size(183, 19)
        lblBelumSub.TabIndex = 2
        lblBelumSub.Text = "Menunggu respon mahasiswa"

        ' 
        ' cardPersen
        ' 
        cardPersen.BackColor = Color.White
        cardPersen.Controls.Add(lblPersenTitle)
        cardPersen.Controls.Add(lblPersentase)
        cardPersen.Controls.Add(lblPersenSub)
        cardPersen.Dock = DockStyle.Fill
        cardPersen.Location = New Point(846, 0)
        cardPersen.Margin = New Padding(10, 0, 0, 0)
        cardPersen.Name = "cardPersen"
        cardPersen.Padding = New Padding(16, 12, 16, 12)
        cardPersen.Size = New Size(283, 110)
        cardPersen.TabIndex = 3

        ' 
        ' lblPersenTitle
        ' 
        lblPersenTitle.AutoSize = True
        lblPersenTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblPersenTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblPersenTitle.Location = New Point(16, 12)
        lblPersenTitle.Name = "lblPersenTitle"
        lblPersenTitle.Size = New Size(157, 19)
        lblPersenTitle.TabIndex = 0
        lblPersenTitle.Text = "TINGKAT PARTISIPASI"

        ' 
        ' lblPersentase
        ' 
        lblPersentase.AutoSize = True
        lblPersentase.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblPersentase.ForeColor = Color.FromArgb(46, 82, 72)
        lblPersentase.Location = New Point(14, 34)
        lblPersentase.Name = "lblPersentase"
        lblPersentase.Size = New Size(89, 46)
        lblPersentase.TabIndex = 1
        lblPersentase.Text = "0.0%"

        ' 
        ' lblPersenSub
        ' 
        lblPersenSub.AutoSize = True
        lblPersenSub.Font = New Font("Segoe UI", 8.0F)
        lblPersenSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblPersenSub.Location = New Point(16, 80)
        lblPersenSub.Name = "lblPersenSub"
        lblPersenSub.Size = New Size(160, 19)
        lblPersenSub.TabIndex = 2
        lblPersenSub.Text = "Target partisipasi: >=75%"

        ' 
        ' pnlScoreCard
        ' 
        pnlScoreCard.BackColor = Color.White
        pnlScoreCard.Controls.Add(lblScoreCardTitle)
        pnlScoreCard.Controls.Add(lblRataRataSkor)
        pnlScoreCard.Controls.Add(lblScoreScale)
        pnlScoreCard.Controls.Add(lblPredikatBadge)
        pnlScoreCard.Controls.Add(pnlAspects)
        pnlScoreCard.Dock = DockStyle.Top
        pnlScoreCard.Location = New Point(0, 126)
        pnlScoreCard.Margin = New Padding(0, 16, 0, 16)
        pnlScoreCard.Name = "pnlScoreCard"
        pnlScoreCard.Padding = New Padding(20, 16, 20, 16)
        pnlScoreCard.Size = New Size(1129, 140)
        pnlScoreCard.TabIndex = 1

        ' 
        ' lblScoreCardTitle
        ' 
        lblScoreCardTitle.AutoSize = True
        lblScoreCardTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblScoreCardTitle.ForeColor = Color.FromArgb(30, 59, 51)
        lblScoreCardTitle.Location = New Point(20, 16)
        lblScoreCardTitle.Name = "lblScoreCardTitle"
        lblScoreCardTitle.Size = New Size(328, 25)
        lblScoreCardTitle.TabIndex = 0
        lblScoreCardTitle.Text = "Indeks Kinerja Dosen (Rata-rata Skor)"

        ' 
        ' lblRataRataSkor
        ' 
        lblRataRataSkor.AutoSize = True
        lblRataRataSkor.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblRataRataSkor.ForeColor = Color.FromArgb(30, 59, 51)
        lblRataRataSkor.Location = New Point(16, 44)
        lblRataRataSkor.Name = "lblRataRataSkor"
        lblRataRataSkor.Size = New Size(118, 62)
        lblRataRataSkor.TabIndex = 1
        lblRataRataSkor.Text = "0.00"

        ' 
        ' lblScoreScale
        ' 
        lblScoreScale.AutoSize = True
        lblScoreScale.Font = New Font("Segoe UI", 10.0F)
        lblScoreScale.ForeColor = Color.FromArgb(108, 117, 125)
        lblScoreScale.Location = New Point(138, 74)
        lblScoreScale.Name = "lblScoreScale"
        lblScoreScale.Size = New Size(54, 23)
        lblScoreScale.TabIndex = 2
        lblScoreScale.Text = "/ 5.00"

        ' 
        ' lblPredikatBadge
        ' 
        lblPredikatBadge.BackColor = Color.FromArgb(236, 241, 234)
        lblPredikatBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblPredikatBadge.ForeColor = Color.FromArgb(30, 59, 51)
        lblPredikatBadge.Location = New Point(20, 106)
        lblPredikatBadge.Name = "lblPredikatBadge"
        lblPredikatBadge.Size = New Size(150, 24)
        lblPredikatBadge.TabIndex = 3
        lblPredikatBadge.Text = "Belum Ada Nilai"
        lblPredikatBadge.TextAlign = ContentAlignment.MiddleCenter

        ' 
        ' pnlAspects
        ' 
        pnlAspects.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAspects.ColumnCount = 4
        pnlAspects.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlAspects.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlAspects.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlAspects.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlAspects.Controls.Add(lblPedagogikTitle, 0, 0)
        pnlAspects.Controls.Add(lblPedagogikVal, 0, 1)
        pnlAspects.Controls.Add(lblProfesionalTitle, 1, 0)
        pnlAspects.Controls.Add(lblProfesionalVal, 1, 1)
        pnlAspects.Controls.Add(lblKepribadianTitle, 2, 0)
        pnlAspects.Controls.Add(lblKepribadianVal, 2, 1)
        pnlAspects.Controls.Add(lblSosialTitle, 3, 0)
        pnlAspects.Controls.Add(lblSosialVal, 3, 1)
        pnlAspects.Location = New Point(270, 20)
        pnlAspects.Name = "pnlAspects"
        pnlAspects.RowCount = 2
        pnlAspects.RowStyles.Add(New RowStyle(SizeType.Absolute, 32.0F))
        pnlAspects.RowStyles.Add(New RowStyle(SizeType.Absolute, 48.0F))
        pnlAspects.Size = New Size(839, 100)
        pnlAspects.TabIndex = 4

        ' 
        ' lblPedagogikTitle
        ' 
        lblPedagogikTitle.AutoSize = True
        lblPedagogikTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblPedagogikTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblPedagogikTitle.Location = New Point(3, 0)
        lblPedagogikTitle.Name = "lblPedagogikTitle"
        lblPedagogikTitle.Size = New Size(130, 20)
        lblPedagogikTitle.TabIndex = 0
        lblPedagogikTitle.Text = "Kompetensi Pedagogik"

        ' 
        ' lblPedagogikVal
        ' 
        lblPedagogikVal.AutoSize = True
        lblPedagogikVal.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblPedagogikVal.ForeColor = Color.FromArgb(30, 59, 51)
        lblPedagogikVal.Location = New Point(3, 32)
        lblPedagogikVal.Name = "lblPedagogikVal"
        lblPedagogikVal.Size = New Size(72, 37)
        lblPedagogikVal.TabIndex = 1
        lblPedagogikVal.Text = "0.00"

        ' 
        ' lblProfesionalTitle
        ' 
        lblProfesionalTitle.AutoSize = True
        lblProfesionalTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblProfesionalTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblProfesionalTitle.Location = New Point(212, 0)
        lblProfesionalTitle.Name = "lblProfesionalTitle"
        lblProfesionalTitle.Size = New Size(144, 20)
        lblProfesionalTitle.TabIndex = 2
        lblProfesionalTitle.Text = "Kompetensi Profesional"

        ' 
        ' lblProfesionalVal
        ' 
        lblProfesionalVal.AutoSize = True
        lblProfesionalVal.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblProfesionalVal.ForeColor = Color.FromArgb(30, 59, 51)
        lblProfesionalVal.Location = New Point(212, 32)
        lblProfesionalVal.Name = "lblProfesionalVal"
        lblProfesionalVal.Size = New Size(72, 37)
        lblProfesionalVal.TabIndex = 3
        lblProfesionalVal.Text = "0.00"

        ' 
        ' lblKepribadianTitle
        ' 
        lblKepribadianTitle.AutoSize = True
        lblKepribadianTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblKepribadianTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblKepribadianTitle.Location = New Point(421, 0)
        lblKepribadianTitle.Name = "lblKepribadianTitle"
        lblKepribadianTitle.Size = New Size(150, 20)
        lblKepribadianTitle.TabIndex = 4
        lblKepribadianTitle.Text = "Kompetensi Kepribadian"

        ' 
        ' lblKepribadianVal
        ' 
        lblKepribadianVal.AutoSize = True
        lblKepribadianVal.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblKepribadianVal.ForeColor = Color.FromArgb(30, 59, 51)
        lblKepribadianVal.Location = New Point(421, 32)
        lblKepribadianVal.Name = "lblKepribadianVal"
        lblKepribadianVal.Size = New Size(72, 37)
        lblKepribadianVal.TabIndex = 5
        lblKepribadianVal.Text = "0.00"

        ' 
        ' lblSosialTitle
        ' 
        lblSosialTitle.AutoSize = True
        lblSosialTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblSosialTitle.ForeColor = Color.FromArgb(108, 117, 125)
        lblSosialTitle.Location = New Point(630, 0)
        lblSosialTitle.Name = "lblSosialTitle"
        lblSosialTitle.Size = New Size(107, 20)
        lblSosialTitle.TabIndex = 6
        lblSosialTitle.Text = "Kompetensi Sosial"

        ' 
        ' lblSosialVal
        ' 
        lblSosialVal.AutoSize = True
        lblSosialVal.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblSosialVal.ForeColor = Color.FromArgb(30, 59, 51)
        lblSosialVal.Location = New Point(630, 32)
        lblSosialVal.Name = "lblSosialVal"
        lblSosialVal.Size = New Size(72, 37)
        lblSosialVal.TabIndex = 7
        lblSosialVal.Text = "0.00"

        ' 
        ' pnlFeedbackSection
        ' 
        pnlFeedbackSection.BackColor = Color.White
        pnlFeedbackSection.Controls.Add(btnRincianButir)
        pnlFeedbackSection.Controls.Add(dgvFeedback)
        pnlFeedbackSection.Controls.Add(lblFeedbackSub)
        pnlFeedbackSection.Controls.Add(lblFeedbackTitle)
        pnlFeedbackSection.Dock = DockStyle.Fill
        pnlFeedbackSection.Location = New Point(0, 266)
        pnlFeedbackSection.Margin = New Padding(0, 16, 0, 0)
        pnlFeedbackSection.Name = "pnlFeedbackSection"
        pnlFeedbackSection.Padding = New Padding(20, 16, 20, 16)
        pnlFeedbackSection.Size = New Size(1129, 490)
        pnlFeedbackSection.TabIndex = 2

        ' 
        ' lblFeedbackTitle
        ' 
        lblFeedbackTitle.AutoSize = True
        lblFeedbackTitle.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblFeedbackTitle.ForeColor = Color.FromArgb(30, 59, 51)
        lblFeedbackTitle.Location = New Point(20, 16)
        lblFeedbackTitle.Name = "lblFeedbackTitle"
        lblFeedbackTitle.Size = New Size(403, 25)
        lblFeedbackTitle.TabIndex = 0
        lblFeedbackTitle.Text = "Rincian Respon Pengisian & Masukan Mahasiswa"

        '
        ' btnRincianButir
        '
        btnRincianButir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRincianButir.BackColor = Color.FromArgb(46, 82, 72)
        btnRincianButir.Cursor = Cursors.Hand
        btnRincianButir.FlatAppearance.BorderSize = 0
        btnRincianButir.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 59, 51)
        btnRincianButir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 105, 93)
        btnRincianButir.FlatStyle = FlatStyle.Flat
        btnRincianButir.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnRincianButir.ForeColor = Color.White
        btnRincianButir.Location = New Point(909, 22)
        btnRincianButir.Name = "btnRincianButir"
        btnRincianButir.Size = New Size(200, 38)
        btnRincianButir.TabIndex = 3
        btnRincianButir.Text = "Rincian Nilai per Butir"
        btnRincianButir.UseVisualStyleBackColor = False

        ' 
        ' lblFeedbackSub
        ' 
        lblFeedbackSub.AutoSize = True
        lblFeedbackSub.Font = New Font("Segoe UI", 9.0F)
        lblFeedbackSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblFeedbackSub.Location = New Point(22, 44)
        lblFeedbackSub.Name = "lblFeedbackSub"
        lblFeedbackSub.Size = New Size(543, 20)
        lblFeedbackSub.TabIndex = 1
        lblFeedbackSub.Text = "Daftar hasil pengisian evaluasi mahasiswa (skor per responden serta saran konstruktif)"

        ' 
        ' dgvFeedback
        ' 
        dgvFeedback.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFeedback.Columns.AddRange(New DataGridViewColumn() {colFNo, colFMataKuliah, colFMahasiswa, colFWaktu, colFSkor, colFSaran})
        dgvFeedback.Location = New Point(20, 74)
        dgvFeedback.Name = "dgvFeedback"
        dgvFeedback.RowHeadersWidth = 51
        dgvFeedback.Size = New Size(1089, 396)
        dgvFeedback.TabIndex = 2

        ' 
        ' colFNo
        ' 
        colFNo.FillWeight = 35.0F
        colFNo.HeaderText = "No"
        colFNo.MinimumWidth = 40
        colFNo.Name = "colFNo"
        colFNo.ReadOnly = True

        ' 
        ' colFMataKuliah
        ' 
        colFMataKuliah.FillWeight = 110.0F
        colFMataKuliah.HeaderText = "Mata Kuliah"
        colFMataKuliah.MinimumWidth = 140
        colFMataKuliah.Name = "colFMataKuliah"
        colFMataKuliah.ReadOnly = True

        ' 
        ' colFMahasiswa
        ' 
        colFMahasiswa.FillWeight = 85.0F
        colFMahasiswa.HeaderText = "Mahasiswa (NIM)"
        colFMahasiswa.MinimumWidth = 100
        colFMahasiswa.Name = "colFMahasiswa"
        colFMahasiswa.ReadOnly = True

        ' 
        ' colFWaktu
        ' 
        colFWaktu.FillWeight = 95.0F
        colFWaktu.HeaderText = "Waktu Pengisian"
        colFWaktu.MinimumWidth = 110
        colFWaktu.Name = "colFWaktu"
        colFWaktu.ReadOnly = True

        ' 
        ' colFSkor
        ' 
        colFSkor.FillWeight = 80.0F
        colFSkor.HeaderText = "Rata-rata Skor"
        colFSkor.MinimumWidth = 90
        colFSkor.Name = "colFSkor"
        colFSkor.ReadOnly = True

        ' 
        ' colFSaran
        ' 
        colFSaran.FillWeight = 160.0F
        colFSaran.HeaderText = "Kritik & Saran / Masukan Mahasiswa"
        colFSaran.MinimumWidth = 180
        colFSaran.Name = "colFSaran"
        colFSaran.ReadOnly = True

        ' 
        ' pnlMataKuliahView
        ' 
        pnlMataKuliahView.Controls.Add(dgvMataKuliahDiajar)
        pnlMataKuliahView.Controls.Add(pnlMkHeader)
        pnlMataKuliahView.Dock = DockStyle.Fill
        pnlMataKuliahView.Location = New Point(32, 164)
        pnlMataKuliahView.Name = "pnlMataKuliahView"
        pnlMataKuliahView.Padding = New Padding(0, 16, 0, 16)
        pnlMataKuliahView.Size = New Size(1129, 772)
        pnlMataKuliahView.TabIndex = 3
        pnlMataKuliahView.Visible = False

        ' 
        ' pnlMkHeader
        ' 
        pnlMkHeader.BackColor = Color.White
        pnlMkHeader.Controls.Add(lblMkViewTitle)
        pnlMkHeader.Controls.Add(lblMkViewSub)
        pnlMkHeader.Dock = DockStyle.Top
        pnlMkHeader.Location = New Point(0, 16)
        pnlMkHeader.Name = "pnlMkHeader"
        pnlMkHeader.Padding = New Padding(20, 16, 20, 16)
        pnlMkHeader.Size = New Size(1129, 80)
        pnlMkHeader.TabIndex = 0

        ' 
        ' lblMkViewTitle
        ' 
        lblMkViewTitle.AutoSize = True
        lblMkViewTitle.Font = New Font("Segoe UI Semibold", 11.5F, FontStyle.Bold)
        lblMkViewTitle.ForeColor = Color.FromArgb(30, 59, 51)
        lblMkViewTitle.Location = New Point(20, 16)
        lblMkViewTitle.Name = "lblMkViewTitle"
        lblMkViewTitle.Size = New Size(403, 28)
        lblMkViewTitle.TabIndex = 0
        lblMkViewTitle.Text = "Daftar Mata Kuliah yang Anda Ajar Semester Ini"

        ' 
        ' lblMkViewSub
        ' 
        lblMkViewSub.AutoSize = True
        lblMkViewSub.Font = New Font("Segoe UI", 9.0F)
        lblMkViewSub.ForeColor = Color.FromArgb(108, 117, 125)
        lblMkViewSub.Location = New Point(22, 46)
        lblMkViewSub.Name = "lblMkViewSub"
        lblMkViewSub.Size = New Size(628, 20)
        lblMkViewSub.TabIndex = 1
        lblMkViewSub.Text = "Pilih baris atau gunakan dropdown di atas untuk melihat detail rincian evaluasi masing-masing kelas"

        ' 
        ' dgvMataKuliahDiajar
        ' 
        dgvMataKuliahDiajar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMataKuliahDiajar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMataKuliahDiajar.Columns.AddRange(New DataGridViewColumn() {colMkNo, colMkNama, colMkRuang, colMkMahasiswa, colMkSudah, colMkBelum, colMkPersen, colMkSkor, colMkStatus})
        dgvMataKuliahDiajar.Location = New Point(0, 110)
        dgvMataKuliahDiajar.Name = "dgvMataKuliahDiajar"
        dgvMataKuliahDiajar.RowHeadersWidth = 51
        dgvMataKuliahDiajar.Size = New Size(1129, 646)
        dgvMataKuliahDiajar.TabIndex = 1

        ' 
        ' colMkNo
        ' 
        colMkNo.FillWeight = 40.0F
        colMkNo.HeaderText = "No"
        colMkNo.MinimumWidth = 40
        colMkNo.Name = "colMkNo"
        colMkNo.ReadOnly = True

        ' 
        ' colMkNama
        ' 
        colMkNama.FillWeight = 160.0F
        colMkNama.HeaderText = "Nama Mata Kuliah"
        colMkNama.MinimumWidth = 150
        colMkNama.Name = "colMkNama"
        colMkNama.ReadOnly = True

        ' 
        ' colMkRuang
        ' 
        colMkRuang.FillWeight = 70.0F
        colMkRuang.HeaderText = "Ruang"
        colMkRuang.MinimumWidth = 70
        colMkRuang.Name = "colMkRuang"
        colMkRuang.ReadOnly = True

        ' 
        ' colMkMahasiswa
        ' 
        colMkMahasiswa.FillWeight = 80.0F
        colMkMahasiswa.HeaderText = "Mahasiswa"
        colMkMahasiswa.MinimumWidth = 80
        colMkMahasiswa.Name = "colMkMahasiswa"
        colMkMahasiswa.ReadOnly = True

        ' 
        ' colMkSudah
        ' 
        colMkSudah.FillWeight = 85.0F
        colMkSudah.HeaderText = "Sudah Mengisi"
        colMkSudah.MinimumWidth = 85
        colMkSudah.Name = "colMkSudah"
        colMkSudah.ReadOnly = True

        ' 
        ' colMkBelum
        ' 
        colMkBelum.FillWeight = 85.0F
        colMkBelum.HeaderText = "Belum Mengisi"
        colMkBelum.MinimumWidth = 85
        colMkBelum.Name = "colMkBelum"
        colMkBelum.ReadOnly = True

        ' 
        ' colMkPersen
        ' 
        colMkPersen.FillWeight = 85.0F
        colMkPersen.HeaderText = "Partisipasi (%)"
        colMkPersen.MinimumWidth = 85
        colMkPersen.Name = "colMkPersen"
        colMkPersen.ReadOnly = True

        ' 
        ' colMkSkor
        ' 
        colMkSkor.FillWeight = 85.0F
        colMkSkor.HeaderText = "Rata-rata Skor"
        colMkSkor.MinimumWidth = 85
        colMkSkor.Name = "colMkSkor"
        colMkSkor.ReadOnly = True

        ' 
        ' colMkStatus
        ' 
        colMkStatus.FillWeight = 120.0F
        colMkStatus.HeaderText = "Status Evaluasi"
        colMkStatus.MinimumWidth = 110
        colMkStatus.Name = "colMkStatus"
        colMkStatus.ReadOnly = True

        ' 
        ' pnlState
        ' 
        pnlState.BackColor = Color.White
        pnlState.Controls.Add(btnRetry)
        pnlState.Controls.Add(lblStateMessage)
        pnlState.Dock = DockStyle.Fill
        pnlState.Location = New Point(32, 164)
        pnlState.Name = "pnlState"
        pnlState.Padding = New Padding(40)
        pnlState.Size = New Size(1129, 772)
        pnlState.TabIndex = 4
        pnlState.Visible = False

        ' 
        ' lblStateMessage
        ' 
        lblStateMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStateMessage.Font = New Font("Segoe UI", 11.0F)
        lblStateMessage.ForeColor = Color.FromArgb(73, 80, 87)
        lblStateMessage.Location = New Point(40, 120)
        lblStateMessage.Name = "lblStateMessage"
        lblStateMessage.Size = New Size(1049, 80)
        lblStateMessage.TabIndex = 0
        lblStateMessage.Text = "Memuat data statistik..."
        lblStateMessage.TextAlign = ContentAlignment.MiddleCenter

        ' 
        ' btnRetry
        ' 
        btnRetry.Anchor = AnchorStyles.Top
        btnRetry.BackColor = Color.FromArgb(46, 82, 72)
        btnRetry.Cursor = Cursors.Hand
        btnRetry.FlatAppearance.BorderSize = 0
        btnRetry.FlatStyle = FlatStyle.Flat
        btnRetry.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnRetry.ForeColor = Color.White
        btnRetry.Location = New Point(489, 220)
        btnRetry.Name = "btnRetry"
        btnRetry.Size = New Size(150, 44)
        btnRetry.TabIndex = 1
        btnRetry.Text = "Coba Lagi"
        btnRetry.UseVisualStyleBackColor = False
        btnRetry.Visible = False

        ' 
        ' dashboard_dosen
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(250, 248, 243)
        ClientSize = New Size(1467, 960)
        Controls.Add(pnlMainContent)
        Controls.Add(sidebar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1100, 750)
        Name = "dashboard_dosen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIAKAD - Dashboard Dosen"

        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        pnlMainContent.ResumeLayout(False)
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlFilterCard.ResumeLayout(False)
        pnlFilterCard.PerformLayout()
        pnlStatistikView.ResumeLayout(False)
        tblMetricCards.ResumeLayout(False)
        cardTotal.ResumeLayout(False)
        cardTotal.PerformLayout()
        cardSudah.ResumeLayout(False)
        cardSudah.PerformLayout()
        cardBelum.ResumeLayout(False)
        cardBelum.PerformLayout()
        cardPersen.ResumeLayout(False)
        cardPersen.PerformLayout()
        pnlScoreCard.ResumeLayout(False)
        pnlScoreCard.PerformLayout()
        pnlAspects.ResumeLayout(False)
        pnlAspects.PerformLayout()
        pnlFeedbackSection.ResumeLayout(False)
        pnlFeedbackSection.PerformLayout()
        CType(dgvFeedback, ComponentModel.ISupportInitialize).EndInit()
        pnlMataKuliahView.ResumeLayout(False)
        pnlMkHeader.ResumeLayout(False)
        pnlMkHeader.PerformLayout()
        CType(dgvMataKuliahDiajar, ComponentModel.ISupportInitialize).EndInit()
        pnlState.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

End Class
