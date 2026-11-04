Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Module DatabaseHelper

    Private Const ConnectionString As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=winforms_login;" &
        "Uid=root;" &
        "Pwd=;"

    Public Function Login(username As String, password As String) As Boolean
        Const query As String =
            "SELECT COUNT(*) " &
            "FROM users " &
            "WHERE username = @username  AND password = @password"

        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()

                Dim result As Object = command.ExecuteScalar()

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Module