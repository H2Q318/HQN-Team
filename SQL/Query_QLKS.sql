USE [master]
GO
/****** Object:  Database [DHP_04]    Script Date: 4/13/2021 10:26:37 AM ******/
CREATE DATABASE [DHP_04]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DHP_04', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DHP_04.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DHP_04_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DHP_04_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DHP_04] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DHP_04].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DHP_04] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DHP_04] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DHP_04] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DHP_04] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DHP_04] SET ARITHABORT OFF 
GO
ALTER DATABASE [DHP_04] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DHP_04] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DHP_04] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DHP_04] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DHP_04] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DHP_04] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DHP_04] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DHP_04] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DHP_04] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DHP_04] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DHP_04] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DHP_04] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DHP_04] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DHP_04] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DHP_04] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DHP_04] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DHP_04] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DHP_04] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DHP_04] SET  MULTI_USER 
GO
ALTER DATABASE [DHP_04] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DHP_04] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DHP_04] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DHP_04] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DHP_04] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DHP_04] SET QUERY_STORE = OFF
GO
USE [DHP_04]
GO
/****** Object:  User [DACNPM]    Script Date: 4/13/2021 10:26:38 AM ******/
CREATE USER [DACNPM] FOR LOGIN [DACNPM] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [DACNPM]
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_book]    Script Date: 4/13/2021 10:26:39 AM ******/
CREATE SEQUENCE [dbo].[seq_book] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 99999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_chucvu]    Script Date: 4/13/2021 10:26:39 AM ******/
CREATE SEQUENCE [dbo].[seq_chucvu] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_hoadon]    Script Date: 4/13/2021 10:26:39 AM ******/
CREATE SEQUENCE [dbo].[seq_hoadon] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 99999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_khachhang]    Script Date: 4/13/2021 10:26:39 AM ******/
CREATE SEQUENCE [dbo].[seq_khachhang] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 99999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_loaidichvu]    Script Date: 4/13/2021 10:26:39 AM ******/
CREATE SEQUENCE [dbo].[seq_loaidichvu] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_loaiphong]    Script Date: 4/13/2021 10:26:40 AM ******/
CREATE SEQUENCE [dbo].[seq_loaiphong] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 99
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_loaivatdung]    Script Date: 4/13/2021 10:26:40 AM ******/
CREATE SEQUENCE [dbo].[seq_loaivatdung] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999
 CYCLE 
 CACHE 
GO
USE [DHP_04]
GO
/****** Object:  Sequence [dbo].[seq_nhanvien]    Script Date: 4/13/2021 10:26:40 AM ******/
CREATE SEQUENCE [dbo].[seq_nhanvien] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 999
 CYCLE 
 CACHE 
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[HoaDonID] [nvarchar](13) NOT NULL,
	[BookID] [nvarchar](12) NOT NULL,
	[NgayThanhToan] [datetime] NOT NULL,
	[TienPhong] [decimal](18, 0) NULL,
	[TienDichVu] [decimal](18, 0) NULL,
	[TienVatTu] [decimal](18, 0) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pk_hoadon_hoadonid] PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON_DUNG_DICHVU]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON_DUNG_DICHVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [nvarchar](12) NOT NULL,
	[NhanVienID] [nvarchar](11) NOT NULL,
	[DichVuID] [nvarchar](5) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [pk_hoadon_dung_dichvu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_XemChiTietHoaDon_DichVu]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Function trả về bảng danh sách các hoá đơn dịch vụ của hoá đơn
   có hoadonid được truyền vào */
create function [dbo].[func_XemChiTietHoaDon_DichVu](@hoadonid nvarchar(13))
returns table
as
	return( select *
			from HOADON_DUNG_DICHVU
			where BookID = (select bookid
							from hoadon 
							where hoadonid = @hoadonid))
