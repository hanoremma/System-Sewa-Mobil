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

DELETE FROM penyewa 
DELETE FROM petugas
DELETE FROM kategori 
DELETE FROM mobil 
DELETE FROM detailSewa 
DELETE FROM pembayaran

select * from penyewa --done
select * from petugas --done
select * from kategori --done
select * from mobil 
select * from detailSewa 
select * from pembayaran

--step paling awal (done)
CREATE SEQUENCE Seq_AutoID
    START WITH 1
    INCREMENT BY 1;
--step1
ALTER TABLE detailSewa DROP CONSTRAINT FK_detailSewa_penyewa;
--step2
ALTER TABLE penyewa DROP CONSTRAINT PK_penyewa_idPenyewa;
--step3
ALTER TABLE penyewa DROP COLUMN idPenyewa;
--step4
ALTER TABLE penyewa ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE penyewa 
ADD idPenyewa AS (CAST(('PEN' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE penyewa ADD CONSTRAINT PK_penyewa_idPenyewa PRIMARY KEY (idPenyewa);

--step1
ALTER TABLE detailSewa DROP CONSTRAINT FK_detailSewa_petugas;
--step2
ALTER TABLE petugas DROP CONSTRAINT PK_petugas_idPetugas;
--step3
ALTER TABLE petugas DROP COLUMN idPetugas;
--step4
ALTER TABLE petugas ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE petugas
ADD idPetugas AS (CAST(('PET' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE petugas ADD CONSTRAINT PK_petugas_idPetugas PRIMARY KEY (idPetugas);

--step1
ALTER TABLE mobil DROP CONSTRAINT FK_mobil_idkategori;
--step2
ALTER TABLE kategori DROP CONSTRAINT PK_kategori_idKategori;
--step3
ALTER TABLE kategori DROP COLUMN idKategori;
--step4
ALTER TABLE kategori ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE kategori
ADD idKategori AS (CAST(('K' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE kategori ADD CONSTRAINT PK_kategori_idKategori PRIMARY KEY (idKategori);

--step1
ALTER TABLE detailSewa DROP CONSTRAINT FK_detailSewa_mobil;
--step2
ALTER TABLE mobil DROP CONSTRAINT PK_mobil_idMobil;
--step3
ALTER TABLE mobil DROP COLUMN idMobil;
--step4
ALTER TABLE mobil ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE mobil
ADD idMobil AS (CAST(('M' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE mobil ADD CONSTRAINT PK_mobil_idMobil PRIMARY KEY (idMobil);

--step1
ALTER TABLE pembayaran DROP CONSTRAINT FK_Pembayaran_DetailSewa;
--step2
ALTER TABLE detailSewa DROP CONSTRAINT PK__detailSe__CDBBD89849636A25;
--step3
ALTER TABLE detailSewa DROP COLUMN idDetailSewa;
--step4
ALTER TABLE detailSewa ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE detailSewa
ADD idDetailSewa AS (CAST(('DS' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE detailSewa ADD CONSTRAINT PK_detailSewa_idDetailSewa PRIMARY KEY (idDetailSewa);

--SELECT name 
--FROM sys.key_constraints 
--WHERE type = 'FK' AND OBJECT_NAME(parent_object_id) = 'pembayaran';

--step1
ALTER TABLE detailSewa DROP CONSTRAINT FK_detailSewa_mobil;
--step2
ALTER TABLE pembayaran DROP CONSTRAINT PK__Pembayar__A88E81D69E669EF1
--step3
ALTER TABLE pembayaran DROP COLUMN idPembayaran;
--step4
ALTER TABLE pembayaran ADD id_angka INT IDENTITY(1,1);
--step5
ALTER TABLE pembayaran
ADD idPembayaran AS (CAST(('INV' + RIGHT('000' + CAST(id_angka AS VARCHAR(5)), 3)) AS VARCHAR(10))) PERSISTED NOT NULL;
--step6
ALTER TABLE pembayaran ADD CONSTRAINT PK_mobil_idPembayaran PRIMARY KEY (idPembayaran);

ALTER TABLE mobil ALTER COLUMN idKategori VARCHAR(10);

ALTER TABLE detailSewa ALTER COLUMN idPenyewa VARCHAR(10);
ALTER TABLE detailSewa ALTER COLUMN idPetugas VARCHAR(10);
ALTER TABLE detailSewa ALTER COLUMN idMobil VARCHAR(10);

ALTER TABLE Pembayaran ALTER COLUMN idDetailSewa VARCHAR(10);

ALTER TABLE mobil ADD CONSTRAINT FK_mobil_idKategori 
FOREIGN KEY (idKategori) REFERENCES kategori(idKategori) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE detailSewa ADD CONSTRAINT FK_detailSewa_penyewa 
FOREIGN KEY (idPenyewa) REFERENCES penyewa(idPenyewa) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE detailSewa ADD CONSTRAINT FK_detailSewa_petugas 
FOREIGN KEY (idPetugas) REFERENCES petugas(idPetugas) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE detailSewa ADD CONSTRAINT FK_detailSewa_mobil 
FOREIGN KEY (idMobil) REFERENCES mobil(idMobil) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE pembayaran ADD CONSTRAINT FK_pembayaran_detailSewa 
FOREIGN KEY (idDetailSewa) REFERENCES detailSewa(idDetailSewa) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Pembayaran 
ADD biayaServis INT NOT NULL CONSTRAINT DF_biayaServis DEFAULT 0,
    diskon INT NOT NULL CONSTRAINT DF_diskon DEFAULT 0;

CREATE TRIGGER trg_HitungTotalBiaya
ON detailSewa
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE ds
    SET ds.totalBiaya = (
        CASE 
            WHEN DATEDIFF(DAY, i.tglPinjam, i.tglKembali) = 0 THEN 1 
            ELSE DATEDIFF(DAY, i.tglPinjam, i.tglKembali) 
        END
    ) * m.hargaSewa
    FROM detailSewa ds
    INNER JOIN inserted i ON ds.idDetailSewa = i.idDetailSewa
    INNER JOIN mobil m ON i.idMobil = m.idMobil;
END;

CREATE TRIGGER trg_HitungTotalPembayaran
ON Pembayaran
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE p
    SET p.totalPembayaran = (ds.totalBiaya + ISNULL(i.biayaServis, 0) - ISNULL(i.diskon, 0))
    FROM Pembayaran p
    INNER JOIN inserted i ON p.idPembayaran = i.idPembayaran
    INNER JOIN detailSewa ds ON i.idDetailSewa = ds.idDetailSewa;
END;

INSERT INTO penyewa (namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa)
VALUES ('Andi Pratama', 'Jl. Merdeka No. 10', '3201011212900001', '085611112222'),
       ('Dewi Lestari', 'Sleman, Yogyakarta', '3404014505950002', '081344445555');

INSERT INTO penyewa (namaPenyewa, alamatPenyewa, noKtpPenyewa, noHpPenyewa)
VALUES ('Halimah Ahmad', 'Sleman, Yogyakarta', '3201011212900004', '085612212222');

INSERT INTO petugas (namaPetugas, noHpPetugas)
VALUES ('Admin Budi', '081234567890'),
       ('Siti Kasir', '081299998888');

INSERT INTO kategori (namaKategori)
VALUES ('City Car'), 
       ('MPV'), 
       ('SUV');

INSERT INTO mobil (idKategori, noPolisi, merkMobil, tahunMobil, statusKetersediaan, hargaSewa)
VALUES 
('K001', 'B 1234 ABC', 'Toyota Avanza', '2022', 'tersedia', 350000),
('K001', 'D 5678 XYZ', 'Honda Brio', '2021', 'tersedia', 250000),
('K002', 'L 9101 QWE', 'Mitsubishi Xpander', '2023', 'Tidak tersedia', 450000);

INSERT INTO detailSewa (idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan)
VALUES 
('PEN001', 'PET001', 'M001', '2025-01-10 08:00:00', '2025-01-12 08:00:00', 'Sedang Berlangsung'),
('PEN002', 'PET002', 'M002', '2025-01-11 10:00:00', '2025-01-11 18:00:00', 'Sedang Berlangsung');

INSERT INTO detailSewa (idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan)
VALUES
('PEN003', 'PET002', 'M001', '2026-01-05', '2026-01-07', 'Sedang Berlangsung');

INSERT INTO Pembayaran (idDetailSewa, metodePembayaran, tglPembayaran, statusPembayaran, biayaServis, diskon)
VALUES 
('DS001', 'Cash', GETDATE(), 'Lunas', 50000, 0),        -- Ada biaya servis 50rb
('DS002', 'Transfer', GETDATE(), 'Belum Lunas', 0, 10000); -- Ada diskon 10rb, servis 0

INSERT INTO Pembayaran (idDetailSewa, metodePembayaran, tglPembayaran, statusPembayaran, biayaServis, diskon)
VALUES 
('DS003', 'E-Wallet', '2026-01-05', 'Lunas', 0, 0);

DELETE FROM penyewa 
DELETE FROM petugas
DELETE FROM kategori 
DELETE FROM mobil 
DELETE FROM detailSewa 
DELETE FROM pembayaran

DBCC CHECKIDENT ('penyewa', RESEED, 0);
DBCC CHECKIDENT ('petugas', RESEED, 0);
DBCC CHECKIDENT ('kategori', RESEED, 0);
DBCC CHECKIDENT ('Pembayaran', RESEED, 0);
DBCC CHECKIDENT ('detailSewa', RESEED, 0);
DBCC CHECKIDENT ('mobil', RESEED, 0);





























































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

SELECT name 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('detailSewa');

select * from penyewa --done
select * from petugas --done
select * from kategori --done
select * from mobil --done
select * from detailSewa --done
select * from pembayaran

INSERT INTO detailSewa 
(idDetailSewa, idPenyewa, idPetugas, idMobil, tglPinjam, tglKembali, statusPenyewaan, totalBiaya)
VALUES
('DS004', 'P003', 'PT001', 'M007', '2025-07-11', '2025-07-12', 'Selesai', 600000);

INSERT INTO kategori (namaKategori)
VALUES ('City Car'), 
       ('MPV'), 
       ('SUV');

       INSERT INTO mobil (idKategori, noPolisi, merkMobil, tahunMobil, statusKetersediaan, hargaSewa)
VALUES 
('K001', 'B 1234 ABC', 'Toyota Avanza', '2022', 'tersedia', 350000),
('K001', 'D 5678 XYZ', 'Honda Brio', '2021', 'tersedia', 250000),
('K002', 'L 9101 QWE', 'Mitsubishi Xpander', '2023', 'Tidak tersedia', 450000);


SELECT 
    ds.idDetailSewa,
    p.idPenyewa,
    p.namaPenyewa,
    p.alamatPenyewa,
    p.noKtpPenyewa,
    p.noHpPenyewa,
    pt.idPetugas,
    pt.namaPetugas,
    m.idMobil,
    m.noPolisi,
    m.merkMobil,
    ds.tglPinjam,
    ds.tglKembali,
    ds.statusPenyewaan,
    ds.totalBiaya

FROM detailSewa ds
JOIN penyewa p   ON ds.idPenyewa = p.idPenyewa
JOIN petugas pt  ON ds.idPetugas = pt.idPetugas
JOIN mobil m     ON ds.idMobil = m.idMobil
ORDER BY ds.tglPinjam DESC;
