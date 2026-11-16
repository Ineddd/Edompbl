<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEvaluasiEdom
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
        lblMatkul = New Label()
        lblDosen = New Label()
        lblTitle = New Label()
        pnlFooter = New Panel()
        lblStatusInfo = New Label()
        btnBatal = New Button()
        btnSimpan = New Button()
        pnlBody = New Panel()
        pnlCard = New Panel()
        lblAlreadyEvaluated = New Label()
        txtSaran = New TextBox()
        lblQ5Desc = New Label()
        lblQ5Title = New Label()
        cmbSosial = New ComboBox()
        lblQ4Desc = New Label()
        lblQ4Title = New Label()
        cmbKepribadian = New ComboBox()
        lblQ3Desc = New Label()
        lblQ3Title = New Label()
        cmbProfesional = New ComboBox()
        lblQ2Desc = New Label()
        lblQ2Title = New Label()
        cmbPedagogik = New ComboBox()
        lblQ1Desc = New Label()
        lblQ1Title = New Label()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        pnlHeader.Controls.Add(lblMatkul)
        pnlHeader.Controls.Add(lblDosen)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(24, 15, 24, 15)
        pnlHeader.Size = New Size(624, 100)
        pnlHeader.TabIndex = 0
        ' 
        ' lblMatkul
        ' 
        lblMatkul.AutoSize = True
        lblMatkul.Font = New Font("Segoe UI", 9.0F)
        lblMatkul.ForeColor = Color.FromArgb(CByte(190), CByte(205), CByte(220))
        lblMatkul.Location = New Point(24, 68)
        lblMatkul.Name = "lblMatkul"
        lblMatkul.Size = New Size(88, 20)
        lblMatkul.TabIndex = 2
        lblMatkul.Text = "Mata Kuliah:"
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
        lblTitle.Size = New Size(405, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Formulir Evaluasi Dosen (EDOM)"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(232))
        pnlFooter.Controls.Add(lblStatusInfo)
        pnlFooter.Controls.Add(btnBatal)
        pnlFooter.Controls.Add(btnSimpan)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 680)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(624, 70)
        pnlFooter.TabIndex = 2
        ' 
        ' lblStatusInfo
        ' 
        lblStatusInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStatusInfo.Font = New Font("Segoe UI", 9.0F)
        lblStatusInfo.ForeColor = Color.FromArgb(CByte(180), CByte(35), CByte(24))
        lblStatusInfo.Location = New Point(20, 15)
        lblStatusInfo.Name = "lblStatusInfo"
        lblStatusInfo.Size = New Size(300, 40)
        lblStatusInfo.TabIndex = 2
        lblStatusInfo.TextAlign = ContentAlignment.MiddleLeft
        lblStatusInfo.Visible = False
        ' 
        ' btnBatal
        ' 
        btnBatal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.DialogResult = DialogResult.Cancel
        btnBatal.FlatAppearance.BorderColor = Color.FromArgb(CByte(206), CByte(212), CByte(218))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        btnBatal.Location = New Point(334, 14)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(100, 42)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimpan.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(444, 14)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(160, 42)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Kirim Evaluasi"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' pnlBody
        ' 
        pnlBody.AutoScroll = True
        pnlBody.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlBody.Controls.Add(pnlCard)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 100)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 15, 20, 15)
        pnlBody.Size = New Size(624, 580)
        pnlBody.TabIndex = 1
        ' 
        ' pnlCard
        ' 
        pnlCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(lblAlreadyEvaluated)
        pnlCard.Controls.Add(txtSaran)
        pnlCard.Controls.Add(lblQ5Desc)
        pnlCard.Controls.Add(lblQ5Title)
        pnlCard.Controls.Add(cmbSosial)
        pnlCard.Controls.Add(lblQ4Desc)
        pnlCard.Controls.Add(lblQ4Title)
        pnlCard.Controls.Add(cmbKepribadian)
        pnlCard.Controls.Add(lblQ3Desc)
        pnlCard.Controls.Add(lblQ3Title)
        pnlCard.Controls.Add(cmbProfesional)
        pnlCard.Controls.Add(lblQ2Desc)
        pnlCard.Controls.Add(lblQ2Title)
        pnlCard.Controls.Add(cmbPedagogik)
        pnlCard.Controls.Add(lblQ1Desc)
        pnlCard.Controls.Add(lblQ1Title)
        pnlCard.Location = New Point(20, 15)
        pnlCard.Name = "pnlCard"
        pnlCard.Padding = New Padding(20)
        pnlCard.Size = New Size(565, 545)
        pnlCard.TabIndex = 0
        ' 
        ' lblAlreadyEvaluated
        ' 
        lblAlreadyEvaluated.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAlreadyEvaluated.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Italic)
        lblAlreadyEvaluated.ForeColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
        lblAlreadyEvaluated.Location = New Point(20, 502)
        lblAlreadyEvaluated.Name = "lblAlreadyEvaluated"
        lblAlreadyEvaluated.Size = New Size(525, 30)
        lblAlreadyEvaluated.TabIndex = 15
        lblAlreadyEvaluated.Text = "Catatan: Anda sudah pernah mengisi evaluasi ini. Menyimpan akan memperbarui data nilai Anda."
        lblAlreadyEvaluated.Visible = False
        ' 
        ' txtSaran
        ' 
        txtSaran.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSaran.Font = New Font("Segoe UI", 9.5F)
        txtSaran.Location = New Point(20, 420)
        txtSaran.Multiline = True
        txtSaran.Name = "txtSaran"
        txtSaran.ScrollBars = ScrollBars.Vertical
        txtSaran.Size = New Size(525, 75)
        txtSaran.TabIndex = 14
        ' 
        ' lblQ5Desc
        ' 
        lblQ5Desc.AutoSize = True
        lblQ5Desc.Font = New Font("Segoe UI", 8.5F)
        lblQ5Desc.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblQ5Desc.Location = New Point(20, 396)
        lblQ5Desc.Name = "lblQ5Desc"
        lblQ5Desc.Size = New Size(479, 20)
        lblQ5Desc.TabIndex = 13
        lblQ5Desc.Text = "Berikan masukan konstruktif untuk peningkatan proses perkuliahan dosen."
        ' 
        ' lblQ5Title
        ' 
        lblQ5Title.AutoSize = True
        lblQ5Title.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQ5Title.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblQ5Title.Location = New Point(20, 373)
        lblQ5Title.Name = "lblQ5Title"
        lblQ5Title.Size = New Size(346, 21)
        lblQ5Title.TabIndex = 12
        lblQ5Title.Text = "5. Kritik, Saran && Masukan Mahasiswa (Opsional)"
        ' 
        ' cmbSosial
        ' 
        cmbSosial.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSosial.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSosial.Font = New Font("Segoe UI", 9.5F)
        cmbSosial.FormattingEnabled = True
        cmbSosial.Location = New Point(20, 329)
        cmbSosial.Name = "cmbSosial"
        cmbSosial.Size = New Size(525, 29)
        cmbSosial.TabIndex = 11
        ' 
        ' lblQ4Desc
        ' 
        lblQ4Desc.AutoSize = True
        lblQ4Desc.Font = New Font("Segoe UI", 8.5F)
        lblQ4Desc.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblQ4Desc.Location = New Point(20, 305)
        lblQ4Desc.Name = "lblQ4Desc"
        lblQ4Desc.Size = New Size(491, 20)
        lblQ4Desc.TabIndex = 10
        lblQ4Desc.Text = "Keterbukaan dalam diskusi, keramahan, dan respons terhadap pertanyaan."
        ' 
        ' lblQ4Title
        ' 
        lblQ4Title.AutoSize = True
        lblQ4Title.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQ4Title.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblQ4Title.Location = New Point(20, 282)
        lblQ4Title.Name = "lblQ4Title"
        lblQ4Title.Size = New Size(365, 21)
        lblQ4Title.TabIndex = 9
        lblQ4Title.Text = "4. Kompetensi Sosial (Komunikasi && Keramahan)"
        ' 
        ' cmbKepribadian
        ' 
        cmbKepribadian.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbKepribadian.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKepribadian.Font = New Font("Segoe UI", 9.5F)
        cmbKepribadian.FormattingEnabled = True
        cmbKepribadian.Location = New Point(20, 238)
        cmbKepribadian.Name = "cmbKepribadian"
        cmbKepribadian.Size = New Size(525, 29)
        cmbKepribadian.TabIndex = 8
        ' 
        ' lblQ3Desc
        ' 
        lblQ3Desc.AutoSize = True
        lblQ3Desc.Font = New Font("Segoe UI", 8.5F)
        lblQ3Desc.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblQ3Desc.Location = New Point(20, 214)
        lblQ3Desc.Name = "lblQ3Desc"
        lblQ3Desc.Size = New Size(499, 20)
        lblQ3Desc.TabIndex = 7
        lblQ3Desc.Text = "Ketepatan waktu mengajar, keteladanan sikap, dan objektivitas penilaian."
        ' 
        ' lblQ3Title
        ' 
        lblQ3Title.AutoSize = True
        lblQ3Title.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQ3Title.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblQ3Title.Location = New Point(20, 191)
        lblQ3Title.Name = "lblQ3Title"
        lblQ3Title.Size = New Size(357, 21)
        lblQ3Title.TabIndex = 6
        lblQ3Title.Text = "3. Kompetensi Kepribadian (Kedisiplinan && Sikap)"
        ' 
        ' cmbProfesional
        ' 
        cmbProfesional.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProfesional.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProfesional.Font = New Font("Segoe UI", 9.5F)
        cmbProfesional.FormattingEnabled = True
        cmbProfesional.Location = New Point(20, 147)
        cmbProfesional.Name = "cmbProfesional"
        cmbProfesional.Size = New Size(525, 29)
        cmbProfesional.TabIndex = 5
        ' 
        ' lblQ2Desc
        ' 
        lblQ2Desc.AutoSize = True
        lblQ2Desc.Font = New Font("Segoe UI", 8.5F)
        lblQ2Desc.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblQ2Desc.Location = New Point(20, 123)
        lblQ2Desc.Name = "lblQ2Desc"
        lblQ2Desc.Size = New Size(480, 20)
        lblQ2Desc.TabIndex = 4
        lblQ2Desc.Text = "Keluasan wawasan materi dosen dan relevansi materi dengan praktik riil."
        ' 
        ' lblQ2Title
        ' 
        lblQ2Title.AutoSize = True
        lblQ2Title.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQ2Title.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblQ2Title.Location = New Point(20, 100)
        lblQ2Title.Name = "lblQ2Title"
        lblQ2Title.Size = New Size(380, 21)
        lblQ2Title.TabIndex = 3
        lblQ2Title.Text = "2. Kompetensi Profesional (Penguasaan Keilmuan)"
        ' 
        ' cmbPedagogik
        ' 
        cmbPedagogik.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbPedagogik.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPedagogik.Font = New Font("Segoe UI", 9.5F)
        cmbPedagogik.FormattingEnabled = True
        cmbPedagogik.Location = New Point(20, 56)
        cmbPedagogik.Name = "cmbPedagogik"
        cmbPedagogik.Size = New Size(525, 29)
        cmbPedagogik.TabIndex = 2
        ' 
        ' lblQ1Desc
        ' 
        lblQ1Desc.AutoSize = True
        lblQ1Desc.Font = New Font("Segoe UI", 8.5F)
        lblQ1Desc.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblQ1Desc.Location = New Point(20, 32)
        lblQ1Desc.Name = "lblQ1Desc"
        lblQ1Desc.Size = New Size(489, 20)
        lblQ1Desc.TabIndex = 1
        lblQ1Desc.Text = "Kejelasan penyampaian materi, penguasaan kelas, dan kejelasan tugas."
        ' 
        ' lblQ1Title
        ' 
        lblQ1Title.AutoSize = True
        lblQ1Title.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblQ1Title.ForeColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        lblQ1Title.Location = New Point(20, 9)
        lblQ1Title.Name = "lblQ1Title"
        lblQ1Title.Size = New Size(378, 21)
        lblQ1Title.TabIndex = 0
        lblQ1Title.Text = "1. Kompetensi Pedagogik (Kemampuan Mengajar)"
        ' 
        ' FormEvaluasiEdom
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        ClientSize = New Size(624, 750)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormEvaluasiEdom"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Pengisian Formulir EDOM"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFooter.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDosen As Label
    Friend WithEvents lblMatkul As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblStatusInfo As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlCard As Panel
    Friend WithEvents lblQ1Title As Label
    Friend WithEvents lblQ1Desc As Label
    Friend WithEvents cmbPedagogik As ComboBox
    Friend WithEvents lblQ2Title As Label
    Friend WithEvents lblQ2Desc As Label
    Friend WithEvents cmbProfesional As ComboBox
    Friend WithEvents lblQ3Title As Label
    Friend WithEvents lblQ3Desc As Label
    Friend WithEvents cmbKepribadian As ComboBox
    Friend WithEvents lblQ4Title As Label
    Friend WithEvents lblQ4Desc As Label
    Friend WithEvents cmbSosial As ComboBox
    Friend WithEvents lblQ5Title As Label
    Friend WithEvents lblQ5Desc As Label
    Friend WithEvents txtSaran As TextBox
    Friend WithEvents lblAlreadyEvaluated As Label

End Class
