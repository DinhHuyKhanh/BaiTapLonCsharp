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
	fGiaBan FLOAT NOT NULL, 
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
	iMaHD		INT NOT NULL,
	iMaMH		INT NOT NULL,
	iSoLuong	INT NOT NULL,
	fThanhTien	FLOAT DEFAULT (0),
	iBaoHanh	INT NOT NULL,
	sGhiChu		NVARCHAR(256),
	PRIMARY KEY(iMaHD, iMaMH),
	FOREIGN KEY(iMaHD) REFERENCES tblHoaDonban(iMaHD),
	FOREIGN KEY(iMaMH) REFERENCES tblMatHang(iMaMH)
)

GO

CREATE TRIGGER trThemChiTietNhap
ON tblChiTietHoaDonNhap
AFTER INSERT, UPDATE
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
ALTER TRIGGER trDeleteChiTietNhap
ON tblChiTietHoaDonNhap
AFTER DELETE
AS
	BEGIN
		DECLARE @iMaHD INT,
				@fTongTien FLOAT
		SELECT @iMaHD = iMaHD
		FROM deleted;
		SELECT @fTongTien = IsNull(SUM(fThanhTien),0) FROM tblChiTietHoaDonNhap WHERE iMaHD = @iMaHD
		UPDATE tblHoaDonNhap
		SET fTongTien = @fTongTien
		WHERE iMaHD = @iMaHD
	END
GO
CREATE TRIGGER trThemChiTietBan
ON tblChiTietHoaDonBan
AFTER INSERT, UPDATE
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
INSERT INTO tblChiTietHoaDonBan(iMaHD, iMaMH, iSoLuong, iBaoHanh)
VALUES (1,1,3, 12)
GO
SELECT* FROM tblChiTietHoaDonNhap
SELECT * FROM tblHoaDonNhap
SELECT * FROM tblMatHang
SELECT * FROM tblHoaDonBan
SELECT * FROM tblChiTietHoaDonBan
select * from tblLoaiHang
GO
create proc prLayLoaiHang
as
begin
select * from tblLoaiHang
end
GO
create proc prThemLoaiHang(@tenhang nvarchar(50))
as
begin
	insert into tblLoaiHang(sTenHang)
	values (@tenhang)
end
GO
exec prThemLoaiHang 'Ram'
GO
create proc prSuaLoaiHang(@maLh int, @tenhang nvarchar(50))
as
begin
	update tblLoaiHang
	set sTenHang=@tenhang
	where iMaLH=@maLh
end
GO
create proc prXoaLoaiHang(@maLh int)
as
begin
	delete from tblLoaiHang
	where iMaLH=@maLh
end
GO
create proc prThemMatHang(@tenloaihang nvarchar(50), @tenHH nvarChar(50),@mau nvarChar(50),@kichthuoc nvarChar(50),@mota nvarChar(50), @giaban float)
as
begin
declare @maLH int;
select @maLH=iMaLH from tblLoaiHang where sTenHang=@tenloaihang
insert into tblMatHang(iMaLH,sTenHH,sMauSac,sKichThuoc,sMoTaChiTiet,fGiaBan)
values (@maLH,@tenHH,@mau,@kichthuoc,@mota,@giaban)
end
GO
create proc prHienMatHang
as
begin
select iMaMH,sTenHH,sTenHang,sMauSac,sKichThuoc,sMoTaChiTiet,fGiaBan,iSoLuong
from tblLoaiHang,tblMatHang
where tblLoaiHang.iMaLH=tblMatHang.iMaLH
end


GO
exec prHienMatHang

GO
create proc prSuaMatHang(@mahang int,@tenloaihang nvarchar(50), @tenHH nvarChar(50),@mau nvarChar(50),@kichthuoc nvarChar(50),@mota nvarChar(50), @giaban float)
as
begin
declare @maLH int;
select @maLH=iMaLH from tblLoaiHang where sTenHang=@tenloaihang
update tblMatHang
set iMaLH=@maLH,sTenHH=@tenHH,sMauSac=@mau,sKichThuoc=@kichthuoc,sMoTaChiTiet=@mota,fGiaBan=@giaban
where iMaMH=@mahang
end
GO
create proc prXoaMatHang(@maMH int)
as
begin
delete from tblMatHang
where iMaMH=@maMH;
end
GO
CREATE PROC prInsertHoaDonNhap(
	@tenNCC NVARCHAR(100),
	@iMaNV	INT)
	AS
	BEGIN
		INSERT INTO tblHoaDonNhap(iMaNV, sNCC)
		VALUES (@iMaNV, @tenNCC)
	END
