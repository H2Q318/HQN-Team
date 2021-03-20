USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 3/20/2021 8:56:24 AM ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLKS] SET QUERY_STORE = OFF
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[BOOK]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[PhongID] [char](3) NOT NULL,
	[KhachHangID] [int] NOT NULL,
	[NhanVienID] [int] NOT NULL,
	[NgayDat] [date] NOT NULL,
	[NgayCheckIn] [date] NOT NULL,
	[NgayCheckOut] [date] NOT NULL,
	[XacNhan] [bit] NULL,
	[ThanhToan] [decimal](18, 0) NULL,
 CONSTRAINT [pk_book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[ChucVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](30) NOT NULL,
	[MoTa] [ntext] NULL,
	[QuyenHan] [int] NOT NULL,
 CONSTRAINT [pk_chucvu] PRIMARY KEY CLUSTERED 
(
	[ChucVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[NhanVienID] [int] NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_dangnhap] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON_DUNG_DICHVU]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON_DUNG_DICHVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[DichVuID] [int] NOT NULL,
	[Ngay] [date] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [pk_hoadon_dung_dichvu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[KhachHangID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[CMND] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](11) NOT NULL,
	[QuocTich] [nvarchar](30) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pk_khachhang] PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[DichVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
	[GioMo] [time](7) NULL,
	[GioDong] [time](7) NULL,
 CONSTRAINT [pk_dichvu] PRIMARY KEY CLUSTERED 
(
	[DichVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[LoaiPhongID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
	[SoNguoi] [int] NOT NULL,
 CONSTRAINT [pk_loaiphong] PRIMARY KEY CLUSTERED 
(
	[LoaiPhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIVATDUNG]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIVATDUNG](
	[VatDungID] [int] IDENTITY(1,1) NOT NULL,
	[TenVatDung] [nvarchar](50) NOT NULL,
	[Gia] [decimal](18, 0) NOT NULL,
	[ThietBiCoDinh] [bit] NULL,
 CONSTRAINT [pk_loaivatdung] PRIMARY KEY CLUSTERED 
(
	[VatDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[NhanVienID] [int] IDENTITY(1,1) NOT NULL,
	[ChucVuID] [int] NOT NULL,
	[Ten] [nvarchar](30) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NOT NULL,
	[CMND] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](11) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [pk_nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[PhongID] [char](3) NOT NULL,
	[LoaiPhongID] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_phong] PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATDUNGPHONG]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATDUNGPHONG](
	[PhongID] [char](3) NOT NULL,
	[VatDungID] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [pk_vatdungphong] PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC,
	[VatDungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD  CONSTRAINT [fk_dangnhap_nhanvienid] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NHANVIEN] ([NhanVienID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DANGNHAP] CHECK CONSTRAINT [fk_dangnhap_nhanvienid]
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_bookid] FOREIGN KEY([BookID])
REFERENCES [dbo].[BOOK] ([BookID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] CHECK CONSTRAINT [fk_hoadon_bookid]
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU]  WITH CHECK ADD  CONSTRAINT [fk_hoadon_dichvuid] FOREIGN KEY([DichVuID])
REFERENCES [dbo].[LOAIDICHVU] ([DichVuID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HOADON_DUNG_DICHVU] CHECK CONSTRAINT [fk_hoadon_dichvuid]
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
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaycheckout] CHECK  (([NgayCheckOut]>=[NgayCheckIn]))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaycheckout]
GO
ALTER TABLE [dbo].[BOOK]  WITH CHECK ADD  CONSTRAINT [chk_ngaydat] CHECK  (([NgayDat]>=getdate()))
GO
ALTER TABLE [dbo].[BOOK] CHECK CONSTRAINT [chk_ngaydat]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [chk_ngaysinh] CHECK  (([NgaySinh]<=getdate()))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [chk_ngaysinh]
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_Book]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_Book](@bookid int)
as
	delete from BOOK
	where BookID = @bookid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_ChucVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_ChucVu](@cvid int)
as
	delete from CHUCVU	
	where ChucVuID = @cvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_DangNhap]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_DangNhap](@nvid int)
