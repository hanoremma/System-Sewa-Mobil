CREATE DATABASE sistemSewaMobil

USE sistemSewaMobil

CREATE TABLE penyewa (
idPenyewa CHAR(10) NOT NULL,
namaPenyewa VARCHAR(50),
alamatPenyewa VARCHAR (100),
noKtpPenyewa CHAR(16),
noHpPenyewa CHAR(14),
CONSTRAINT PK_penyewa_idPenyewa PRIMARY KEY (idPenyewa)       
);

CREATE TABLE petugas (
idPetugas CHAR(10) NOT NULL,
namaPetugas VARCHAR(50),
noHpPetugas CHAR(14),
CONSTRAINT PK_petugas_idPetugas PRIMARY KEY (idPetugas)
);

CREATE TABLE kategori (
idKategori CHAR(10) NOT NULL,
namaKategori VARCHAR(30),
CONSTRAINT PK_kategori_idKategori PRIMARY KEY (idKategori)
);

CREATE TABLE mobil (
idMobil CHAR(10) NOT NULL,
idKategori CHAR(10),
noPolisi VARCHAR(30),
merkMobil VARCHAR(20),
tahunMobil CHAR(4),
statusKetersediaan VARCHAR(10)
	 CHECK (statusKetersediaan IN ('tersedia', 'Tidak tersedia')),
hargaSewa INT,
CONSTRAINT PK_mobil_idMobil PRIMARY KEY (idMobil),
CONSTRAINT FK_mobil_idKategori FOREIGN KEY (idKategori)
REFERENCES kategori(idKategori)
ON DELETE CASCADE
ON UPDATE CASCADE
);

