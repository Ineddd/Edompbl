"""
EDOM - Fuzzy Tsukamoto
4 kategori (Pedagogik, Profesional, Kepribadian, Sosial) x 3 himpunan (kurang, cukup, baik)
= 81 aturan.

Alur perhitungan:
  1. Hitung rata-rata nilai tiap kategori
  2. Fuzzifikasi  : rata-rata -> derajat keanggotaan (mu) kurang / cukup / baik
  3. Evaluasi aturan: alpha-predikat = MIN dari mu keempat kategori
  4. Inferensi Tsukamoto: alpha -> nilai z tiap aturan (dari kurva output monoton)
  5. Defuzzifikasi: Z akhir = jumlah(alpha * z) / jumlah(alpha)
"""

# DATA DASAR
NAMA_KATEGORI = ["Pedagogik", "Profesional", "Kepribadian", "Sosial"]
LABEL = ["kurang", "cukup", "baik"]



# LANGKAH 2 - FUZZIFIKASI INPUT (domain rata-rata 1..5)
def mu_kurang(x):
    """Kurva TURUN: 1 saat x <= 1, turun linear sampai 0 saat x >= 3."""
    if x <= 1:
        return 1.0
    elif x < 3:
        return (3 - x) / 2
    else:
        return 0.0


def mu_cukup(x):
    """Kurva SEGITIGA 2-3-4: puncak (1) di x = 3."""
    if x <= 2 or x >= 4:
        return 0.0
    elif x <= 3:
        return x - 2
    else:
        return 4 - x


def mu_baik(x):
    """Kurva NAIK: 0 saat x <= 3, naik linear sampai 1 saat x >= 5."""
    if x <= 3:
        return 0.0
    elif x < 5:
        return (x - 3) / 2
    else:
        return 1.0



# LANGKAH 4 - HIMPUNAN OUTPUT TSUKAMOTO (domain z 0..100, monoton)
# Nilai z dicari dari kebalikan kurva, berdasarkan alpha.
def z_kurang(alpha):
    """Kurva turun (1 di z<=25, 0 di z>=50)  ->  z = 50 - 25*alpha"""
    return 50 - 25 * alpha


def z_cukup(alpha):
    """Kurva naik (0 di z<=50, 1 di z>=75)   ->  z = 50 + 25*alpha"""
    return 50 + 25 * alpha


def z_baik(alpha):
    """Kurva naik (0 di z<=75, 1 di z>=100)  ->  z = 75 + 25*alpha"""
    return 75 + 25 * alpha


FUNGSI_Z = {"kurang": z_kurang, "cukup": z_cukup, "baik": z_baik}



