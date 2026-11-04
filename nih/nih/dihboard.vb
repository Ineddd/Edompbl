Public Class dihboard

    Private ReadOnly _nim As String

    ''' <summary>True when the user pressed "Keluar", so the login form should reappear.</summary>
    Public Property LoggedOut As Boolean

    ' Required by the WinForms designer.
    Public Sub New()
        Me.New(String.Empty)
    End Sub

    Public Sub New(nim As String)
        InitializeComponent()
        _nim = nim
    End Sub

    Public ReadOnly Property Nim As String
        Get
            Return _nim
        End Get
    End Property

    Private Sub dihboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = "NIM " & _nim
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoggedOut = True
        Close()
    End Sub

End Class