/*procedure của bảng BOOK*/
create proc sp_Ins_Book(@phongid char(3), 
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
go

create proc sp_Up_Book(@bookid int,
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
go

create proc sp_Del_Book(@bookid int)
as
	delete from BOOK
	where BookID = @bookid
go

/*procedure của bảng CHUCVU*/
create proc sp_Ins_ChucVu(@tencv nvarchar(30),
							@mota ntext,
							@quyenhan int)
as
	insert into CHUCVU(TenChucVu,
						MoTa,
						QuyenHan)
	values(@tencv, @mota, @quyenhan)
go

create proc sp_Up_ChucVu(@cvid int, 
							@tencv nvarchar(30),
							@mota ntext,
							@quyenhan int)
as
	update CHUCVU
	set TenChucVu = @tencv,
		MoTa = @mota,
		QuyenHan = @quyenhan
	where ChucVuID = @cvid
go

create proc sp_Del_ChucVu(@cvid int)
as
	delete from CHUCVU	
	where ChucVuID = @cvid
go

/*procedure của bảng DANGNHAP*/

create proc sp_Ins_DangNhap(@nvid int,
							@mk nvarchar(20),
							@status bit)
as
	insert into DANGNHAP
	values(@nvid, @mk, @status)
go

create proc sp_Up_DangNhap(@nvid int,
							@mk nvarchar(20),
							@status bit)
as
	update DANGNHAP
	set MatKhau = @mk,
		TrangThai = @status
	where NhanVienID = @nvid
go

create proc sp_Del_DangNhap(@nvid int)
as
	delete from DANGNHAP
	where NhanVienID = @nvid
go

/*procedure của bảng HOADON_DUNG_DICHVU*/

create proc sp_Ins_HoaDon_Dung_DichVu(@bookid int,
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
go

create proc sp_Up_HoaDon_Dung_DichVu(@id int,
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
go

create proc sp_Del_HoaDon_Dung_DichVu(@id int)
as
	delete from HOADON_DUNG_DICHVU
	where ID = @id
go

/*procedure của bảng KHACHHANG*/

create proc sp_Ins_KhachHang(@ten nvarchar(30),
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
go

create proc sp_Up_KhachHang(@khid int,
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
go

create proc sp_Del_KhachHang(@khid int)
as
	delete from KHACHHANG
	where KhachHangID = @khid
go

/*procedure của bảng LOAIDICHVU*/

create proc sp_Ins_LoaiDichVu(@tendv nvarchar(50),
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
go

create proc sp_Up_LoaiDichVu(@dvid int,
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
go

create proc sp_Del_LoaiDichVu(@dvid int)
as
	delete from LOAIDICHVU
	where DichVuID = @dvid
go

/*procedure của bảng LOAIPHONG*/

create proc sp_Ins_LoaiPhong(@ten nvarchar(50),
								@gia decimal,
								@songuoi int)
as
	insert into LOAIPHONG(TenLoaiPhong,
							Gia,
							SoNguoi)
	values(@ten,
			@gia,
			@songuoi)
go

create proc sp_Up_LoaiPhong(@lpid int,
								@ten nvarchar(50),
								@gia decimal,
								@songuoi int)
as
	update LOAIPHONG
	set TenLoaiPhong = @ten,
		Gia = @gia,
		SoNguoi = @songuoi
	where LoaiPhongID = @lpid
go

create proc sp_Del_LoaiPhong(@lpid int)
as
	delete from LOAIPHONG
	where LoaiPhongID = @lpid
go

/*procedure của bảng LOAIVATDUNG*/

create proc sp_Ins_LoaiVatDung(@ten nvarchar(50),
								@gia decimal,
								@thietbicd bit)
as
	insert into LOAIVATDUNG(TenVatDung, Gia, ThietBiCoDinh)
	values(@ten, @gia, @thietbicd)
go

create proc sp_Up_LoaiVatDung(@vdid int,
								@ten nvarchar(50),
								@gia decimal,
								@thietbicd bit)
as
	update LOAIVATDUNG
	set TenVatDung = @ten, Gia = @gia, ThietBiCoDinh = @thietbicd
	where VatDungID = @vdid
go

create proc sp_Del_LoaiVatDung(@vdid int)
as
	delete from LOAIVATDUNG
	where VatDungID = @vdid
go

/*procedure của bảng NHANVIEN*/

create proc sp_Ins_NhanVien(@cvid int,
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
go

create proc sp_Up_NhanVien(@nvid int,
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
go

create proc sp_Del_NhanVien(@nvid int)
as
	delete from NHANVIEN
	where NhanVienID = @nvid
go

/*procedure của bảng PHONG*/

create proc sp_Ins_Phong(@lp int, @status bit)
as
	insert into PHONG(LoaiPhongID, TrangThai)
	values(@lp, @status)
go

create proc sp_Up_Phong(@pid int, @lp int, @status bit)
as
	update PHONG
	set LoaiPhongID = @lp,
		TrangThai = @status
	where PhongID = @pid
go

create proc sp_Del_Phong(@pid int)
as
	delete from PHONG
	where PhongID = @pid
go

/*procedure của bảng VATDUNGPHONG*/

create proc sp_Ins_VatDungPhong(@pid char(3), @vdid int, @sl int, @status bit)
as
	insert into VATDUNGPHONG
	values (@pid, @vdid, @sl, @status)
go

create proc sp_Up_VatDungPhong(@pid char(3), @vdid int, @sl int, @status bit)
as
	update VATDUNGPHONG
	set SoLuong = @sl, 
		TrangThai = @status
	where PhongID = @pid and VatDungID = @vdid
go

create proc sp_Del_VatDungPhong(@pid char(3), @vdid int)
as
	delete from VATDUNGPHONG
	where PhongID = @pid and VatDungID = @vdid
go