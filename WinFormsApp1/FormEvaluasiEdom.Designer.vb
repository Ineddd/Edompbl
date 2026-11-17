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
        flpIsi = New FlowLayoutPanel()
        lblMemuat = New Label()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlBody.SuspendLayout()
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
        pnlHeader.Size = New Size(720, 100)
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
        pnlFooter.Location = New Point(0, 690)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(720, 70)
        pnlFooter.TabIndex = 2
        '
        ' lblStatusInfo
        '
        lblStatusInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStatusInfo.Font = New Font("Segoe UI", 9.0F)
        lblStatusInfo.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblStatusInfo.Location = New Point(20, 15)
        lblStatusInfo.Name = "lblStatusInfo"
        lblStatusInfo.Size = New Size(400, 40)
        lblStatusInfo.TabIndex = 2
        lblStatusInfo.TextAlign = ContentAlignment.MiddleLeft
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
        btnBatal.Location = New Point(430, 14)
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
        btnSimpan.Enabled = False
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(114), CByte(142), CByte(109))
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(540, 14)
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
        pnlBody.Controls.Add(flpIsi)
        pnlBody.Controls.Add(lblMemuat)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 100)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 15, 20, 15)
        pnlBody.Size = New Size(720, 590)
        pnlBody.TabIndex = 1
        '
        ' flpIsi
        '
        flpIsi.AutoSize = True
        flpIsi.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpIsi.FlowDirection = FlowDirection.TopDown
        flpIsi.Location = New Point(20, 15)
        flpIsi.Margin = New Padding(0)
        flpIsi.Name = "flpIsi"
        flpIsi.Padding = New Padding(0, 0, 0, 15)
        flpIsi.Size = New Size(0, 15)
        flpIsi.TabIndex = 0
        flpIsi.WrapContents = False
        '
        ' lblMemuat
        '
        lblMemuat.Font = New Font("Segoe UI", 10.0F)
        lblMemuat.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lblMemuat.Location = New Point(20, 15)
        lblMemuat.Name = "lblMemuat"
        lblMemuat.Size = New Size(660, 120)
        lblMemuat.TabIndex = 1
        lblMemuat.Text = "Memuat butir pertanyaan EDOM..."
        lblMemuat.TextAlign = ContentAlignment.MiddleCenter
        '
        ' FormEvaluasiEdom
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        CancelButton = btnBatal
        ClientSize = New Size(720, 760)
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
        pnlBody.PerformLayout()
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
    Friend WithEvents flpIsi As FlowLayoutPanel
    Friend WithEvents lblMemuat As Label

End Class
