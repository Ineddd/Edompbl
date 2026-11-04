-- Jalankan di HeidiSQL / phpMyAdmin Laragon.
-- Akun contoh: NIM 2507411026, password 12345
-- password_hash = SHA-256 dari password, dalam Base64 (sesuai PasswordHasher.vb)

CREATE DATABASE IF NOT EXISTS edompbl
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE edompbl;

CREATE TABLE IF NOT EXISTS mahasiswa (
    id            INT AUTO_INCREMENT PRIMARY KEY,
    nim           VARCHAR(15)  NOT NULL UNIQUE,
    email         VARCHAR(100) NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    created_at    TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO mahasiswa (nim, email, password_hash)
VALUES ('2507411026', NULL, 'WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=')
ON DUPLICATE KEY UPDATE password_hash = VALUES(password_hash);

