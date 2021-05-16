using PBL.BLL;
using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime NgayCheckIn { get; set; }
        public DateTime NgayCheckOut { get; set; }
        public Nullable<DateTime> NgayCheckIn_ThucTe { get; set; }
        public Nullable<DateTime> NgayCheckOut_ThucTe { get; set; }
        public Decimal ThanhToan { get; set; }

        public Book_View(BOOK b)
        {
            BookID = b.BookID;
            PhongID = b.PhongID;
            KhachHangID = b.KhachHangID;
            TenKhachHang = BLL_QLKH.Instance.FindKh(b.KhachHangID).Ten;
            NhanVienID = b.NhanVienID;
            TenNhanVien = BLL_QLNV.Instance.GetNhanVienByID(b.NhanVienID).Ten;
            NgayDat = b.NgayDat;
            NgayCheckIn = (DateTime)b.NgayCheckIn;
            NgayCheckOut = (DateTime)b.NgayCheckOut;
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

        }
    }
}
