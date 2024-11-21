-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Bảng Tài khoản
CREATE TABLE TaiKhoan (
    TenDN NVARCHAR(100) PRIMARY KEY,
    TenNV NVARCHAR(255) NOT NULL DEFAULT N'TV nhóm 7',
    MK NVARCHAR(100) NOT NULL DEFAULT 0,
    Loai INT NOT NULL DEFAULT 0 --1: ADMIN && 0: STAFF
);


-- Thêm 10 tài khoản 
INSERT INTO TaiKhoan (TenDN, TenNV, MK, Loai) VALUES
    ('admin', N'Trần Đức Hoàn', '123456', 1),
    ('staff1', N'Tạ Xuân Hoàng', '123456', 0),
    ('staff2', N'Trần Quang Huy', '123456', 0),
    ('staff3', N'Phạm Duy Thái', '123456', 0),
    ('staff4', N'Mai Thanh Minh', '123456', 0),
    ('staff5', N'Bùi Ngọc Chiến', '123456', 0),
    ('staff6', N'Nguyễn Mạnh Dũng', '123456', 0),
    ('staff7', N'Mai Thế Đạt', '123456', 0),
    ('staff8', N'Trần Quang Tường', '123456', 0),
    ('staff9', N'Ngô Quang Hưng', '123456', 0),
    ('staff10', N'Mai Huy Hùng', '123456', 0);

-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV INT IDENTITY PRIMARY KEY,
    TenNV NVARCHAR(255) NOT NULL DEFAULT N'Chưa có tên',
    Chucvu NVARCHAR(255) NOT NULL DEFAULT N'Chưa có chức vụ',
    NgaySinh NVARCHAR(50) ,
	DiaChi NVARCHAR(255) NOT NULL DEFAULT N'Chưa có địa chỉ',
	SoDienThoai TEXT,
);

-- Thêm 10 nhân viên 
INSERT INTO NhanVien (TenNV, Chucvu, NgaySinh, DiaChi, SoDienThoai) VALUES
    (N'Tạ Xuân Hoàng', N'Nhân Viên' , '2003-12-01', N'Bắc Giang','0466865466'),
    (N'Trần Quang Huy', N'Nhân Viên', '2003-12-15',N'Hà Nam', '0466812466'),
    (N'Phạm Duy Thái', N'Giám Sát', '2004-01-10',N'Hà Nội','0349894908'),
    (N'Mai Thanh Minh', N'Nhân Viên', '2003-11-20',N'Bắc Giang','0466885466'),
    (N'Bùi Ngọc Chiến', N'Nhân Viên', '2003-10-10',N'Bắc Giang','0466865466'),
    (N'Nguyễn Mạnh Dũng', N'Nhân Viên', '2003-12-25',N'Thanh Hóa','0466865466'),
    (N'Mai Thế Đạt', N'Nhân Viên', '2004-01-20',N'Bắc Giang','0466865466'),
    (N'Mai Huy Hùng', N'Nhân Viên', '2003-11-15',N'Bắc Giang','0466455446'),
    (N'Trần Quang Tường', N'Nhân Viên', '2004-02-10',N'Bắc Giang','023165466'),
    (N'Ngô Quang Hưng', N'Nhân Viên', '2003-12-05',N'Bắc Giang' ,'0466875466');

-- Bảng Loại sản phẩm
CREATE TABLE LoaiSP (
    MaLoai INT IDENTITY PRIMARY KEY,
    TenLoai NVARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên'
);

-- Thêm 10 loại sản phẩm 
INSERT INTO LoaiSP (TenLoai) VALUES
    (N'Cà phê'),
    (N'Trà'),
    (N'Sinh tố'),
    (N'Nước ép'),
    (N'Bánh ngọt'),
    (N'Món ăn nhẹ'),
    (N'Kem'),
    (N'Sữa chua'),
    (N'Nước uống'),
    (N'Cocktail');

-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSP INT IDENTITY PRIMARY KEY,
    TenSP NVARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên',
    GiaBan FLOAT NOT NULL DEFAULT 0,
    MaLoai INT NOT NULL,

    FOREIGN KEY (MaLoai) REFERENCES dbo.LoaiSP(MaLoai)
);