CREATE TABLE detailSewa (
    idDetailSewa CHAR(10) PRIMARY KEY,
    idPenyewa CHAR(10),
    idPetugas CHAR(10),
    idMobil CHAR(10),
    tglPinjam DATETIME,
    tglKembali DATETIME,
    statusPenyewaan VARCHAR(20)
        CHECK (statusPenyewaan IN ('Sedang Berlangsung', 'Dibatalkan')),
    totalBiaya INT,

    CONSTRAINT CK_detailSewa_tanggal
        CHECK (tglKembali IS NULL OR tglKembali >= tglPinjam),

    CONSTRAINT FK_detailSewa_penyewa
        FOREIGN KEY (idPenyewa)
        REFERENCES Penyewa(idPenyewa)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT FK_detailSewa_petugas
        FOREIGN KEY (idPetugas)
        REFERENCES Petugas(idPetugas)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT FK_detailSewa_mobil
        FOREIGN KEY (idMobil)
        REFERENCES Mobil(idMobil)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


CREATE TABLE Pembayaran (
    idPembayaran CHAR(10) PRIMARY KEY,
    idDetailSewa CHAR(10),
    metodePembayaran VARCHAR(20) 
        CHECK (metodePembayaran IN ('Cash', 'Transfer', 'E-Wallet')),
    tglPembayaran DATETIME,
    statusPembayaran VARCHAR(20) 
        CHECK (statusPembayaran IN ('Lunas', 'Belum Lunas')),
    totalPembayaran INT,

    CONSTRAINT FK_Pembayaran_DetailSewa
        FOREIGN KEY (idDetailSewa)
        REFERENCES detailSewa(idDetailSewa)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

INSERT INTO penyewa (idPenyewa, namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa)
VALUES
('P001', 'Andika Pratama', 'Sleman, Kaliurang', '3275011203980001', '081234567890'),
('P002', 'Budi Santoso', 'Yogyakarta, Bantul', '3404011504970002', '082198765432'),
('P003', 'Citra Lestari', 'Yogyakarta, Sleman', '3471015203980003', '085712345678'),
('P004', 'Dewi Anggraini', 'Magelang, Muntilan', '3308024501960004', '081356789012'),
('P005', 'Eko Nugroho', 'Klaten, Prambanan', '3310021012950005', '083812345679');

SELECT * FROM penyewa

INSERT INTO petugas (idPetugas, namaPetugas, noHpPetugas)
VALUES
('PT001', 'Rizki Hidayat', '081234567801'),
('PT002', 'Siti Aisyah', '082145678902'),
('PT003', 'Ahmad Fauzi', '085712349803'),
('PT004', 'Dina Pramesti', '081398765404'),
('PT005', 'Yoga Pratama', '083812340505');

INSERT INTO kategori (idKategori, namaKategori)
VALUES
('K02', 'SUV'),
('K03', 'MPV'),
('K04', 'LCGC'),
('K05', 'Premium');

INSERT INTO kategori (idKategori, namaKategori)
VALUES ('K01', 'SUV');

DELETE FROM kategori
WHERE idKategori = 'K05';

/* Mengubah K01 menjadi SUV */
UPDATE kategori 
SET namaKategori = 'SUV' 
WHERE idKategori = 'K01';

/* Mengubah K02 menjadi MPV */
UPDATE kategori 
SET namaKategori = 'MPV' 
WHERE idKategori = 'K02';

/* Mengubah K03 menjadi Sedan */
UPDATE kategori 
SET namaKategori = 'LCGC' 
WHERE idKategori = 'K03';

UPDATE kategori 
SET namaKategori = 'Premium' 
WHERE idKategori = 'K04';

SELECT * FROM kategori

INSERT INTO mobil (idMobil, idKategori, noPolisi, merkMobil, tahunMobil, statusKetersediaan, hargaSewa)
VALUES
-- K03 adalah MPV (Multi Purpose Vehicle) -> Contoh: Avanza
('M001', 'K02', 'AB 1029 CD', 'Toyota Avanza', '2022', 'Tersedia', 300000),

-- K04 adalah LCGC (Low Cost Green Car) -> Contoh: Brio Satya
('M002', 'K03', 'AB 4452 XY', 'Honda Brio', '2023', 'Tersedia', 275000),

-- K02 adalah SUV (Sport Utility Vehicle) -> Contoh: Pajero Sport
('M003', 'K01', 'AB 8080 JK', 'Mitsubishi Pajero', '2021', 'Tersedia', 850000),

-- K05 adalah Premium -> Contoh: Alphard
('M004', 'K05', 'AB 1111 RZ', 'Toyota Alphard', '2023', 'Tersedia', 1500000),

-- K03 adalah MPV (Medium MPV) -> Contoh: Innova Reborn
('M005', 'K02', 'AB 5678 FG', 'Toyota Innova', '2020', 'Tersedia', 450000);



INSERT INTO mobil 
(idMobil, idKategori, noPolisi, merkMobil, tahunMobil, statusKetersediaan, hargaSewa)
VALUES
('M006', 'K01', 'AB 2024 RS', 'Honda CR-V', '2022', 'Tersedia', 600000),
('M007', 'K01', 'AB 9999 LL', 'Toyota Fortuner', '2023', 'Tersedia', 850000),
('M008', 'K02', 'AB 3344 MT', 'Suzuki Ertiga', '2021', 'Tersedia', 350000),
('M009', 'K02', 'AB 7788 PL', 'Mitsubishi Xpander', '2022', 'Tersedia', 400000),
('M010', 'K03', 'AB 1234 QQ', 'Daihatsu Ayla', '2023', 'Tersedia', 250000),
('M011', 'K03', 'AB 5566 ZZ', 'Toyota Calya', '2022', 'Tersedia', 300000),
('M012', 'K05', 'AB 7777 VIP', 'BMW 320i', '2023', 'Tersedia', 2500000);

ALTER TABLE petugas
ADD alamatPetugas VARCHAR(255);

UPDATE petugas SET alamatPetugas = 'Sleman, Kaliurang' WHERE idPetugas = 'PT001';
UPDATE petugas SET alamatPetugas = 'Jl. Merdeka No.10, Jakarta' WHERE idPetugas = 'PT002';
UPDATE petugas SET alamatPetugas = 'Jl. Sudirman No.25, Bandung' WHERE idPetugas = 'PT003';
UPDATE petugas SET alamatPetugas = 'Magelang, Muntilan' WHERE idPetugas = 'PT004';
UPDATE petugas SET alamatPetugas = 'Klaten, Prambanan' WHERE idPetugas = 'PT005';

select * from mobil
select * from detailSewa
select * from pembayaran
select * from petugas
select * from penyewa

ALTER TABLE mobil
ALTER COLUMN statusKetersediaan VARCHAR(30);

ALTER TABLE detailSewa
ALTER COLUMN statusPenyewaan VARCHAR(50);


UPDATE mobil
SET statusKetersediaan = 'Tidak tersedia'
WHERE idMobil = 'M001';

SELECT
    ds.idDetailSewa,
    p.namaPenyewa,
    pt.namaPetugas,
    m.noPolisi AS PlatMobil,
    ds.tglPinjam,
    ds.tglKembali,
    ds.statusPenyewaan,
    ds.totalBiaya
FROM detailSewa ds
JOIN penyewa p 
    ON ds.idPenyewa = p.idPenyewa
JOIN petugas pt 
    ON ds.idPetugas = pt.idPetugas
JOIN mobil m 
    ON ds.idMobil = m.idMobil;

sys.tables;

sp_help



--ingin menampilkan idDetailSewa, Nama penyewa, Nama Petugas, Plat Mobil, Tanggal Pinjam, Tanggal Kembali, statusPenyewaan, titalBiaya