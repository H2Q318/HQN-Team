sp_ins_khachhang N'Huỳnh Phú Quý',
				 1,
				 '231331427',
				 '0946944601',
				 'Việt Nam',
				 null
go
sp_up_khachhang 'KH12042100001',
				 N'Huỳnh Phú Quý',
				 1,
				 '231331427',
				 '0946944601',
				 N'Việt Nam',
				 null
go

sp_ins_chucvu N'Lễ tân',
			  N'Đặt book và tính hoá đơn',
			  1
go
sp_ins_chucvu N'Admin',
			  N'Quản lý và bảo trì hệ thống',
			  10
go

sp_ins_nhanvien 'CV001',
				N'Hùng Quang Hoàng',
				0,
				'08-31-2001',
				'435236731',
				'0797927276',
				N'3/34 Nguyễn Tri Phương, phường Phú Nhuận, thành phố Huế, tỉnh Thừa Thiên Huế',
				null
go
sp_ins_nhanvien 'CV002',
				N'Nguyên Vũ Xuân',
				0,
				'08-31-2001',
				'435236731',
				'0797927276',
				N'3/34 Nguyễn Tri Phương, phường Phú Nhuận, thành phố Huế, tỉnh Thừa Thiên Huế',
				null
go

sp_ins_loaidichvu N'Xông hơi',
				  100000,
				  '00:00:00.000',
				  '23:59:59.000'
go

sp_ins_dangnhap 'NV120421001',
				'hung',
				0
go

sp_ins_loaiphong 'Suite',
				 70000,
				 2
go

sp_ins_loaivatdung N'Tủ lạnh',
				   7000000,
				   1
go

sp_ins_phong '101',
			 'LP01',
			 1
go
sp_ins_phong '201',
			 'LP01',
			 1
go

sp_ins_trangthaivatdung N'Khách làm hư',
						N'Vật dụng bị khách làm hư, bắt khách đền'
go
sp_ins_trangthaivatdung N'Tốt',
						N'Vật dụng đang ở trạng thái tốt.'
go
sp_ins_trangthaivatdung N'Bảo trì',
						N'Vật dụng đang được bảo trì.'
go

sp_ins_vatdungphong '101',
					'VD001',
					1,
					1,
					N'Tốt'
go
sp_ins_vatdungphong '201',
					'VD001',
					1,
					1,
					N'Tốt'
go

sp_ins_trangthaibook N'Đã thanh toán',
					 N'Khách đã trả phòng và thanh toán hoá đơn.'
go
sp_ins_trangthaibook N'Chưa nhận',
					 N'Khách chưa đến nhận phòng.'
go
sp_ins_trangthaibook N'Đã nhận',
					 N'Khách đã nhận phòng.'
go

sp_ins_book '101',
			'KH12042100001',
			'NV120421001',
			'04-12-2021',
			'04-13-2021',
			'04-15-2021',
			'04-13-2021',
			'04-15-2021',
			N'Chưa nhận',
			null
go

sp_ins_hoadon_dung_dichvu 'B12042100001',
						  'NV120421001',
						  'DV001',
						  '04-12-2021',
						  3,
						  null
go

sp_up_vatdungphong '101',
				   'VD001',
				   1,
				   0,
				   N'Khách làm hư'
go

sp_cal_hoadon 'B12042100001'
go

select * from func_xemchitiethoadon_dichvu('HD12042100001')
go

select * from func_xemchitiethoadon_vattu('HD12042100001')
go
