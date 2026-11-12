<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        lblRole = New Label()
        btnKelola = New Button()
        btnLogout = New Button()
        btnProgres = New Button()
        lblBrandSubtitle = New Label()
        lblBrand = New Label()
        pnlProgres = New Panel()
        pnlProgresState = New Panel()
        btnProgresRetry = New Button()
        lblProgresState = New Label()
        dgvProgres = New DataGridView()
        colPMataKuliah = New DataGridViewTextBoxColumn()
        colPDosen = New DataGridViewTextBoxColumn()
        colPSudah = New DataGridViewTextBoxColumn()
        colPBelum = New DataGridViewTextBoxColumn()
        colPPersen = New DataGridViewTextBoxColumn()
        lblProgresHint = New Label()
        pnlProgresHeader = New Panel()
        lblLastUpdated = New Label()
        btnRefresh = New Button()
        lblProgresSummary = New Label()
        lblProgresTitle = New Label()
        pnlKelola = New Panel()
        tblKelola = New TableLayoutPanel()
        pnlDosen = New Panel()
        dgvDosen = New DataGridView()
        colDNama = New DataGridViewTextBoxColumn()
        colDNidn = New DataGridViewTextBoxColumn()
        pnlDosenForm = New Panel()
        btnDosenHapus = New Button()
        btnDosenSimpan = New Button()
        btnDosenTambah = New Button()
        lblDosenError = New Label()
        txtDosenNidn = New TextBox()
        lblDosenNidn = New Label()
        txtDosenNama = New TextBox()
        lblDosenNama = New Label()
        lblDosenTitle = New Label()
        pnlMk = New Panel()
        dgvMk = New DataGridView()
        colMNama = New DataGridViewTextBoxColumn()
        colMDosen = New DataGridViewTextBoxColumn()
        colMRuang = New DataGridViewTextBoxColumn()
        pnlMkForm = New Panel()
        btnMkHapus = New Button()
        btnMkSimpan = New Button()
        btnMkTambah = New Button()
        lblMkError = New Label()
        cmbMkDosen = New ComboBox()
        lblMkDosen = New Label()
        txtMkRuang = New TextBox()
        lblMkRuang = New Label()
        txtMkNama = New TextBox()
        lblMkNama = New Label()
        lblMkTitle = New Label()
        lblKelolaError = New Label()
        lblKelolaTitle = New Label()
        sidebar.SuspendLayout()
        pnlProgres.SuspendLayout()
        pnlProgresState.SuspendLayout()
        CType(dgvProgres, ComponentModel.ISupportInitialize).BeginInit()
        pnlProgresHeader.SuspendLayout()
        pnlKelola.SuspendLayout()
        tblKelola.SuspendLayout()
        pnlDosen.SuspendLayout()
        CType(dgvDosen, ComponentModel.ISupportInitialize).BeginInit()
        pnlDosenForm.SuspendLayout()
        pnlMk.SuspendLayout()
        CType(dgvMk, ComponentModel.ISupportInitialize).BeginInit()
        pnlMkForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' sidebar
        ' 
        sidebar.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        sidebar.BorderStyle = BorderStyle.Fixed3D
        sidebar.Controls.Add(lblRole)
        sidebar.Controls.Add(btnKelola)
        sidebar.Controls.Add(btnLogout)
        sidebar.Controls.Add(btnProgres)
        sidebar.Controls.Add(lblBrandSubtitle)
        sidebar.Controls.Add(lblBrand)
        sidebar.Dock = DockStyle.Left
        sidebar.Location = New Point(0, 0)
        sidebar.Margin = New Padding(3, 4, 3, 4)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(274, 960)
        sidebar.TabIndex = 0
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblRole.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(206))
        lblRole.Location = New Point(34, 124)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(48, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "Admin"
        ' 
        ' btnKelola
        ' 
        btnKelola.BackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnKelola.Cursor = Cursors.Hand
        btnKelola.FlatAppearance.BorderSize = 0
        btnKelola.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnKelola.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        btnKelola.FlatStyle = FlatStyle.Flat
        btnKelola.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnKelola.ForeColor = Color.White
        btnKelola.Location = New Point(-2, 255)
        btnKelola.Margin = New Padding(3, 4, 3, 4)
        btnKelola.Name = "btnKelola"
        btnKelola.Size = New Size(274, 56)
        btnKelola.TabIndex = 4
        btnKelola.Text = "    Dosen && Mata Kuliah"
        btnKelola.TextAlign = ContentAlignment.MiddleLeft
        btnKelola.UseVisualStyleBackColor = False
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
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProgres
        ' 
        btnProgres.BackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnProgres.Cursor = Cursors.Hand
        btnProgres.FlatAppearance.BorderSize = 0
        btnProgres.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnProgres.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(88), CByte(118), CByte(84))
        btnProgres.FlatStyle = FlatStyle.Flat
        btnProgres.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnProgres.ForeColor = Color.White
        btnProgres.Location = New Point(-2, 187)
        btnProgres.Margin = New Padding(3, 4, 3, 4)
        btnProgres.Name = "btnProgres"
        btnProgres.Size = New Size(274, 56)
        btnProgres.TabIndex = 3
        btnProgres.Text = "    Progres EDOM"
        btnProgres.TextAlign = ContentAlignment.MiddleLeft
        btnProgres.UseVisualStyleBackColor = False
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
        ' pnlProgres
        ' 
        pnlProgres.AutoScroll = True
        pnlProgres.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlProgres.Controls.Add(pnlProgresState)
        pnlProgres.Controls.Add(dgvProgres)
        pnlProgres.Controls.Add(lblProgresHint)
        pnlProgres.Controls.Add(pnlProgresHeader)
        pnlProgres.Dock = DockStyle.Fill
        pnlProgres.Location = New Point(274, 0)
        pnlProgres.Name = "pnlProgres"
        pnlProgres.Padding = New Padding(40, 33, 40, 33)
        pnlProgres.Size = New Size(1193, 960)
        pnlProgres.TabIndex = 1
        ' 
        ' pnlProgresState
        ' 
        pnlProgresState.BackColor = Color.White
        pnlProgresState.Controls.Add(btnProgresRetry)
        pnlProgresState.Controls.Add(lblProgresState)
        pnlProgresState.Dock = DockStyle.Top
        pnlProgresState.Location = New Point(40, 619)
        pnlProgresState.Name = "pnlProgresState"
        pnlProgresState.Size = New Size(1113, 124)
        pnlProgresState.TabIndex = 3
        ' 
        ' btnProgresRetry
        ' 
        btnProgresRetry.BackColor = Color.White
        btnProgresRetry.Cursor = Cursors.Hand
        btnProgresRetry.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnProgresRetry.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        btnProgresRetry.FlatStyle = FlatStyle.Flat
        btnProgresRetry.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnProgresRetry.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnProgresRetry.Location = New Point(24, 70)
        btnProgresRetry.Name = "btnProgresRetry"
        btnProgresRetry.Size = New Size(140, 40)
        btnProgresRetry.TabIndex = 1
        btnProgresRetry.Text = "Coba lagi"
        btnProgresRetry.UseVisualStyleBackColor = False
        btnProgresRetry.Visible = False
        ' 
        ' lblProgresState
        ' 
        lblProgresState.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProgresState.Font = New Font("Segoe UI", 10.0F)
        lblProgresState.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblProgresState.Location = New Point(24, 20)
        lblProgresState.Name = "lblProgresState"
        lblProgresState.Size = New Size(1065, 46)
        lblProgresState.TabIndex = 0
        lblProgresState.Text = "Memuat progres EDOM..."
        ' 
        ' dgvProgres
        ' 
        dgvProgres.Columns.AddRange(New DataGridViewColumn() {colPMataKuliah, colPDosen, colPSudah, colPBelum, colPPersen})
        dgvProgres.Dock = DockStyle.Top
        dgvProgres.Location = New Point(40, 179)
        dgvProgres.Name = "dgvProgres"
        dgvProgres.RowHeadersWidth = 51
        dgvProgres.Size = New Size(1113, 440)
        dgvProgres.TabIndex = 2
        dgvProgres.Visible = False
        ' 
        ' colPMataKuliah
        ' 
        colPMataKuliah.FillWeight = 30.0F
        colPMataKuliah.HeaderText = "Mata kuliah"
        colPMataKuliah.MinimumWidth = 6
        colPMataKuliah.Name = "colPMataKuliah"
        colPMataKuliah.ReadOnly = True
        ' 
        ' colPDosen
        ' 
        colPDosen.FillWeight = 28.0F
        colPDosen.HeaderText = "Dosen pengampu"
        colPDosen.MinimumWidth = 6
        colPDosen.Name = "colPDosen"
        colPDosen.ReadOnly = True
        ' 
        ' colPSudah
        ' 
        colPSudah.FillWeight = 14.0F
        colPSudah.HeaderText = "Sudah mengisi"
        colPSudah.MinimumWidth = 6
        colPSudah.Name = "colPSudah"
        colPSudah.ReadOnly = True
        ' 
        ' colPBelum
        ' 
        colPBelum.FillWeight = 14.0F
        colPBelum.HeaderText = "Belum mengisi"
        colPBelum.MinimumWidth = 6
        colPBelum.Name = "colPBelum"
        colPBelum.ReadOnly = True
        ' 
        ' colPPersen
        ' 
        colPPersen.FillWeight = 14.0F
        colPPersen.HeaderText = "Persentase"
        colPPersen.MinimumWidth = 6
        colPPersen.Name = "colPPersen"
        colPPersen.ReadOnly = True
        ' 
        ' lblProgresHint
        ' 
        lblProgresHint.Dock = DockStyle.Top
        lblProgresHint.Font = New Font("Segoe UI", 9.5F)
        lblProgresHint.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblProgresHint.Location = New Point(40, 143)
        lblProgresHint.Name = "lblProgresHint"
        lblProgresHint.Size = New Size(1113, 36)
        lblProgresHint.TabIndex = 1
        lblProgresHint.Text = "Diurutkan dari pengisian paling sedikit, supaya mata kuliah yang tertinggal terlihat lebih dulu."
        ' 
        ' pnlProgresHeader
        ' 
        pnlProgresHeader.Controls.Add(lblLastUpdated)
        pnlProgresHeader.Controls.Add(btnRefresh)
        pnlProgresHeader.Controls.Add(lblProgresSummary)
        pnlProgresHeader.Controls.Add(lblProgresTitle)
        pnlProgresHeader.Dock = DockStyle.Top
        pnlProgresHeader.Location = New Point(40, 33)
        pnlProgresHeader.Name = "pnlProgresHeader"
        pnlProgresHeader.Size = New Size(1113, 110)
        pnlProgresHeader.TabIndex = 0
        ' 
        ' lblLastUpdated
        ' 
        lblLastUpdated.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblLastUpdated.Font = New Font("Segoe UI", 9.0F)
        lblLastUpdated.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblLastUpdated.Location = New Point(903, 58)
        lblLastUpdated.Name = "lblLastUpdated"
        lblLastUpdated.Size = New Size(210, 22)
        lblLastUpdated.TabIndex = 3
        lblLastUpdated.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.White
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnRefresh.Location = New Point(963, 8)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(150, 44)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Muat ulang"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblProgresSummary
        ' 
        lblProgresSummary.AutoSize = True
        lblProgresSummary.Font = New Font("Segoe UI", 11.0F)
        lblProgresSummary.ForeColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        lblProgresSummary.Location = New Point(2, 56)
        lblProgresSummary.Name = "lblProgresSummary"
        lblProgresSummary.Size = New Size(125, 25)
        lblProgresSummary.TabIndex = 1
        lblProgresSummary.Text = "Memuat data..."
        ' 
        ' lblProgresTitle
        ' 
        lblProgresTitle.AutoSize = True
        lblProgresTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblProgresTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblProgresTitle.Location = New Point(0, 6)
        lblProgresTitle.Name = "lblProgresTitle"
        lblProgresTitle.Size = New Size(228, 41)
        lblProgresTitle.TabIndex = 0
        lblProgresTitle.Text = "Progres EDOM"
        ' 
        ' pnlKelola
        ' 
        pnlKelola.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlKelola.Controls.Add(tblKelola)
        pnlKelola.Controls.Add(lblKelolaError)
        pnlKelola.Controls.Add(lblKelolaTitle)
        pnlKelola.Dock = DockStyle.Fill
        pnlKelola.Location = New Point(274, 0)
        pnlKelola.Name = "pnlKelola"
        pnlKelola.Padding = New Padding(40, 33, 40, 33)
        pnlKelola.Size = New Size(1193, 960)
        pnlKelola.TabIndex = 2
        pnlKelola.Visible = False
        ' 
        ' tblKelola
        ' 
        tblKelola.ColumnCount = 2
        tblKelola.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        tblKelola.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.0F))
        tblKelola.Controls.Add(pnlDosen, 0, 0)
        tblKelola.Controls.Add(pnlMk, 1, 0)
        tblKelola.Dock = DockStyle.Fill
        tblKelola.Location = New Point(40, 121)
        tblKelola.Name = "tblKelola"
        tblKelola.RowCount = 1
        tblKelola.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tblKelola.Size = New Size(1113, 806)
        tblKelola.TabIndex = 2
        ' 
        ' pnlDosen
        ' 
        pnlDosen.BackColor = Color.White
        pnlDosen.Controls.Add(dgvDosen)
        pnlDosen.Controls.Add(pnlDosenForm)
        pnlDosen.Controls.Add(lblDosenTitle)
        pnlDosen.Dock = DockStyle.Fill
        pnlDosen.Location = New Point(0, 0)
        pnlDosen.Margin = New Padding(0, 0, 12, 0)
        pnlDosen.Name = "pnlDosen"
        pnlDosen.Padding = New Padding(20)
        pnlDosen.Size = New Size(488, 806)
        pnlDosen.TabIndex = 0
        ' 
        ' dgvDosen
        ' 
        dgvDosen.Columns.AddRange(New DataGridViewColumn() {colDNama, colDNidn})
        dgvDosen.Dock = DockStyle.Fill
        dgvDosen.Location = New Point(20, 274)
        dgvDosen.Name = "dgvDosen"
        dgvDosen.RowHeadersWidth = 51
        dgvDosen.Size = New Size(448, 512)
        dgvDosen.TabIndex = 2
        ' 
        ' colDNama
        ' 
        colDNama.FillWeight = 65.0F
        colDNama.HeaderText = "Nama dosen"
        colDNama.MinimumWidth = 6
        colDNama.Name = "colDNama"
        colDNama.ReadOnly = True
        ' 
        ' colDNidn
        ' 
        colDNidn.FillWeight = 35.0F
        colDNidn.HeaderText = "NIDN"
        colDNidn.MinimumWidth = 6
        colDNidn.Name = "colDNidn"
        colDNidn.ReadOnly = True
        ' 
        ' pnlDosenForm
        ' 
        pnlDosenForm.Controls.Add(btnDosenHapus)
        pnlDosenForm.Controls.Add(btnDosenSimpan)
        pnlDosenForm.Controls.Add(btnDosenTambah)
        pnlDosenForm.Controls.Add(lblDosenError)
        pnlDosenForm.Controls.Add(txtDosenNidn)
        pnlDosenForm.Controls.Add(lblDosenNidn)
        pnlDosenForm.Controls.Add(txtDosenNama)
        pnlDosenForm.Controls.Add(lblDosenNama)
        pnlDosenForm.Dock = DockStyle.Top
        pnlDosenForm.Location = New Point(20, 64)
        pnlDosenForm.Name = "pnlDosenForm"
        pnlDosenForm.Size = New Size(448, 210)
        pnlDosenForm.TabIndex = 1
        ' 
        ' btnDosenHapus
        ' 
        btnDosenHapus.BackColor = Color.White
        btnDosenHapus.Cursor = Cursors.Hand
        btnDosenHapus.Enabled = False
        btnDosenHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        btnDosenHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(251), CByte(235), CByte(236))
        btnDosenHapus.FlatStyle = FlatStyle.Flat
        btnDosenHapus.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDosenHapus.ForeColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        btnDosenHapus.Location = New Point(232, 152)
        btnDosenHapus.Name = "btnDosenHapus"
        btnDosenHapus.Size = New Size(84, 42)
        btnDosenHapus.TabIndex = 7
        btnDosenHapus.Text = "Hapus"
        btnDosenHapus.UseVisualStyleBackColor = False
        ' 
        ' btnDosenSimpan
        ' 
        btnDosenSimpan.BackColor = Color.White
        btnDosenSimpan.Cursor = Cursors.Hand
        btnDosenSimpan.Enabled = False
        btnDosenSimpan.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnDosenSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        btnDosenSimpan.FlatStyle = FlatStyle.Flat
        btnDosenSimpan.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDosenSimpan.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnDosenSimpan.Location = New Point(128, 152)
        btnDosenSimpan.Name = "btnDosenSimpan"
        btnDosenSimpan.Size = New Size(96, 42)
        btnDosenSimpan.TabIndex = 6
        btnDosenSimpan.Text = "Simpan"
        btnDosenSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnDosenTambah
        ' 
        btnDosenTambah.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnDosenTambah.Cursor = Cursors.Hand
        btnDosenTambah.FlatAppearance.BorderSize = 0
        btnDosenTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnDosenTambah.FlatStyle = FlatStyle.Flat
        btnDosenTambah.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnDosenTambah.ForeColor = Color.White
        btnDosenTambah.Location = New Point(0, 152)
        btnDosenTambah.Name = "btnDosenTambah"
        btnDosenTambah.Size = New Size(120, 42)
        btnDosenTambah.TabIndex = 5
        btnDosenTambah.Text = "Tambah dosen"
        btnDosenTambah.UseVisualStyleBackColor = False
        ' 
        ' lblDosenError
        ' 
        lblDosenError.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDosenError.Font = New Font("Segoe UI", 9.0F)
        lblDosenError.ForeColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        lblDosenError.Location = New Point(0, 120)
        lblDosenError.Name = "lblDosenError"
        lblDosenError.Size = New Size(448, 24)
        lblDosenError.TabIndex = 4
        ' 
        ' txtDosenNidn
        ' 
        txtDosenNidn.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDosenNidn.Font = New Font("Segoe UI", 10.0F)
        txtDosenNidn.Location = New Point(0, 86)
        txtDosenNidn.MaxLength = 20
        txtDosenNidn.Name = "txtDosenNidn"
        txtDosenNidn.Size = New Size(448, 30)
        txtDosenNidn.TabIndex = 3
        ' 
        ' lblDosenNidn
        ' 
        lblDosenNidn.AutoSize = True
        lblDosenNidn.Font = New Font("Segoe UI", 9.0F)
        lblDosenNidn.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblDosenNidn.Location = New Point(0, 62)
        lblDosenNidn.Name = "lblDosenNidn"
        lblDosenNidn.Size = New Size(113, 20)
        lblDosenNidn.TabIndex = 2
        lblDosenNidn.Text = "NIDN (opsional)"
        ' 
        ' txtDosenNama
        ' 
        txtDosenNama.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDosenNama.Font = New Font("Segoe UI", 10.0F)
        txtDosenNama.Location = New Point(0, 24)
        txtDosenNama.MaxLength = 100
        txtDosenNama.Name = "txtDosenNama"
        txtDosenNama.Size = New Size(448, 30)
        txtDosenNama.TabIndex = 1
        ' 
        ' lblDosenNama
        ' 
        lblDosenNama.AutoSize = True
        lblDosenNama.Font = New Font("Segoe UI", 9.0F)
        lblDosenNama.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblDosenNama.Location = New Point(0, 0)
        lblDosenNama.Name = "lblDosenNama"
        lblDosenNama.Size = New Size(89, 20)
        lblDosenNama.TabIndex = 0
        lblDosenNama.Text = "Nama dosen"
        ' 
        ' lblDosenTitle
        ' 
        lblDosenTitle.Dock = DockStyle.Top
        lblDosenTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblDosenTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblDosenTitle.Location = New Point(20, 20)
        lblDosenTitle.Name = "lblDosenTitle"
        lblDosenTitle.Size = New Size(448, 44)
        lblDosenTitle.TabIndex = 0
        lblDosenTitle.Text = "Dosen"
        ' 
        ' pnlMk
        ' 
        pnlMk.BackColor = Color.White
        pnlMk.Controls.Add(dgvMk)
        pnlMk.Controls.Add(pnlMkForm)
        pnlMk.Controls.Add(lblMkTitle)
        pnlMk.Dock = DockStyle.Fill
        pnlMk.Location = New Point(512, 0)
        pnlMk.Margin = New Padding(12, 0, 0, 0)
        pnlMk.Name = "pnlMk"
        pnlMk.Padding = New Padding(20)
        pnlMk.Size = New Size(601, 806)
        pnlMk.TabIndex = 1
        ' 
        ' dgvMk
        ' 
        dgvMk.Columns.AddRange(New DataGridViewColumn() {colMNama, colMDosen, colMRuang})
        dgvMk.Dock = DockStyle.Fill
        dgvMk.Location = New Point(20, 274)
        dgvMk.Name = "dgvMk"
        dgvMk.RowHeadersWidth = 51
        dgvMk.Size = New Size(561, 512)
        dgvMk.TabIndex = 2
        ' 
        ' colMNama
        ' 
        colMNama.FillWeight = 40.0F
        colMNama.HeaderText = "Mata kuliah"
        colMNama.MinimumWidth = 6
        colMNama.Name = "colMNama"
        colMNama.ReadOnly = True
        ' 
        ' colMDosen
        ' 
        colMDosen.FillWeight = 40.0F
        colMDosen.HeaderText = "Dosen pengampu"
        colMDosen.MinimumWidth = 6
        colMDosen.Name = "colMDosen"
        colMDosen.ReadOnly = True
        ' 
        ' colMRuang
        ' 
        colMRuang.FillWeight = 20.0F
        colMRuang.HeaderText = "Ruang"
        colMRuang.MinimumWidth = 6
        colMRuang.Name = "colMRuang"
        colMRuang.ReadOnly = True
        ' 
        ' pnlMkForm
        ' 
        pnlMkForm.Controls.Add(btnMkHapus)
        pnlMkForm.Controls.Add(btnMkSimpan)
        pnlMkForm.Controls.Add(btnMkTambah)
        pnlMkForm.Controls.Add(lblMkError)
        pnlMkForm.Controls.Add(cmbMkDosen)
        pnlMkForm.Controls.Add(lblMkDosen)
        pnlMkForm.Controls.Add(txtMkRuang)
        pnlMkForm.Controls.Add(lblMkRuang)
        pnlMkForm.Controls.Add(txtMkNama)
        pnlMkForm.Controls.Add(lblMkNama)
        pnlMkForm.Dock = DockStyle.Top
        pnlMkForm.Location = New Point(20, 64)
        pnlMkForm.Name = "pnlMkForm"
        pnlMkForm.Size = New Size(561, 210)
        pnlMkForm.TabIndex = 1
        ' 
        ' btnMkHapus
        ' 
        btnMkHapus.BackColor = Color.White
        btnMkHapus.Cursor = Cursors.Hand
        btnMkHapus.Enabled = False
        btnMkHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        btnMkHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(251), CByte(235), CByte(236))
        btnMkHapus.FlatStyle = FlatStyle.Flat
        btnMkHapus.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnMkHapus.ForeColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        btnMkHapus.Location = New Point(282, 152)
        btnMkHapus.Name = "btnMkHapus"
        btnMkHapus.Size = New Size(84, 42)
        btnMkHapus.TabIndex = 9
        btnMkHapus.Text = "Hapus"
        btnMkHapus.UseVisualStyleBackColor = False
        ' 
        ' btnMkSimpan
        ' 
        btnMkSimpan.BackColor = Color.White
        btnMkSimpan.Cursor = Cursors.Hand
        btnMkSimpan.Enabled = False
        btnMkSimpan.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnMkSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        btnMkSimpan.FlatStyle = FlatStyle.Flat
        btnMkSimpan.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnMkSimpan.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnMkSimpan.Location = New Point(178, 152)
        btnMkSimpan.Name = "btnMkSimpan"
        btnMkSimpan.Size = New Size(96, 42)
        btnMkSimpan.TabIndex = 8
        btnMkSimpan.Text = "Simpan"
        btnMkSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnMkTambah
        ' 
        btnMkTambah.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnMkTambah.Cursor = Cursors.Hand
        btnMkTambah.FlatAppearance.BorderSize = 0
        btnMkTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnMkTambah.FlatStyle = FlatStyle.Flat
        btnMkTambah.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnMkTambah.ForeColor = Color.White
        btnMkTambah.Location = New Point(0, 152)
        btnMkTambah.Name = "btnMkTambah"
        btnMkTambah.Size = New Size(170, 42)
        btnMkTambah.TabIndex = 7
        btnMkTambah.Text = "Tambah mata kuliah"
        btnMkTambah.UseVisualStyleBackColor = False
        ' 
        ' lblMkError
        ' 
        lblMkError.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblMkError.Font = New Font("Segoe UI", 9.0F)
        lblMkError.ForeColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        lblMkError.Location = New Point(0, 120)
        lblMkError.Name = "lblMkError"
        lblMkError.Size = New Size(561, 24)
        lblMkError.TabIndex = 6
        ' 
        ' cmbMkDosen
        ' 
        cmbMkDosen.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMkDosen.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMkDosen.Font = New Font("Segoe UI", 10.0F)
        cmbMkDosen.FormattingEnabled = True
        cmbMkDosen.Location = New Point(166, 86)
        cmbMkDosen.Name = "cmbMkDosen"
        cmbMkDosen.Size = New Size(395, 31)
        cmbMkDosen.TabIndex = 5
        ' 
        ' lblMkDosen
        ' 
        lblMkDosen.AutoSize = True
        lblMkDosen.Font = New Font("Segoe UI", 9.0F)
        lblMkDosen.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblMkDosen.Location = New Point(166, 62)
        lblMkDosen.Name = "lblMkDosen"
        lblMkDosen.Size = New Size(119, 20)
        lblMkDosen.TabIndex = 4
        lblMkDosen.Text = "Dosen pengampu"
        ' 
        ' txtMkRuang
        ' 
        txtMkRuang.Font = New Font("Segoe UI", 10.0F)
        txtMkRuang.Location = New Point(0, 86)
        txtMkRuang.MaxLength = 20
        txtMkRuang.Name = "txtMkRuang"
        txtMkRuang.Size = New Size(150, 30)
        txtMkRuang.TabIndex = 3
        ' 
        ' lblMkRuang
        ' 
        lblMkRuang.AutoSize = True
        lblMkRuang.Font = New Font("Segoe UI", 9.0F)
        lblMkRuang.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblMkRuang.Location = New Point(0, 62)
        lblMkRuang.Name = "lblMkRuang"
        lblMkRuang.Size = New Size(118, 20)
        lblMkRuang.TabIndex = 2
        lblMkRuang.Text = "Ruang (opsional)"
        ' 
        ' txtMkNama
        ' 
        txtMkNama.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMkNama.Font = New Font("Segoe UI", 10.0F)
        txtMkNama.Location = New Point(0, 24)
        txtMkNama.MaxLength = 100
        txtMkNama.Name = "txtMkNama"
        txtMkNama.Size = New Size(561, 30)
        txtMkNama.TabIndex = 1
        ' 
        ' lblMkNama
        ' 
        lblMkNama.AutoSize = True
        lblMkNama.Font = New Font("Segoe UI", 9.0F)
        lblMkNama.ForeColor = Color.FromArgb(CByte(73), CByte(80), CByte(87))
        lblMkNama.Location = New Point(0, 0)
        lblMkNama.Name = "lblMkNama"
        lblMkNama.Size = New Size(126, 20)
        lblMkNama.TabIndex = 0
        lblMkNama.Text = "Nama mata kuliah"
        ' 
        ' lblMkTitle
        ' 
        lblMkTitle.Dock = DockStyle.Top
        lblMkTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblMkTitle.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        lblMkTitle.Location = New Point(20, 20)
        lblMkTitle.Name = "lblMkTitle"
        lblMkTitle.Size = New Size(561, 44)
        lblMkTitle.TabIndex = 0
        lblMkTitle.Text = "Mata kuliah"
        ' 
        ' lblKelolaError
        ' 
        lblKelolaError.Dock = DockStyle.Top
        lblKelolaError.Font = New Font("Segoe UI", 9.5F)
        lblKelolaError.ForeColor = Color.FromArgb(CByte(176), CByte(42), CByte(55))
        lblKelolaError.Location = New Point(40, 89)
        lblKelolaError.Name = "lblKelolaError"
        lblKelolaError.Size = New Size(1113, 32)
        lblKelolaError.TabIndex = 1
        lblKelolaError.Visible = False
        ' 
        ' lblKelolaTitle
        ' 
        lblKelolaTitle.Dock = DockStyle.Top
        lblKelolaTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblKelolaTitle.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblKelolaTitle.Location = New Point(40, 33)
        lblKelolaTitle.Name = "lblKelolaTitle"
        lblKelolaTitle.Size = New Size(1113, 56)
        lblKelolaTitle.TabIndex = 0
        lblKelolaTitle.Text = "Dosen && Mata Kuliah"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1467, 960)
        Controls.Add(pnlProgres)
        Controls.Add(pnlKelola)
        Controls.Add(sidebar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(1255, 918)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIAKAD - Dashboard Admin"
        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        pnlProgres.ResumeLayout(False)
        pnlProgresState.ResumeLayout(False)
        CType(dgvProgres, ComponentModel.ISupportInitialize).EndInit()
        pnlProgresHeader.ResumeLayout(False)
        pnlProgresHeader.PerformLayout()
        pnlKelola.ResumeLayout(False)
        tblKelola.ResumeLayout(False)
        pnlDosen.ResumeLayout(False)
        CType(dgvDosen, ComponentModel.ISupportInitialize).EndInit()
        pnlDosenForm.ResumeLayout(False)
        pnlDosenForm.PerformLayout()
        pnlMk.ResumeLayout(False)
        CType(dgvMk, ComponentModel.ISupportInitialize).EndInit()
        pnlMkForm.ResumeLayout(False)
        pnlMkForm.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSubtitle As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnProgres As Button
    Friend WithEvents btnKelola As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlProgres As Panel
    Friend WithEvents pnlProgresHeader As Panel
    Friend WithEvents lblProgresTitle As Label
    Friend WithEvents lblProgresSummary As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblLastUpdated As Label
    Friend WithEvents lblProgresHint As Label
    Friend WithEvents dgvProgres As DataGridView
    Friend WithEvents colPMataKuliah As DataGridViewTextBoxColumn
    Friend WithEvents colPDosen As DataGridViewTextBoxColumn
    Friend WithEvents colPSudah As DataGridViewTextBoxColumn
    Friend WithEvents colPBelum As DataGridViewTextBoxColumn
    Friend WithEvents colPPersen As DataGridViewTextBoxColumn
    Friend WithEvents pnlProgresState As Panel
    Friend WithEvents lblProgresState As Label
    Friend WithEvents btnProgresRetry As Button
    Friend WithEvents pnlKelola As Panel
    Friend WithEvents lblKelolaTitle As Label
    Friend WithEvents lblKelolaError As Label
    Friend WithEvents tblKelola As TableLayoutPanel
    Friend WithEvents pnlDosen As Panel
    Friend WithEvents lblDosenTitle As Label
    Friend WithEvents pnlDosenForm As Panel
    Friend WithEvents lblDosenNama As Label
    Friend WithEvents txtDosenNama As TextBox
    Friend WithEvents lblDosenNidn As Label
    Friend WithEvents txtDosenNidn As TextBox
    Friend WithEvents lblDosenError As Label
    Friend WithEvents btnDosenTambah As Button
    Friend WithEvents btnDosenSimpan As Button
    Friend WithEvents btnDosenHapus As Button
    Friend WithEvents dgvDosen As DataGridView
    Friend WithEvents colDNama As DataGridViewTextBoxColumn
    Friend WithEvents colDNidn As DataGridViewTextBoxColumn
    Friend WithEvents pnlMk As Panel
    Friend WithEvents lblMkTitle As Label
    Friend WithEvents pnlMkForm As Panel
    Friend WithEvents lblMkNama As Label
    Friend WithEvents txtMkNama As TextBox
    Friend WithEvents lblMkRuang As Label
    Friend WithEvents txtMkRuang As TextBox
    Friend WithEvents lblMkDosen As Label
    Friend WithEvents cmbMkDosen As ComboBox
    Friend WithEvents lblMkError As Label
    Friend WithEvents btnMkTambah As Button
    Friend WithEvents btnMkSimpan As Button
    Friend WithEvents btnMkHapus As Button
    Friend WithEvents dgvMk As DataGridView
    Friend WithEvents colMNama As DataGridViewTextBoxColumn
    Friend WithEvents colMDosen As DataGridViewTextBoxColumn
    Friend WithEvents colMRuang As DataGridViewTextBoxColumn

End Class