-- Thêm 10 sản phẩm 
INSERT INTO SanPham (TenSP, GiaBan, MaLoai) VALUES
    (N'Cà phê đen', 25000, 1),
    (N'Cà phê sữa', 30000, 1),
    (N'Trà đào', 20000, 2),
    (N'Sinh tố bơ', 35000, 3),
    (N'Nước ép cam', 28000, 4),
    (N'Bánh mì bơ', 15000, 5),
    (N'Khoai tây chiên', 18000, 6),
    (N'Kem chuối', 22000, 7),
    (N'Sữa chua trái cây', 25000, 8),
    (N'Soda chanh', 15000, 9);

--INSERT INTO SanPham (TenSP, GiaBan, MaLoai) VALUES 
--	(N'Martini', 150000, 10),
--	(N'Daiquiri', 200000, 10)

-- Bảng Bàn
CREATE TABLE Ban (
    MaBan INT IDENTITY PRIMARY KEY,
    TenBan NVARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên',
    TinhTrang NVARCHAR(100) NOT NULL DEFAULT N'Trống' --Trống || Có người
);

-- Thêm 10 bàn 
INSERT INTO Ban (TenBan) VALUES
    (N'Bàn 1'),
    (N'Bàn 2'),
    (N'Bàn 3'),
    (N'Bàn 4'),
    (N'Bàn 5'),
    (N'Bàn 6'),
    (N'Bàn 7'),
    (N'Bàn 8'),
    (N'Bàn 9'),
    (N'Bàn 10');

--Set lại bàn
--UPDATE Ban SET TinhTrang = N'Có Người' WHERE MaBan = 7
	 
--Cách insert bàn nhanh chóng:
--DECLARE @i INT = 11

--WHILE @i <= 21
--BEGIN 
--	INSERT dbo.Ban (TenBan) VALUES (N'Bàn '+ CAST (@i AS nvarchar(100)))
--	SET @i = @i + 1
--END

-- Bảng Hóa đơn
CREATE TABLE HD (
    MaHD INT IDENTITY PRIMARY KEY,
    NgayBan DATE NOT NULL DEFAULT GETDATE(),
    MaBan INT NOT NULL,
    TinhTrang INT NOT NULL DEFAULT 0 --1: đã thanh toán && 0: chưa thanh toán

    FOREIGN KEY (MaBan) REFERENCES dbo.Ban(MaBan)
);

-- Thêm 10 hóa đơn 
INSERT INTO HD (NgayBan, MaBan, TinhTrang) VALUES
    ('2023-12-10', 1, 1),
    ('2023-12-11', 2, 0),
    ('2023-12-12', 3, 1),
    ('2023-12-13', 4, 0),
    ('2023-12-14', 5, 1),
    ('2023-12-15', 6, 0),
    ('2023-12-16', 7, 1),
    ('2023-12-17', 8, 0),
    ('2023-12-18', 9, 1),
    ('2023-12-19', 10, 0);

--INSERT INTO HD (NgayBan, MaBan, TinhTrang) VALUES
--	(GETDATE(), 11, 0)

-- Bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHD (
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,

    FOREIGN KEY (MaHD) REFERENCES dbo.HD(MaHD),
    FOREIGN KEY (MaSP) REFERENCES dbo.SanPham(MaSP)
);

--Kiểm tra HD đã tồn tại hay chưa
--Nên dùng
--CREATE PROCEDURE USP_InsertBillInfo
--    @idBill INT,
--    @idFood INT,
--    @count INT
--AS
--BEGIN
--    DECLARE @isExistsBillInfo INT;
--    DECLARE @foodCount INT = 1; 

--    SELECT @isExistsBillInfo = MaHD, @foodCount = b.SoLuong
--    FROM ChiTietHD AS b
--    WHERE MaHD = @idBill AND MaSP = @idFood;

--    IF (@isExistsBillInfo > 0)
--    BEGIN
--        DECLARE @newCount INT = @foodCount + @count;
--        IF (@newCount > 0) 
--            UPDATE ChiTietHD SET SoLuong = @foodCount + @count WHERE MaSP = @idFood;
--        ELSE
--            DELETE ChiTietHD WHERE MaHD = @idBill AND MaSP = @idFood;
--    END
--    ELSE
--    BEGIN
--        INSERT ChiTietHD(MaHD, MaSP, SoLuong)
--        VALUES (@idBill, @idFood, @count);
--    END
--END
--GO

