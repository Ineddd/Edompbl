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
    Private databaseEnsured As Boolean

    ' Membuat database (mis. winforms_login) jika belum ada, supaya aplikasi bisa langsung
    ' dijalankan di MySQL/XAMPP/Laragon yang masih kosong tanpa import SQL manual.
    Private Sub EnsureDatabaseExists()
        If databaseEnsured Then Return

        Dim builder As New MySqlConnectionStringBuilder(ConnectionString)
        Dim databaseName As String = builder.Database
        If String.IsNullOrWhiteSpace(databaseName) Then
            databaseEnsured = True
            Return
        End If

        builder.Database = ""
        Using connection As New MySqlConnection(builder.ConnectionString)
            connection.Open()
            Dim safeName As String = databaseName.Replace("`", "``")
            Using cmd As New MySqlCommand(
                $"CREATE DATABASE IF NOT EXISTS `{safeName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci",
                connection)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        databaseEnsured = True
    End Sub

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

        Try
            EnsureInstrumenEdom(connection)
        Catch
        End Try

        schemaInitialized = True
    End Sub

    ' ---------- Instrumen EDOM (butir pertanyaan & jawaban per butir) ----------

    Public Const KompetensiPedagogik As String = "pedagogik"
    Public Const KompetensiProfesional As String = "profesional"
    Public Const KompetensiKepribadian As String = "kepribadian"
    Public Const KompetensiSosial As String = "sosial"

    ' Butir sesuai INSTRUMEN EDOM 2023 (skala 1-5).
    Private ReadOnly InstrumenEdom2023 As (Nomor As Integer, Kompetensi As String, Pertanyaan As String)() = {
        (1, KompetensiPedagogik, "Kesiapan memberikan kuliah dan/atau praktek/praktikum"),
        (2, KompetensiPedagogik, "Keteraturan dan ketertiban penyelenggaraan perkuliahan"),
        (3, KompetensiPedagogik, "Kemampuan menghidupkan suasana kelas"),
        (4, KompetensiPedagogik, "Kejelasan penyampaian materi dan jawaban terhadap pertanyaan di kelas"),
        (5, KompetensiPedagogik, "Pemanfaatan media dan teknologi pembelajaran"),
        (6, KompetensiPedagogik, "Keanekaragaman cara pengukuran/penilaian hasil belajar"),
        (7, KompetensiPedagogik, "Pemberian umpan balik terhadap tugas/penilaian"),
        (8, KompetensiPedagogik, "Kesesuaian materi ujian dan/atau tugas dengan tujuan mata kuliah"),
        (9, KompetensiPedagogik, "Kesesuaian nilai yang diberikan dengan hasil belajar"),
        (10, KompetensiProfesional, "Kemampuan menjelaskan pokok bahasan/topik secara tepat sesuai Garis-garis Besar Pengajaran (GBPP) dan Satuan Acara Pengajaran (SAP)"),
        (11, KompetensiProfesional, "Kemampuan memberi contoh relevan dari konsep yang diajarkan berdasarkan Program Studi"),
        (12, KompetensiProfesional, "Kemampuan menjelaskan keterkaitan bidang/topik yang diajarkan dengan bidang/topik lain"),
        (13, KompetensiProfesional, "Kemampuan menjelaskan keterkaitan bidang/topik yang diajarkan dengan konteks kehidupan"),
        (14, KompetensiProfesional, "Penguasaan akan isu-isu mutakhir dalam bidang yang diajarkan (kemutakhiran bahan/referensi kuliah)"),
        (15, KompetensiProfesional, "Penggunaan hasil-hasil penelitian untuk meningkatkan kualitas perkuliahan"),
        (16, KompetensiProfesional, "Pelibatan mahasiswa dalam penelitian/kajian dan atau pengembangan/rekayasa/desain yang dilakukan dosen"),
        (17, KompetensiProfesional, "Kemampuan menggunakan beragam teknologi komunikasi"),
        (18, KompetensiKepribadian, "Kewibawaan sebagai pribadi dosen"),
        (19, KompetensiKepribadian, "Kearifan dalam mengambil keputusan"),
        (20, KompetensiKepribadian, "Menjadi contoh dalam bersikap dan berperilaku"),
        (21, KompetensiKepribadian, "Satu kata dan tindakan"),
        (22, KompetensiKepribadian, "Kemampuan mengendalikan diri dalam berbagai situasi dan kondisi"),
        (23, KompetensiKepribadian, "Adil dalam memperlakukan mahasiswa"),
        (24, KompetensiSosial, "Kemampuan menyampaikan pendapat"),
        (25, KompetensiSosial, "Kemampuan menerima kritik, saran, dan pendapat dari mahasiswa"),
        (26, KompetensiSosial, "Mengenal dengan baik mahasiswa yang mengikuti kuliahnya"),
        (27, KompetensiSosial, "Toleransi terhadap keberagaman mahasiswa")
    }

    Public Function JudulKompetensi(kompetensi As String) As String
        Select Case If(kompetensi, "").Trim().ToLowerInvariant()
            Case KompetensiPedagogik : Return "A. Kompetensi Pedagogik"
            Case KompetensiProfesional : Return "B. Kompetensi Profesional"
            Case KompetensiKepribadian : Return "C. Kompetensi Kepribadian"
            Case KompetensiSosial : Return "D. Kompetensi Sosial"
            Case Else : Return "Kompetensi Lainnya"
        End Select
    End Function

    Private Sub EnsureInstrumenEdom(connection As MySqlConnection)
        Using cmd As New MySqlCommand(
            "CREATE TABLE IF NOT EXISTS edom_pertanyaan (" &
            "  id INT AUTO_INCREMENT PRIMARY KEY," &
            "  nomor INT NOT NULL," &
            "  kompetensi VARCHAR(20) NOT NULL," &
            "  pertanyaan VARCHAR(255) NOT NULL," &
            "  aktif TINYINT(1) NOT NULL DEFAULT 1," &
            "  UNIQUE KEY uq_pertanyaan_nomor (nomor)" &
            ")", connection)
            cmd.ExecuteNonQuery()
        End Using

        ' Tipe kolom FK harus sama persis dengan kolom induknya. Tabel induk bisa dibuat oleh
        ' aplikasi (INT) atau oleh database\winforms_login.sql (INT UNSIGNED), jadi dicek dulu.
        Dim pengisianIdType As String = GetIntColumnType(connection, "edom_pengisian", "id")
        Dim pertanyaanIdType As String = GetIntColumnType(connection, "edom_pertanyaan", "id")

        Dim kolomJawaban As String =
            "  id INT AUTO_INCREMENT PRIMARY KEY," &
            $"  pengisian_id {pengisianIdType} NOT NULL," &
            $"  pertanyaan_id {pertanyaanIdType} NOT NULL," &
            "  nilai TINYINT NOT NULL," &
            "  UNIQUE KEY uq_jawaban (pengisian_id, pertanyaan_id)"

        Try
            Using cmd As New MySqlCommand(
                "CREATE TABLE IF NOT EXISTS edom_jawaban (" & kolomJawaban & "," &
                "  CONSTRAINT fk_jawaban_pengisian FOREIGN KEY (pengisian_id) REFERENCES edom_pengisian (id) ON DELETE CASCADE," &
                "  CONSTRAINT fk_jawaban_pertanyaan FOREIGN KEY (pertanyaan_id) REFERENCES edom_pertanyaan (id) ON DELETE CASCADE" &
                ")", connection)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            ' Database lama yang tidak mendukung FK tetap bisa dipakai; penghapusan jawaban
            ' juga dilakukan manual di DeleteDosen/DeleteMataKuliah.
            Using cmd As New MySqlCommand("CREATE TABLE IF NOT EXISTS edom_jawaban (" & kolomJawaban & ")", connection)
                cmd.ExecuteNonQuery()
            End Using
        End Try

        Dim jumlahPertanyaan As Integer
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM edom_pertanyaan", connection)
            jumlahPertanyaan = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        If jumlahPertanyaan = 0 Then
            Using cmd As New MySqlCommand(
                "INSERT IGNORE INTO edom_pertanyaan (nomor, kompetensi, pertanyaan) VALUES (@n, @k, @p)", connection)
                cmd.Parameters.Add("@n", MySqlDbType.Int32)
                cmd.Parameters.Add("@k", MySqlDbType.VarChar)
                cmd.Parameters.Add("@p", MySqlDbType.VarChar)

                For Each butir In InstrumenEdom2023
                    cmd.Parameters("@n").Value = butir.Nomor
                    cmd.Parameters("@k").Value = butir.Kompetensi
                    cmd.Parameters("@p").Value = butir.Pertanyaan
                    cmd.ExecuteNonQuery()
                Next
            End Using
        End If
    End Sub

    Private Function GetIntColumnType(connection As MySqlConnection, table As String, column As String) As String
        Using cmd As New MySqlCommand(
            "SELECT COLUMN_TYPE FROM information_schema.COLUMNS " &
            "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @t AND COLUMN_NAME = @c", connection)
            cmd.Parameters.AddWithValue("@t", table)
            cmd.Parameters.AddWithValue("@c", column)
            Dim res As Object = cmd.ExecuteScalar()
            Dim columnType As String = If(res Is Nothing OrElse res Is DBNull.Value, "", res.ToString())
            Return If(columnType.IndexOf("unsigned", StringComparison.OrdinalIgnoreCase) >= 0, "INT UNSIGNED", "INT")
        End Using
    End Function

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
        ' Login selalu menjadi akses database pertama, jadi database dipastikan ada di sini.
        ' Kegagalan di sini (MySQL mati, tidak punya hak CREATE DATABASE) diabaikan; koneksi
        ' di bawah akan memunculkan error yang sama dan diterjemahkan oleh DescribeError.
        Try
            EnsureDatabaseExists()
        Catch ex As MySqlException
        End Try

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
        If sqlEx Is Nothing AndAlso ex.InnerException IsNot Nothing Then
            sqlEx = TryCast(ex.InnerException, MySqlException)
        End If

        If sqlEx IsNot Nothing Then
            Select Case sqlEx.Number
                Case 1054, 1146
                    Return "Struktur database belum diperbarui. Jalankan database\winforms_login.sql, lalu coba lagi."
                Case 1049
                    Return "Database winforms_login belum dibuat di MySQL."
                Case 1045
                    Return "MySQL menolak login. Periksa user dan password di DatabaseHelper.vb."
                Case 1451, 1217
                    Return "Data ini masih memiliki relasi aktif di database dan tidak dapat dihapus."
                Case 1062
                    Return "Data dengan identitas tersebut (NIM/NIDN/Username) sudah ada di database (duplikat)."
                Case Else
                    Return $"Kesalahan database (kode {sqlEx.Number}): {sqlEx.Message}"
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
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Dim nidn As String = Nothing
            Using getCmd As New MySqlCommand("SELECT nidn FROM dosen WHERE id = @id", connection)
                getCmd.Parameters.AddWithValue("@id", id)
                Dim res As Object = getCmd.ExecuteScalar()
                If res IsNot Nothing AndAlso res IsNot DBNull.Value Then
                    nidn = res.ToString().Trim()
                End If
            End Using

            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    ' 1. Unlink dosen_id pada tabel users agar tidak melanggar foreign key
                    Using cmd As New MySqlCommand("UPDATE users SET dosen_id = NULL WHERE dosen_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Jika ada akun user khusus untuk dosen ini, hapus juga akunnya
                    If Not String.IsNullOrWhiteSpace(nidn) Then
                        Using cmd As New MySqlCommand("DELETE FROM users WHERE username = @nidn AND role = 'dosen'", connection, transaction)
                            cmd.Parameters.AddWithValue("@nidn", nidn)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' 2. Hapus jawaban per butir lalu data evaluasi edom_pengisian untuk seluruh mata kuliah yang diampu dosen ini
                    Using cmd As New MySqlCommand(
                        "DELETE j FROM edom_jawaban j " &
                        "JOIN edom_pengisian p ON p.id = j.pengisian_id " &
                        "JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
                        "WHERE mk.dosen_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand(
                        "DELETE p FROM edom_pengisian p " &
                        "JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
                        "WHERE mk.dosen_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 3. Hapus seluruh mata kuliah yang diampu dosen ini
                    Using cmd As New MySqlCommand("DELETE FROM mata_kuliah WHERE dosen_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 4. Hapus dosen dari tabel dosen
                    Using cmd As New MySqlCommand("DELETE FROM dosen WHERE id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                Catch
                    transaction.Rollback()
                    Throw
                End Try
            End Using
        End Using
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
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    ' 1. Hapus jawaban per butir dan data pengisian EDOM terkait mata kuliah ini
                    Using cmd As New MySqlCommand(
                        "DELETE j FROM edom_jawaban j " &
                        "JOIN edom_pengisian p ON p.id = j.pengisian_id " &
                        "WHERE p.mata_kuliah_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand("DELETE FROM edom_pengisian WHERE mata_kuliah_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 2. Hapus mata kuliah
                    Using cmd As New MySqlCommand("DELETE FROM mata_kuliah WHERE id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                Catch
                    transaction.Rollback()
                    Throw
                End Try
            End Using
        End Using
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

    ' Rata-rata nilai setiap butir instrumen untuk seorang dosen. mataKuliahId kosong/0 = semua mata kuliah dosen.
    ' Hanya pengisian yang memiliki jawaban per butir (edom_jawaban) yang ikut dihitung.
    Public Function GetRataRataPerButir(dosenId As Integer, Optional mataKuliahId As Integer? = Nothing) As List(Of RataRataButirItem)
        Const query As String =
            "SELECT q.id, q.nomor, q.kompetensi, q.pertanyaan, " &
            "  COUNT(x.nilai) AS responden, " &
            "  COALESCE(AVG(x.nilai), 0) AS rata_rata " &
            "FROM edom_pertanyaan q " &
            "LEFT JOIN (" &
            "  SELECT j.pertanyaan_id, j.nilai " &
            "  FROM edom_jawaban j " &
            "  JOIN edom_pengisian p ON p.id = j.pengisian_id " &
            "  JOIN mata_kuliah mk ON mk.id = p.mata_kuliah_id " &
            "  WHERE mk.dosen_id = @dosenId AND (@mkId = 0 OR mk.id = @mkId)" &
            ") x ON x.pertanyaan_id = q.id " &
            "WHERE q.aktif = 1 " &
            "GROUP BY q.id, q.nomor, q.kompetensi, q.pertanyaan " &
            "ORDER BY q.nomor"

        Dim items As New List(Of RataRataButirItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@dosenId", dosenId)
                command.Parameters.AddWithValue("@mkId", If(mataKuliahId.HasValue, mataKuliahId.Value, 0))
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        items.Add(New RataRataButirItem With {
                            .PertanyaanId = Convert.ToInt32(reader("id")),
                            .Nomor = Convert.ToInt32(reader("nomor")),
                            .Kompetensi = reader.GetString("kompetensi"),
                            .Pertanyaan = reader.GetString("pertanyaan"),
                            .Responden = Convert.ToInt32(reader("responden")),
                            .RataRata = Math.Round(Convert.ToDouble(reader("rata_rata")), 2)
                        })
                    End While
                End Using
            End Using
        End Using

        Return items
    End Function

    ' ---------- Mahasiswa: Pengisian EDOM ----------

    Public Function GetEdomMahasiswa(username As String) As List(Of EdomMahasiswaItem)
        Const query As String =
            "SELECT " &
            "  d.id AS dosen_id, " &
            "  d.nama AS dosen_nama, " &
            "  COALESCE(d.nidn, '') AS dosen_nidn, " &
            "  mk.id AS mata_kuliah_id, " &
            "  mk.nama AS mata_kuliah_nama, " &
            "  COALESCE(mk.ruang, '') AS ruang, " &
            "  p.id AS pengisian_id, " &
            "  COALESCE(p.nilai_rata_rata, 0) AS nilai_rata_rata, " &
            "  COALESCE(p.skor_pedagogik, 0) AS skor_pedagogik, " &
            "  COALESCE(p.skor_profesional, 0) AS skor_profesional, " &
            "  COALESCE(p.skor_kepribadian, 0) AS skor_kepribadian, " &
            "  COALESCE(p.skor_sosial, 0) AS skor_sosial, " &
            "  p.diisi_pada, " &
            "  p.saran " &
            "FROM dosen d " &
            "LEFT JOIN mata_kuliah mk ON mk.dosen_id = d.id " &
            "LEFT JOIN edom_pengisian p ON p.mata_kuliah_id = mk.id AND p.username = @username " &
            "ORDER BY d.nama ASC, mk.nama ASC"

        Dim items As New List(Of EdomMahasiswaItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim item As New EdomMahasiswaItem With {
                            .DosenId = reader.GetInt32("dosen_id"),
                            .DosenNama = reader.GetString("dosen_nama"),
                            .DosenNidn = reader.GetString("dosen_nidn"),
                            .SudahDievaluasi = Not reader.IsDBNull(reader.GetOrdinal("pengisian_id"))
                        }

                        If Not reader.IsDBNull(reader.GetOrdinal("mata_kuliah_id")) Then
                            item.MataKuliahId = reader.GetInt32("mata_kuliah_id")
                            item.MataKuliahNama = reader.GetString("mata_kuliah_nama")
                            item.Ruang = reader.GetString("ruang")
                        End If

                        If item.SudahDievaluasi Then
                            item.NilaiRataRata = Convert.ToDouble(reader("nilai_rata_rata"))
                            item.SkorPedagogik = Convert.ToDouble(reader("skor_pedagogik"))
                            item.SkorProfesional = Convert.ToDouble(reader("skor_profesional"))
                            item.SkorKepribadian = Convert.ToDouble(reader("skor_kepribadian"))
                            item.SkorSosial = Convert.ToDouble(reader("skor_sosial"))
                            If Not reader.IsDBNull(reader.GetOrdinal("diisi_pada")) Then
                                item.DiisiPada = reader.GetDateTime("diisi_pada")
                            End If
                            item.Saran = If(reader.IsDBNull(reader.GetOrdinal("saran")), "", reader.GetString("saran"))
                        End If

                        items.Add(item)
                    End While
                End Using
            End Using
        End Using

        Return items
    End Function

    ' Butir pertanyaan aktif, urut sesuai nomor di instrumen.
    Public Function GetPertanyaanEdom() As List(Of PertanyaanEdomItem)
        Const query As String =
            "SELECT id, nomor, kompetensi, pertanyaan " &
            "FROM edom_pertanyaan " &
            "WHERE aktif = 1 " &
            "ORDER BY nomor"

        Dim items As New List(Of PertanyaanEdomItem)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        items.Add(New PertanyaanEdomItem With {
                            .Id = Convert.ToInt32(reader("id")),
                            .Nomor = Convert.ToInt32(reader("nomor")),
                            .Kompetensi = reader.GetString("kompetensi"),
                            .Pertanyaan = reader.GetString("pertanyaan")
                        })
                    End While
                End Using
            End Using
        End Using

        Return items
    End Function

    ' Jawaban mahasiswa sebelumnya untuk satu mata kuliah: pertanyaan_id -> nilai (1-5).
    Public Function GetJawabanEdom(username As String, mataKuliahId As Integer) As Dictionary(Of Integer, Integer)
        Const query As String =
            "SELECT j.pertanyaan_id, j.nilai " &
            "FROM edom_jawaban j " &
            "JOIN edom_pengisian p ON p.id = j.pengisian_id " &
            "WHERE p.username = @u AND p.mata_kuliah_id = @mkId"

        Dim jawaban As New Dictionary(Of Integer, Integer)

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@u", username)
                command.Parameters.AddWithValue("@mkId", mataKuliahId)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        jawaban(Convert.ToInt32(reader("pertanyaan_id"))) = Convert.ToInt32(reader("nilai"))
                    End While
                End Using
            End Using
        End Using

        Return jawaban
    End Function

    ' Menyimpan nilai setiap butir ke edom_jawaban, lalu merangkumnya ke edom_pengisian
    ' (rata-rata per kompetensi + rata-rata seluruh butir) agar dashboard dosen tetap bekerja.
    Public Sub SimpanPengisianEdom(
        username As String,
        mataKuliahId As Integer,
        jawaban As IReadOnlyDictionary(Of Integer, Integer),
        saran As String
    )
        If jawaban Is Nothing OrElse jawaban.Count = 0 Then
            Throw New ArgumentException("Belum ada butir yang dinilai.", NameOf(jawaban))
        End If

        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            EnsureSchema(connection)

            Dim kompetensiPerPertanyaan As New Dictionary(Of Integer, String)
            Using cmd As New MySqlCommand("SELECT id, kompetensi FROM edom_pertanyaan", connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        kompetensiPerPertanyaan(Convert.ToInt32(reader("id"))) = reader.GetString("kompetensi").Trim().ToLowerInvariant()
                    End While
                End Using
            End Using

            Dim nilaiPerKompetensi As New Dictionary(Of String, List(Of Integer))
            For Each kv In jawaban
                If kv.Value < 1 OrElse kv.Value > 5 Then
                    Throw New ArgumentOutOfRangeException(NameOf(jawaban), $"Nilai butir harus 1-5 (didapat {kv.Value}).")
                End If

                Dim kompetensi As String = Nothing
                If Not kompetensiPerPertanyaan.TryGetValue(kv.Key, kompetensi) Then
                    Throw New ArgumentException($"Butir pertanyaan dengan id {kv.Key} tidak ada di database.", NameOf(jawaban))
                End If

                If Not nilaiPerKompetensi.ContainsKey(kompetensi) Then
                    nilaiPerKompetensi(kompetensi) = New List(Of Integer)
                End If
                nilaiPerKompetensi(kompetensi).Add(kv.Value)
            Next

            Dim rataRata As Double = Math.Round(jawaban.Values.Average(), 2)

            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    Using cmd As New MySqlCommand(
                        "INSERT INTO edom_pengisian (" &
                        "  username, mata_kuliah_id, skor_pedagogik, skor_profesional, skor_kepribadian, skor_sosial, nilai_rata_rata, saran, diisi_pada" &
                        ") VALUES (" &
                        "  @u, @mkId, @ped, @pro, @kep, @sos, @avg, @saran, NOW()" &
                        ") ON DUPLICATE KEY UPDATE " &
                        "  skor_pedagogik = VALUES(skor_pedagogik), " &
                        "  skor_profesional = VALUES(skor_profesional), " &
                        "  skor_kepribadian = VALUES(skor_kepribadian), " &
                        "  skor_sosial = VALUES(skor_sosial), " &
                        "  nilai_rata_rata = VALUES(nilai_rata_rata), " &
                        "  saran = VALUES(saran), " &
                        "  diisi_pada = VALUES(diisi_pada)", connection, transaction)
                        cmd.Parameters.AddWithValue("@u", username)
                        cmd.Parameters.AddWithValue("@mkId", mataKuliahId)
                        cmd.Parameters.AddWithValue("@ped", RataRataKompetensi(nilaiPerKompetensi, KompetensiPedagogik))
                        cmd.Parameters.AddWithValue("@pro", RataRataKompetensi(nilaiPerKompetensi, KompetensiProfesional))
                        cmd.Parameters.AddWithValue("@kep", RataRataKompetensi(nilaiPerKompetensi, KompetensiKepribadian))
                        cmd.Parameters.AddWithValue("@sos", RataRataKompetensi(nilaiPerKompetensi, KompetensiSosial))
                        cmd.Parameters.AddWithValue("@avg", rataRata)
                        cmd.Parameters.AddWithValue("@saran", NullIfEmpty(saran))
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim pengisianId As Long
                    Using cmd As New MySqlCommand(
                        "SELECT id FROM edom_pengisian WHERE username = @u AND mata_kuliah_id = @mkId", connection, transaction)
                        cmd.Parameters.AddWithValue("@u", username)
                        cmd.Parameters.AddWithValue("@mkId", mataKuliahId)
                        pengisianId = Convert.ToInt64(cmd.ExecuteScalar())
                    End Using

                    Using cmd As New MySqlCommand("DELETE FROM edom_jawaban WHERE pengisian_id = @id", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", pengisianId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand(
                        "INSERT INTO edom_jawaban (pengisian_id, pertanyaan_id, nilai) VALUES (@id, @q, @n)", connection, transaction)
                        cmd.Parameters.AddWithValue("@id", pengisianId)
                        cmd.Parameters.Add("@q", MySqlDbType.Int32)
                        cmd.Parameters.Add("@n", MySqlDbType.Int32)

                        For Each kv In jawaban
                            cmd.Parameters("@q").Value = kv.Key
                            cmd.Parameters("@n").Value = kv.Value
                            cmd.ExecuteNonQuery()
                        Next
                    End Using

                    transaction.Commit()
                Catch
                    transaction.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Function RataRataKompetensi(nilaiPerKompetensi As Dictionary(Of String, List(Of Integer)), kompetensi As String) As Object
        Dim nilai As List(Of Integer) = Nothing
        If nilaiPerKompetensi.TryGetValue(kompetensi, nilai) AndAlso nilai.Count > 0 Then
            Return Math.Round(nilai.Average(), 2)
        End If
        Return DBNull.Value
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

Public Class PertanyaanEdomItem
    Public Property Id As Integer
    Public Property Nomor As Integer
    Public Property Kompetensi As String
    Public Property Pertanyaan As String
End Class

Public Class RataRataButirItem
    Public Property PertanyaanId As Integer
    Public Property Nomor As Integer
    Public Property Kompetensi As String
    Public Property Pertanyaan As String
    Public Property Responden As Integer
    Public Property RataRata As Double
End Class

Public Class EdomMahasiswaItem
    Public Property DosenId As Integer
    Public Property DosenNama As String
    Public Property DosenNidn As String
    Public Property MataKuliahId As Integer?
    Public Property MataKuliahNama As String
    Public Property Ruang As String
    Public Property SudahDievaluasi As Boolean
    Public Property NilaiRataRata As Double
    Public Property SkorPedagogik As Double
    Public Property SkorProfesional As Double
    Public Property SkorKepribadian As Double
    Public Property SkorSosial As Double
    Public Property DiisiPada As DateTime?
    Public Property Saran As String
End Class