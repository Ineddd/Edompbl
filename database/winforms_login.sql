-- Database schema untuk project WinFormsApp1
-- Jalankan file ini melalui MySQL/Laragon/phpMyAdmin.

CREATE DATABASE IF NOT EXISTS `winforms_login`
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE `winforms_login`;

-- 1. Tabel Dosen
CREATE TABLE IF NOT EXISTS `dosen` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nidn` VARCHAR(20) NULL,
    `nama` VARCHAR(100) NOT NULL,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uq_dosen_nidn` (`nidn`)
) ENGINE=InnoDB;

-- 2. Tabel Users (Mendukung role mahasiswa, admin, dosen)
CREATE TABLE IF NOT EXISTS `users` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `username` VARCHAR(50) NOT NULL,
    `password` VARCHAR(255) NOT NULL,
    `role` ENUM('mahasiswa', 'admin', 'dosen') NOT NULL DEFAULT 'mahasiswa',
    `dosen_id` INT UNSIGNED NULL,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uq_users_username` (`username`),
    KEY `idx_users_dosen_id` (`dosen_id`),
    CONSTRAINT `fk_users_dosen`
        FOREIGN KEY (`dosen_id`) REFERENCES `dosen` (`id`)
        ON UPDATE CASCADE
        ON DELETE SET NULL
) ENGINE=InnoDB;

-- 3. Tabel Mata Kuliah
CREATE TABLE IF NOT EXISTS `mata_kuliah` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nama` VARCHAR(100) NOT NULL,
    `ruang` VARCHAR(20) NULL,
    `dosen_id` INT UNSIGNED NOT NULL,
    PRIMARY KEY (`id`),
    KEY `idx_mata_kuliah_dosen_id` (`dosen_id`),
    CONSTRAINT `fk_mata_kuliah_dosen`
        FOREIGN KEY (`dosen_id`) REFERENCES `dosen` (`id`)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
) ENGINE=InnoDB;

-- 4. Tabel Hasil Pengisian EDOM (Dengan data statistik & nilai evaluasi)
CREATE TABLE IF NOT EXISTS `edom_pengisian` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `username` VARCHAR(50) NOT NULL,
    `mata_kuliah_id` INT UNSIGNED NOT NULL,
    `skor_pedagogik` DECIMAL(3,2) NULL DEFAULT 4.50,
    `skor_profesional` DECIMAL(3,2) NULL DEFAULT 4.50,
    `skor_kepribadian` DECIMAL(3,2) NULL DEFAULT 4.50,
    `skor_sosial` DECIMAL(3,2) NULL DEFAULT 4.50,
    `nilai_rata_rata` DECIMAL(3,2) NULL DEFAULT 4.50,
    `saran` TEXT NULL,
    `diisi_pada` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uq_pengisian` (`username`, `mata_kuliah_id`),
    KEY `idx_pengisian_mata_kuliah_id` (`mata_kuliah_id`),
    CONSTRAINT `fk_pengisian_mata_kuliah`
        FOREIGN KEY (`mata_kuliah_id`) REFERENCES `mata_kuliah` (`id`)
        ON UPDATE CASCADE
        ON DELETE CASCADE
) ENGINE=InnoDB;

-- 5. Tabel Butir Pertanyaan EDOM (INSTRUMEN EDOM 2023, skala 1-5)
CREATE TABLE IF NOT EXISTS `edom_pertanyaan` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nomor` INT NOT NULL,
    `kompetensi` VARCHAR(20) NOT NULL COMMENT 'pedagogik | profesional | kepribadian | sosial',
    `pertanyaan` VARCHAR(255) NOT NULL,
    `aktif` TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uq_pertanyaan_nomor` (`nomor`)
) ENGINE=InnoDB;

-- 6. Tabel Jawaban per Butir (satu baris per butir per pengisian)
CREATE TABLE IF NOT EXISTS `edom_jawaban` (
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `pengisian_id` INT UNSIGNED NOT NULL,
    `pertanyaan_id` INT UNSIGNED NOT NULL,
    `nilai` TINYINT NOT NULL,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uq_jawaban` (`pengisian_id`, `pertanyaan_id`),
    KEY `idx_jawaban_pertanyaan_id` (`pertanyaan_id`),
    CONSTRAINT `fk_jawaban_pengisian`
        FOREIGN KEY (`pengisian_id`) REFERENCES `edom_pengisian` (`id`)
        ON DELETE CASCADE,
    CONSTRAINT `fk_jawaban_pertanyaan`
        FOREIGN KEY (`pertanyaan_id`) REFERENCES `edom_pertanyaan` (`id`)
        ON DELETE CASCADE
) ENGINE=InnoDB;

