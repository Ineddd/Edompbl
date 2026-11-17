<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRincianButir
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
        pnlHeader = New Panel()
        lblCakupan = New Label()
        lblDosen = New Label()
        lblTitle = New Label()
        pnlRingkasan = New Panel()
        lblRingkasan = New Label()
        pnlFooter = New Panel()
        lblKeterangan = New Label()
        btnTutup = New Button()
        pnlBody = New Panel()
        dgvButir = New DataGridView()
        colNo = New DataGridViewTextBoxColumn()
        colButir = New DataGridViewTextBoxColumn()
        colResponden = New DataGridViewTextBoxColumn()
        colRataRata = New DataGridViewTextBoxColumn()
        colPredikat = New DataGridViewTextBoxColumn()
        lblKosong = New Label()
        pnlHeader.SuspendLayout()
        pnlRingkasan.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvButir, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        pnlHeader.Controls.Add(lblCakupan)
        pnlHeader.Controls.Add(lblDosen)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(980, 100)
        pnlHeader.TabIndex = 0
        '
        ' lblCakupan
        '
        lblCakupan.AutoSize = True
        lblCakupan.Font = New Font("Segoe UI", 9.0F)
        lblCakupan.ForeColor = Color.FromArgb(CByte(190), CByte(205), CByte(220))
        lblCakupan.Location = New Point(24, 68)
        lblCakupan.Name = "lblCakupan"
        lblCakupan.Size = New Size(98, 20)
        lblCakupan.TabIndex = 2
        lblCakupan.Text = "Mata Kuliah: -"
        '
        ' lblDosen
        '
        lblDosen.AutoSize = True
        lblDosen.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblDosen.ForeColor = Color.FromArgb(CByte(214), CByte(226), CByte(220))
        lblDosen.Location = New Point(24, 44)
        lblDosen.Name = "lblDosen"
        lblDosen.Size = New Size(63, 23)
        lblDosen.TabIndex = 1
        lblDosen.Text = "Dosen:"
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(22, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(320, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Rincian Nilai per Butir EDOM"
        '
        ' pnlRingkasan
        '
        pnlRingkasan.BackColor = Color.FromArgb(CByte(236), CByte(241), CByte(234))
        pnlRingkasan.Controls.Add(lblRingkasan)
        pnlRingkasan.Dock = DockStyle.Top
        pnlRingkasan.Location = New Point(0, 100)
        pnlRingkasan.Name = "pnlRingkasan"
        pnlRingkasan.Padding = New Padding(24, 0, 24, 0)
        pnlRingkasan.Size = New Size(980, 56)
        pnlRingkasan.TabIndex = 1
        '
        ' lblRingkasan
        '
        lblRingkasan.Dock = DockStyle.Fill
        lblRingkasan.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblRingkasan.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblRingkasan.Location = New Point(24, 0)
        lblRingkasan.Name = "lblRingkasan"
        lblRingkasan.Size = New Size(932, 56)
        lblRingkasan.TabIndex = 0
        lblRingkasan.Text = "Memuat data..."
        lblRingkasan.TextAlign = ContentAlignment.MiddleLeft
        '
        ' pnlFooter
        '
        pnlFooter.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(232))
        pnlFooter.Controls.Add(lblKeterangan)
        pnlFooter.Controls.Add(btnTutup)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 656)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(980, 64)
        pnlFooter.TabIndex = 3
        '
        ' lblKeterangan
        '
        lblKeterangan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblKeterangan.Font = New Font("Segoe UI", 8.5F)
        lblKeterangan.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblKeterangan.Location = New Point(20, 10)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(800, 44)
        lblKeterangan.TabIndex = 1
        lblKeterangan.Text = "Skala 1-5. Predikat: >= 4.50 Sangat Baik, >= 3.75 Baik, >= 3.00 Cukup, < 3.00 Perlu Evaluasi. " &
            "Hanya pengisian dengan formulir 27 butir yang dihitung."
        lblKeterangan.TextAlign = ContentAlignment.MiddleLeft
        '
        ' btnTutup
        '
        btnTutup.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTutup.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnTutup.Cursor = Cursors.Hand
        btnTutup.DialogResult = DialogResult.Cancel
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(840, 12)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(120, 40)
        btnTutup.TabIndex = 0
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        '
        ' pnlBody
        '
        pnlBody.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlBody.Controls.Add(dgvButir)
        pnlBody.Controls.Add(lblKosong)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 156)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 16, 20, 16)
        pnlBody.Size = New Size(980, 500)
        pnlBody.TabIndex = 2
        '
        ' dgvButir
        '
        dgvButir.Columns.AddRange(New DataGridViewColumn() {colNo, colButir, colResponden, colRataRata, colPredikat})
        dgvButir.Dock = DockStyle.Fill
        dgvButir.Location = New Point(20, 16)
        dgvButir.Name = "dgvButir"
        dgvButir.RowHeadersWidth = 51
        dgvButir.Size = New Size(940, 468)
        dgvButir.TabIndex = 0
        '
        ' colNo
        '
        colNo.FillWeight = 7.0F
        colNo.HeaderText = "No."
        colNo.Name = "colNo"
        colNo.ReadOnly = True
        colNo.SortMode = DataGridViewColumnSortMode.NotSortable
        '
        ' colButir
        '
        colButir.FillWeight = 61.0F
        colButir.HeaderText = "Aspek yang Dinilai"
        colButir.Name = "colButir"
        colButir.ReadOnly = True
        colButir.SortMode = DataGridViewColumnSortMode.NotSortable
        '
        ' colResponden
        '
        colResponden.FillWeight = 10.0F
        colResponden.HeaderText = "Responden"
        colResponden.Name = "colResponden"
        colResponden.ReadOnly = True
        colResponden.SortMode = DataGridViewColumnSortMode.NotSortable
        '
        ' colRataRata
        '
        colRataRata.FillWeight = 10.0F
        colRataRata.HeaderText = "Rata-rata"
        colRataRata.Name = "colRataRata"
        colRataRata.ReadOnly = True
        colRataRata.SortMode = DataGridViewColumnSortMode.NotSortable
        '
        ' colPredikat
        '
        colPredikat.FillWeight = 12.0F
        colPredikat.HeaderText = "Predikat"
        colPredikat.Name = "colPredikat"
        colPredikat.ReadOnly = True
        colPredikat.SortMode = DataGridViewColumnSortMode.NotSortable
        '
        ' lblKosong
        '
        lblKosong.Dock = DockStyle.Fill
        lblKosong.Font = New Font("Segoe UI", 10.0F)
        lblKosong.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblKosong.Location = New Point(20, 16)
        lblKosong.Name = "lblKosong"
        lblKosong.Padding = New Padding(40, 0, 40, 0)
        lblKosong.Size = New Size(940, 468)
        lblKosong.TabIndex = 1
        lblKosong.TextAlign = ContentAlignment.MiddleCenter
        lblKosong.Visible = False
        '
        ' FormRincianButir
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        CancelButton = btnTutup
        ClientSize = New Size(980, 720)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlRingkasan)
        Controls.Add(pnlHeader)
        MinimizeBox = False
        MinimumSize = New Size(760, 560)
        Name = "FormRincianButir"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Rincian Nilai per Butir EDOM"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlRingkasan.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        CType(dgvButir, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDosen As Label
    Friend WithEvents lblCakupan As Label
    Friend WithEvents pnlRingkasan As Panel
    Friend WithEvents lblRingkasan As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents pnlBody As Panel
    Friend WithEvents dgvButir As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colButir As DataGridViewTextBoxColumn
    Friend WithEvents colResponden As DataGridViewTextBoxColumn
    Friend WithEvents colRataRata As DataGridViewTextBoxColumn
    Friend WithEvents colPredikat As DataGridViewTextBoxColumn
    Friend WithEvents lblKosong As Label

End Class
