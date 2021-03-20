create table KHACHHANG
(
	KhachHangID int not null,
	Ten nvarchar(30) not null,
	GioiTinh bit null,
	CMND nvarchar(10) not null,
	SDT nvarchar(11) not null,
	QuocTich nvarchar(30) null,
	GhiChu ntext null,
	constraint pk_khachhang primary key (khachhangid)
)
go

create table CHUCVU
(
	ChucVuID int not null,
	TenChucVu nvarchar(30) not null,
	MoTa ntext null,
	QuyenHan int not null,
	constraint pk_chucvu primary key (chucvuid)
)
go

create table NHANVIEN
(
	NhanVienID int not null,
	ChucVuID int not null,
	Ten nvarchar(30) not null,
	GioiTinh bit null,
	NgaySinh datetime not null,
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

create table LOAIDICHVU
(
	DichVuID int not null,
	TenDichVu nvarchar(50) not null,
	Gia decimal not null,
	GioMo time null, 
	GioDong time null,
	constraint pk_dichvu primary key (dichvuid)
)
go

create table DANGNHAP
(
	NhanVienID int not null, 
	MatKhau nvarchar(20) not null,
	TrangThai bit not null,
	constraint pk_dangnhap primary key (nhanvienid),
	constraint fk_dangnhap_nhanvienid foreign key (nhanvienid) references nhanvien(nhanvienid)
	on delete cascade
	on update cascade
)
go

create table LOAIPHONG
(
	LoaiPhongID int not null,
	TenLoaiPhong nvarchar(50) not null,
	Gia decimal not null,
	SoNguoi int not null,
	constraint pk_loaiphong primary key (loaiphongid)
)
go

create table LOAIVATDUNG
(
	VatDungID int not null,
	TenVatDung nvarchar(50) not null, 
	Gia decimal not null,
	ThietBiCoDinh bit,
	constraint pk_loaivatdung primary key (vatdungid)
)
go

create table PHONG
(
	PhongID char(3) not null,
	LoaiPhongID int not null,
	TrangThai bit not null,
	constraint pk_phong primary key (phongid),
	constraint fk_phong_loaiphongid foreign key (loaiphongid) references loaiphong(loaiphongid)
	on delete cascade
	on update cascade
)
go

create table VATDUNGPHONG
(
	PhongID char(3) not null,
	VatDungID int not null,
	SoLuong int not null,
	TrangThai bit not null,
	constraint pk_vatdungphong primary key (phongid, vatdungid),
	constraint fk_vatdungphong_vatdungid foreign key (vatdungid) references loaivatdung(vatdungid)
	on delete cascade
	on update cascade,
	constraint fk_vatdungphong_phongid foreign key (phongid) references phong(phongid)
	on delete cascade
	on update cascade
)
go

create table BOOK
(
	BookID int not null, 
	PhongID char(3) not null,
	KhachHangID int not null, 
	NhanVienID int not null,
	NgayDat date not null,
	NgayCheckIn date not null,
	NgayCheckOut date not null,
	XacNhan bit null,
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
	constraint chk_ngaydat check(NgayDat >= getdate()),
	constraint chk_ngaycheckin check(NgayCheckIn >= NgayDat),
	constraint chk_ngaycheckout check(NgayCheckOut >= NgayCheckIn)
)
go

create table HOADON_DUNG_DICHVU
(
	ID int not null,
	BookID int not null,
	DichVuID int not null,
	Ngay date not null,
	SoLuong int not null,
	ThanhTien decimal not null,
	constraint pk_hoadon_dung_dichvu primary key (ID),
	constraint fk_hoadon_bookid foreign key (bookid) references book(bookid)
	on delete cascade
	on update cascade,
	constraint fk_hoadon_dichvuid foreign key (dichvuid) references loaidichvu(dichvuid)
	on delete cascade
	on update cascade
)
go