as
	delete from DANGNHAP
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_HoaDon_Dung_DichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_HoaDon_Dung_DichVu](@id int)
as
	delete from HOADON_DUNG_DICHVU
	where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_KhachHang]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_KhachHang](@khid int)
as
	delete from KHACHHANG
	where KhachHangID = @khid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiDichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiDichVu](@dvid int)
as
	delete from LOAIDICHVU
	where DichVuID = @dvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiPhong](@lpid int)
as
	delete from LOAIPHONG
	where LoaiPhongID = @lpid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_LoaiVatDung]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_LoaiVatDung](@vdid int)
as
	delete from LOAIVATDUNG
	where VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_NhanVien]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_NhanVien](@nvid int)
as
	delete from NHANVIEN
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_Phong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_Phong](@pid int)
as
	delete from PHONG
	where PhongID = @pid
GO
/****** Object:  StoredProcedure [dbo].[sp_Del_VatDungPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Del_VatDungPhong](@pid char(3), @vdid int)
as
	delete from VATDUNGPHONG
	where PhongID = @pid and VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_Book]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*procedure của bảng BOOK*/
create proc [dbo].[sp_Ins_Book](@phongid char(3), 
						@khid int,
						@nvid int,
						@ngaydat date,
						@ngaycheckin date,
						@ngaycheckout date,
						@xacnhan bit = 0,
						@thanhtoan decimal)
as
	insert into BOOK(PhongID,
					KhachHangID,
					NhanVienID,
					NgayDat,
					NgayCheckIn,
					NgayCheckOut,
					XacNhan,
					ThanhToan)
	values (@phongid,
			@khid,
			@nvid,
			@ngaydat,
			@ngaycheckin,
			@ngaycheckout,
			@xacnhan,
			@thanhtoan)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_ChucVu]    Script Date: 3/20/2021 8:56:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Ins_DangNhap]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng DANGNHAP*/

create proc [dbo].[sp_Ins_DangNhap](@nvid int,
							@mk nvarchar(20),
							@status bit)
as
	insert into DANGNHAP
	values(@nvid, @mk, @status)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_HoaDon_Dung_DichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng HOADON_DUNG_DICHVU*/

create proc [dbo].[sp_Ins_HoaDon_Dung_DichVu](@bookid int,
										@dvid int,
										@ngay date,
										@sl int,
										@thanhtien decimal)
as
	insert into HOADON_DUNG_DICHVU(BookID,
									DichVuID,
									Ngay,
									SoLuong,
									ThanhTien)
	values(@bookid,
			@dvid,
			@ngay,
			@sl,
			@thanhtien)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_KhachHang]    Script Date: 3/20/2021 8:56:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiDichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng LOAIDICHVU*/

create proc [dbo].[sp_Ins_LoaiDichVu](@tendv nvarchar(50),
								@gia decimal,
								@giomo time,
								@giodong time)
as
	insert into LOAIDICHVU(TenDichVu,
							Gia,
							GioMo,
							GioDong)
	values(@tendv,
			@gia,
			@giomo,
			@giodong)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Ins_LoaiVatDung]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng LOAIVATDUNG*/

create proc [dbo].[sp_Ins_LoaiVatDung](@ten nvarchar(50),
								@gia decimal,
								@thietbicd bit)
as
	insert into LOAIVATDUNG(TenVatDung, Gia, ThietBiCoDinh)
	values(@ten, @gia, @thietbicd)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_NhanVien]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng NHANVIEN*/

create proc [dbo].[sp_Ins_NhanVien](@cvid int,
							@ten nvarchar(30),
							@gt bit,
							@ngaysinh datetime,
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
/****** Object:  StoredProcedure [dbo].[sp_Ins_Phong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng PHONG*/

create proc [dbo].[sp_Ins_Phong](@lp int, @status bit)
as
	insert into PHONG(LoaiPhongID, TrangThai)
	values(@lp, @status)
GO
/****** Object:  StoredProcedure [dbo].[sp_Ins_VatDungPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*procedure của bảng VATDUNGPHONG*/

create proc [dbo].[sp_Ins_VatDungPhong](@pid char(3), @vdid int, @sl int, @status bit)
as
	insert into VATDUNGPHONG
	values (@pid, @vdid, @sl, @status)
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_Book]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_Book](@bookid int,
						@phongid char(3), 
						@khid int,
						@nvid int,
						@ngaydat date,
						@ngaycheckin date,
						@ngaycheckout date,
						@xacnhan bit = 0,
						@thanhtoan decimal)