-- ============================================================================
-- SINTAKS MIGRASI: Jalankan jika tabel sudah ada sebelumnya di database
-- ============================================================================
ALTER TABLE `users` 
    MODIFY COLUMN `role` ENUM('mahasiswa', 'admin', 'dosen') NOT NULL DEFAULT 'mahasiswa';

-- ============================================================================
-- DATA AWAL DOSEN
-- ============================================================================
INSERT INTO `dosen` (`nidn`, `nama`)
VALUES
    ('0012038501', 'Asep Taufik, M.Kom.'),
    ('0015078802', 'Risna Sari, M.Kom.'),
    ('0021098603', 'Bagus Wijaya, M.Kom.'),
    ('0005118004', 'Dr. Hendra Pratama, M.T.')
ON DUPLICATE KEY UPDATE
    `nidn` = VALUES(`nidn`),
    `nama` = VALUES(`nama`);

-- ============================================================================
-- DATA MATA KULIAH (Setiap dosen memiliki mata kuliah yang diajar)
-- ============================================================================
-- Asep Taufik, M.Kom.
INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Pemrograman Web Lanjut', 'AA 301', `id`
FROM `dosen` WHERE `nama` = 'Asep Taufik, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Pemrograman Web Lanjut');

INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Pemrograman Berorientasi Objek', 'AA 304', `id`
FROM `dosen` WHERE `nama` = 'Asep Taufik, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Pemrograman Berorientasi Objek');

INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Workshop Aplikasi Enterprise', 'Lab RPL 1', `id`
FROM `dosen` WHERE `nama` = 'Asep Taufik, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Workshop Aplikasi Enterprise');

-- Risna Sari, M.Kom.
INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Pemrograman Basis Data', 'GSG 204', `id`
FROM `dosen` WHERE `nama` = 'Risna Sari, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Pemrograman Basis Data');

INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Administrasi Basis Data', 'GSG 205', `id`
FROM `dosen` WHERE `nama` = 'Risna Sari, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Administrasi Basis Data');

-- Bagus Wijaya, M.Kom.
INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Analisis Sistem', 'PUT 301', `id`
FROM `dosen` WHERE `nama` = 'Bagus Wijaya, M.Kom.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Analisis Sistem');

-- Dr. Hendra Pratama, M.T.
INSERT INTO `mata_kuliah` (`nama`, `ruang`, `dosen_id`)
SELECT 'Rekayasa Perangkat Lunak', 'AA 205', `id`
FROM `dosen` WHERE `nama` = 'Dr. Hendra Pratama, M.T.'
AND NOT EXISTS (SELECT 1 FROM `mata_kuliah` WHERE `nama` = 'Rekayasa Perangkat Lunak');

