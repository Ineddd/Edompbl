<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKuisionerEdom
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
        lblSubHeader = New Label()
        lblJudul = New Label()
        pnlFooter = New Panel()
        btnBatal = New Button()
        btnSimpan = New Button()
        pnlContainer = New Panel()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(25, 20, 25, 20)
        pnlHeader.Size = New Size(1100, 110)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 10.0F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(210), CByte(230), CByte(220))
        lblSubHeader.Location = New Point(25, 60)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(420, 23)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Dosen: - | Mata Kuliah: -"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(540, 32)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Kuisioner Evaluasi Dosen Oleh Mahasiswa (EDOM)"
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.BorderStyle = BorderStyle.FixedSingle
        pnlFooter.Controls.Add(btnBatal)
        pnlFooter.Controls.Add(btnSimpan)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 770)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(1100, 80)
        pnlFooter.TabIndex = 2
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(230), CByte(235), CByte(232))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnBatal.Location = New Point(680, 15)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(160, 48)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(30), CByte(59), CByte(51))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(46), CByte(82), CByte(72))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(860, 15)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(215, 48)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Hitung & Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' pnlContainer
        ' 
        pnlContainer.AutoScroll = True
        pnlContainer.BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(243))
        pnlContainer.Dock = DockStyle.Fill
        pnlContainer.Location = New Point(0, 110)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Padding = New Padding(30, 20, 30, 20)
        pnlContainer.Size = New Size(1100, 660)
        pnlContainer.TabIndex = 1
        ' 
        ' FormKuisionerEdom
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 850)
        Controls.Add(pnlContainer)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        MinimumSize = New Size(950, 700)
        Name = "FormKuisionerEdom"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pengisian Kuisioner EDOM"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents pnlContainer As Panel

End Class