GO
/****** Object:  Table [dbo].[LOAIVATDUNG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIVATDUNG](
	[VatDungID] [nvarchar](5) NOT NULL,
	[TenVatDung] [nvarchar](50) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[ThietBiCoDinh] [bit] NULL,
 CONSTRAINT [pk_loaivatdung] PRIMARY KEY CLUSTERED 
(
	[VatDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATDUNGPHONG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATDUNGPHONG](
	[PhongID] [char](3) NOT NULL,
	[VatDungID] [nvarchar](5) NOT NULL,
	[SoLuongBanDau] [int] NOT NULL,
	[SoLuongHienTai] [int] NOT NULL,
	[TrangThaiVatDungID] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_vatdungphong] PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC,
	[VatDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOOK]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK](
	[BookID] [nvarchar](12) NOT NULL,
	[PhongID] [char](3) NOT NULL,
	[KhachHangID] [nvarchar](13) NOT NULL,
	[NhanVienID] [nvarchar](11) NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[NgayCheckIn] [datetime] NULL,
	[NgayCheckOut] [datetime] NULL,
	[NgayCheckIn_ThucTe] [datetime] NULL,
	[NgayCheckOut_ThucTe] [datetime] NULL,
	[TrangThaiBookID] [nvarchar](50) NULL,
	[ThanhToan] [decimal](18, 0) NULL,
 CONSTRAINT [pk_book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_XemChiTietHoaDon_VatTu]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Function trả về bảng danh sách các vật dụng bị hư của phòng trong hoá
   đơn có hoadonid được truyền vào */
create function [dbo].[func_XemChiTietHoaDon_VatTu](@hoadonid nvarchar(13))
returns table
as	
	return(select Loaivatdung.VatDungID,
			tenvatdung,
			DonGia,
			(SoLuongBanDau - SoLuongHienTai) as 'SoLuongHu'
	from VATDUNGPHONG inner join LOAIVATDUNG
	on LOAIVATDUNG.VatDungID = VATDUNGPHONG.VatDungID
	where PhongID = (select PhongID 
					 from BOOK 
					 where BookID = (select BookID
									 from HOADON
									 where HoaDonID = @hoadonid))
			and TrangThaiVatDungID = N'Khách làm hư')
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[ChucVuID] [nvarchar](5) NOT NULL,
	[TenChucVu] [nvarchar](30) NOT NULL,
	[MoTa] [ntext] NULL,
	[QuyenHan] [int] NOT NULL,
 CONSTRAINT [pk_chucvu] PRIMARY KEY CLUSTERED 