-- ============================================================================
-- BUTIR PERTANYAAN EDOM (sesuai INSTRUMEN EDOM 2023)
-- Skala: 1 (Sangat Kurang), 2 (Kurang), 3 (Cukup), 4 (Baik), 5 (Sangat Baik)
-- ============================================================================
INSERT INTO `edom_pertanyaan` (`nomor`, `kompetensi`, `pertanyaan`)
VALUES
    -- A. Kompetensi Pedagogik
    (1,  'pedagogik',   'Kesiapan memberikan kuliah dan/atau praktek/praktikum'),
    (2,  'pedagogik',   'Keteraturan dan ketertiban penyelenggaraan perkuliahan'),
    (3,  'pedagogik',   'Kemampuan menghidupkan suasana kelas'),
    (4,  'pedagogik',   'Kejelasan penyampaian materi dan jawaban terhadap pertanyaan di kelas'),
    (5,  'pedagogik',   'Pemanfaatan media dan teknologi pembelajaran'),
    (6,  'pedagogik',   'Keanekaragaman cara pengukuran/penilaian hasil belajar'),
    (7,  'pedagogik',   'Pemberian umpan balik terhadap tugas/penilaian'),
    (8,  'pedagogik',   'Kesesuaian materi ujian dan/atau tugas dengan tujuan mata kuliah'),
    (9,  'pedagogik',   'Kesesuaian nilai yang diberikan dengan hasil belajar'),
    -- B. Kompetensi Profesional
    (10, 'profesional', 'Kemampuan menjelaskan pokok bahasan/topik secara tepat sesuai Garis-garis Besar Pengajaran (GBPP) dan Satuan Acara Pengajaran (SAP)'),
    (11, 'profesional', 'Kemampuan memberi contoh relevan dari konsep yang diajarkan berdasarkan Program Studi'),
    (12, 'profesional', 'Kemampuan menjelaskan keterkaitan bidang/topik yang diajarkan dengan bidang/topik lain'),
    (13, 'profesional', 'Kemampuan menjelaskan keterkaitan bidang/topik yang diajarkan dengan konteks kehidupan'),
    (14, 'profesional', 'Penguasaan akan isu-isu mutakhir dalam bidang yang diajarkan (kemutakhiran bahan/referensi kuliah)'),
    (15, 'profesional', 'Penggunaan hasil-hasil penelitian untuk meningkatkan kualitas perkuliahan'),
    (16, 'profesional', 'Pelibatan mahasiswa dalam penelitian/kajian dan atau pengembangan/rekayasa/desain yang dilakukan dosen'),
    (17, 'profesional', 'Kemampuan menggunakan beragam teknologi komunikasi'),
    -- C. Kompetensi Kepribadian
    (18, 'kepribadian', 'Kewibawaan sebagai pribadi dosen'),
    (19, 'kepribadian', 'Kearifan dalam mengambil keputusan'),
    (20, 'kepribadian', 'Menjadi contoh dalam bersikap dan berperilaku'),
    (21, 'kepribadian', 'Satu kata dan tindakan'),
    (22, 'kepribadian', 'Kemampuan mengendalikan diri dalam berbagai situasi dan kondisi'),
    (23, 'kepribadian', 'Adil dalam memperlakukan mahasiswa'),
    -- D. Kompetensi Sosial
    (24, 'sosial',      'Kemampuan menyampaikan pendapat'),
    (25, 'sosial',      'Kemampuan menerima kritik, saran, dan pendapat dari mahasiswa'),
    (26, 'sosial',      'Mengenal dengan baik mahasiswa yang mengikuti kuliahnya'),
    (27, 'sosial',      'Toleransi terhadap keberagaman mahasiswa')
ON DUPLICATE KEY UPDATE
    `kompetensi` = VALUES(`kompetensi`),
    `pertanyaan` = VALUES(`pertanyaan`);

-- ============================================================================
-- DATA AKUN PENGGUNA (Admin, Mahasiswa, dan Dosen)
-- Password default: admin123 (admin), 12345 (mahasiswa), dosen123 (dosen)
-- ============================================================================
-- Akun Admin
INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
VALUES ('admin', 'admin123', 'admin', NULL)
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`);

-- Akun Mahasiswa
INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
VALUES
    ('2507411026', '12345', 'mahasiswa', NULL),
    ('2507411001', '12345', 'mahasiswa', NULL),
    ('2507411002', '12345', 'mahasiswa', NULL),
    ('2507411003', '12345', 'mahasiswa', NULL),
    ('2507411004', '12345', 'mahasiswa', NULL),
    ('2507411005', '12345', 'mahasiswa', NULL)
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`);

-- Akun Dosen (Bisa login via username 'dosen' atau NIDN masing-masing dosen)
INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
SELECT 'dosen', 'dosen123', 'dosen', `id`
FROM `dosen` WHERE `nama` = 'Asep Taufik, M.Kom.'
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`), `dosen_id` = VALUES(`dosen_id`);

INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
SELECT '0012038501', 'dosen123', 'dosen', `id`
FROM `dosen` WHERE `nama` = 'Asep Taufik, M.Kom.'
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`), `dosen_id` = VALUES(`dosen_id`);

INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
SELECT '0015078802', 'dosen123', 'dosen', `id`
FROM `dosen` WHERE `nama` = 'Risna Sari, M.Kom.'
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`), `dosen_id` = VALUES(`dosen_id`);

INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
SELECT '0021098603', 'dosen123', 'dosen', `id`
FROM `dosen` WHERE `nama` = 'Bagus Wijaya, M.Kom.'
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`), `dosen_id` = VALUES(`dosen_id`);

INSERT INTO `users` (`username`, `password`, `role`, `dosen_id`)
SELECT '0005118004', 'dosen123', 'dosen', `id`
FROM `dosen` WHERE `nama` = 'Dr. Hendra Pratama, M.T.'
ON DUPLICATE KEY UPDATE `role` = VALUES(`role`), `dosen_id` = VALUES(`dosen_id`);

