CREATE DATABASE db_QuanLyHangHoa
GO
USE db_QuanLyHangHoa
GO
CREATE TABLE tblLoaiHang(
	iMaLH	INT IDENTITY(1,1) PRIMARY KEY,
	sTenHang NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE tblMatHang(
	iMaMH INT IDENTITY(1,1) PRIMARY KEY,
	iMaLH INT NOT NULL,
	sTenHH  NVARCHAR(50) NOT NULL,
	sMauSac NVARCHAR(50),
	sKichThuoc NVARCHAR(50),
	sMoTaChiTiet NVARCHAR(100),
	fGiaBan FLOAT, 
	iSoLuong int DEFAULT (0)
	FOREIGN KEY (iMaLH) REFERENCES tblLoaiHang(iMaLH)
)
GO
CREATE TABLE tblNhanVien(
	iMaNV	INT IDENTITY(1,1) PRIMARY KEY,
	sTen	NVARCHAR(100) NOT NULL,
	sSDT	VARCHAR(15) UNIQUE
)
GO
CREATE TABLE tblHoaDonNhap(
	iMaHD		INT IDENTITY(1,1) PRIMARY KEY,
	iMaNV		INT NOT NULL,
	sNCC		NVARCHAR(50) NOT NULL, 
	dNgayTao	DATETIME DEFAULT GETDATE(),
	fTongTien	INT DEFAULT (0)
	FOREIGN KEY (iMaNV) REFERENCES tblNhanVien(iMaNV)
)
GO
CREATE TABLE tblChiTietHoaDonNhap(
	iMaHD INT NOT NULL,
	iMaMH INT NOT NULL,
	iSoLuong INT NOT NULL,
	fDonGia FLOAT NOT NULL,
	fThanhTien	FLOAT DEFAULT(0),
	PRIMARY KEY(iMaHD, iMaMH),
	FOREIGN KEY(iMaHD) REFERENCES tblHoaDonNhap(iMaHD),
	FOREIGN KEY(iMaMH) REFERENCES tblMatHang(iMaMH)
)
GO
CREATE TABLE tblHoaDonBan(
	iMaHD INT IDENTITY(1,1) PRIMARY KEY,
	iMaNV INT NOT NULL,
	dNgayTao DATETIME DEFAULT GETDATE() NOT NULL,
	fTongTien FLOAT DEFAULT (0)
	FOREIGN KEY(iMaNV) REFERENCES tblNhanVien(iMaNV)
)
GO

CREATE TABLE tblChiTietHoaDonBan(
	iMaHD INT NOT NULL,
	iMaMH INT NOT NULL,
	iSoLuong INT NOT NULL,
	fThanhTien FLOAT DEFAULT (0),
	PRIMARY KEY(iMaHD, iMaMH),
	FOREIGN KEY(iMaHD) REFERENCES tblHoaDonban(iMaHD),
	FOREIGN KEY(iMaMH) REFERENCES tblMatHang(iMaMH)
)

GO

CREATE TRIGGER trThemChiTietNhap
ON tblChiTietHoaDonNhap
AFTER INSERT
AS
	BEGIN
		DECLARE @iMaHD INT,
				@iMaMH INT,
				@iSoLuong INT,
				@fGiaBan FLOAT,
				@fDonGia FLOAT,
				@fThanhTien FLOAT
		SELECT @iMaHD = iMaHD,
				@iMaMH = iMaMH,
				@iSoLuong = iSoLuong,
				@fDonGia = fDonGia
		FROM inserted;

		SELECT @fThanhTien = @iSoLuong*@fDonGia

		UPDATE tblChiTietHoaDonNhap
		SET  fThanhTien = @fThanhTien
		WHERE iMaHD = @iMaHD AND iMaMH = @iMaMH
		
		UPDATE tblHoaDonNhap
		SET fTongTien = (SELECT SUM(fThanhTien) FROM tblChiTietHoaDonNhap WHERE iMaHD = @iMaHD)
		WHERE iMaHD = @iMaHD
		
		UPDATE tblMatHang
		SET  iSoLuong = a.iSoLuong + @iSoLuong
		FROM  tblMatHang a
		WHERE a.iMaMH = @iMaMH
	END
GO
CREATE TRIGGER trThemChiTietBan
ON tblChiTietHoaDonBan
AFTER INSERT
AS
	BEGIN
		DECLARE @iMaHD INT,
				@iMaMH INT,
				@iSoLuong INT,
				@fGiaBan FLOAT,
				@fThanhTien FLOAT
		SELECT @iMaHD = iMaHD,
				@iMaMH = iMaMH,
				@iSoLuong = iSoLuong
		FROM inserted;

		SELECT @fGiaBan = fGiaBan FROM tblMatHang WHERE iMaMH = @iMaMH

		SELECT @fThanhTien = @iSoLuong*@fGiaBan

		UPDATE tblChiTietHoaDonBan
		SET  fThanhTien = @fThanhTien
		WHERE iMaHD = @iMaHD AND iMaMH = @iMaMH
		
		UPDATE tblHoaDonBan
		SET fTongTien = (SELECT SUM(fThanhTien) FROM tblChiTietHoaDonBan WHERE iMaHD = @iMaHD)
		WHERE iMaHD = @iMaHD
		
		UPDATE tblMatHang
		SET  iSoLuong = a.iSoLuong - @iSoLuong
		FROM  tblMatHang a
		WHERE a.iMaMH = @iMaMH
	END
GO
INSERT INTO tblLoaiHang(sTenHang)
VALUES ('phu kien may tinh')
GO
INSERT INTO tblMatHang(iMaLH, sTenHH, fGiaBan)
VALUES(1,'chuot', 250000)
GO
INSERT INTO tblNhanVien(sTen, sSDT)
VALUES ('huy khanh', '0977919999')
GO
INSERT tblHoaDonNhap(iMaNV, sNCC )
VALUES (1,'ncc')
GO
INSERT INTO tblChiTietHoaDonNhap(iMaHD, iMaMH, iSoLuong, fDonGia)
VALUES (1, 1, 10, 200000)
GO
INSERT INTO tblHoaDonBan(iMaNV)
VALUES (1)
GO
INSERT INTO tblChiTietHoaDonBan(iMaHD, iMaMH, iSoLuong)
VALUES (2,1,3)
GO
SELECT* FROM tblChiTietHoaDonNhap
SELECT * FROM tblHoaDonNhap
SELECT * FROM tblMatHang
SELECT * FROM tblHoaDonBan
SELECT * FROM tblChiTietHoaDonBan