(
	[ChucVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[NhanVienID] [nvarchar](11) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_dangnhap] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[KhachHangID] [nvarchar](13) NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[CMND] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](11) NOT NULL,
	[QuocTich] [nvarchar](30) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pk_khachhang] PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG_BOOK]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG_BOOK](
	[KhachHangID] [nvarchar](13) NOT NULL,
	[BookID] [nvarchar](12) NOT NULL,
 CONSTRAINT [pk_khachhang_book] PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC,
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[DichVuID] [nvarchar](5) NOT NULL,
	[TenDichVu] [nvarchar](50) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[GioMo] [time](7) NULL,
	[GioDong] [time](7) NULL,
 CONSTRAINT [pk_dichvu] PRIMARY KEY CLUSTERED 
(
	[DichVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[LoaiPhongID] [nvarchar](4) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
	[SoNguoi] [int] NOT NULL,
 CONSTRAINT [pk_loaiphong] PRIMARY KEY CLUSTERED 
(
	[LoaiPhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[NhanVienID] [nvarchar](11) NOT NULL,
	[ChucVuID] [nvarchar](5) NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NOT NULL,
	[CMND] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](11) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pk_nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[PhongID] [char](3) NOT NULL,
	[LoaiPhongID] [nvarchar](4) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_phong] PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHAIBOOK]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAIBOOK](
	[TrangThaiBookID] [nvarchar](50) NOT NULL,
	[Mota] [ntext] NULL,
 CONSTRAINT [pk_trangthaibook_trangthaibookid] PRIMARY KEY CLUSTERED 
(
	[TrangThaiBookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHAIVATDUNG]    Script Date: 4/13/2021 10:26:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAIVATDUNG](
	[TrangThaiVatDungID] [nvarchar](50) NOT NULL,
	[Mota] [ntext] NULL,
 CONSTRAINT [pk_trangthaivatdung_trangthaivatdungid] PRIMARY KEY CLUSTERED 
(
	[TrangThaiVatDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[BOOK] ADD  CONSTRAINT [df_book_bookid]  DEFAULT (('B'+format(getdate(),'ddMMyy'))+format(NEXT VALUE FOR [seq_book],'00000')) FOR [BookID]
GO
ALTER TABLE [dbo].[CHUCVU] ADD  CONSTRAINT [df_chucvu_chucvuid]  DEFAULT ('CV'+format(NEXT VALUE FOR [seq_chucvu],'000')) FOR [ChucVuID]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_hoadonid]  DEFAULT (('HD'+format(getdate(),'ddMMyy'))+format(NEXT VALUE FOR [seq_hoadon],'00000')) FOR [HoaDonID]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_ngaythanhtoan]  DEFAULT (getdate()) FOR [NgayThanhToan]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_tienphong]  DEFAULT ((0)) FOR [TienPhong]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_tiendichvu]  DEFAULT ((0)) FOR [TienDichVu]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_tienvattu]  DEFAULT ((0)) FOR [TienVatTu]
GO
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [df_hoadon_tongtien]  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [df_khachhang_khachhangid]  DEFAULT (('KH'+format(getdate(),'ddMMyy'))+format(NEXT VALUE FOR [seq_khachhang],'00000')) FOR [KhachHangID]
GO
ALTER TABLE [dbo].[LOAIDICHVU] ADD  CONSTRAINT [df_loaidichvu_dichvuid]  DEFAULT ('DV'+format(NEXT VALUE FOR [seq_loaidichvu],'000')) FOR [DichVuID]
GO
ALTER TABLE [dbo].[LOAIPHONG] ADD  CONSTRAINT [df_loaiphong_loaiphongid]  DEFAULT ('LP'+format(NEXT VALUE FOR [seq_loaiphong],'00')) FOR [LoaiPhongID]
GO
ALTER TABLE [dbo].[LOAIVATDUNG] ADD  CONSTRAINT [df_loaivatdung_vatdungid]  DEFAULT ('VD'+format(NEXT VALUE FOR [seq_loaivatdung],'000')) FOR [VatDungID]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [df_nhanvien_nhanvienid]  DEFAULT (('NV'+format(getdate(),'ddMMyy'))+format(NEXT VALUE FOR [seq_nhanvien],'000')) FOR [NhanVienID]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [fk_book_khachhangid] FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KHACHHANG] ([KhachHangID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [fk_book_khachhangid]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [fk_book_nhanvienid] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NHANVIEN] ([NhanVienID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [fk_book_nhanvienid]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [fk_book_phongid] FOREIGN KEY([PhongID])
REFERENCES [dbo].[PHONG] ([PhongID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [fk_book_phongid]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [fk_book_trangthaibookid] FOREIGN KEY([TrangThaiBookID])
REFERENCES [dbo].[TRANGTHAIBOOK] ([TrangThaiBookID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [fk_book_trangthaibookid]
GO
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD  CONSTRAINT [fk_dangnhap_nhanvienid] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NHANVIEN] ([NhanVienID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DANGNHAP] CHECK CONSTRAINT [fk_dangnhap_nhanvienid]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_bookid] FOREIGN KEY([BookID])
REFERENCES [dbo].[BOOK] ([BookID])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_hoadon_bookid]
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_dung_dichvu_bookid] FOREIGN KEY([BookID])
REFERENCES [dbo].[BOOK] ([BookID])
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] CHECK CONSTRAINT [fk_hoadon_dung_dichvu_bookid]
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_dung_dichvu_dichvuid] FOREIGN KEY([DichVuID])
REFERENCES [dbo].[LOAIDICHVU] ([DichVuID])
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] CHECK CONSTRAINT [fk_hoadon_dung_dichvu_dichvuid]
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_dung_dichvu_nhanvienid] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NHANVIEN] ([NhanVienID])
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] CHECK CONSTRAINT [fk_hoadon_dung_dichvu_nhanvienid]
GO
ALTER TABLE [dbo].[KHACHHANG_BOOK]  WITH CHECK ADD  CONSTRAINT [fk_khachhang_book_bookid] FOREIGN KEY([BookID])
REFERENCES [dbo].[BOOK] ([BookID])
GO
ALTER TABLE [dbo].[KHACHHANG_BOOK] CHECK CONSTRAINT [fk_khachhang_book_bookid]
GO
ALTER TABLE [dbo].[KHACHHANG_BOOK]  WITH CHECK ADD  CONSTRAINT [fk_khachhang_book_khachhangid] FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KHACHHANG] ([KhachHangID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KHACHHANG_BOOK] CHECK CONSTRAINT [fk_khachhang_book_khachhangid]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_chucvuid] FOREIGN KEY([ChucVuID])
REFERENCES [dbo].[CHUCVU] ([ChucVuID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fk_nhanvien_chucvuid]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [fk_phong_loaiphongid] FOREIGN KEY([LoaiPhongID])
REFERENCES [dbo].[LOAIPHONG] ([LoaiPhongID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [fk_phong_loaiphongid]
GO
ALTER TABLE [dbo].[VATDUNGPHONG]  WITH CHECK ADD  CONSTRAINT [fk_vatdungphong_phongid] FOREIGN KEY([PhongID])
REFERENCES [dbo].[PHONG] ([PhongID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VATDUNGPHONG] CHECK CONSTRAINT [fk_vatdungphong_phongid]
GO
ALTER TABLE [dbo].[VATDUNGPHONG]  WITH CHECK ADD  CONSTRAINT [fk_vatdungphong_trangthaivatdungid] FOREIGN KEY([TrangThaiVatDungID])
REFERENCES [dbo].[TRANGTHAIVATDUNG] ([TrangThaiVatDungID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VATDUNGPHONG] CHECK CONSTRAINT [fk_vatdungphong_trangthaivatdungid]
GO
ALTER TABLE [dbo].[VATDUNGPHONG]  WITH CHECK ADD  CONSTRAINT [fk_vatdungphong_vatdungid] FOREIGN KEY([VatDungID])
REFERENCES [dbo].[LOAIVATDUNG] ([VatDungID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VATDUNGPHONG] CHECK CONSTRAINT [fk_vatdungphong_vatdungid]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaycheckin] CHECK  (([NgayCheckIn]>=[NgayDat]))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaycheckin]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaycheckin_thucte] CHECK  (([NgayCheckIn_ThucTe]>=[NgayDat]))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaycheckin_thucte]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaycheckout] CHECK  (([NgayCheckOut]>=[NgayCheckIn]))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaycheckout]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaycheckout_thucte] CHECK  (([NgayCheckOut_ThucTe]>=[NgayCheckIn_ThucTe]))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaycheckout_thucte]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [chk_ngaysinh] CHECK  (([NgaySinh]<=getdate()))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [chk_ngaysinh]
GO
/****** Object:  StoredProcedure [dbo].[sp_Cal_HoaDon]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Procedure tính bảng HOADON - khi khách hàng thuộc bookid_A checkout, sẽ gọi procedure
  này trong chương trình để thực hiện tính tổng tiền hoá đơn cho một bookID_A và lưu vào
  bảng HOADON */
