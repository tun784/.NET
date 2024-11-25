create database NguyenHoangTuan_2001224555_KT2
go
use NguyenHoangTuan_2001224555_KT2
go
create table SanPham(
	MaSanPham char(20) primary key,
	TenSanPham nvarchar(100),
	DonViTinh nvarchar(20)
);
create table PhieuThu(
	MaPT char(20) primary key,
	TenPT nvarchar(100),
	NgayXuat date
);
create table CTPhieuThu(
	MaPT char(20),
	MaSanPham char(20),
	SoLuong int,
	DonGia money,
	constraint PK_CTPhieuThu primary key (MaPT, MaSanPham),
	constraint FK_CTPhieuThu_SanPham foreign key (MaSanPham) references SanPham(MaSanPham),
	constraint FK_CTPhieuThu_PhieuThu foreign key (MaPT) references PhieuThu(MaPT)
);
go

insert into SanPham (MaSanPham, TenSanPham, DonViTinh) values
('SP001', N'Kính mắt', N'Cái'),
('SP002', N'Giày thể thao', N'Đôi'),
('SP003', N'Balo', N'Cái'),
('SP004', N'Máy tính bảng', N'Cái'),
('SP005', N'Áo khoác', N'Cái'),
('SP006', N'Mũ bảo hiểm', N'Cái'),
('SP007', N'Điện thoại', N'Cái'),
('SP008', N'Tai nghe', N'Cái'),
('SP009', N'Chuột máy tính', N'Cái'),
('SP010', N'Bàn phím', N'Cái');
set dateformat dmy;
insert into PhieuThu (MaPT, TenPT, NgayXuat) values
('HD001', N'Phiếu thu khách hàng A', '25-11-2024'),
('HD002', N'Phiếu thu khách hàng B', '20-11-2024'),
('HD003', N'Phiếu thu khách hàng C', '2024-11-18'),
('HD004', N'Phiếu thu khách hàng D', '2024-11-22'),
('HD005', N'Phiếu thu khách hàng E', '2024-11-24'),
('HD006', N'Phiếu thu khách hàng F', '2024-11-25'),
('HD007', N'Phiếu thu khách hàng G', '2024-11-20');
insert into CTPhieuThu (MaPT, MaSanPham, SoLuong, DonGia) values
('HD001', 'SP001', 1, 20000),
('HD001', 'SP002', 1, 30000),
('HD002', 'SP003', 1, 30000),
('HD002', 'SP004', 1, 40000),
('HD003', 'SP005', 2, 25000),
('HD003', 'SP006', 1, 15000),
('HD004', 'SP007', 1, 60000),
('HD004', 'SP008', 1, 80000),
('HD005', 'SP009', 3, 10000),
('HD005', 'SP010', 2, 15000);
go
--use master
--drop database NguyenHoangTuan_2001224555_KT2