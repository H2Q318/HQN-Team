using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

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
            foreach (NHANVIEN item in db.NHANVIENs.ToList())
            {
                data.Add(new NV_View(item));
            }
            return data;
        }

        public NHANVIEN GetNhanVienByID(string idNhanVien)
        {
            try
            {
                return new QLKS().NHANVIENs.Find(idNhanVien);
            }
            catch
            {
                return null;
            }
        }

        public List<NV_View> GetListNhanVien(string search, int searchcase)
        {
            List<NV_View> data = new List<NV_View>();
            foreach (NV_View item in GetAllNhanVien())
            {
                switch (searchcase) //Truong hop search
                {
                    case 0: //Ten
                        if (item.Ten.Contains(search))
                        {
                            data.Add(item);
                        }
                        break;
                    case 1: //SDT
                        if (item.SDT.Contains(search))
                        {
                            data.Add(item);
                        }
                        break;
                    case 2: //CMND
                        if (item.CMND.Contains(search))
                        {
                            data.Add(item);
                        }
                        break;
                    case 3: //Dia chi
                        if (item.DiaChi.Contains(search))
                        {
                            data.Add(item);
                        }
                        break;
                }
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

        public List<NV_View> GetListNhanVienSorted(List<string> LnvID, int sortcase)
        {
            List<NV_View> data = GetListNhanVienByID(LnvID);
            switch(sortcase)
            {
                case 0: //ten
                    data = data.OrderBy(p => p.Ten).ToList();
                    break;
                case 1: //gioi tinh
                    data = data.OrderBy(p => p.GioiTinh).ToList();
                    break;
                case 2: //ngay sinh
                    data = data.OrderBy(p => p.NgaySinh).ToList();
                    break;
                case 3: //ten chuc vu
                    data = data.OrderBy(p => p.TenChucVu).ToList();
                    break;
            }
            return data;
        }

        public List<NV_View> GetListNhanVienByID(List<string> LnvID)
        {
            List<NV_View> data = new List<NV_View>();
            foreach (string item in LnvID)
            {
                foreach (NV_View item1 in GetAllNhanVien())
                {
                    if (item.Equals(item1.NhanVienID))
                    {
                        data.Add(item1);
                    }
                }
            }
            return data;
        }

        public int GetQuyenHanByNhanVienID(string nhanvienid)
        {
            QLKS db = new QLKS();
            var nhanVien = db.NHANVIENs.Find(nhanvienid);
            if (nhanVien != null)
            {
                return Convert.ToInt32(nhanVien.CHUCVU.QuyenHan);
            }
            return -1;
        }
    }
}