create proc [dbo].[sp_Cal_HoaDon](@bookid nvarchar(12))
as
	declare @today datetime = getdate()
	declare @tienphong decimal = 0
	declare @tiendichvu decimal = 0
	declare @tienvattu decimal = 0
	declare @tongtien decimal = 0
	declare @gia decimal = 0

	select @gia = gia from loaiphong where loaiphongid =
							(select loaiphongid from PHONG where phongid =
							(select phongid from BOOK where BookID = @bookid))

	select @tienphong = datediff(day,
						(select ngaycheckin_thucte from BOOK where BookID = @bookid), 
						(select ngaycheckout_thucte from BOOK where BookID = @bookid)) * @gia
	
	select @tiendichvu = sum(thanhtien) from HOADON_DUNG_DICHVU where BookID = @bookid

	select @tienvattu = sum(dongia * (soluongbandau - soluonghientai))
	from VATDUNGPHONG inner join LOAIVATDUNG
	on LOAIVATDUNG.VatDungID = VATDUNGPHONG.VatDungID
	where PhongID = (select PhongID from BOOK where BookID = @bookid)
			and TrangThaiVatDungID = N'Khách làm hư'

	select @tiendichvu = ISNULL(@tiendichvu, 0)
	select @tienphong = ISNULL(@tienphong, 0)
	select @tienvattu= ISNULL(@tienvattu, 0)

	select @tongtien = @tienphong + @tiendichvu + @tienvattu
	exec sp_Ins_HoaDon @bookid,
						@today,
						@tienphong,
						@tiendichvu,
						@tienvattu,
						@tongtien,
						null
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_Book]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_Book](@bookid nvarchar(12))
as
	delete from BOOK
	where BookID = @bookid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_ChucVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_ChucVu](@cvid nvarchar(5))
as
	delete from CHUCVU	
	where ChucVuID = @cvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_DangNhap]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_DangNhap](@nvid nvarchar(11))