--CREATE PROCEDURE USP_InsertBillInfo
--    @MaHD INT,
--    @MaSP INT,
--    @SoLuong INT
--AS
--BEGIN
--    IF EXISTS (SELECT 1 FROM ChiTietHD WHERE MaHD = @MaHD AND MaSP = @MaSP)
--    BEGIN
--        -- Cập nhật số lượng
--        UPDATE ChiTietHD 
--        SET SoLuong = SoLuong + @SoLuong
--        WHERE MaHD = @MaHD AND MaSP = @MaSP;

--		--Xóa nếu SoLuong = 0 sau khi cập nhật
--		IF (SELECT SoLuong FROM ChiTietHD WHERE MaHD = @MaHD AND MaSP = @MaSP) = 0
--			DELETE FROM ChiTietHD WHERE MaHD = @MaHD AND MaSP = @MaSP;

--    END
--    ELSE
--    BEGIN
--        -- Thêm mới
--        INSERT ChiTietHD (MaHD, MaSP, SoLuong)
--        VALUES (@MaHD, @MaSP, @SoLuong);
--    END
--END;
--GO

--ALTER PROCEDURE USP_InsertBillInfo
--    @idBill INT,
--    @idFood INT,
--    @count INT
--AS
--BEGIN
--    -- Kiểm tra hóa đơn có tồn tại không
--    IF NOT EXISTS (SELECT 1 FROM HD WHERE MaHD = @idBill)
--    BEGIN
--        PRINT N'Hóa đơn không tồn tại';
--        RETURN;
--    END

--    -- Kiểm tra sản phẩm có tồn tại không
--    IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSP = @idFood)
--    BEGIN
--        PRINT N'Sản phẩm không tồn tại';
--        RETURN;
--    END

--    DECLARE @isExistsBillInfo INT;
--    DECLARE @foodCount INT;

--    SELECT @isExistsBillInfo = COUNT(*), @foodCount = SUM(SoLuong)
--    FROM ChiTietHD 
--    WHERE MaHD = @idBill AND MaSP = @idFood;

--    IF (@isExistsBillInfo > 0)
--    BEGIN
--        DECLARE @newCount INT = @foodCount + @count;

--        IF (@newCount > 0)
--        BEGIN
--            UPDATE ChiTietHD 
--            SET SoLuong = @newCount 
--            WHERE MaHD = @idBill AND MaSP = @idFood;
--        END
--        ELSE
--        BEGIN
--            DELETE FROM ChiTietHD 
--            WHERE MaHD = @idBill AND MaSP = @idFood;
--        END
--    END
--    ELSE
--    BEGIN
--        IF (@count > 0)
--        BEGIN
--            INSERT INTO ChiTietHD (MaHD, MaSP, SoLuong)
--            VALUES (@idBill, @idFood, @count);
--        END
--    END

--    -- Nếu số lượng là âm, trừ bớt số lượng của món ăn
--    IF (@count < 0)
--    BEGIN
--        DECLARE @currentQuantity INT;

--        SELECT @currentQuantity = SoLuong 
--        FROM ChiTietHD 
--        WHERE MaHD = @idBill AND MaSP = @idFood;

--        IF @currentQuantity IS NOT NULL AND @currentQuantity + @count >= 0
--        BEGIN
--            UPDATE ChiTietHD 
--            SET SoLuong = @currentQuantity + @count 
--            WHERE MaHD = @idBill AND MaSP = @idFood;
--        END
--        ELSE
--        BEGIN
--            PRINT N'Số lượng không đủ để trừ.';
--        END
--    END
--END
--GO

-- Thêm 10 chi tiết hóa đơn 
INSERT INTO ChiTietHD (MaHD, MaSP, SoLuong) VALUES
    (1, 1, 2),
    (1, 2, 1),
    (2, 3, 3),
    (2, 4, 2),
    (3, 5, 1),
    (3, 6, 2),
    (4, 7, 2),
    (4, 8, 1),
    (5, 9, 3),
    (5, 10, 2);

