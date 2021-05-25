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
            TenChucVu = nv.CHUCVU.TenChucVu;
        }
    }
}