as
	delete from DANGNHAP
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_HoaDon]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_HoaDon](@hdid nvarchar(13))
as
	delete from HOADON
	where HoaDonID = @hdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_HoaDon_Dung_DichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_HoaDon_Dung_DichVu](@id int)
as
	delete from HOADON_DUNG_DICHVU
	where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_KhachHang]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_KhachHang](@khid nvarchar(13))
as
	delete from KHACHHANG
	where KhachHangID = @khid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_KhachHang_Book]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_KhachHang_Book](@khid nvarchar(13),
									@bookid nvarchar(12))
as
	delete from KHACHHANG_BOOK
	where KhachHangID = @khid and BookID = @bookid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiDichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiDichVu](@dvid nvarchar(5))
as
	delete from LOAIDICHVU
	where DichVuID = @dvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiPhong](@lpid nvarchar(4))
as
	delete from LOAIPHONG
	where LoaiPhongID = @lpid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiVatDung](@vdid nvarchar(5))
as
	delete from LOAIVATDUNG
	where VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_NhanVien]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_NhanVien](@nvid nvarchar(11))
as
	delete from NHANVIEN
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_Phong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_Phong](@pid char(3))
as
	delete from PHONG
	where PhongID = @pid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_TrangThaiBook]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_TrangThaiBook](@ttbid nvarchar(50))
as
	delete from trangthaibook
	where trangthaibookid = @ttbid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_TrangThaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_TrangThaiVatDung](@ttvdid nvarchar(50))
as
	delete from trangthaivatdung
	where TrangThaiVatDungID = @ttvdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_VatDungPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_VatDungPhong](@pid char(3), @vdid nvarchar(5))
as
	delete from VATDUNGPHONG
	where PhongID = @pid and VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Book]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng BOOK*/

create proc [dbo].[sp_Ins_Book](@phongid char(3), 
						@khid nvarchar(13),
						@nvid nvarchar(11),
						@ngaydat datetime,
						@ngaycheckin datetime,
						@ngaycheckout datetime,
						@ngaycheckint_tt datetime,
						@ngaycheckout_tt datetime,
						@trangthaibookid nvarchar(50),
						@thanhtoan decimal)
as
	insert into BOOK(PhongID,
					KhachHangID,
					NhanVienID,
					NgayDat,
					NgayCheckIn,
					NgayCheckOut,
					NgayCheckIn_ThucTe,
					NgayCheckOut_ThucTe,
					TrangThaiBookID,
					ThanhToan)
	values (@phongid,
			@khid,
			@nvid,
			@ngaydat,
			@ngaycheckin,
			@ngaycheckout,
			@ngaycheckint_tt,
			@ngaycheckout_tt,
			@trangthaibookid,
			@thanhtoan)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_ChucVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng CHUCVU*/
create proc [dbo].[sp_Ins_ChucVu](@tencv nvarchar(30),
							@mota ntext,
							@quyenhan int)
as
	insert into CHUCVU(TenChucVu,
						MoTa,
						QuyenHan)
	values(@tencv, @mota, @quyenhan)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_DangNhap]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[sp_Ins_DangNhap](@nvid nvarchar(11),
							@mk nvarchar(20),
							@status bit)
as
	begin
		declare @s bit = 1;
		if (select count(*)
			from DANGNHAP
			where NhanVienID = @nvid) = 0
			insert into DANGNHAP
			values(@nvid, @mk, @status)
		else
			set @s = 0
		select @s
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_HoaDon]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng HOADON*/

create proc [dbo].[sp_Ins_HoaDon](@bookid nvarchar(12),
							@ngaytt datetime,
							@tienphong decimal,
							@tiendichvu decimal,
							@tienvattu decimal,
							@tongtien decimal,
							@ghichu ntext)
as
	insert into HOADON(BookID,
						NgayThanhToan,
						TienPhong,
						TienDichVu,
						TienVatTu,
						TongTien,
						GhiChu)
	values(@bookid,
			@ngaytt,
			@tienphong,
			@tiendichvu,
			@tienvattu,
			@tongtien,
			@ghichu)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_HoaDon_Dung_DichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng HOADON_DUNG_DICHVU*/

create proc [dbo].[sp_Ins_HoaDon_Dung_DichVu](@bookid nvarchar(12),
										@nvid nvarchar(11),
										@dvid nvarchar(5),
										@ngay datetime,
										@sl int,
										@thanhtien decimal = 0)