GO
CREATE PROC prDeleteHoaDonNhap(@iMaHD	INT)
	AS
	BEGIN
		DELETE FROM tblHoaDonNhap 
		WHERE iMaHD = @iMaHD
	END
GO
CREATE PROC prUpdateHoaDonNhap(@sNCC NVARCHAR(100), @iMaHD INT)
	AS
	BEGIN
		UPDATE tblHoaDonNhap
		SET sNCC = @sNCC
		WHERE iMaHD = @iMaHD
	END
GO
CREATE VIEW vwHoaDonNhap
AS
		SELECT  a.iMaHD, a.sNCC, a.dNgayTao, a.fTongTien, b.sTen
		FROM tblHoaDonNhap a, tblNhanVien b
		WHERE  a.iMaNV = b.iMaNV
GO
CREATE VIEW vwChiTietHoaDonNhap
AS
	SELECT a.iMaHD, a.iMaMH, b.iMaLH, c.sTen as 'tenNVNhap', c.sNCC , b.sTenHH, a.iSoLuong, a.fDonGia, a.fThanhTien
	FROM tblChiTietHoaDonNhap a
	INNER JOIN tblMatHang b
	ON a.iMaMH = b.iMaMH
	INNER JOIN vwHoaDonNhap c
	ON c.iMaHD = a.iMaHD
	
GO

CREATE PROC prViewChiTietHDNhap
AS
begin
	SELECT * FROM  vwChiTietHoaDonNhap
END
GO
CREATE PROC prViewdeltailHDNhap(@iMaHD INT)
AS
	IF @iMaHD != 0
		SELECT * FROM  vwChiTietHoaDonNhap
		WHERE iMaHD = @iMaHD
	ELSE
		SELECT * FROM  vwChiTietHoaDonNhap
GO
CREATE PROC prViewLoaiHang
AS 
	SELECT iMaLH, sTenHang
	FROM tblLoaiHang 
GO
CREATE PROC prViewMatHang(@iMaLH INT)
AS 
	SELECT iMaMH, sTenHH
	FROM tblMatHang
	WHERE iMaLH = @iMaLH
SELECT * FROM tblChiTietHoaDonNhap
GO
CREATE  PROC prInsertChiTietHoaDonNhap(@iMaMH INT, @iSoLuong INT, @iMaHD INT, @fGiaNhap FLOAT)
AS
	INSERT INTO tblChiTietHoaDonNhap(iMaMH, iSoLuong, iMaHD, fDonGia)
	VALUES(@iMaMH, @iSoLuong, @iMaHD, @fGiaNhap)
GO
CREATE PROC prUpdateChiTietHDNhap(@iMaHD INT, @iMaMH INT, @iSoLuong INT, @fDonGia FLOAT)
AS
	UPDATE tblChiTietHoaDonNhap
	SET iSoLuong = @iSoLuong, fDonGia = @fDonGia
	WHERE iMaHD = @iMaHD AND iMaMH = @iMaMH

GO
CREATE PROC prSelectRowChiTietHDNhap(@iMaHD INT, @iMaMH INT)
AS
	SELECT * FROM  tblChiTietHoaDonNhap
	WHERE iMaMH= @iMaMH AND  iMaHD = @iMaHD
GO
CREATE PROC prDeleteRowChiTietHDNhap(@iMaHD INT, @iMaMH INT)
AS
	DELETE tblChiTietHoaDonNhap
	WHERE iMaMH= @iMaMH AND  iMaHD = @iMaHD
GO
CREATE PROC prFindAllHDBan
AS
	SELECT a.iMaHD, b.sTen as 'sTenNv', a.dNgayTao, a.fTongTien
	FROM tblHoaDonBan a
	INNER JOIN tblNhanVien b
	ON a.iMaNV = b.iMaNV
GO
CREATE PROC prInsertHDban(@iMaNV INT)
AS
	INSERT INTO tblHoaDonBan(iMaNV)
	VALUES(@iMaNV)

GO
CREATE PROC prUpdateHDban(@iMaNV INT, @iMaHD INT)
AS
	UPDATE tblHoaDonBan
	SET iMaNV = @iMaNV
	WHERE iMaHD = @iMaHD

GO
CREATE PROC prDeleteHDban(@iMaHD INT)
AS
	DELETE tblHoaDonBan
	WHERE iMaHD = @iMaHD
GO
CREATE PROC prSearchHDban(@numberMin INT, @numberMax INT)
AS
	SELECT * FROM tblHoaDonBan
	WHERE fTongTien between  @numberMin and @numberMax;

