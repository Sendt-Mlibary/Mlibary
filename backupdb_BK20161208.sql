create database [MLibary]
go
USE [MLibary]
GO
/****** Object:  Table [dbo].[BanDoc]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanDoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[NamSinh] [date] NULL,
	[SoDienThoai] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](256) NULL,
	[HoTen] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[NamSinh] [date] NULL,
	[QueQuan] [nvarchar](256) NULL,
	[PhanQuyen] [int] NULL,
	[SoDienThoai] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgonNguSach]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgonNguSach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNgonNguSach] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganhHoc]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhHoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNganhHoc] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoaiSach]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoaiSach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](1024) NULL,
	[TacGia] [nvarchar](1024) NULL,
	[NamXuatBan] [nvarchar](25) NULL,
	[Gia] [float] NULL,
	[ID_TheLoaiSach] [int] NULL,
	[ID_NganhHoc] [int] NULL,
	[ID_NgonNguSach] [int] NULL,
	[TaiBan] [int] NULL,
	[SoLuong] [int] NULL,
	[SoNgayMuon] [int] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayMuon] [date] NULL,
	[GhiChu] [nvarchar](1024) NULL,
	[ID_BanDoc] [int] NOT NULL,
	[ID_NhanVien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 11/24/2016 03:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MoTa] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[ID_PhieuMuon] [int] NOT NULL,
	[ID_TaiLieu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__ChiTietPh__SoLuo__1FCDBCEB]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon] ADD  DEFAULT ((1)) FOR [SoLuong]
GO
/****** Object:  Default [DF__TaiLieu__SoNgayM__173876EA]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[TaiLieu] ADD  DEFAULT ((180)) FOR [SoNgayMuon]
GO
/****** Object:  ForeignKey [FK_CT]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CT] FOREIGN KEY([ID_PhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_CT]
GO
/****** Object:  ForeignKey [FK_CT1]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CT1] FOREIGN KEY([ID_TaiLieu])
REFERENCES [dbo].[TaiLieu] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_CT1]
GO
/****** Object:  ForeignKey [FK_PM1]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PM1] FOREIGN KEY([ID_BanDoc])
REFERENCES [dbo].[BanDoc] ([ID])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PM1]
GO
/****** Object:  ForeignKey [FK_PM2]    Script Date: 11/24/2016 03:22:59 ******/
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PM2] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PM2]
GO