as
	update BOOK
	set PhongID = @phongid,
		KhachHangID = @khid,
		NhanVienID = @nvid,
		NgayDat = @ngaydat,
		NgayCheckIn = @ngaycheckin,
		NgayCheckOut = @ngaycheckout,
		XacNhan = @xacnhan,
		ThanhToan = @thanhtoan
	where BookID = @bookid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_ChucVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_ChucVu](@cvid int, 
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
/****** Object:  StoredProcedure [dbo].[sp_Up_DangNhap]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_DangNhap](@nvid int,
							@mk nvarchar(20),
							@status bit)
as
	update DANGNHAP
	set MatKhau = @mk,
		TrangThai = @status
	where NhanVienID = @nvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_HoaDon_Dung_DichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_HoaDon_Dung_DichVu](@id int,
										@bookid int,
										@dvid int,
										@ngay date,
										@sl int,
										@thanhtien decimal)
as
	update HOADON_DUNG_DICHVU
	set BookID = @bookid,
		DichVuID = @dvid,
		Ngay = @ngay,
		SoLuong = @sl,
		ThanhTien = @thanhtien
	where ID = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_KhachHang]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_KhachHang](@khid int,
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
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiDichVu]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiDichVu](@dvid int,
								@tendv nvarchar(50),
								@gia decimal,
								@giomo time,
								@giodong time)
as
	update LOAIDICHVU
	set TenDichVu = @tendv,
		Gia = @gia,
		GioDong = @giodong,
		GioMo = @giomo
	where DichVuID = @dvid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiPhong](@lpid int,
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
/****** Object:  StoredProcedure [dbo].[sp_Up_LoaiVatDung]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_LoaiVatDung](@vdid int,
								@ten nvarchar(50),
								@gia decimal,
								@thietbicd bit)
as
	update LOAIVATDUNG
	set TenVatDung = @ten, Gia = @gia, ThietBiCoDinh = @thietbicd
	where VatDungID = @vdid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_NhanVien]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_NhanVien](@nvid int,
							@cvid int,
							@ten nvarchar(30),
							@gt bit,
							@ngaysinh datetime,
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
/****** Object:  StoredProcedure [dbo].[sp_Up_Phong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_Phong](@pid int, @lp int, @status bit)
as
	update PHONG
	set LoaiPhongID = @lp,
		TrangThai = @status
	where PhongID = @pid
GO
/****** Object:  StoredProcedure [dbo].[sp_Up_VatDungPhong]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_Up_VatDungPhong](@pid char(3), @vdid int, @sl int, @status bit)
as
	update VATDUNGPHONG
	set SoLuong = @sl, 
		TrangThai = @status
	where PhongID = @pid and VatDungID = @vdid
GO
/****** Object:  Trigger [dbo].[trg_Book_Del]    Script Date: 3/20/2021 8:56:24 AM ******/
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
/****** Object:  Trigger [dbo].[trg_Book_Ins]    Script Date: 3/20/2021 8:56:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Trigger cho cập nhật cho bảng phòng khi bảng book thêm dữ liệu*/
create trigger [dbo].[trg_Book_Ins]
on [dbo].[BOOK]
for insert
as
	update PHONG
	set TrangThai = 0
	from PHONG inner join inserted
	on PHONG.PhongID = inserted.PhongID
	where PHONG.PhongID = inserted.phongid
GO
ALTER TABLE [dbo].[BOOK] ENABLE TRIGGER [trg_Book_Ins]
GO
/****** Object:  Trigger [dbo].[trg_Book_Up]    Script Date: 3/20/2021 8:56:24 AM ******/
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
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
