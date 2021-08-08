using PBL.DAL;
using System;

namespace PBL
{
    class Book_View
    {
        public string BookID { get; set; }
        public string PhongID { get; set; }
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgayDat { get; set; }
        public Nullable<DateTime> NgayCheckIn { get; set; }
        public Nullable<DateTime> NgayCheckOut { get; set; }
        public Nullable<DateTime> NgayCheckIn_ThucTe { get; set; }
        public Nullable<DateTime> NgayCheckOut_ThucTe { get; set; }
        public Decimal ThanhToan { get; set; }
        public Book_View()
        { }
        public Book_View(BOOK b)
        {
            BookID = b.BookID;
            PhongID = b.PhongID;
            KhachHangID = b.KhachHangID;
            TenKhachHang = b.KHACHHANG.Ten;
            NhanVienID = b.NhanVienID;
            TenNhanVien = b.NHANVIEN.Ten;
            NgayDat = b.NgayDat;

            if (b.NgayCheckIn != null)
            {
                NgayCheckIn = (DateTime)b.NgayCheckIn;
            }
            else
            {
                NgayCheckIn = null;
            }

            if (b.NgayCheckOut != null)
            {
                NgayCheckOut = (DateTime)b.NgayCheckOut;
            }
            else
            {
                NgayCheckOut = null;
            }

            if (b.NgayCheckIn_ThucTe != null)
            {
                NgayCheckIn_ThucTe = (DateTime)b.NgayCheckIn_ThucTe;
            }
            else
            {
                NgayCheckIn_ThucTe = null;
            }

            if (b.NgayCheckOut_ThucTe != null)
            {
                NgayCheckOut_ThucTe = (DateTime)b.NgayCheckOut_ThucTe;
            }
            else
            {
                NgayCheckOut_ThucTe = null;
            }
            ThanhToan = b.ThanhToan == null ? 0 : (decimal)b.ThanhToan;
        }
    }
}
