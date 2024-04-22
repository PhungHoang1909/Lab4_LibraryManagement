CREATE DATABASE Lab4_QuanLyThuVien

USE Lab4_QuanLyThuVien
-- Tạo bảng cho thực thể Sách
CREATE TABLE SACH (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(255),
    NXB NVARCHAR(255),
    TG NVARCHAR(255),
    TheLoai NVARCHAR(255),
    MoTa NVARCHAR(255)
);

-- Tạo bảng cho thực thể SinhVien
CREATE TABLE SINHVIEN (
    MSSV INT PRIMARY KEY,
    TenSV NVARCHAR(255),
    SDT VARCHAR(10),
    DiaChi NVARCHAR(255)
);

-- Tạo bảng cho quan hệ SinhVien_Muon_Sach
CREATE TABLE SINHVIEN_MUON_SACH (
    MaPhieuMuon INT IDENTITY(1,1) PRIMARY KEY,
    TrangThai NVARCHAR(50),
    HanSach DATE,
	MaSach int FOREIGN KEY REFERENCES SACH(MaSach),
    MSSV int FOREIGN KEY REFERENCES SinhVien(MSSV)
);


-- Thêm dữ liệu vào bảng Sach
INSERT INTO Sach (TenSach, NXB, TG, TheLoai, MoTa) VALUES 
(N'Cuốn theo chiều gió', N'NXB Kim Đồng', N'Margaret Mitchell', N'Tiểu thuyết lịch sử', N'Cuốn sách nổi tiếng về cuộc đời và tình yêu của Scarlett O''Hara và Rhett Butler.'),
(N'Harry Potter và Hòn đá Phù thủy', N'NXB Trẻ', 'J.K. Rowling', N'Tiểu thuyết huyền bí', N'Cuốn đầu tiên trong loạt truyện kỳ diệu về phù thủy Harry Potter.'),
(N'Nhà Giả Kim', N'NXB Hội Nhà Văn', 'Paulo Coelho', N'Tiểu thuyết hành động', N'Cuốn sách kể về hành trình tìm kiếm đích thực của một nhà Giả Kim.'),
(N'Sử ta diễn ra như thế nào', N'NXB Đại Học Quốc Gia Hà Nội', N'Nguyễn Phú Trọng', N'Báo cáo chính trị', N'Sách tập hợp các diễn văn, bài phát biểu của Chủ tịch nước Nguyễn Phú Trọng.'),
(N'Toán học vui', N'NXB Giáo Dục', N'Nguyễn Văn Bình', N'Sách giáo khoa', N'Cuốn sách giúp học sinh tiểu học yêu thích môn Toán hơn.');

-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MSSV, TenSV, SDT, DiaChi) VALUES 
(101, N'Lê Nguyễn Phụng Hoàng', '0123456789', N'Số 10, Đường Pasteur, Quận 1, TP. HCM'),
(102, N'Đoàn Ngọc Hiếu', '0987654321', N'Số 20, Đường Cô Giang, Quận 2, TP. HCM'),
(103, N'Lê Hoàng Hiếu', '0369852147', N'Số 30, Đường Pasteur, Quận 3, TP. HCM'),
(104, N'Nguyễn An', '0901234567', N'Số 40, Đường Pasteur, Quận 4, TP. HCM'),
(105, N'Trần Cường', '0365478912', N'Số 50, Đường Cô Giang, Quận 5, TP. HCM');


-- Thêm dữ liệu vào bảng SinhVien_Muon_Sach
INSERT INTO SinhVien_Muon_Sach (MSSV, MaSach, TrangThai, HanSach) VALUES
(101, 1, N'Đã mượn', '2024-04-15'),
(102, 2, N'Đã mượn', '2024-04-18'),
(103, 3, N'Đã mượn', '2024-04-20'),
(104, 4, N'Đã mượn', '2024-04-16'),
(105, 5, N'Đã mượn', '2024-04-19');