# LANGKAH 3 - BASIS ATURAN (81 aturan, ditulis satu per satu)
# Format: (no, Pedagogik, Profesional, Kepribadian, Sosial, KESIMPULAN)
ATURAN = [
    ( 1, "kurang", "kurang", "kurang", "kurang", "kurang"),
    ( 2, "kurang", "kurang", "kurang", "cukup",  "kurang"),
    ( 3, "kurang", "kurang", "kurang", "baik",   "kurang"),
    ( 4, "kurang", "kurang", "cukup",  "kurang", "kurang"),
    ( 5, "kurang", "kurang", "cukup",  "cukup",  "kurang"),
    ( 6, "kurang", "kurang", "cukup",  "baik",   "cukup"),
    ( 7, "kurang", "kurang", "baik",   "kurang", "kurang"),
    ( 8, "kurang", "kurang", "baik",   "cukup",  "cukup"),
    ( 9, "kurang", "kurang", "baik",   "baik",   "cukup"),
    (10, "kurang", "cukup",  "kurang", "kurang", "kurang"),
    (11, "kurang", "cukup",  "kurang", "cukup",  "kurang"),
    (12, "kurang", "cukup",  "kurang", "baik",   "cukup"),
    (13, "kurang", "cukup",  "cukup",  "kurang", "kurang"),
    (14, "kurang", "cukup",  "cukup",  "cukup",  "cukup"),
    (15, "kurang", "cukup",  "cukup",  "baik",   "cukup"),
    (16, "kurang", "cukup",  "baik",   "kurang", "cukup"),
    (17, "kurang", "cukup",  "baik",   "cukup",  "cukup"),
    (18, "kurang", "cukup",  "baik",   "baik",   "cukup"),
    (19, "kurang", "baik",   "kurang", "kurang", "kurang"),
    (20, "kurang", "baik",   "kurang", "cukup",  "cukup"),
    (21, "kurang", "baik",   "kurang", "baik",   "cukup"),
    (22, "kurang", "baik",   "cukup",  "kurang", "cukup"),
    (23, "kurang", "baik",   "cukup",  "cukup",  "cukup"),
    (24, "kurang", "baik",   "cukup",  "baik",   "cukup"),
    (25, "kurang", "baik",   "baik",   "kurang", "cukup"),
    (26, "kurang", "baik",   "baik",   "cukup",  "cukup"),
    (27, "kurang", "baik",   "baik",   "baik",   "baik"),
    (28, "cukup",  "kurang", "kurang", "kurang", "kurang"),
    (29, "cukup",  "kurang", "kurang", "cukup",  "kurang"),
    (30, "cukup",  "kurang", "kurang", "baik",   "cukup"),
    (31, "cukup",  "kurang", "cukup",  "kurang", "kurang"),
    (32, "cukup",  "kurang", "cukup",  "cukup",  "cukup"),
    (33, "cukup",  "kurang", "cukup",  "baik",   "cukup"),
    (34, "cukup",  "kurang", "baik",   "kurang", "cukup"),
    (35, "cukup",  "kurang", "baik",   "cukup",  "cukup"),
    (36, "cukup",  "kurang", "baik",   "baik",   "cukup"),
    (37, "cukup",  "cukup",  "kurang", "kurang", "kurang"),
    (38, "cukup",  "cukup",  "kurang", "cukup",  "cukup"),
    (39, "cukup",  "cukup",  "kurang", "baik",   "cukup"),
    (40, "cukup",  "cukup",  "cukup",  "kurang", "cukup"),
    (41, "cukup",  "cukup",  "cukup",  "cukup",  "cukup"),
    (42, "cukup",  "cukup",  "cukup",  "baik",   "cukup"),
    (43, "cukup",  "cukup",  "baik",   "kurang", "cukup"),
    (44, "cukup",  "cukup",  "baik",   "cukup",  "cukup"),
    (45, "cukup",  "cukup",  "baik",   "baik",   "baik"),
    (46, "cukup",  "baik",   "kurang", "kurang", "cukup"),
    (47, "cukup",  "baik",   "kurang", "cukup",  "cukup"),
    (48, "cukup",  "baik",   "kurang", "baik",   "cukup"),
    (49, "cukup",  "baik",   "cukup",  "kurang", "cukup"),
    (50, "cukup",  "baik",   "cukup",  "cukup",  "cukup"),
    (51, "cukup",  "baik",   "cukup",  "baik",   "baik"),
    (52, "cukup",  "baik",   "baik",   "kurang", "cukup"),
    (53, "cukup",  "baik",   "baik",   "cukup",  "baik"),
    (54, "cukup",  "baik",   "baik",   "baik",   "baik"),
    (55, "baik",   "kurang", "kurang", "kurang", "kurang"),
    (56, "baik",   "kurang", "kurang", "cukup",  "cukup"),
    (57, "baik",   "kurang", "kurang", "baik",   "cukup"),
    (58, "baik",   "kurang", "cukup",  "kurang", "cukup"),
    (59, "baik",   "kurang", "cukup",  "cukup",  "cukup"),
    (60, "baik",   "kurang", "cukup",  "baik",   "cukup"),
    (61, "baik",   "kurang", "baik",   "kurang", "cukup"),
    (62, "baik",   "kurang", "baik",   "cukup",  "cukup"),
    (63, "baik",   "kurang", "baik",   "baik",   "baik"),
    (64, "baik",   "cukup",  "kurang", "kurang", "cukup"),
    (65, "baik",   "cukup",  "kurang", "cukup",  "cukup"),
    (66, "baik",   "cukup",  "kurang", "baik",   "cukup"),
    (67, "baik",   "cukup",  "cukup",  "kurang", "cukup"),
    (68, "baik",   "cukup",  "cukup",  "cukup",  "cukup"),
    (69, "baik",   "cukup",  "cukup",  "baik",   "baik"),
    (70, "baik",   "cukup",  "baik",   "kurang", "cukup"),
    (71, "baik",   "cukup",  "baik",   "cukup",  "baik"),
    (72, "baik",   "cukup",  "baik",   "baik",   "baik"),
    (73, "baik",   "baik",   "kurang", "kurang", "cukup"),
    (74, "baik",   "baik",   "kurang", "cukup",  "cukup"),
    (75, "baik",   "baik",   "kurang", "baik",   "baik"),
    (76, "baik",   "baik",   "cukup",  "kurang", "cukup"),
    (77, "baik",   "baik",   "cukup",  "cukup",  "baik"),
    (78, "baik",   "baik",   "cukup",  "baik",   "baik"),
    (79, "baik",   "baik",   "baik",   "kurang", "baik"),
    (80, "baik",   "baik",   "baik",   "cukup",  "baik"),
    (81, "baik",   "baik",   "baik",   "baik",   "baik"),
]



