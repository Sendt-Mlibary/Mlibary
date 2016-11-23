create database MLibary
go
use MLibary
GO
CREATE TABLE [dbo].[BanDoc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY key,
	[HoTen] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[NamSinh] [date] NULL,
	[SoDienThoai] [nvarchar](25) NULL
)
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL  PRIMARY key,
	[TenDangNhap] [nvarchar](50) NULL unique,
	[MatKhau] [nvarchar](256) NULL,
	[HoTen] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[NamSinh] [date] NULL,
	[QueQuan] [nvarchar](256) NULL,
	[PhanQuyen] [int] NULL,
	[SoDienThoai] [nvarchar](25) NULL
	)
GO
CREATE TABLE [dbo].[NgonNguSach](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY key ,
	[TenNganhHoc] [nvarchar](256) NULL
	)
GO
CREATE TABLE [dbo].[NganhHoc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY key,
	[TenNganhHoc] [nvarchar](256) NULL)
GO
CREATE TABLE [dbo].[TheLoaiSach](
	[ID] [int] IDENTITY(1,1) NOT NULL  PRIMARY key,
	[TenTheLoai] [nvarchar](256) NULL
	)
GO
CREATE TABLE [dbo].[TaiLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL  PRIMARY key,
	[TenSach] [nvarchar](1024) NULL,
	[TacGia] [nvarchar](1024) NULL,
	[NamXuatBan] [nvarchar](25) NULL,
	[Gia] [float] NULL,
	[ID_TheLoaiSach] [int] NULL,
	[ID_NganhHoc] [int] NULL,
	[ID_NgonNguSach] [int] NULL,
	[TaiBan] [int] NULL,
	[SoLuong] [int] NULL,
	[SoNgayMuon] [int]  default(180),
	[TrangThai] [bit] NULL
	)
GO
CREATE TABLE [dbo].[PhieuMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY key,
	[NgayMuon] [date] NULL,
	-- [HanTra] [date] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[ID_BanDoc] [int] NOT NULL,
	[ID_NhanVien] [int] NOT NULL)
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY key,
	[MoTa] [nvarchar](50) NULL,
	[SoLuong] int default(1),
	[ID_PhieuMuon] [int] NOT NULL,
	[ID_TaiLieu] [int] NOT NULL
	
	)
GO
/****** Object:  ForeignKey [FK_PM1]    Script Date: 11/17/2016 01:01:40 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PM1] FOREIGN KEY([ID_BanDoc])
REFERENCES [dbo].[BanDoc] ([ID])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PM1]
GO
/****** Object:  ForeignKey [FK_PM2]    Script Date: 11/17/2016 01:01:40 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PM2] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PM2]
GO
/****** Object:  ForeignKey [FK_CT]    Script Date: 11/17/2016 01:01:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CT] FOREIGN KEY([ID_PhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_CT]
GO
/****** Object:  ForeignKey [FK_CT1]    Script Date: 11/17/2016 01:01:40 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CT1] FOREIGN KEY([ID_TaiLieu])
REFERENCES [dbo].[TaiLieu] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_CT1]
GO
