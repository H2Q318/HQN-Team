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

create proc sp_Up_KhachHang(@khid nvarchar(13),
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

create proc sp_Del_KhachHang(@khid nvarchar(13))
as
	delete from KHACHHANG
	where KhachHangID = @khid
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

create proc sp_Up_ChucVu(@cvid nvarchar(5), 
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

create proc sp_Del_ChucVu(@cvid nvarchar(5))
as
	delete from CHUCVU	
	where ChucVuID = @cvid
go

/*procedure của bảng NHANVIEN*/

create proc sp_Ins_NhanVien(@cvid nvarchar(5),
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
go

create proc sp_Up_NhanVien(@nvid nvarchar(11),
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
go

create proc sp_Del_NhanVien(@nvid nvarchar(11))
as
	delete from NHANVIEN
	where NhanVienID = @nvid
go

/*procedure của bảng LOAIDICHVU*/

create proc sp_Ins_LoaiDichVu(@tendv nvarchar(50),
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
go

create proc sp_Up_LoaiDichVu(@dvid nvarchar(5),
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
go

create proc sp_Del_LoaiDichVu(@dvid nvarchar(5))
as
	delete from LOAIDICHVU
	where DichVuID = @dvid
go

/*procedure của bảng DANGNHAP*/

create proc sp_Ins_DangNhap(@nvid nvarchar(11),
							@mk nvarchar(20),
							@status bit)
as
	insert into DANGNHAP
	values(@nvid, @mk, @status)
go

create proc sp_Up_DangNhap(@nvid nvarchar(11),
							@mk nvarchar(20),
							@status bit)
as
	update DANGNHAP
	set MatKhau = @mk,
		TrangThai = @status
	where NhanVienID = @nvid
go

create proc sp_Del_DangNhap(@nvid nvarchar(11))
as
	delete from DANGNHAP
	where NhanVienID = @nvid
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

create proc sp_Up_LoaiPhong(@lpid nvarchar(4),
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

create proc sp_Del_LoaiPhong(@lpid nvarchar(4))
as
	delete from LOAIPHONG
	where LoaiPhongID = @lpid
go

/*procedure của bảng LOAIVATDUNG*/

create proc sp_Ins_LoaiVatDung(@ten nvarchar(50),
								@dongia decimal,
								@thietbicd bit)
as
	insert into LOAIVATDUNG(TenVatDung, DonGia, ThietBiCoDinh)
	values(@ten, @dongia, @thietbicd)
go

create proc sp_Up_LoaiVatDung(@vdid nvarchar(5),
								@ten nvarchar(50),
								@dongia decimal,
								@thietbicd bit)
as
	update LOAIVATDUNG
	set TenVatDung = @ten, DonGia = @dongia, ThietBiCoDinh = @thietbicd
	where VatDungID = @vdid
go

create proc sp_Del_LoaiVatDung(@vdid nvarchar(5))
as
	delete from LOAIVATDUNG
	where VatDungID = @vdid
go

/*procedure của bảng PHONG*/

create proc sp_Ins_Phong(@phongid char(3),
						@lp nvarchar(4),
						@status bit)
as
	insert into PHONG
	values(@phongid, @lp, @status)
go

create proc sp_Up_Phong(@pid char(3), @lp nvarchar(4), @status bit)
as
	update PHONG
	set LoaiPhongID = @lp,
		TrangThai = @status
	where PhongID = @pid
go

create proc sp_Del_Phong(@pid char(3))
as
	delete from PHONG
	where PhongID = @pid
go

/*procedure của bảng TRANGTHAIVATDUNG*/

create proc sp_Ins_TrangThaiVatDung(@ttvdid nvarchar(50),
									@mota ntext)
as
	insert into trangthaivatdung
	values(@ttvdid, @mota)
go

create proc sp_Up_TrangThaiVatDung(@ttvdid nvarchar(50),
									@mota ntext)
as
	update trangthaivatdung
	set Mota = @mota
	where TrangThaiVatDungID = @ttvdid
go

create proc sp_Del_TrangThaiVatDung(@ttvdid nvarchar(50))
as
	delete from trangthaivatdung
	where TrangThaiVatDungID = @ttvdid
go

/*procedure của bảng VATDUNGPHONG*/

create proc sp_Ins_VatDungPhong(@pid char(3),
								@vdid nvarchar(5),
								@slbd int,
								@slht int,
								@status nvarchar(50))
as
	insert into VATDUNGPHONG
	values (@pid, @vdid, @slbd, @slht, @status)
go

create proc sp_Up_VatDungPhong(@pid char(3),
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
go

create proc sp_Del_VatDungPhong(@pid char(3), @vdid nvarchar(5))
as
	delete from VATDUNGPHONG
	where PhongID = @pid and VatDungID = @vdid
go

/*procedure của bảng TRANGTHAIBOOK*/

create proc sp_Ins_TrangThaiBook(@ttbid nvarchar(50),
									@Mota ntext)
as
	insert into trangthaibook
	values(@ttbid, @Mota)
go

create proc sp_Up_TrangThaiBook(@ttbid nvarchar(50),
									@Mota ntext)
as
	update trangthaibook
	set Mota = @Mota
	where TrangThaiBookID = @ttbid
go

create proc sp_Del_TrangThaiBook(@ttbid nvarchar(50))
as
	delete from trangthaibook
	where trangthaibookid = @ttbid
go

/*procedure của bảng BOOK*/

create proc sp_Ins_Book(@phongid char(3), 
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
go

create proc sp_Up_Book(@bookid nvarchar(12),
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
go

create proc sp_Del_Book(@bookid nvarchar(12))
as
	delete from BOOK
	where BookID = @bookid
go

/*procedure của bảng HOADON_DUNG_DICHVU*/

create proc sp_Ins_HoaDon_Dung_DichVu(@bookid nvarchar(12),
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
go

create proc sp_Up_HoaDon_Dung_DichVu(@id int,
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
go

create proc sp_Del_HoaDon_Dung_DichVu(@id int)
as
	delete from HOADON_DUNG_DICHVU
	where ID = @id
go

/*procedure của bảng KHACHHANG_BOOK*/

create proc sp_Ins_KhachHang_Book(@khid nvarchar(13),
									@bookid nvarchar(12))
as
	insert into KHACHHANG_BOOK
	values(@khid, @bookid)
go

create proc sp_Del_KhachHang_Book(@khid nvarchar(13),
									@bookid nvarchar(12))
as
	delete from KHACHHANG_BOOK
	where KhachHangID = @khid and BookID = @bookid
go

/*procedure của bảng HOADON*/

create proc sp_Ins_HoaDon(@bookid nvarchar(12),
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
go

create proc sp_Up_HoaDon(@hdid nvarchar(13),
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
go

create proc sp_Del_HoaDon(@hdid nvarchar(13))
as
	delete from HOADON
	where HoaDonID = @hdid
go

/*Procedure tính bảng HOADON - khi khách hàng thuộc bookid_A checkout, sẽ gọi procedure
  này trong chương trình để thực hiện tính tổng tiền hoá đơn cho một bookID_A và lưu vào
  bảng HOADON */
create proc sp_Cal_HoaDon(@bookid nvarchar(12))
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
go
