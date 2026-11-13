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
    Public Const RoleDosen As String = "dosen"

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
                "  role ENUM('mahasiswa', 'admin', 'dosen') NOT NULL DEFAULT 'mahasiswa'" &
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
                    "ALTER TABLE users ADD COLUMN role ENUM('mahasiswa', 'admin', 'dosen') NOT NULL DEFAULT 'mahasiswa'",
                    connection)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                Using cmd As New MySqlCommand(
                    "ALTER TABLE users MODIFY COLUMN role ENUM('mahasiswa', 'admin', 'dosen') NOT NULL DEFAULT 'mahasiswa'",
                    connection)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch
        End Try

        Try
            Dim hasDosenIdColumn As Boolean
            Using cmd As New MySqlCommand("SHOW COLUMNS FROM users LIKE 'dosen_id'", connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    hasDosenIdColumn = reader.HasRows
                End Using
            End Using

            If Not hasDosenIdColumn Then
                Using cmd As New MySqlCommand(
                    "ALTER TABLE users ADD COLUMN dosen_id INT NULL",
                    connection)
                    cmd.ExecuteNonQuery()
                End Using
            End If
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
                "  skor_pedagogik DECIMAL(3,2) NULL DEFAULT 4.50," &
                "  skor_profesional DECIMAL(3,2) NULL DEFAULT 4.50," &
                "  skor_kepribadian DECIMAL(3,2) NULL DEFAULT 4.50," &
                "  skor_sosial DECIMAL(3,2) NULL DEFAULT 4.50," &
                "  nilai_rata_rata DECIMAL(3,2) NULL DEFAULT 4.50," &
                "  saran TEXT NULL," &
                "  diisi_pada TIMESTAMP DEFAULT CURRENT_TIMESTAMP," &
                "  UNIQUE KEY uq_pengisian (username, mata_kuliah_id)," &
                "  CONSTRAINT fk_pengisian_mata_kuliah FOREIGN KEY (mata_kuliah_id) REFERENCES mata_kuliah (id) ON DELETE CASCADE" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using

            ' Ensure columns in edom_pengisian if table was created previously without scores
            Dim hasSkorColumn As Boolean
            Using cmd As New MySqlCommand("SHOW COLUMNS FROM edom_pengisian LIKE 'nilai_rata_rata'", connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    hasSkorColumn = reader.HasRows
                End Using
            End Using

            If Not hasSkorColumn Then
                Using cmd As New MySqlCommand(
                    "ALTER TABLE edom_pengisian " &
                    "ADD COLUMN skor_pedagogik DECIMAL(3,2) NULL DEFAULT 4.50, " &
                    "ADD COLUMN skor_profesional DECIMAL(3,2) NULL DEFAULT 4.50, " &
                    "ADD COLUMN skor_kepribadian DECIMAL(3,2) NULL DEFAULT 4.50, " &
                    "ADD COLUMN skor_sosial DECIMAL(3,2) NULL DEFAULT 4.50, " &
                    "ADD COLUMN nilai_rata_rata DECIMAL(3,2) NULL DEFAULT 4.50, " &
                    "ADD COLUMN saran TEXT NULL",
                    connection)
                    cmd.ExecuteNonQuery()
                End Using
            End If

            Dim dosenCount As Integer
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM dosen", connection)
                dosenCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If dosenCount = 0 Then
                SeedInitialCourses(connection)
            End If

            ' Ensure default accounts
            EnsureAccount(connection, "admin", "admin123", RoleAdmin)
            EnsureAccount(connection, "2507411026", "12345", RoleMahasiswa)
            EnsureAccount(connection, "2507411001", "12345", RoleMahasiswa)
            EnsureAccount(connection, "2507411002", "12345", RoleMahasiswa)
            EnsureAccount(connection, "2507411003", "12345", RoleMahasiswa)

            ' Link default 'dosen' to Asep Taufik, M.Kom.
            Dim asepId As Integer = 0
            Using cmd As New MySqlCommand("SELECT id FROM dosen WHERE nama LIKE '%Asep Taufik%' LIMIT 1", connection)
                Dim res As Object = cmd.ExecuteScalar()
                If res IsNot Nothing AndAlso res IsNot DBNull.Value Then
                    asepId = Convert.ToInt32(res)
                End If
            End Using

            EnsureDosenAccount(connection, "dosen", "dosen123", RoleDosen, asepId)
            EnsureDosenAccount(connection, "0012038501", "dosen123", RoleDosen, asepId)

            If asepId > 0 Then
                EnsureCourseExists(connection, "Pemrograman Berorientasi Objek", "AA 304", asepId)
                EnsureCourseExists(connection, "Workshop Aplikasi Enterprise", "Lab RPL 1", asepId)
                EnsureSampleEdomFeedback(connection)
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

    Private Sub EnsureDosenAccount(connection As MySqlConnection, username As String, password As String, role As String, dosenId As Integer)
        Dim exists As Integer
        Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @u", connection)
            checkCmd.Parameters.AddWithValue("@u", username)
            exists = Convert.ToInt32(checkCmd.ExecuteScalar())
        End Using

        If exists = 0 Then
            Using insertCmd As New MySqlCommand(
                "INSERT INTO users (username, password, role, dosen_id) VALUES (@u, @p, @r, @d)", connection)
                insertCmd.Parameters.AddWithValue("@u", username)
                insertCmd.Parameters.AddWithValue("@p", password)
                insertCmd.Parameters.AddWithValue("@r", role)
                insertCmd.Parameters.AddWithValue("@d", If(dosenId > 0, dosenId, DBNull.Value))
                insertCmd.ExecuteNonQuery()
            End Using
        Else
            Using updateCmd As New MySqlCommand(
                "UPDATE users SET role = @r, dosen_id = @d WHERE username = @u", connection)
                updateCmd.Parameters.AddWithValue("@r", role)
                updateCmd.Parameters.AddWithValue("@d", If(dosenId > 0, dosenId, DBNull.Value))
                updateCmd.Parameters.AddWithValue("@u", username)
                updateCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Private Sub EnsureCourseExists(connection As MySqlConnection, namaMk As String, ruang As String, dosenId As Integer)
        Dim exists As Integer
        Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM mata_kuliah WHERE nama = @n", connection)
            checkCmd.Parameters.AddWithValue("@n", namaMk)
            exists = Convert.ToInt32(checkCmd.ExecuteScalar())
        End Using

        If exists = 0 Then
            Using insertCmd As New MySqlCommand(
                "INSERT INTO mata_kuliah (nama, ruang, dosen_id) VALUES (@n, @r, @d)", connection)
                insertCmd.Parameters.AddWithValue("@n", namaMk)
                insertCmd.Parameters.AddWithValue("@r", ruang)
                insertCmd.Parameters.AddWithValue("@d", dosenId)
                insertCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Private Sub EnsureSampleEdomFeedback(connection As MySqlConnection)
        Dim count As Integer
        Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM edom_pengisian", connection)
            count = Convert.ToInt32(checkCmd.ExecuteScalar())
        End Using

        If count = 0 Then
            Dim mkIdWeb As Integer = 0
            Using cmd As New MySqlCommand("SELECT id FROM mata_kuliah WHERE nama = 'Pemrograman Web Lanjut' LIMIT 1", connection)
                Dim res = cmd.ExecuteScalar()
                If res IsNot Nothing AndAlso res IsNot DBNull.Value Then mkIdWeb = Convert.ToInt32(res)
            End Using

            If mkIdWeb > 0 Then
                Using insertCmd As New MySqlCommand(
                    "INSERT INTO edom_pengisian (username, mata_kuliah_id, skor_pedagogik, skor_profesional, skor_kepribadian, skor_sosial, nilai_rata_rata, saran) " &
                    "VALUES " &
                    "('2507411026', @id, 4.80, 4.90, 5.00, 4.70, 4.85, 'Penyampaian materi sangat interaktif dan mudah dipahami. Contoh coding langsung relevan dengan industri.'), " &
                    "('2507411001', @id, 4.50, 4.60, 4.70, 4.60, 4.60, 'Dosen sangat ramah dan sabar membimbing saat mahasiswa mengalami error saat praktikum.'), " &
                    "('2507411002', @id, 4.20, 4.40, 4.50, 4.30, 4.35, 'Modul dan slide presentasi lengkap, penjelasan tugas terstruktur dengan baik.')",
                    connection)
                    insertCmd.Parameters.AddWithValue("@id", mkIdWeb)
                    insertCmd.ExecuteNonQuery()
                End Using
            End If
        End If
    End Sub

    Private Sub SeedInitialCourses(connection As MySqlConnection)
        Dim seeds As (Nidn As String, Dosen As String, Matkul As String, Ruang As String)() = {
            ("0012038501", "Asep Taufik, M.Kom.", "Pemrograman Web Lanjut", "AA 301"),
            ("0015078802", "Risna Sari, M.Kom.", "Pemrograman Basis Data", "GSG 204"),
            ("0021098603", "Bagus Wijaya, M.Kom.", "Analisis Sistem", "PUT 301"),
            ("0005118004", "Dr. Hendra Pratama, M.T.", "Rekayasa Perangkat Lunak", "AA 205")
        }

        For Each s In seeds
            Dim dosenId As Integer
            Using cmd As New MySqlCommand("INSERT INTO dosen (nidn, nama) VALUES (@nidn, @nama) ON DUPLICATE KEY UPDATE nama = VALUES(nama)", connection)
                cmd.Parameters.AddWithValue("@nidn", s.Nidn)
                cmd.Parameters.AddWithValue("@nama", s.Dosen)
                cmd.ExecuteNonQuery()
                dosenId = Convert.ToInt32(cmd.LastInsertedId)
            End Using

            If dosenId = 0 Then
                Using getCmd As New MySqlCommand("SELECT id FROM dosen WHERE nama = @nama LIMIT 1", connection)
                    getCmd.Parameters.AddWithValue("@nama", s.Dosen)
                    dosenId = Convert.ToInt32(getCmd.ExecuteScalar())
                End Using
            End If

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

        ' Built-in dosen credentials fallback
        If (String.Equals(username, "dosen", StringComparison.OrdinalIgnoreCase) OrElse
            String.Equals(username, "0012038501", StringComparison.OrdinalIgnoreCase)) AndAlso
           password = "dosen123" Then
            Try
                Using conn As New MySqlConnection(ConnectionString)
                    conn.Open()
                    EnsureSchema(conn)
                End Using
            Catch
            End Try
            Return RoleDosen
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
                    Return "Struktur database belum diperbarui. Jalankan database\winforms_login.sql, lalu coba lagi."
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

    ' ---------- Dosen: Pengambilan Profil & Mata Kuliah ----------

    Public Function GetDosenByUsername(username As String) As DosenItem
        Dim item As DosenItem = Nothing

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            ' 1. Cek berdasarkan users.dosen_id
            Const queryUser As String =
                "SELECT d.id, d.nidn, d.nama " &
                "FROM dosen d " &
                "JOIN users u ON u.dosen_id = d.id " &
                "WHERE u.username = @u LIMIT 1"

            Using cmd As New MySqlCommand(queryUser, connection)
                cmd.Parameters.AddWithValue("@u", username)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        item = New DosenItem With {
                            .Id = reader.GetInt32("id"),
                            .Nidn = If(reader.IsDBNull(reader.GetOrdinal("nidn")), "", reader.GetString("nidn")),
                            .Nama = reader.GetString("nama")
                        }
                    End If
                End Using
            End Using

            If item IsNot Nothing Then Return item

            ' 2. Cek berdasarkan NIDN atau kesamaan nama dosen
            Const queryDosen As String =
                "SELECT id, nidn, nama FROM dosen " &
                "WHERE nidn = @u OR nama LIKE CONCAT('%', @u, '%') LIMIT 1"

            Using cmd As New MySqlCommand(queryDosen, connection)
                cmd.Parameters.AddWithValue("@u", username)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        item = New DosenItem With {
                            .Id = reader.GetInt32("id"),
                            .Nidn = If(reader.IsDBNull(reader.GetOrdinal("nidn")), "", reader.GetString("nidn")),
                            .Nama = reader.GetString("nama")
                        }
                    End If
                End Using
            End Using

            If item IsNot Nothing Then Return item

            ' 3. Fallback jika login via akun admin atau test dosen
            Const queryFirst As String = "SELECT id, nidn, nama FROM dosen ORDER BY id ASC LIMIT 1"
            Using cmd As New MySqlCommand(queryFirst, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        item = New DosenItem With {
                            .Id = reader.GetInt32("id"),
                            .Nidn = If(reader.IsDBNull(reader.GetOrdinal("nidn")), "", reader.GetString("nidn")),
                            .Nama = reader.GetString("nama")
                        }
                    End If
                End Using
            End Using
        End Using

        Return item
    End Function

    Public Function GetMataKuliahByDosen(dosenId As Integer) As List(Of MataKuliahItem)
        Const query As String =
            "SELECT mk.id, mk.nama, mk.ruang, mk.dosen_id, d.nama AS dosen " &
            "FROM mata_kuliah mk " &
            "JOIN dosen d ON d.id = mk.dosen_id " &
            "WHERE mk.dosen_id = @dosenId " &
            "ORDER BY mk.nama"

        Dim items As New List(Of MataKuliahItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@dosenId", dosenId)
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

    ' ---------- Dosen: Statistik Hasil Pengisian EDOM ----------

    Public Function GetStatistikEdomDosen(dosenId As Integer, Optional mataKuliahId As Integer? = Nothing) As DosenEdomStatistik
        Dim stats As New DosenEdomStatistik

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            ' Total Mahasiswa terdaftar
            Const totalMahasiswaQuery As String = "SELECT COUNT(*) FROM users WHERE role = 'mahasiswa'"
            Using cmd As New MySqlCommand(totalMahasiswaQuery, connection)
                Try
                    stats.TotalMahasiswa = Convert.ToInt32(cmd.ExecuteScalar())
                Catch
                    stats.TotalMahasiswa = 0
                End Try
            End Using

            ' Statistik per mata kuliah yang diampu dosen
            Const mkQuery As String =
                "SELECT mk.id, mk.nama, mk.ruang, " &
                "COUNT(p.username) AS sudah, " &
                "COALESCE(AVG(p.nilai_rata_rata), 0) AS avg_skor " &
                "FROM mata_kuliah mk " &
                "LEFT JOIN edom_pengisian p ON p.mata_kuliah_id = mk.id " &
                "WHERE mk.dosen_id = @dosenId " &
                "GROUP BY mk.id, mk.nama, mk.ruang " &
                "ORDER BY mk.nama"

            Using cmd As New MySqlCommand(mkQuery, connection)
                cmd.Parameters.AddWithValue("@dosenId", dosenId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim mkId As Integer = reader.GetInt32("id")
                        Dim mkNama As String = reader.GetString("nama")
                        Dim mkRuang As String = If(reader.IsDBNull(reader.GetOrdinal("ruang")), "-", reader.GetString("ruang"))
                        Dim sudah As Integer = Convert.ToInt32(reader("sudah"))
                        Dim avgSkor As Double = Convert.ToDouble(reader("avg_skor"))
                        Dim belum As Integer = Math.Max(0, stats.TotalMahasiswa - sudah)
                        Dim persen As Double = If(stats.TotalMahasiswa > 0, (CDbl(sudah) / stats.TotalMahasiswa) * 100, 0)

                        Dim status As String = "Belum Ada Pengisian"
                        If persen >= 75 Then
                            status = "Sangat Baik (Optimal)"
                        ElseIf persen >= 50 Then
                            status = "Cukup Baik"
                        ElseIf sudah > 0 Then
                            status = "Perlu Ditingkatkan"
                        End If

                        stats.PerMataKuliah.Add(New DosenMkStatistik With {
                            .Id = mkId,
                            .Nama = mkNama,
                            .Ruang = mkRuang,
                            .TotalMahasiswa = stats.TotalMahasiswa,
                            .Sudah = sudah,
                            .Belum = belum,
                            .Persentase = Math.Round(persen, 1),
                            .RataRataSkor = Math.Round(avgSkor, 2),
                            .Status = status
                        })
                    End While
                End Using
            End Using

            If mataKuliahId.HasValue AndAlso mataKuliahId.Value > 0 Then
                ' Filter spesifik 1 mata kuliah
                Dim selectedMk = stats.PerMataKuliah.FirstOrDefault(Function(m) m.Id = mataKuliahId.Value)
                If selectedMk IsNot Nothing Then
                    stats.SudahMengisi = selectedMk.Sudah
                    stats.BelumMengisi = selectedMk.Belum
                    stats.Persentase = selectedMk.Persentase
                End If

                Const avgScoreQuery As String =
                    "SELECT " &
                    "  COALESCE(AVG(nilai_rata_rata), 0) AS avg_total, " &
                    "  COALESCE(AVG(skor_pedagogik), 0) AS avg_pedagogik, " &
                    "  COALESCE(AVG(skor_profesional), 0) AS avg_profesional, " &
                    "  COALESCE(AVG(skor_kepribadian), 0) AS avg_kepribadian, " &
                    "  COALESCE(AVG(skor_sosial), 0) AS avg_sosial " &
                    "FROM edom_pengisian " &
                    "WHERE mata_kuliah_id = @mkId"

                Using cmd As New MySqlCommand(avgScoreQuery, connection)
                    cmd.Parameters.AddWithValue("@mkId", mataKuliahId.Value)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            stats.RataRataSkor = Math.Round(Convert.ToDouble(reader("avg_total")), 2)
                            stats.SkorPedagogik = Math.Round(Convert.ToDouble(reader("avg_pedagogik")), 2)
                            stats.SkorProfesional = Math.Round(Convert.ToDouble(reader("avg_profesional")), 2)
                            stats.SkorKepribadian = Math.Round(Convert.ToDouble(reader("avg_kepribadian")), 2)
                            stats.SkorSosial = Math.Round(Convert.ToDouble(reader("avg_sosial")), 2)
                        End If
                    End Using
                End Using

                Const feedbackQuery As String =
                    "SELECT p.id, p.username, mk.nama AS mata_kuliah, p.diisi_pada, " &
                    "COALESCE(p.nilai_rata_rata, 0) AS nilai_rata_rata, " &
                    "COALESCE(p.skor_pedagogik, 0) AS skor_pedagogik, " &
                    "COALESCE(p.skor_profesional, 0) AS skor_profesional, " &
                    "COALESCE(p.skor_kepribadian, 0) AS skor_kepribadian, " &
                    "COALESCE(p.skor_sosial, 0) AS skor_sosial, " &
                    "p.saran " &
                    "FROM edom_pengisian p " &
                    "JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
                    "WHERE p.mata_kuliah_id = @mkId " &
                    "ORDER BY p.diisi_pada DESC"

                Using cmd As New MySqlCommand(feedbackQuery, connection)
                    cmd.Parameters.AddWithValue("@mkId", mataKuliahId.Value)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            stats.DaftarFeedback.Add(New EdomFeedbackItem With {
                                .Id = reader.GetInt32("id"),
                                .Username = reader.GetString("username"),
                                .MataKuliah = reader.GetString("mata_kuliah"),
                                .DiisiPada = reader.GetDateTime("diisi_pada"),
                                .NilaiRataRata = Math.Round(Convert.ToDouble(reader("nilai_rata_rata")), 2),
                                .SkorPedagogik = Math.Round(Convert.ToDouble(reader("skor_pedagogik")), 2),
                                .SkorProfesional = Math.Round(Convert.ToDouble(reader("skor_profesional")), 2),
                                .SkorKepribadian = Math.Round(Convert.ToDouble(reader("skor_kepribadian")), 2),
                                .SkorSosial = Math.Round(Convert.ToDouble(reader("skor_sosial")), 2),
                                .Saran = If(reader.IsDBNull(reader.GetOrdinal("saran")), "", reader.GetString("saran"))
                            })
                        End While
                    End Using
                End Using
            Else
                ' Agregasi semua mata kuliah yang diajar dosen ini
                Dim totalTarget As Integer = stats.TotalMahasiswa * stats.PerMataKuliah.Count
                Dim totalSudah As Integer = stats.PerMataKuliah.Sum(Function(m) m.Sudah)
                stats.SudahMengisi = totalSudah
                stats.BelumMengisi = Math.Max(0, totalTarget - totalSudah)
                stats.Persentase = If(totalTarget > 0, Math.Round((CDbl(totalSudah) / totalTarget) * 100, 1), 0)

                Const avgAllScoreQuery As String =
                    "SELECT " &
                    "  COALESCE(AVG(p.nilai_rata_rata), 0) AS avg_total, " &
                    "  COALESCE(AVG(p.skor_pedagogik), 0) AS avg_pedagogik, " &
                    "  COALESCE(AVG(p.skor_profesional), 0) AS avg_profesional, " &
                    "  COALESCE(AVG(p.skor_kepribadian), 0) AS avg_kepribadian, " &
                    "  COALESCE(AVG(p.skor_sosial), 0) AS avg_sosial " &
                    "FROM edom_pengisian p " &
                    "JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
                    "WHERE mk.dosen_id = @dosenId"

                Using cmd As New MySqlCommand(avgAllScoreQuery, connection)
                    cmd.Parameters.AddWithValue("@dosenId", dosenId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            stats.RataRataSkor = Math.Round(Convert.ToDouble(reader("avg_total")), 2)
                            stats.SkorPedagogik = Math.Round(Convert.ToDouble(reader("avg_pedagogik")), 2)
                            stats.SkorProfesional = Math.Round(Convert.ToDouble(reader("avg_profesional")), 2)
                            stats.SkorKepribadian = Math.Round(Convert.ToDouble(reader("avg_kepribadian")), 2)
                            stats.SkorSosial = Math.Round(Convert.ToDouble(reader("avg_sosial")), 2)
                        End If
                    End Using
                End Using

                Const feedbackAllQuery As String =
                    "SELECT p.id, p.username, mk.nama AS mata_kuliah, p.diisi_pada, " &
                    "COALESCE(p.nilai_rata_rata, 0) AS nilai_rata_rata, " &
                    "COALESCE(p.skor_pedagogik, 0) AS skor_pedagogik, " &
                    "COALESCE(p.skor_profesional, 0) AS skor_profesional, " &
                    "COALESCE(p.skor_kepribadian, 0) AS skor_kepribadian, " &
                    "COALESCE(p.skor_sosial, 0) AS skor_sosial, " &
                    "p.saran " &
                    "FROM edom_pengisian p " &
                    "JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
                    "WHERE mk.dosen_id = @dosenId " &
                    "ORDER BY p.diisi_pada DESC"

                Using cmd As New MySqlCommand(feedbackAllQuery, connection)
                    cmd.Parameters.AddWithValue("@dosenId", dosenId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            stats.DaftarFeedback.Add(New EdomFeedbackItem With {
                                .Id = reader.GetInt32("id"),
                                .Username = reader.GetString("username"),
                                .MataKuliah = reader.GetString("mata_kuliah"),
                                .DiisiPada = reader.GetDateTime("diisi_pada"),
                                .NilaiRataRata = Math.Round(Convert.ToDouble(reader("nilai_rata_rata")), 2),
                                .SkorPedagogik = Math.Round(Convert.ToDouble(reader("skor_pedagogik")), 2),
                                .SkorProfesional = Math.Round(Convert.ToDouble(reader("skor_profesional")), 2),
                                .SkorKepribadian = Math.Round(Convert.ToDouble(reader("skor_kepribadian")), 2),
                                .SkorSosial = Math.Round(Convert.ToDouble(reader("skor_sosial")), 2),
                                .Saran = If(reader.IsDBNull(reader.GetOrdinal("saran")), "", reader.GetString("saran"))
                            })
                        End While
                    End Using
                End Using
            End If
        End Using

        Return stats
    End Function

    ' ---------- Mahasiswa: Pengisian EDOM & Fuzzy Tsukamoto ----------

    Public Function SimpanPengisianEdom(
        username As String,
        mataKuliahId As Integer,
        skorPedagogik As Double,
        skorProfesional As Double,
        skorKepribadian As Double,
        skorSosial As Double,
        nilaiAkhir As Double,
        saran As String
    ) As Boolean
        Const query As String =
            "INSERT INTO edom_pengisian (" &
            "  username, mata_kuliah_id, skor_pedagogik, skor_profesional, " &
            "  skor_kepribadian, skor_sosial, nilai_rata_rata, saran, diisi_pada" &
            ") VALUES (" &
            "  @u, @mk, @ped, @pro, @kep, @sos, @avg, @sar, CURRENT_TIMESTAMP" &
            ") ON DUPLICATE KEY UPDATE " &
            "  skor_pedagogik = VALUES(skor_pedagogik), " &
            "  skor_profesional = VALUES(skor_profesional), " &
            "  skor_kepribadian = VALUES(skor_kepribadian), " &
            "  skor_sosial = VALUES(skor_sosial), " &
            "  nilai_rata_rata = VALUES(nilai_rata_rata), " &
            "  saran = VALUES(saran), " &
            "  diisi_pada = CURRENT_TIMESTAMP"

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@mk", mataKuliahId)
                cmd.Parameters.AddWithValue("@ped", Math.Round(skorPedagogik, 2))
                cmd.Parameters.AddWithValue("@pro", Math.Round(skorProfesional, 2))
                cmd.Parameters.AddWithValue("@kep", Math.Round(skorKepribadian, 2))
                cmd.Parameters.AddWithValue("@sos", Math.Round(skorSosial, 2))
                cmd.Parameters.AddWithValue("@avg", Math.Round(nilaiAkhir, 2))
                cmd.Parameters.AddWithValue("@sar", If(String.IsNullOrWhiteSpace(saran), DBNull.Value, saran.Trim()))
                cmd.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Public Function GetStatusPengisianMahasiswa(username As String) As HashSet(Of Integer)
        Dim sudahDiisi As New HashSet(Of Integer)()

        Const query As String = "SELECT mata_kuliah_id FROM edom_pengisian WHERE username = @u"

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@u", username)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        sudahDiisi.Add(reader.GetInt32("mata_kuliah_id"))
                    End While
                End Using
            End Using
        End Using

        Return sudahDiisi
    End Function

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
        Return If(String.IsNullOrWhiteSpace(Nidn), Nama, $"{Nama} ({Nidn})")
    End Function
End Class

Public Class MataKuliahItem
    Public Property Id As Integer
    Public Property Nama As String
    Public Property Ruang As String
    Public Property DosenId As Integer
    Public Property DosenNama As String

    Public Overrides Function ToString() As String
        Return If(String.IsNullOrWhiteSpace(Ruang), Nama, $"{Nama} ({Ruang})")
    End Function
End Class

Public Class DosenMkStatistik
    Public Property Id As Integer
    Public Property Nama As String
    Public Property Ruang As String
    Public Property TotalMahasiswa As Integer
    Public Property Sudah As Integer
    Public Property Belum As Integer
    Public Property Persentase As Double
    Public Property RataRataSkor As Double
    Public Property Status As String
End Class

Public Class EdomFeedbackItem
    Public Property Id As Integer
    Public Property Username As String
    Public Property MataKuliah As String
    Public Property DiisiPada As DateTime
    Public Property NilaiRataRata As Double
    Public Property SkorPedagogik As Double
    Public Property SkorProfesional As Double
    Public Property SkorKepribadian As Double
    Public Property SkorSosial As Double
    Public Property Saran As String
End Class

Public Class DosenEdomStatistik
    Public Property TotalMahasiswa As Integer
    Public Property SudahMengisi As Integer
    Public Property BelumMengisi As Integer
    Public Property Persentase As Double
    Public Property RataRataSkor As Double
    Public Property SkorPedagogik As Double
    Public Property SkorProfesional As Double
    Public Property SkorKepribadian As Double
    Public Property SkorSosial As Double
    Public Property PerMataKuliah As New List(Of DosenMkStatistik)
    Public Property DaftarFeedback As New List(Of EdomFeedbackItem)
End Class