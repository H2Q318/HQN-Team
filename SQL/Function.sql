/* Function trả về bảng danh sách các hoá đơn dịch vụ của hoá đơn
   có hoadonid được truyền vào */
create function func_XemChiTietHoaDon_DichVu(@hoadonid nvarchar(13))
returns table
as
	return( 
	        select TenDichVu, DonGia, sum(SoLuong) as 'TongSoLuong', sum(ThanhTien) as 'TongThanhTien'
			from HOADON_DUNG_DICHVU inner join LOAIDICHVU
			on HOADON_DUNG_DICHVU.DichVuID = LOAIDICHVU.DichVuID
			where BookID = (select bookid
							from hoadon 
							where hoadonid = @hoadonid)
			group by TenDichVu, DonGia
		   )
go
/* Function trả về bảng danh sách các vật dụng bị hư của phòng trong hoá
   đơn có hoadonid được truyền vào */
create function func_XemChiTietHoaDon_VatTu(@hoadonid nvarchar(13))
returns table
as	
	return(
		   select TenVatDung, SoLuongHu, DonGia from HOADONVATDUNGPHONG 
		   where BookID = (select BookID from HOADON where HoaDonID = @hoadonid)
		         and PhongID = (select PhongID from HOADON where HoaDonID = @hoadonid)
		  )
go