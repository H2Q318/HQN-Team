/*Đây là các procedure mẫu, đừng có cái nào cũng chạy nhá, chỉ xem thôi :))*/

--sp_ins_khachhang N'Nguyên Xuân Vũ', 1, 231331123, '0914662074', N'Lào', N'Wibu cha'
--sp_up_khachhang 'KH30032100001', N'Vũ Xuân Nguyên', 0, 231331123, '0914662074', N'Campuchia', N'Wibu ông nội'
--sp_del_khachhang 'KH30032100001'

/*
sp_ins_chucvu N'Nhân viên lễ tân', 'Lễ tân là bộ phận chính ở tiền sảnh, là nơi để khách hàng đến đặt phòng, đặt bàn, phản hồi ý kiến và giải đáp thắc mắc . . .', 1
go
sp_ins_chucvu N'Kỹ thuật viên', 'Bảo hành và sửa chữa hệ thống.', 10
go
*/
/*
sp_up_chucvu 'CV007', N'Nhân viên lễ tân', N'Lễ tân là bộ phận chính ở tiền sảnh, là nơi để khách hàng đến đặt phòng, đặt bàn, phản hồi ý kiến và giải đáp thắc mắc . . .', 1
go
sp_up_chucvu 'CV008', N'Kỹ thuật viên', N'Bảo hành và sửa chữa hệ thống.', 10
go
*/
/*
sp_del_chucvu 'CV005'
go
sp_del_chucvu 'CV006'
go
*/

--sp_ins_nhanvien 'CV007', N'Hùng Quang Hoàng', 1, '2001-08-31', '231133213', '0797927276', N'3/34 Nguyễn Tri Phương, phường Phú Nhuận, thành phố Huế, tỉnh Thừa Thiên Huế', 'Wibu con'
--sp_ins_loaidichvu N'Pizza siêu to khổng lồ', 500000, '00:00:00', '00:00:00'
--sp_ins_dangnhap 'NV300321001', 'Toilawbucon', 0
--sp_ins_loaiphong 'Luxury', 2000000, 3
--sp_ins_loaivatdung N'Tủ lạnh', 20000000, 1
--sp_ins_phong '101', 'LP01', 0
--sp_ins_trangthaivatdung N'Tốt', N'Vật dụng vẫn hoạt động tốt, không bị hư hại.'
--sp_ins_vatdungphong '101', 'VD001', 1, N'Tốt'
--sp_ins_trangthaibook N'Chưa nhận', N'Khách hàng chưa nhận book'
--sp_ins_book '101', 'KH30032100002', 'NV300321001', '2021-03-30', '2021-03-30','2021-03-30','2021-03-30','2021-03-30', N'Chưa nhận', 0
--sp_ins_hoadon_dung_dichvu 'B30032100001', 'NV300321001', 'DV001', '2021-03-30', 2, 0
--sp_ins_khachhang_book 'KH30032100002', 'B30032100001'

/*Bảng hoá đơn sẽ có function riêng để tự tính, không cần thêm thủ công !*/

