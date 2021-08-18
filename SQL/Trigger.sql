/*Trigger cập nhật cho bảng phòng khi bảng book thay đổi dữ liệu 
  Tự thêm mã khách hàng của khách hàng đại diện trong book vào bảng khách hàng - book khi mới tạo book
  Tự đổi trạng thái phòng khi xoá book */
create trigger trg_Book_Ins
on BOOK
for insert
as
	if (select NgayCheckIn_ThucTe from inserted) is not null
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
go

create trigger trg_Book_Up
on BOOK
for update
as 
	update PHONG
	set TrangThai = 1
	from PHONG inner join deleted
	on PHONG.PhongID = deleted.PhongID
	where PHONG.PhongID = deleted.PhongID

	if (select NgayCheckIn_ThucTe from inserted) is not null
		update PHONG
		set TrangThai = 0
		from PHONG inner join inserted
		on PHONG.PhongID = inserted.PhongID
		where PHONG.PhongID = inserted.PhongID
	else
		update PHONG
		set TrangThai = 1
		from PHONG inner join inserted
		on PHONG.PhongID = inserted.PhongID
		where PHONG.PhongID = inserted.PhongID

	if (select NgayCheckOut_ThucTe from inserted) is not null
		update PHONG
		set TrangThai = 1
		from PHONG inner join inserted
		on PHONG.PhongID = inserted.PhongID
		where PHONG.PhongID = inserted.PhongID
go

create trigger trg_Book_Del
on BOOK
for delete
as
	if (select ngaycheckin_thucte from deleted) is not null
		update PHONG
		set TrangThai = 1
		from PHONG inner join deleted
		on PHONG.PhongID = deleted.PhongID
		where PHONG.PhongID = deleted.PhongID
go

/*Trigger cập nhật cho bảng HOADON_DUNG_DICHVU tự tính tổng tiền*/
create trigger trg_HoaDon_Dung_DichVu_Ins
on hoadon_dung_dichvu
for insert
as
	update HOADON_DUNG_DICHVU
	set ThanhTien = inserted.soluong * (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.dichvuid)
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where HOADON_DUNG_DICHVU.ID = inserted.ID
go

create trigger trg_HoaDon_Dung_DichVu_Up
on hoadon_dung_dichvu
for update
as
	update HOADON_DUNG_DICHVU
	set ThanhTien = inserted.soluong * (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.dichvuid)
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where HOADON_DUNG_DICHVU.ID = inserted.ID
go

create trigger trg_dangnhap_up
on dangnhap
for update
as
	declare @nhanvienid nvarchar(11)
	declare @trangthai bit
	select @nhanvienid = nhanvienid, @trangthai = trangthai from inserted
	insert into lichsudangnhap
	values (@nhanvienid,
	case when @trangthai = 0 then N'Đăng xuất' else N'Đăng nhập' end,
	GETDATE())
go