as
	insert into HOADON_DUNG_DICHVU(BookID,
									NhanVienID,
									DichVuID,
									Ngay,
									SoLuong,
									ThanhTien)
	values(@bookid,
			@nvid,
			@dvid,
			@ngay,
			@sl,
			@thanhtien)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_KhachHang]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*procedure của bảng KHACHHANG*/

create proc [dbo].[sp_Ins_KhachHang](@ten nvarchar(30),
							@gt bit,
							@cmnd nvarchar(10),
							@sdt nvarchar(11),
							@quoctich nvarchar(30),
							@ghichu ntext)
as
	insert into KHACHHANG(Ten,
							GioiTinh,
							cmnd,
							sdt,
							quoctich,
							ghichu)
	values(@ten,
			@gt,
			@cmnd,
			@sdt,
			@quoctich,
			@ghichu)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_KhachHang_Book]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng KHACHHANG_BOOK*/

create proc [dbo].[sp_Ins_KhachHang_Book](@khid nvarchar(13),
									@bookid nvarchar(12))
as
	insert into KHACHHANG_BOOK
	values(@khid, @bookid)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiDichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng LOAIDICHVU*/

create proc [dbo].[sp_Ins_LoaiDichVu](@tendv nvarchar(50),
								@dongia decimal,
								@giomo time,
								@giodong time)
as
	insert into LOAIDICHVU(TenDichVu,
							DonGia,
							GioMo,
							GioDong)
	values(@tendv,
			@dongia,
			@giomo,
			@giodong)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng LOAIPHONG*/

create proc [dbo].[sp_Ins_LoaiPhong](@ten nvarchar(50),
								@gia decimal,
								@songuoi int)
as
	insert into LOAIPHONG(TenLoaiPhong,
							Gia,
							SoNguoi)
	values(@ten,
			@gia,
			@songuoi)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng LOAIVATDUNG*/

create proc [dbo].[sp_Ins_LoaiVatDung](@ten nvarchar(50),
								@dongia decimal,
								@thietbicd bit)
as
	insert into LOAIVATDUNG(TenVatDung, DonGia, ThietBiCoDinh)
	values(@ten, @dongia, @thietbicd)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_NhanVien]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng NHANVIEN*/

create proc [dbo].[sp_Ins_NhanVien](@cvid nvarchar(5),
							@ten nvarchar(30),
							@gt bit,
							@ngaysinh date,
							@cmnd nvarchar(10),
							@sdt nvarchar(11),
							@diachi nvarchar(100),
							@ghichu ntext)
as
	insert into NHANVIEN(ChucVuID,
							Ten, 
							GioiTinh,
							NgaySinh,
							CMND, 
							SDT,
							DiaChi,
							GhiChu)
	values(@cvid,
			@ten, 
			@gt,
			@ngaysinh,
			@cmnd,
			@sdt,
			@diachi,
			@ghichu)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Phong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng PHONG*/

create proc [dbo].[sp_Ins_Phong](@phongid char(3),
						@lp nvarchar(4),
						@status bit)
as
	insert into PHONG
	values(@phongid, @lp, @status)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_TrangThaiBook]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng TRANGTHAIBOOK*/

create proc [dbo].[sp_Ins_TrangThaiBook](@ttbid nvarchar(50),
									@Mota ntext)
as
	insert into trangthaibook
	values(@ttbid, @Mota)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_TrangThaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng TRANGTHAIVATDUNG*/

create proc [dbo].[sp_Ins_TrangThaiVatDung](@ttvdid nvarchar(50),
									@mota ntext)
as
	insert into trangthaivatdung
	values(@ttvdid, @mota)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_VatDungPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng VATDUNGPHONG*/

create proc [dbo].[sp_Ins_VatDungPhong](@pid char(3),
								@vdid nvarchar(5),
								@slbd int,
								@slht int,
								@status nvarchar(50))
as
	insert into VATDUNGPHONG
	values (@pid, @vdid, @slbd, @slht, @status)
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_Book]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_Book](@bookid nvarchar(12),
						@phongid char(3), 
						@khid nvarchar(13),
						@nvid nvarchar(11),
						@ngaydat datetime,
						@ngaycheckin datetime,
						@ngaycheckout datetime,
						@ngaycheckint_tt datetime,
						@ngaycheckout_tt datetime,
						@trangthaibookid nvarchar(50),
						@thanhtoan decimal)
