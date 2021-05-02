/* Function trả về bảng danh sách các hoá đơn dịch vụ của hoá đơn
   có hoadonid được truyền vào */
create function func_XemChiTietHoaDon_DichVu(@hoadonid nvarchar(13))
returns table
as
	return( select *
			from HOADON_DUNG_DICHVU
			where BookID = (select bookid
							from hoadon 
							where hoadonid = @hoadonid))
go
/* Function trả về bảng danh sách các vật dụng bị hư của phòng trong hoá
   đơn có hoadonid được truyền vào */
create function func_XemChiTietHoaDon_VatTu(@hoadonid nvarchar(13))
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
go