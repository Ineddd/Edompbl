Imports MySql.Data.MySqlClient

Public Module DatabaseHelper

    Private Const ConnectionString As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=edompbl;" &
        "Uid=root;" &
        "Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    Public Function Login(nim As String, password As String) As Boolean
        Const query As String =
            "SELECT password_hash " &
            "FROM mahasiswa " &
            "WHERE nim = @nim " &
            "LIMIT 1;"

        Using connection As MySqlConnection = GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nim", nim)

                connection.Open()

                Dim passwordHash As Object = command.ExecuteScalar()

                If passwordHash Is Nothing OrElse passwordHash Is DBNull.Value Then
                    Return False
                End If

                Return PasswordHasher.VerifyPassword(
                    password,
                    passwordHash.ToString()
                )
            End Using
        End Using
    End Function

    Public Function RegisterStudent(
        nim As String,
        email As String,
        password As String
    ) As Boolean

        Const query As String =
            "INSERT INTO mahasiswa " &
            "(nim, email, password_hash) " &
            "VALUES (@nim, @email, @password_hash);"

        Using connection As MySqlConnection = GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nim", nim)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue(
                    "@password_hash",
                    PasswordHasher.HashPassword(password)
                )

                connection.Open()

                Try
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As MySqlException When ex.Number = 1062
                    Throw New ApplicationException(
                        "NIM atau email sudah terdaftar.",
                        ex
                    )
                End Try
            End Using
        End Using
    End Function

End Module