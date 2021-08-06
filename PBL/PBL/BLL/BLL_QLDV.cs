using PBL.DAL;
using System.Collections.Generic;
using System.Linq;

namespace PBL
{
    class BLL_QLDV
    {
        private static BLL_QLDV _instance;
        public static BLL_QLDV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLDV();
                }
                return _instance;
            }
            private set { }
        }
        private BLL_QLDV() { }

        public List<LOAIDICHVU> GetAllDichVu()
        {
            return new QLKS().LOAIDICHVUs.ToList();
        }

        public List<LOAIDICHVU> GetListDichVu(string s)
        {
            List<LOAIDICHVU> data = new List<LOAIDICHVU>();
            foreach(LOAIDICHVU item in GetAllDichVu())
            {
                if (item.TenDichVu.Contains(s))
                {
                    data.Add(item);
                }
            }
            return data;
        }

        public bool AddDichVu(LOAIDICHVU dv)
        {
            try
            {
                QLKS db = new QLKS();
                db.LOAIDICHVUs.Add(dv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDichVu(LOAIDICHVU dv)
        {
            try
            {
                QLKS db = new QLKS();
                var dichvu = db.LOAIDICHVUs.Find(dv.DichVuID);
                dichvu.TenDichVu = dv.TenDichVu;
                dichvu.DonGia = dv.DonGia;
                dichvu.GioMo = dv.GioMo;
                dichvu.GioDong = dv.GioDong;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDichVu(string dvid)
        {
            try
            {
                QLKS db = new QLKS();
                db.LOAIDICHVUs.Remove(db.LOAIDICHVUs.Find(dvid));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LOAIDICHVU> GetListDichVuSorted(List<string> LdvId, int sortcase)
        {
            List<LOAIDICHVU> data = GetListDichVuByID(LdvId);
            switch (sortcase)
            {
                case 0: //Theo ten dich vu
                    data = data.OrderBy(p => p.TenDichVu).ToList();
                    break;
                case 1: //Theo gia
                    data = data.OrderBy(p => p.DonGia).ToList();
                    break;
            }
            return data;
        }

        public List<LOAIDICHVU> GetListDichVuByID(List<string> LdvID)
        {
            List<LOAIDICHVU> data = new List<LOAIDICHVU>();
            foreach (string item in LdvID)
            {
                foreach (LOAIDICHVU item1 in GetAllDichVu())
                {
                    if (item.Equals(item1.DichVuID))
                    {
                        data.Add(item1);
                    }
                }
            }
            return data;
        }

        public void AddDichVu(HOADON_DUNG_DICHVU s)
        {
            QLKS db = new QLKS();
            db.HOADON_DUNG_DICHVU.Add(s);
            db.SaveChanges();
        }

        public List<HOADON_DUNG_DICHVU> GetAllHoaDon(string IDBook)
        {
            return new QLKS().HOADON_DUNG_DICHVU.Where(p => p.BookID == IDBook).ToList();
        }
    }
}
