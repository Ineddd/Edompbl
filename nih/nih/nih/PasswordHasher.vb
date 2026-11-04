Imports System.Security.Cryptography
Imports System.Text

Public Module PasswordHasher

    Public Function HashPassword(password As String) As String
        If String.IsNullOrEmpty(password) Then
            Return String.Empty
        End If

        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Public Function VerifyPassword(password As String, storedHash As String) As Boolean
        If String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(storedHash) Then
            Return False
        End If

        Dim newHash As String = HashPassword(password)
        Return String.Equals(newHash, storedHash, StringComparison.Ordinal)
    End Function

End Module

