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
    Luong Float NOT NULL,
    NgayLam DATE 
);

-- Thêm 10 nhân viên 
INSERT INTO NhanVien (TenNV, Luong, NgayLam) VALUES
    (N'Tạ Xuân Hoàng', 7000000, '2023-12-01'),
    (N'Trần Quang Huy', 8000000, '2023-12-15'),
    (N'Phạm Duy Thái', 6000000, '2024-01-10'),
    (N'Mai Thanh Minh', 7500000, '2023-11-20'),
    (N'Bùi Ngọc Chiến', 9000000, '2023-10-10'),
    (N'Nguyễn Mạnh Dũng', 6500000, '2023-12-25'),
    (N'Mai Thế Đạt', 7800000, '2024-01-20'),
    (N'Mai Huy Hùng', 8500000, '2023-11-15'),
    (N'Trần Quang Tường', 7200000, '2024-02-10'),
    (N'Ngô Quang Hưng', 8200000, '2023-12-05');

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

-- Bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHD (
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,

    FOREIGN KEY (MaHD) REFERENCES dbo.HD(MaHD),
    FOREIGN KEY (MaSP) REFERENCES dbo.SanPham(MaSP)
);

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