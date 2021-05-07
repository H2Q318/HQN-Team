create sequence seq_khachhang
	start with 1
	increment by 1
	minvalue 1
	maxvalue 99999
	cycle
go

create table KHACHHANG
(
	KhachHangID nvarchar(13) not null
	constraint df_khachhang_khachhangid default ('KH' + format(getdate(), 'ddMMyy') +format((next value for seq_khachhang),'00000' )),
	Ten nvarchar(30) not null,
	GioiTinh bit null,
	CMND nvarchar(10) not null,
	SDT nvarchar(11) not null,
	QuocTich nvarchar(30) null,
	GhiChu ntext null,
	constraint pk_khachhang primary key (khachhangid),
)
go

create sequence seq_chucvu
	start with 1
	increment by 1
	minvalue 1
	maxvalue 999
	cycle
go

create table CHUCVU
(
	ChucVuID nvarchar(5) not null
	constraint df_chucvu_chucvuid default ('CV' + format((next value for seq_chucvu), '000')),
	TenChucVu nvarchar(30) not null,
	MoTa ntext null,
	QuyenHan int not null,
	constraint pk_chucvu primary key (chucvuid),
)
go

create sequence seq_nhanvien
	start with 1
	increment by 1
	minvalue 1
	maxvalue 999
	cycle
go

create table NHANVIEN
(
	NhanVienID nvarchar(11) not null
	constraint df_nhanvien_nhanvienid default ('NV' + format(getdate(), 'ddMMyy') + format((next value for seq_nhanvien), '000')),
	ChucVuID nvarchar(5) not null,
	Ten nvarchar(30) not null,
	GioiTinh bit null,
	NgaySinh date not null,
	CMND nvarchar(10) not null,
	SDT nvarchar(11) not null,
	DiaChi nvarchar(100) null,
	GhiChu ntext null,
	constraint pk_nhanvien primary key (nhanvienid),
	constraint fk_nhanvien_chucvuid foreign key (chucvuid) references chucvu(chucvuid)
	on delete cascade
	on update cascade,
	constraint chk_ngaysinh check(NgaySinh <= getdate())
)
go
create sequence seq_loaidichvu
	start with 1
	increment by 1
	minvalue 1
	maxvalue 999
	cycle
go

create table LOAIDICHVU
(
	DichVuID nvarchar(5) not null
	constraint df_loaidichvu_dichvuid default ('DV' + format((next value for seq_loaidichvu), '000')),
	TenDichVu nvarchar(50) not null,
	DonGia decimal not null,
	GioMo time null, 
	GioDong time null,
	constraint pk_dichvu primary key (dichvuid)
)
go

create table DANGNHAP
(
	NhanVienID nvarchar(11) not null, 
	MatKhau nvarchar(20) not null,
	TrangThai bit not null,
	constraint pk_dangnhap primary key (nhanvienid),
	constraint fk_dangnhap_nhanvienid foreign key (nhanvienid) references nhanvien(nhanvienid)
	on delete cascade
	on update cascade
)
go

create sequence seq_loaiphong
	start with 1
	increment by 1
	minvalue 1
	maxvalue 99
	cycle
go

create table LOAIPHONG
(
	LoaiPhongID nvarchar(4) not null
	constraint df_loaiphong_loaiphongid default ('LP' + format((next value for seq_loaiphong), '00')),
	TenLoaiPhong nvarchar(50) not null,
	Gia decimal not null,
	SoNguoi int not null,
	constraint pk_loaiphong primary key (loaiphongid)
)
go

create sequence seq_loaivatdung
	start with 1
	increment by 1
	minvalue 1
	maxvalue 999
	cycle
go

create table LOAIVATDUNG
(
	VatDungID nvarchar(5) not null
	constraint df_loaivatdung_vatdungid default ('VD' + format((next value for seq_loaivatdung), '000')),
	TenVatDung nvarchar(50) not null, 
	DonGia decimal not null,
	ThietBiCoDinh bit,
	constraint pk_loaivatdung primary key (vatdungid)
)
go

create table PHONG
(
	PhongID char(3) not null,
	LoaiPhongID nvarchar(4) not null,
	TrangThai bit not null,
	constraint pk_phong primary key (phongid),
	constraint fk_phong_loaiphongid foreign key (loaiphongid) references loaiphong(loaiphongid)
	on delete cascade
	on update cascade
)
go

create table TRANGTHAIVATDUNG
(
	TrangThaiVatDungID nvarchar(50) not null,
	Mota ntext null,
	constraint pk_trangthaivatdung_trangthaivatdungid primary key (trangthaivatdungid)
)
go

