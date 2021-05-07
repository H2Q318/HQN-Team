using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class NV_View
    {
        public string NhanVienID { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ChucVuID { get; set; }
        public string TenChucVu { get; set; }
        public string GhiChu { get; set; }
        public NV_View(NHANVIEN nv)
        {
            NhanVienID = nv.NhanVienID;
            Ten = nv.Ten;
            GioiTinh = (bool)nv.GioiTinh;
            NgaySinh = nv.NgaySinh;
            CMND = nv.CMND;
            SDT = nv.SDT;
            DiaChi = nv.DiaChi;
            ChucVuID = nv.ChucVuID;
            GhiChu = nv.GhiChu;
            QLKS db = new QLKS();
            foreach(CHUCVU item in db.CHUCVUs.ToList())
            {
                if (ChucVuID == item.ChucVuID)
                {
                    TenChucVu = item.TenChucVu;
                }
            }
        }

        public static bool Compare_TenNhanVien(object o1, object o2)
        {
            if (string.Compare(((NV_View)o1).Ten, ((NV_View)o2).Ten) > 0){
                return true;
            }
            return false;
        }

        public static bool Compare_GioiTinh(object o1, object o2)
        {
            return (bool)(((NV_View)o1).GioiTinh);
        }

        public static bool Compare_NamSinh(object o1, object o2)
        {
            if (((NV_View)o1).NgaySinh > ((NV_View)o1).NgaySinh)
            {
                return true;
            }
            return false;
        }

        public static bool Compare_Chucvu(object o1, object o2)
        {
            if (string.Compare(((NV_View)o1).TenChucVu, ((NV_View)o2).TenChucVu) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
