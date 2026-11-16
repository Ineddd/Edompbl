Imports System.Windows.Forms

Public Class FormEvaluasiEdom

    Private ReadOnly _username As String
    Private ReadOnly _item As EdomMahasiswaItem

    Private ReadOnly RatingOptions As String() = {
        "5 - Sangat Baik",
        "4 - Baik",
        "3 - Cukup",
        "2 - Kurang",
        "1 - Sangat Kurang"
    }

    Public Sub New(username As String, item As EdomMahasiswaItem)
        InitializeComponent()

        _username = If(String.IsNullOrWhiteSpace(username), "Mahasiswa", username.Trim())
        _item = item
    End Sub

    Private Sub FormEvaluasiEdom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cmbPedagogik)
        PopulateComboBox(cmbProfesional)
        PopulateComboBox(cmbKepribadian)
        PopulateComboBox(cmbSosial)

        If _item IsNot Nothing Then
            Dim nidnPart As String = If(String.IsNullOrWhiteSpace(_item.DosenNidn), "", $" ({_item.DosenNidn})")
            lblDosen.Text = $"Dosen: {_item.DosenNama}{nidnPart}"

            Dim ruangPart As String = If(String.IsNullOrWhiteSpace(_item.Ruang), "-", _item.Ruang)
            lblMatkul.Text = $"Mata Kuliah: {_item.MataKuliahNama}  |  Ruang {ruangPart}"

            If _item.SudahDievaluasi Then
                cmbPedagogik.SelectedIndex = ScoreToIndex(_item.SkorPedagogik)
                cmbProfesional.SelectedIndex = ScoreToIndex(_item.SkorProfesional)
                cmbKepribadian.SelectedIndex = ScoreToIndex(_item.SkorKepribadian)
                cmbSosial.SelectedIndex = ScoreToIndex(_item.SkorSosial)
                txtSaran.Text = _item.Saran
                btnSimpan.Text = "Perbarui Evaluasi"
                lblAlreadyEvaluated.Visible = True
            Else
                cmbPedagogik.SelectedIndex = 0
                cmbProfesional.SelectedIndex = 0
                cmbKepribadian.SelectedIndex = 0
                cmbSosial.SelectedIndex = 0
                txtSaran.Clear()
                btnSimpan.Text = "Kirim Evaluasi"
                lblAlreadyEvaluated.Visible = False
            End If
        End If
    End Sub

    Private Sub PopulateComboBox(cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.AddRange(RatingOptions)
    End Sub

    Private Function ScoreToIndex(score As Double) As Integer
        If score <= 0 Then Return 0
        Dim rounded As Integer = CInt(Math.Round(score))
        Dim idx As Integer = 5 - rounded
        If idx < 0 Then idx = 0
        If idx > 4 Then idx = 4
        Return idx
    End Function

    Private Function IndexToScore(idx As Integer) As Double
        If idx < 0 Then idx = 0
        Return CDbl(5 - idx)
    End Function

    Private Async Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        lblStatusInfo.Visible = False

        If _item Is Nothing OrElse Not _item.MataKuliahId.HasValue Then
            lblStatusInfo.Text = "Mata kuliah belum valid untuk dievaluasi."
            lblStatusInfo.Visible = True
            Return
        End If

        Dim ped As Double = IndexToScore(cmbPedagogik.SelectedIndex)
        Dim pro As Double = IndexToScore(cmbProfesional.SelectedIndex)
        Dim kep As Double = IndexToScore(cmbKepribadian.SelectedIndex)
        Dim sos As Double = IndexToScore(cmbSosial.SelectedIndex)
        Dim saran As String = txtSaran.Text.Trim()

        SetBusy(True)

        Try
            Dim mkId As Integer = _item.MataKuliahId.Value
            Await Task.Run(Sub() DatabaseHelper.SimpanPengisianEdom(_username, mkId, ped, pro, kep, sos, saran))

            MessageBox.Show(
                "Terima kasih! Evaluasi Anda untuk dosen pengampu berhasil disimpan ke sistem.",
                "Evaluasi Tersimpan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            DialogResult = DialogResult.OK
            Close()
        Catch ex As Exception
            lblStatusInfo.Text = DatabaseHelper.DescribeError(ex)
            lblStatusInfo.Visible = True
        Finally
            SetBusy(False)
        End Try
    End Sub

    Private Sub SetBusy(busy As Boolean)
        btnSimpan.Enabled = Not busy
        btnBatal.Enabled = Not busy
        cmbPedagogik.Enabled = Not busy
        cmbProfesional.Enabled = Not busy
        cmbKepribadian.Enabled = Not busy
        cmbSosial.Enabled = Not busy
        txtSaran.ReadOnly = busy
        UseWaitCursor = busy
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class

