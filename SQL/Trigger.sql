/*Trigger cập nhật cho bảng phòng khi bảng book thay đổi dữ liệu 

và tự thêm mã khách hàng của khách hàng đại diện trong book vào bảng khách hàng - book khi mới tạo book*/
create trigger trg_Book_Ins
on BOOK
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
go

create trigger trg_Book_Del
on Book
for delete
as
	update PHONG
	set TrangThai = 1
	from PHONG inner join deleted
	on PHONG.PhongID = deleted.PhongID
	where PHONG.PhongID = deleted.PhongID
go

create trigger trg_Book_Up
on BOOK
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

/*Trigger cho bảng hoá đơn khi bảng hoá đơn dùng dịch vụ thay đổi dữ liệu
create trigger trg_HoaDon_Dung_DichVu_Ins
on HOADON_DUNG_DICHVU
for insert
as
	update HOADON
	set TienDichVu = TienDichVu + (select DonGia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.DichVuID) * inserted.SoLuong
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where hoadon.BookID = inserted.BookID
go

create trigger trg_HoaDon_Dung_DichVu_Del
on hoadon_dung_dichvu
for delete
as
	update HOADON
	set TienDichVu = TienDichVu - (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = deleted.dichvuid)
	from HOADON_DUNG_DICHVU inner join deleted
	on HOADON_DUNG_DICHVU.ID = deleted.ID
	where HOADON.BookID = deleted.BookID
go

create trigger trg_HoaDon_Dung_DichVu_Up
on hoadon_dung_dichvu
for update
as
	update HOADON
	set TienDichVu = TienDichVu + (select DonGia from LOAIDICHVU where LOAIDICHVU.DichVuID = inserted.DichVuID) * inserted.SoLuong
	from HOADON_DUNG_DICHVU inner join inserted
	on HOADON_DUNG_DICHVU.ID = inserted.ID
	where hoadon.BookID = inserted.BookID

	update HOADON
	set TienDichVu = TienDichVu - (select dongia from LOAIDICHVU where LOAIDICHVU.DichVuID = deleted.dichvuid)
	from HOADON_DUNG_DICHVU inner join deleted
	on HOADON_DUNG_DICHVU.ID = deleted.ID
	where HOADON.BookID = deleted.BookID
go*/
	