as
	update BOOK
	set PhongID = @phongid,
		KhachHangID = @khid,
		NhanVienID = @nvid,
		NgayDat = @ngaydat,
		NgayCheckIn = @ngaycheckin,
		NgayCheckOut = @ngaycheckout,
		NgayCheckIn_ThucTe = @ngaycheckint_tt,
		NgayCheckOut_ThucTe = @ngaycheckout_tt,
		TrangThaiBookID = @trangthaibookid,
		ThanhToan = @thanhtoan
	where BookID = @bookid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_ChucVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_ChucVu](@cvid nvarchar(5), 
							@tencv nvarchar(30),
							@mota ntext,
							@quyenhan int)
as
	update CHUCVU
	set TenChucVu = @tencv,
		MoTa = @mota,
		QuyenHan = @quyenhan
	where ChucVuID = @cvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_DangNhap]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_DangNhap](@nvid nvarchar(11),
							@mk nvarchar(20),
							@status bit)
as
	update DANGNHAP
	set MatKhau = @mk,
		TrangThai = @status
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_HoaDon]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_HoaDon](@hdid nvarchar(13),
							@bookid nvarchar(12),
							@ngaytt datetime,
							@tienphong decimal,
							@tiendichvu decimal,
							@tienvattu decimal,
							@tongtien decimal,
							@ghichu ntext)
as
	update HOADON
	set BookID = @bookid,
		NgayThanhToan = @ngaytt,
		TienDichVu = @tiendichvu,
		TienPhong = @tienphong,
		TienVatTu = @tienvattu,
		TongTien = @tongtien,
		GhiChu = @ghichu
	where HoaDonID = @hdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_HoaDon_Dung_DichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_HoaDon_Dung_DichVu](@id int,
										@bookid nvarchar(12),
										@nvid nvarchar(11),
										@dvid nvarchar(5),
										@ngay datetime,
										@sl int,
										@thanhtien decimal = 0)
as
	update HOADON_DUNG_DICHVU
	set BookID = @bookid,
		NhanVienID = @nvid,
		DichVuID = @dvid,
		Ngay = @ngay,
		SoLuong = @sl,
		ThanhTien = @thanhtien
	where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_KhachHang]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_KhachHang](@khid nvarchar(13),
							@ten nvarchar(30),
							@gt bit,
							@cmnd nvarchar(10),
							@sdt nvarchar(11),
							@quoctich nvarchar(30),
							@ghichu ntext)
as
	update KHACHHANG
	set Ten = @ten,
		GioiTinh = @gt,
		CMND = @cmnd,
		SDT = @sdt,
		QuocTich = @quoctich,
		GhiChu = @ghichu
	where KhachHangID = @khid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiDichVu]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiDichVu](@dvid nvarchar(5),
								@tendv nvarchar(50),
								@dongia decimal,
								@giomo time,
								@giodong time)
as
	update LOAIDICHVU
	set TenDichVu = @tendv,
		DonGia = @dongia,
		GioDong = @giodong,
		GioMo = @giomo
	where DichVuID = @dvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiPhong](@lpid nvarchar(4),
								@ten nvarchar(50),
								@gia decimal,
								@songuoi int)
as
	update LOAIPHONG
	set TenLoaiPhong = @ten,
		Gia = @gia,
		SoNguoi = @songuoi
	where LoaiPhongID = @lpid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiVatDung](@vdid nvarchar(5),
								@ten nvarchar(50),
								@dongia decimal,
								@thietbicd bit)
as
	update LOAIVATDUNG
	set TenVatDung = @ten, DonGia = @dongia, ThietBiCoDinh = @thietbicd
	where VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_NhanVien]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_NhanVien](@nvid nvarchar(11),
							@cvid nvarchar(5),
							@ten nvarchar(30),
							@gt bit,
							@ngaysinh date,
							@cmnd nvarchar(10),
							@sdt nvarchar(11),
							@diachi nvarchar(100),
							@ghichu ntext)
as
	update NHANVIEN
	set ChucVuID = @cvid,
		Ten = @ten,
		GioiTinh = @gt,
		NgaySinh = @ngaysinh,
		CMND = @cmnd,
		SDT = @sdt,
		DiaChi = @diachi,
		GhiChu = @ghichu
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_Phong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_Phong](@pid char(3), @lp nvarchar(4), @status bit)
as
	update PHONG
	set LoaiPhongID = @lp,
		TrangThai = @status
	where PhongID = @pid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_TrangThaiBook]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_TrangThaiBook](@ttbid nvarchar(50),
									@Mota ntext)
