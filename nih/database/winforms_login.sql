-- Skema untuk database yang dipakai aplikasi (DatabaseHelper.vb -> winforms_login).
-- Catatan: DatabaseHelper.vb sekarang juga otomatis membuat kolom & tabel ini saat login,
-- namun file ini tetap bisa dijalankan manual di HeidiSQL / phpMyAdmin Laragon.

CREATE DATABASE IF NOT EXISTS winforms_login
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE winforms_login;

CREATE TABLE IF NOT EXISTS users (
    id       INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50)  NOT NULL,
    password VARCHAR(255) NOT NULL,
    role     ENUM('mahasiswa', 'admin') NOT NULL DEFAULT 'mahasiswa'
);

-- Tambahkan kolom role jika tabel users lama belum memilikinya:
ALTER TABLE users
    ADD COLUMN role ENUM('mahasiswa', 'admin') NOT NULL DEFAULT 'mahasiswa';

-- Akun contoh Mahasiswa (username: 2507411026, password: 12345)
INSERT INTO users (username, password, role)
SELECT '2507411026', '12345', 'mahasiswa'
WHERE NOT EXISTS (SELECT 1 FROM users WHERE username = '2507411026');

-- Akun contoh Admin (username: admin, password: admin123)
INSERT INTO users (username, password, role)
SELECT 'admin', 'admin123', 'admin'
WHERE NOT EXISTS (SELECT 1 FROM users WHERE username = 'admin');

-- Tabel Dosen dan Mata Kuliah
CREATE TABLE IF NOT EXISTS dosen (
    id    INT AUTO_INCREMENT PRIMARY KEY,
    nidn  VARCHAR(20)  NULL UNIQUE,
    nama  VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS mata_kuliah (
    id        INT AUTO_INCREMENT PRIMARY KEY,
    nama      VARCHAR(100) NOT NULL,
    ruang     VARCHAR(20)  NULL,
    dosen_id  INT NOT NULL,
    CONSTRAINT fk_mata_kuliah_dosen
        FOREIGN KEY (dosen_id) REFERENCES dosen (id) ON DELETE RESTRICT
);

CREATE TABLE IF NOT EXISTS edom_pengisian (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    username        VARCHAR(50) NOT NULL,
    mata_kuliah_id  INT NOT NULL,
    diisi_pada      TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UNIQUE KEY uq_pengisian (username, mata_kuliah_id),
    CONSTRAINT fk_pengisian_mata_kuliah
        FOREIGN KEY (mata_kuliah_id) REFERENCES mata_kuliah (id) ON DELETE CASCADE
);