-- Bảng Nguyên liệu
CREATE TABLE NguyenLieu (
    MaNL INT IDENTITY PRIMARY KEY,
    TenNL NVARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên',
    GiaNhap FLOAT NOT NULL DEFAULT 0,
    SLTon INT NOT NULL DEFAULT 0,
    HanSD DATE,
    TenNCC NVARCHAR(255) NOT NULL DEFAULT N'Chưa đặt tên',
    MaLoai INT NOT NULL,

    FOREIGN KEY (MaLoai) REFERENCES dbo.LoaiSP(MaLoai)
);

-- Thêm 10 nguyên liệu 
INSERT INTO NguyenLieu (TenNL, GiaNhap, SLTon, HanSD, TenNCC, MaLoai) VALUES
    (N'Cà phê nguyên chất', 150000, 20, '2024-06-30', N'Công ty cà phê A', 1),
    (N'Sữa tươi', 30000, 30, '2024-05-15', N'Công ty sữa B', 1),
    (N'Đường', 20000, 50, '2024-07-10', N'Công ty đường C', 1),
    (N'Trà đen', 80000, 15, '2024-04-20', N'Công ty trà D', 2),
    (N'Bơ', 50000, 10, '2024-06-05', N'Công ty bơ E', 3),
    (N'Cam', 40000, 25, '2024-05-20', N'Vườn cam F', 4),
    (N'Bánh mì', 25000, 10, '2024-05-30', N'Nhà máy bánh mì G', 5),
    (N'Khoai tây', 35000, 40, '2024-07-15', N'Công ty khoai tây H', 6),
    (N'Kem tươi', 60000, 12, '2024-04-10', N'Công ty kem I', 7),
    (N'Trái cây', 70000, 35, '2024-06-10', N'Siêu thị J', 8);

--Câu truy vấn đa bảng hiển thị thông tin bàn 3
--SELECT * FROM ChiTietHD AS cthd, HD AS hd, SanPham AS sp
--WHERE cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP AND hd.MaBan = 3

--Câu truy vấn hiển thị cột theo ý muốn
--SELECT sp.TenSP, cthd.SoLuong, sp.GiaBan, sp.GiaBan*cthd.SoLuong AS ThanhTien FROM ChiTietHD AS cthd, HD AS hd, SanPham AS sp
--WHERE cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP AND hd.MaBan = 3

--Hiển thị ra  tổng số hóa đơn
--SELECT MAX(MaHD) FROM HD

--UPDATE HD SET TinhTrang = 1 WHERE MaHD = 8

--Tạo trigger để cập nhật thông tin bàn khi thêm hay sửa
-- -CREATE TRIGGER UTG_UpdateBillInfo
--ON dbo.ChiTietHD FOR INSERT, UPDATE
--AS
--BEGIN
--	DECLARE @idBill INT
--	SELECT @idBill = MaHD FROM Inserted
--	DECLARE @idTable INT
--	SELECT @idTable = MaBan FROM dbo.HD WHERE MaHD = @idBill AND TinhTrang = 0
--	UPDATE Ban SET TinhTrang = N'Có Người' WHERE MaBan = @idTable
--END
--GO

--CREATE TRIGGER UTG_UpdateBill
--ON dbo.HD FOR UPDATE
--AS
--BEGIN
--	DECLARE @idBill INT
--	SELECT @idBill = MaHD FROM Inserted
--	DECLARE @idTable INT
--	SELECT @idTable = MaBan FROM dbo.HD WHERE MaHD = @idBill
--	DECLARE @count INT = 0
--	SELECT @count = COUNT(*) FROM HD WHERE MaBan = @idTable AND TinhTrang = 0
--	IF (@count = 0)
--		UPDATE Ban SET TinhTrang = N'Trống' WHERE MaBan = @idTable
--END
--GO

----thêm cột giảm giá ở bảng HD
--ALTER TABLE HD 
--ADD GiamGia INT

--UPDATE HD SET GiamGia = 0

--ALTER TABLE HD ADD TongTien FLOAT

---- doanh thu
--SELECT *--b.TenBan, NgayBan, GiamGia 
--FROM HD AS hd, ChiTietHD AS cthd, Ban AS b, SanPham AS sp
--WHERE NgayBan = '20241115' AND hd.TinhTrang = 1 AND b.MaBan = hd.MaBan
--AND cthd.MaHD = hd.MaHD AND cthd.MaSP = sp.MaSP