# PROSES PERHITUNGAN
def hitung_rata_rata(jawaban):
    """Langkah 1: rata-rata nilai tiap kategori."""
    rata = {}
    for kategori in NAMA_KATEGORI:
        nilai = jawaban[kategori]
        rata[kategori] = sum(nilai) / len(nilai)
    return rata


def fuzzifikasi(rata):
    """Langkah 2: ubah rata-rata menjadi derajat keanggotaan."""
    mu = {}
    for kategori in NAMA_KATEGORI:
        x = rata[kategori]
        mu[kategori] = {
            "kurang": mu_kurang(x),
            "cukup": mu_cukup(x),
            "baik": mu_baik(x),
        }
    return mu


def evaluasi_aturan(mu):
    """Langkah 3 & 4: hitung alpha dan z untuk setiap aturan."""
    hasil = []
    for no, ped, prof, kep, sos, kesimpulan in ATURAN:
        # alpha = nilai MIN dari derajat keanggotaan keempat kategori
        alpha = min(
            mu["Pedagogik"][ped],
            mu["Profesional"][prof],
            mu["Kepribadian"][kep],
            mu["Sosial"][sos],
        )
        z = FUNGSI_Z[kesimpulan](alpha)
        hasil.append({
            "no": no,
            "kondisi": (ped, prof, kep, sos),
            "kesimpulan": kesimpulan,
            "alpha": alpha,
            "z": z,
        })
    return hasil


def defuzzifikasi(hasil_aturan):
    """Langkah 5: rata-rata terbobot  Z = sum(alpha*z) / sum(alpha)."""
    total_alpha = sum(r["alpha"] for r in hasil_aturan)
    total_alpha_z = sum(r["alpha"] * r["z"] for r in hasil_aturan)
    return total_alpha_z / total_alpha


def predikat(z):
    if z < 50:
        return "Kurang"
    elif z < 75:
        return "Cukup"
    else:
        return "Baik"


def hitung(jawaban):
    rata = hitung_rata_rata(jawaban)
    mu = fuzzifikasi(rata)
    hasil_aturan = evaluasi_aturan(mu)
    z_akhir = defuzzifikasi(hasil_aturan)
    return rata, mu, hasil_aturan, z_akhir



# CONTOH PENGGUNAAN
if __name__ == "__main__":
    contoh = {
        "Pedagogik":   [4, 3, 4, 5, 3, 4, 4, 3, 4],
        "Profesional": [3, 3, 4, 3, 2, 3, 3, 2],
        "Kepribadian": [4, 4, 3, 4, 4, 3],
        "Sosial":      [3, 2, 3, 3],
    }

    rata, mu, hasil_aturan, z_akhir = hitung(contoh)

    print("=== LANGKAH 1 & 2: RATA-RATA DAN FUZZIFIKASI ===")
    for k in NAMA_KATEGORI:
        print(f"{k:12s} total={sum(contoh[k])} soal={len(contoh[k])} rata={rata[k]:.4f}  "
              f"kurang={mu[k]['kurang']:.4f} cukup={mu[k]['cukup']:.4f} baik={mu[k]['baik']:.4f}")

    aktif = [r for r in hasil_aturan if r["alpha"] > 0]
    print("\n=== LANGKAH 3 & 4: ATURAN AKTIF (alpha > 0) ===")
    print(f"Jumlah aturan aktif: {len(aktif)}")
    for r in aktif:
        kondisi = [LABEL_[0:3] for LABEL_ in r["kondisi"]]
        print(f"R{r['no']:02d} {str(kondisi):38s} -> {r['kesimpulan']:6s} "
              f"alpha={r['alpha']:.4f}  z={r['z']:.3f}  alpha*z={r['alpha']*r['z']:.3f}")

    print("\n=== LANGKAH 5: DEFUZZIFIKASI ===")
    print("sum alpha   =", sum(r["alpha"] for r in aktif))
    print("sum alpha*z =", sum(r["alpha"] * r["z"] for r in aktif))
    print(f"Z akhir     = {z_akhir:.4f}  ->  {predikat(z_akhir)}")