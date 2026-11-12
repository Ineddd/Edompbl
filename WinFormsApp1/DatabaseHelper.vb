Imports MySql.Data.MySqlClient

Public Module DatabaseHelper

    Private Const ConnectionString As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=winforms_login;" &
        "Uid=root;" &
        "Pwd=;"

    Public Const RoleAdmin As String = "admin"
    Public Const RoleMahasiswa As String = "mahasiswa"

    Private schemaInitialized As Boolean

    ' Ensures the role column, EDOM tables, and default accounts exist.
    ' Each step is isolated so an existing database quirk never blocks login.
    Private Sub EnsureSchema(connection As MySqlConnection)
        If schemaInitialized Then Return

        Try
            Using cmd As New MySqlCommand(
                "CREATE TABLE IF NOT EXISTS users (" &
                "  id INT AUTO_INCREMENT PRIMARY KEY," &
                "  username VARCHAR(50) NOT NULL," &
                "  password VARCHAR(255) NOT NULL," &
                "  role ENUM('mahasiswa', 'admin') NOT NULL DEFAULT 'mahasiswa'" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using
        Catch
        End Try

        Try
            Dim hasRoleColumn As Boolean
            Using cmd As New MySqlCommand("SHOW COLUMNS FROM users LIKE 'role'", connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    hasRoleColumn = reader.HasRows
                End Using
            End Using

            If Not hasRoleColumn Then
                Using cmd As New MySqlCommand(
                    "ALTER TABLE users ADD COLUMN role ENUM('mahasiswa', 'admin') NOT NULL DEFAULT 'mahasiswa'",
                    connection)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch
        End Try

        Try
            EnsureAccount(connection, "admin", "admin123", RoleAdmin)
            EnsureAccount(connection, "2507411026", "12345", RoleMahasiswa)
        Catch
        End Try

        Try
            Using cmd As New MySqlCommand(
                "CREATE TABLE IF NOT EXISTS dosen (" &
                "  id INT AUTO_INCREMENT PRIMARY KEY," &
                "  nidn VARCHAR(20) NULL UNIQUE," &
                "  nama VARCHAR(100) NOT NULL" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New MySqlCommand(
                "CREATE TABLE IF NOT EXISTS mata_kuliah (" &
                "  id INT AUTO_INCREMENT PRIMARY KEY," &
                "  nama VARCHAR(100) NOT NULL," &
                "  ruang VARCHAR(20) NULL," &
                "  dosen_id INT NOT NULL," &
                "  CONSTRAINT fk_mata_kuliah_dosen FOREIGN KEY (dosen_id) REFERENCES dosen (id) ON DELETE RESTRICT" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New MySqlCommand(
                "CREATE TABLE IF NOT EXISTS edom_pengisian (" &
                "  id INT AUTO_INCREMENT PRIMARY KEY," &
                "  username VARCHAR(50) NOT NULL," &
                "  mata_kuliah_id INT NOT NULL," &
                "  diisi_pada TIMESTAMP DEFAULT CURRENT_TIMESTAMP," &
                "  UNIQUE KEY uq_pengisian (username, mata_kuliah_id)," &
                "  CONSTRAINT fk_pengisian_mata_kuliah FOREIGN KEY (mata_kuliah_id) REFERENCES mata_kuliah (id) ON DELETE CASCADE" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using

            Dim dosenCount As Integer
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM dosen", connection)
                dosenCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If dosenCount = 0 Then
                SeedInitialCourses(connection)
            End If
        Catch
        End Try

        schemaInitialized = True
    End Sub

    Private Sub EnsureAccount(connection As MySqlConnection, username As String, password As String, role As String)
        Dim exists As Integer
        Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @u", connection)
            checkCmd.Parameters.AddWithValue("@u", username)
            exists = Convert.ToInt32(checkCmd.ExecuteScalar())
        End Using

        If exists = 0 Then
            Using insertCmd As New MySqlCommand(
                "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)", connection)
                insertCmd.Parameters.AddWithValue("@u", username)
                insertCmd.Parameters.AddWithValue("@p", password)
                insertCmd.Parameters.AddWithValue("@r", role)
                insertCmd.ExecuteNonQuery()
            End Using
        ElseIf role = RoleAdmin Then
            Using updateCmd As New MySqlCommand(
                "UPDATE users SET role = 'admin' WHERE username = @u", connection)
                updateCmd.Parameters.AddWithValue("@u", username)
                updateCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Private Sub SeedInitialCourses(connection As MySqlConnection)
        Dim seeds As (Dosen As String, Matkul As String, Ruang As String)() = {
            ("Asep Taufik, M.Kom.", "Pemrograman Web Lanjut", "AA 301"),
            ("Risna Sari, M.Kom.", "Pemrograman Basis Data", "GSG 204"),
            ("Bagus Wijaya, M.Kom.", "Analisis Sistem", "PUT 301"),
            ("Dr. Hendra Pratama, M.T.", "Rekayasa Perangkat Lunak", "AA 205")
        }

        For Each s In seeds
            Dim dosenId As Integer
            Using cmd As New MySqlCommand("INSERT INTO dosen (nama) VALUES (@nama)", connection)
                cmd.Parameters.AddWithValue("@nama", s.Dosen)
                cmd.ExecuteNonQuery()
                dosenId = Convert.ToInt32(cmd.LastInsertedId)
            End Using

            Using cmd As New MySqlCommand(
                "INSERT INTO mata_kuliah (nama, ruang, dosen_id) VALUES (@nama, @ruang, @dosenId)", connection)
                cmd.Parameters.AddWithValue("@nama", s.Matkul)
                cmd.Parameters.AddWithValue("@ruang", s.Ruang)
                cmd.Parameters.AddWithValue("@dosenId", dosenId)
                cmd.ExecuteNonQuery()
            End Using
        Next
    End Sub

    ' Returns the account's role, or Nothing when the credentials don't match.
    Public Function Login(username As String, password As String) As String
        ' Built-in admin credentials always work even before SQL migration is run.
        If String.Equals(username, "admin", StringComparison.OrdinalIgnoreCase) AndAlso
           password = "admin123" Then
            Try
                Using conn As New MySqlConnection(ConnectionString)
                    conn.Open()
                    EnsureSchema(conn)
                End Using
            Catch
            End Try
            Return RoleAdmin
        End If

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Try
                Const queryWithRole As String =
                    "SELECT role " &
                    "FROM users " &
                    "WHERE username = @username AND password = @password " &
                    "LIMIT 1"

                Using command As New MySqlCommand(queryWithRole, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    Dim result As Object = command.ExecuteScalar()
                    If result Is Nothing OrElse result Is DBNull.Value Then
                        Return Nothing
                    End If

                    Dim roleValue As String = result.ToString().Trim().ToLowerInvariant()
                    If String.IsNullOrEmpty(roleValue) Then
                        Return If(String.Equals(username, "admin", StringComparison.OrdinalIgnoreCase), RoleAdmin, RoleMahasiswa)
                    End If
                    Return roleValue
                End Using
            Catch ex As MySqlException When ex.Number = 1054
                ' Fallback if the users table does not have a role column.
                Const queryLegacy As String =
                    "SELECT COUNT(*) " &
                    "FROM users " &
                    "WHERE username = @username AND password = @password"

                Using command As New MySqlCommand(queryLegacy, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count <= 0 Then Return Nothing

                    Return If(String.Equals(username, "admin", StringComparison.OrdinalIgnoreCase), RoleAdmin, RoleMahasiswa)
                End Using
            End Try
        End Using
    End Function

    ' Turns a database exception into a message the user can act on.
    Public Function DescribeError(ex As Exception) As String
        Dim sqlEx As MySqlException = TryCast(ex, MySqlException)

        If sqlEx IsNot Nothing Then
            Select Case sqlEx.Number
                Case 1054, 1146
                    Return "Struktur database belum diperbarui. Jalankan nih\database\winforms_login.sql, lalu coba lagi."
                Case 1049
                    Return "Database winforms_login belum dibuat di MySQL."
                Case 1045
                    Return "MySQL menolak login. Periksa user dan password di DatabaseHelper.vb."
            End Select
        End If

        Return "Database tidak bisa dihubungi. Pastikan MySQL di Laragon sudah berjalan, lalu coba lagi."
    End Function

    ' ---------- Admin: progres ----------

    Public Function GetRingkasanProgres() As RingkasanProgres
        Const totalQuery As String =
            "SELECT COUNT(*) FROM users WHERE role = 'mahasiswa'"

        Const selesaiQuery As String =
            "SELECT COUNT(*) FROM users u " &
            "WHERE u.role = 'mahasiswa' " &
            "  AND (SELECT COUNT(*) FROM mata_kuliah) > 0 " &
            "  AND (SELECT COUNT(DISTINCT p.mata_kuliah_id) FROM edom_pengisian p " &
            "       WHERE p.username = u.username) = (SELECT COUNT(*) FROM mata_kuliah)"

        Const perMataKuliahQuery As String =
            "SELECT mk.nama, d.nama AS dosen, COUNT(u.username) AS sudah " &
            "FROM mata_kuliah mk " &
            "JOIN dosen d ON d.id = mk.dosen_id " &
            "LEFT JOIN edom_pengisian p ON p.mata_kuliah_id = mk.id " &
            "LEFT JOIN users u ON u.username = p.username AND u.role = 'mahasiswa' " &
            "GROUP BY mk.id, mk.nama, d.nama " &
            "ORDER BY sudah, mk.nama"

        Dim ringkasan As New RingkasanProgres

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Try
                Using command As New MySqlCommand(totalQuery, connection)
                    ringkasan.TotalMahasiswa = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch
                Using command As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username <> 'admin'", connection)
                    ringkasan.TotalMahasiswa = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Try

            Try
                Using command As New MySqlCommand(selesaiQuery, connection)
                    ringkasan.MahasiswaSelesai = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch
                ringkasan.MahasiswaSelesai = 0
            End Try

            Using command As New MySqlCommand(perMataKuliahQuery, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ringkasan.PerMataKuliah.Add(New ProgresMataKuliah With {
                            .Nama = reader.GetString("nama"),
                            .Dosen = reader.GetString("dosen"),
                            .Sudah = Convert.ToInt32(reader("sudah"))
                        })
                    End While
                End Using
            End Using
        End Using

        Return ringkasan
    End Function

    ' ---------- Admin: dosen ----------

    Public Function GetDosen() As List(Of DosenItem)
        Const query As String = "SELECT id, nidn, nama FROM dosen ORDER BY nama"

        Dim items As New List(Of DosenItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        items.Add(New DosenItem With {
                            .Id = reader.GetInt32("id"),
                            .Nidn = If(reader.IsDBNull(reader.GetOrdinal("nidn")), "", reader.GetString("nidn")),
                            .Nama = reader.GetString("nama")
                        })
                    End While
                End Using
            End Using
        End Using

        Return items
    End Function

    Public Sub AddDosen(nama As String, nidn As String)
        Execute(
            "INSERT INTO dosen (nama, nidn) VALUES (@nama, @nidn)",
            ("@nama", nama),
            ("@nidn", NullIfEmpty(nidn)))
    End Sub

    Public Sub UpdateDosen(id As Integer, nama As String, nidn As String)
        Execute(
            "UPDATE dosen SET nama = @nama, nidn = @nidn WHERE id = @id",
            ("@nama", nama),
            ("@nidn", NullIfEmpty(nidn)),
            ("@id", id))
    End Sub

    Public Sub DeleteDosen(id As Integer)
        Execute("DELETE FROM dosen WHERE id = @id", ("@id", id))
    End Sub

    ' ---------- Admin: mata kuliah ----------

    Public Function GetMataKuliah() As List(Of MataKuliahItem)
        Const query As String =
            "SELECT mk.id, mk.nama, mk.ruang, mk.dosen_id, d.nama AS dosen " &
            "FROM mata_kuliah mk " &
            "JOIN dosen d ON d.id = mk.dosen_id " &
            "ORDER BY mk.nama"

        Dim items As New List(Of MataKuliahItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        items.Add(New MataKuliahItem With {
                            .Id = reader.GetInt32("id"),
                            .Nama = reader.GetString("nama"),
                            .Ruang = If(reader.IsDBNull(reader.GetOrdinal("ruang")), "", reader.GetString("ruang")),
                            .DosenId = reader.GetInt32("dosen_id"),
                            .DosenNama = reader.GetString("dosen")
                        })
                    End While
                End Using
            End Using
        End Using

        Return items
    End Function

    Public Sub AddMataKuliah(nama As String, ruang As String, dosenId As Integer)
        Execute(
            "INSERT INTO mata_kuliah (nama, ruang, dosen_id) VALUES (@nama, @ruang, @dosen)",
            ("@nama", nama),
            ("@ruang", NullIfEmpty(ruang)),
            ("@dosen", dosenId))
    End Sub

    Public Sub UpdateMataKuliah(id As Integer, nama As String, ruang As String, dosenId As Integer)
        Execute(
            "UPDATE mata_kuliah SET nama = @nama, ruang = @ruang, dosen_id = @dosen WHERE id = @id",
            ("@nama", nama),
            ("@ruang", NullIfEmpty(ruang)),
            ("@dosen", dosenId),
            ("@id", id))
    End Sub

    Public Sub DeleteMataKuliah(id As Integer)
        Execute("DELETE FROM mata_kuliah WHERE id = @id", ("@id", id))
    End Sub

    ' ---------- Helpers ----------

    Private Sub Execute(query As String, ParamArray parameters() As (Name As String, Value As Object))
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                For Each p In parameters
                    command.Parameters.AddWithValue(p.Name, p.Value)
                Next

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function NullIfEmpty(value As String) As Object
        If String.IsNullOrWhiteSpace(value) Then
            Return DBNull.Value
        End If

        Return value.Trim()
    End Function

End Module

Public Class ProgresMataKuliah
    Public Property Nama As String
    Public Property Dosen As String
    Public Property Sudah As Integer
End Class

Public Class RingkasanProgres
    Public Property TotalMahasiswa As Integer
    Public Property MahasiswaSelesai As Integer
    Public Property PerMataKuliah As New List(Of ProgresMataKuliah)
End Class

Public Class DosenItem
    Public Property Id As Integer
    Public Property Nidn As String
    Public Property Nama As String

    Public Overrides Function ToString() As String
        Return Nama
    End Function
End Class

Public Class MataKuliahItem
    Public Property Id As Integer
    Public Property Nama As String
    Public Property Ruang As String
    Public Property DosenId As Integer
    Public Property DosenNama As String
End Class