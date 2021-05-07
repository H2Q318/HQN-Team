using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class BLL_QLNV
    {
        private static BLL_QLNV _instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLNV();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLNV() { }

        public List<NV_View> GetAllNhanVien()
        {
            List<NV_View> data = new List<NV_View>();
            QLKS db = new QLKS();
            foreach(NHANVIEN item in db.NHANVIENs.ToList())
            {
                data.Add(new NV_View(item));
            }
            return data;
        }

        public bool AddNhanVien(NHANVIEN nv)
        {
            try
            {
                QLKS db = new QLKS();
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNhanVien(NHANVIEN nv)
        {
            try
            {
                QLKS db = new QLKS();
                var nhanvien = db.NHANVIENs.Find(nv.NhanVienID);
                nhanvien.Ten = nv.Ten;
                nhanvien.GioiTinh = nv.GioiTinh;
                nhanvien.NgaySinh = nv.NgaySinh;
                nhanvien.CMND = nv.CMND;
                nhanvien.SDT = nv.SDT;
                nhanvien.DiaChi = nv.DiaChi;
                nhanvien.ChucVuID = nv.ChucVuID;
                nhanvien.GhiChu = nv.GhiChu;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNhanVien(string nvid)
        {
            try
            {
                QLKS db = new QLKS();
                db.NHANVIENs.Remove(db.NHANVIENs.Find(nvid));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