create table VATDUNGPHONG
(
	PhongID char(3) not null,
	VatDungID nvarchar(5) not null,
	SoLuongBanDau int not null,
	SoLuongHienTai int not null,
	TrangThaiVatDungID nvarchar(50) not null,
	constraint pk_vatdungphong primary key (phongid, vatdungid),
	constraint fk_vatdungphong_vatdungid foreign key (vatdungid) references loaivatdung(vatdungid)
	on delete cascade
	on update cascade,
	constraint fk_vatdungphong_phongid foreign key (phongid) references phong(phongid)
	on delete cascade
	on update cascade,
	constraint fk_vatdungphong_trangthaivatdungid foreign key (trangthaivatdungid) references trangthaivatdung(trangthaivatdungid)
	on delete cascade
	on update cascade
)
go

create sequence seq_book
	start with 1
	increment by 1
	minvalue 1
	maxvalue 99999
	cycle
go

create table BOOK
(
	BookID nvarchar(12) not null
	constraint df_book_bookid default ('B' + format(getdate(), 'ddMMyy') + format((next value for seq_book), '00000')), 
	PhongID char(3) not null,
	KhachHangID nvarchar(13) not null, 
	NhanVienID nvarchar(11) not null,
	NgayDat datetime not null,
	NgayCheckIn datetime null,
	NgayCheckOut datetime null,
	NgayCheckIn_ThucTe datetime null,
	NgayCheckOut_ThucTe datetime null,
	TrangThaiBookID nvarchar(50) null,
	ThanhToan decimal null,
	constraint pk_book primary key (bookid),
	constraint fk_book_phongid foreign key (phongid) references phong(phongid)
	on delete cascade
	on update cascade,
	constraint fk_book_khachhangid foreign key (khachhangid) references khachhang(khachhangid)
	on delete cascade
	on update cascade,
	constraint fk_book_nhanvienid foreign key (nhanvienid) references nhanvien(nhanvienid)
	on delete cascade
	on update cascade,
	constraint fk_book_trangthaibookid foreign key (TrangThaiBookID) references trangthaibook(TrangThaiBookID)
	on delete cascade
	on update cascade
)
go

create table HOADON_DUNG_DICHVU
(
	ID int not null identity,
	BookID nvarchar(12) not null,
	NhanVienID nvarchar(11) not null,
	DichVuID nvarchar(5) not null,
	Ngay datetime not null,
	SoLuong int not null,
	ThanhTien decimal null,
	constraint pk_hoadon_dung_dichvu primary key (ID),
	constraint fk_hoadon_dung_dichvu_bookid foreign key (bookid) references book(bookid),
	--on delete cascade
	--on update cascade,
	constraint fk_hoadon_dung_dichvu_dichvuid foreign key (dichvuid) references loaidichvu(dichvuid),
	--on delete cascade
	--on update cascade,
	constraint fk_hoadon_dung_dichvu_nhanvienid foreign key (nhanvienid) references nhanvien(nhanvienid)
	--on delete cascade
	--on update cascade
)
go

create table KHACHHANG_BOOK
(
	KhachHangID nvarchar(13) not null,
	BookID nvarchar(12) not null
	constraint pk_khachhang_book primary key (khachhangid, bookid),
	constraint fk_khachhang_book_khachhangid foreign key (khachhangid) references khachhang(khachhangid)
	on delete cascade
	on update cascade,
	constraint fk_khachhang_book_bookid foreign key (bookid) references book(bookid)
	--on delete cascade
	--on update cascade
)
go

create sequence seq_hoadon
	start with 1
	increment by 1
	minvalue 1
	maxvalue 99999
	cycle
go 

create table HOADON
(
	HoaDonID nvarchar(13) not null
	constraint df_hoadon_hoadonid default ('HD' + format(getdate(), 'ddMMyy') + format((next value for seq_hoadon), '00000')),
	BookID nvarchar(12) not null,
	NgayThanhToan datetime not null
	constraint df_hoadon_ngaythanhtoan default getdate(),
	TienPhong decimal null
	constraint df_hoadon_tienphong default 0,
	TienDichVu decimal null
	constraint df_hoadon_tiendichvu default 0,
	TienVatTu decimal null
	constraint df_hoadon_tienvattu default 0,
	TongTien decimal null
	constraint df_hoadon_tongtien default 0,
	GhiChu ntext null,
	constraint pk_hoadon_hoadonid primary key (hoadonid),
	constraint fk_hoadon_bookid foreign key (bookid) references book(bookid)
)
go