-- ============================================================================
-- DATA HASIL PENGISIAN EDOM (Statistik & Evaluasi Mahasiswa)
-- ============================================================================
-- Evaluasi untuk Pemrograman Web Lanjut (Dosen: Asep Taufik, M.Kom.)
INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411026', mk.id, 4.80, 4.90, 5.00, 4.70, 4.85, 'Penyampaian materi sangat interaktif dan mudah dipahami. Contoh coding langsung relevan dengan industri.', NOW() - INTERVAL 5 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Web Lanjut'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411001', mk.id, 4.50, 4.60, 4.70, 4.60, 4.60, 'Dosen sangat ramah dan sabar membimbing saat mahasiswa mengalami error saat praktikum.', NOW() - INTERVAL 4 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Web Lanjut'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411002', mk.id, 4.20, 4.40, 4.50, 4.30, 4.35, 'Modul dan slide presentasi lengkap, penjelasan tugas terstruktur dengan baik.', NOW() - INTERVAL 3 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Web Lanjut'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411003', mk.id, 4.70, 4.80, 4.80, 4.70, 4.75, 'Waktu pembelajaran dimanfaatkan sangat efektif, materi selalu update.', NOW() - INTERVAL 2 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Web Lanjut'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411004', mk.id, 4.40, 4.50, 4.60, 4.50, 4.50, 'Sangat baik, mohon ditambahkan studi kasus integrasi API eksternal.', NOW() - INTERVAL 1 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Web Lanjut'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

-- Evaluasi untuk Pemrograman Berorientasi Objek (Dosen: Asep Taufik, M.Kom.)
INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411026', mk.id, 4.60, 4.70, 4.80, 4.50, 4.65, 'Konsep OOP seperti polymorphism dan encapsulation dijelaskan dengan analogi yang sangat mudah dimengerti.', NOW() - INTERVAL 3 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Berorientasi Objek'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411002', mk.id, 4.50, 4.60, 4.50, 4.60, 4.55, 'Tugas praktikum sangat melatih logika pemrograman berorientasi objek.', NOW() - INTERVAL 2 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Berorientasi Objek'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411005', mk.id, 4.70, 4.80, 4.90, 4.80, 4.80, 'Kuis dan feedback latihan selalu dibahas secara transparan di kelas.', NOW() - INTERVAL 1 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Berorientasi Objek'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

-- Evaluasi untuk Workshop Aplikasi Enterprise (Dosen: Asep Taufik, M.Kom.)
INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411026', mk.id, 4.80, 4.90, 4.80, 4.90, 4.85, 'Pengalaman proyek riil sangat berharga untuk persiapan magang dan tugas akhir.', NOW() - INTERVAL 2 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Workshop Aplikasi Enterprise'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411001', mk.id, 4.60, 4.70, 4.70, 4.60, 4.65, 'Bimbingan arsitektur software sangat detail.', NOW() - INTERVAL 1 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Workshop Aplikasi Enterprise'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

-- Evaluasi untuk Pemrograman Basis Data (Dosen: Risna Sari, M.Kom.)
INSERT INTO `edom_pengisian` (`username`, `mata_kuliah_id`, `skor_pedagogik`, `skor_profesional`, `skor_kepribadian`, `skor_sosial`, `nilai_rata_rata`, `saran`, `diisi_pada`)
SELECT '2507411026', mk.id, 4.70, 4.80, 4.60, 4.70, 4.70, 'Latihan query SQL dan normalisasi dijelaskan tahap demi tahap.', NOW() - INTERVAL 4 DAY
FROM `mata_kuliah` mk WHERE mk.nama = 'Pemrograman Basis Data'
ON DUPLICATE KEY UPDATE `nilai_rata_rata` = VALUES(`nilai_rata_rata`);

-- ============================================================================
-- VERIFIKASI SINTAKS & DATA
-- ============================================================================
SELECT * FROM `users`;
SELECT * FROM `dosen`;
SELECT mk.id, mk.nama, mk.ruang, d.nama AS dosen
FROM `mata_kuliah` mk
JOIN `dosen` d ON d.id = mk.dosen_id;
SELECT p.id, p.username, mk.nama AS mata_kuliah, p.nilai_rata_rata, p.saran, p.diisi_pada
FROM `edom_pengisian` p
JOIN `mata_kuliah` mk ON mk.id = p.mata_kuliah_id;
SELECT `nomor`, `kompetensi`, `pertanyaan` FROM `edom_pertanyaan` ORDER BY `nomor`;
