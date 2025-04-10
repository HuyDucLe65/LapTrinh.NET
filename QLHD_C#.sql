CREATE DATABASE QLHD
drop database QLHD
USE QLHD
-- B?ng Bao
CREATE TABLE Bao (
    Mabao VARCHAR(10) PRIMARY KEY,
    Tenbao VARCHAR(100),
    Machucnang VARCHAR(10),
    Diachi VARCHAR(200),
    Dienthoai VARCHAR(15),
    Email VARCHAR(100)
);

-- B?ng Theloai
CREATE TABLE Theloai (
    Matheloai VARCHAR(10) PRIMARY KEY,
    Tentheloai VARCHAR(100)
)

-- B?ng BaoTheloai
CREATE TABLE Bao_Theloai (
    Mabao VARCHAR(10),
    Matheloai VARCHAR(10),
    Nhuanbut DECIMAL(10,2),
    PRIMARY KEY (Mabao, Matheloai),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao),
    FOREIGN KEY (Matheloai) REFERENCES Theloai(Matheloai)
)

-- B?ng Phongban
CREATE TABLE Phongban (
    Maphong VARCHAR(10) PRIMARY KEY,
    Tenphong VARCHAR(100),
    Mabao VARCHAR(10),
    Dienthoai VARCHAR(15),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao)
);

-- B?ng Trinhdo
CREATE TABLE Trinhdo (
    MaTD VARCHAR(10) PRIMARY KEY,
    TenTD VARCHAR(100)
);

-- B?ng Chucnang
CREATE TABLE Chucnang (
    Machucnang VARCHAR(10) PRIMARY KEY,
    Tenchucnang VARCHAR(100)
);

-- B?ng Chuyenmon
CREATE TABLE Chuyenmon (
    MaCM VARCHAR(10) PRIMARY KEY,
    TenCM VARCHAR(100)
);

-- B?ng Chucvu
CREATE TABLE Chucvu (
    Machucvu VARCHAR(10) PRIMARY KEY,
    Tenchucvu VARCHAR(100)
);

-- B?ng Nhanvien
CREATE TABLE Nhanvien (
    MaNV VARCHAR(10) PRIMARY KEY,
    TenNV VARCHAR(100),
    Mabao VARCHAR(10),
    Maphong VARCHAR(10),
    Machucvu VARCHAR(10),
    Matrinhdo VARCHAR(10),
    MaCM VARCHAR(10),
    Diachi VARCHAR(200),
    Ngaysinh DATE,
    Gioitinh VARCHAR(10),
    Dienthoai VARCHAR(15),
    Mobile VARCHAR(15),
    Email VARCHAR(100),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao),
    FOREIGN KEY (Maphong) REFERENCES Phongban(Maphong),
    FOREIGN KEY (Machucvu) REFERENCES Chucvu(Machucvu),
    FOREIGN KEY (Matrinhdo) REFERENCES Trinhdo(MaTD),
    FOREIGN KEY (MaCM) REFERENCES Chuyenmon(MaCM)
);

-- B?ng Linhvuchoatdong
CREATE TABLE Linhvuchoatdong (
    MaLVHD VARCHAR(10) PRIMARY KEY,
    TenLVHD VARCHAR(100)
);

-- B?ng Khachhang
CREATE TABLE Khachhang (
    MaKH VARCHAR(10) PRIMARY KEY,
    TenKH VARCHAR(100),
    Diachi VARCHAR(200),
    Dienthoai VARCHAR(15),
    Didong VARCHAR(15),
    Email VARCHAR(100),
    MaLVHD VARCHAR(10), 
	FOREIGN KEY (MaLVHD) REFERENCES Linhvuchoatdong(MaLVHD),
);

-- B?ng Khachguibai
CREATE TABLE Khachguibai (
    Malangui VARCHAR(10) PRIMARY KEY,
    MaKH VARCHAR(10),
    Matheloai VARCHAR(10),
    Mabao VARCHAR(10),
    Tieude VARCHAR(200),
    Noidung TEXT,
    MaNV VARCHAR(10),
    Ngaydang DATE,
    Nhuanbut DECIMAL(10,2),
    FOREIGN KEY (MaKH) REFERENCES Khachhang(MaKH),
    FOREIGN KEY (Matheloai) REFERENCES Theloai(Matheloai),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao),
    FOREIGN KEY (MaNV) REFERENCES Nhanvien(MaNV)
);

-- B?ng TTQuangcao
CREATE TABLE TTQuangcao (
    MaQcao VARCHAR(10) PRIMARY KEY,
    TenQcao VARCHAR(100)
);

-- B?ng Banggia
CREATE TABLE Banggia (
    Mabao VARCHAR(10),
    MaQcao VARCHAR(10),
    Dongia DECIMAL(10,2),
    PRIMARY KEY (Mabao, MaQcao),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao),
    FOREIGN KEY (MaQcao) REFERENCES TTQuangcao(MaQcao)
);

-- B?ng KhachQuangcao
CREATE TABLE KhachQuangcao (
    MalanQC VARCHAR(10) PRIMARY KEY,
    MaKH VARCHAR(10),
    Mabao VARCHAR(10),
    MaNV VARCHAR(10),
    MaQcao VARCHAR(10),
    Noidung TEXT,
    NgayBD DATE,
    NgayKT DATE,
    Tongtien DECIMAL(10,2),
    FOREIGN KEY (MaKH) REFERENCES Khachhang(MaKH),
    FOREIGN KEY (Mabao) REFERENCES Bao(Mabao),
    FOREIGN KEY (MaNV) REFERENCES Nhanvien(MaNV),
    FOREIGN KEY (MaQcao) REFERENCES TTQuangcao(MaQcao)
);