as
	update trangthaibook
	set Mota = @Mota
	where TrangThaiBookID = @ttbid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_TrangThaiVatDung]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_TrangThaiVatDung](@ttvdid nvarchar(50),
									@mota ntext)
as
	update trangthaivatdung
	set Mota = @mota
	where TrangThaiVatDungID = @ttvdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_VatDungPhong]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_VatDungPhong](@pid char(3),
								@vdid nvarchar(5),
								@slbd int,
								@slht int,
								@status nvarchar(50))
as
	update VATDUNGPHONG
	set SoLuongBanDau = @slbd,
		SoLuongHienTai = @slht,
		TrangThaiVatDungID = @status
	where PhongID = @pid and VatDungID = @vdid
GO
/****** Object:  Trigger [dbo].[trg_Book_Del]    Script Date: 4/13/2021 10:26:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_Book_Del]
on [dbo].[BOOK]
for delete
as
	update PHONG
	set TrangThai = 1
	from PHONG inner join deleted
	on PHONG.PhongID = deleted.PhongID
	where PHONG.PhongID = deleted.PhongID
GO
ALTER TABLE [dbo].[BOOK] ENABLE TRIGGER [trg_Book_Del]
GO
/****** Object:  Trigger [dbo].[trg_Book_Ins]    Script Date: 4/13/2021 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Trigger cập nhật cho bảng phòng khi bảng book thay đổi dữ liệu 

và tự thêm mã khách hàng của khách hàng đại diện trong book vào bảng khách hàng - book khi mới tạo book*/
create trigger [dbo].[trg_Book_Ins]
on [dbo].[BOOK]
for insert
as
	update PHONG
	set TrangThai = 0
	from PHONG inner join inserted
	on PHONG.PhongID = inserted.PhongID
	where PHONG.PhongID = inserted.phongid

	declare @bookid nvarchar(12)
	declare @khid nvarchar(13)
	select @bookid = inserted.BookID, @khid = inserted.KhachHangID
	from BOOK inner join inserted
	on BOOK.BookID = inserted.BookID
	insert into KHACHHANG_BOOK
	values (@khid, @bookid)
GO
ALTER TABLE [dbo].[BOOK] ENABLE TRIGGER [trg_Book_Ins]
GO
/****** Object:  Trigger [dbo].[trg_Book_Up]    Script Date: 4/13/2021 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_Book_Up]
on [dbo].[BOOK]
for update
as 
	update PHONG
	set TrangThai = 0
	from PHONG inner join inserted
	on PHONG.PhongID = inserted.PhongID
	where PHONG.PhongID = inserted.PhongID

	update PHONG
	set TrangThai = 1
	from PHONG inner join deleted
	on PHONG.PhongID = deleted.PhongID
	where PHONG.PhongID = deleted.PhongID
GO
ALTER TABLE [dbo].[BOOK] ENABLE TRIGGER [trg_Book_Up]
GO
/****** Object:  Trigger [dbo].[trg_HoaDon_Dung_DichVu_Ins]    Script Date: 4/13/2021 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Trigger cập nhật cho bảng HOADON_DUNG_DICHVU tự tính tổng tiền*/
create trigger [dbo].[trg_HoaDon_Dung_DichVu_Ins]
on [dbo].[HOADON_DUNG_DICHVU]
for insert
as
	update HOADON_DUNG_DICHVU
	set ThanhTien = inserted.soluong * (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.dichvuid)
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where HOADON_DUNG_DICHVU.ID = inserted.ID
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] ENABLE TRIGGER [trg_HoaDon_Dung_DichVu_Ins]
GO
/****** Object:  Trigger [dbo].[trg_HoaDon_Dung_DichVu_Up]    Script Date: 4/13/2021 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[trg_HoaDon_Dung_DichVu_Up]
on [dbo].[HOADON_DUNG_DICHVU]
for update
as
	update HOADON_DUNG_DICHVU
	set ThanhTien = inserted.soluong * (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.dichvuid)
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where HOADON_DUNG_DICHVU.ID = inserted.ID
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] ENABLE TRIGGER [trg_HoaDon_Dung_DichVu_Up]
GO
USE [master]
GO
ALTER DATABASE [DHP_04] SET  READ_WRITE 
GO
