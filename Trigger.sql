/*Trigger cho cập nhật cho bảng phòng khi bảng book thêm dữ liệu*/
create trigger trg_Book_Ins
on BOOK
for insert
as
	update PHONG
	set TrangThai = 0
	from PHONG inner join inserted
	on PHONG.PhongID = inserted.PhongID
	where PHONG.PhongID = inserted.phongid
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

	