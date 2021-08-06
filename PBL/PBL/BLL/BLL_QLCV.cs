using PBL.DAL;
using PBL.DTO;
using System.Collections.Generic;
using System.Linq;

namespace PBL
{
    class BLL_QLCV
    {
        private static BLL_QLCV _instance;
        public static BLL_QLCV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLCV();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLCV() { }

        public List<CHUCVU> GetAllChucVu()
        {
            return new QLKS().CHUCVUs.ToList();
        }

        public List<CHUCVU> GetListChucVu(string s)
        {
            List<CHUCVU> data = new List<CHUCVU>();
            foreach (CHUCVU item in GetAllChucVu())
            {
                if (item.TenChucVu.Contains(s))
                {
                    data.Add(item);
                }
            }
            return data;
        }

        public bool AddChucVu(CHUCVU cv)
        {
            try
            {
                QLKS db = new QLKS();
                db.CHUCVUs.Add(cv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateChucVu(CHUCVU cv)
        {
            try
            {
                QLKS db = new QLKS();
                var chucvu = db.CHUCVUs.Find(cv.ChucVuID);
                chucvu.TenChucVu = cv.TenChucVu;
                chucvu.MoTa = cv.MoTa;
                chucvu.QuyenHan = cv.QuyenHan;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteChucVu(string cvid)
        {
            try
            {
                QLKS db = new QLKS();
                db.CHUCVUs.Remove(db.CHUCVUs.Find(cvid));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CHUCVU> GetListChucVuSorted(List<string> LcvID, int sortcase)
        {
            List<CHUCVU> data = GetListChucVuByID(LcvID);
            switch (sortcase)
            {
                case 0:
                    data = data.OrderBy(p => p.TenChucVu).ToList();
                    break;
                case 1:
                    data = data.OrderBy(p => p.QuyenHan).ToList();
                    break;
            }
            return data;
        }

        public List<CHUCVU> GetListChucVuByID(List<string> LcvID)
        {
            List<CHUCVU> data = new List<CHUCVU>();
            foreach(string item in LcvID)
            {
                foreach(CHUCVU item1 in GetAllChucVu())
                {
                    if (item.Equals(item1.ChucVuID))
                    {
                        data.Add(item1);
                    }
                }
            }
            return data;
        }

        public List<CBBItem> GetListCBBChucVu()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(CHUCVU item in GetAllChucVu())
            {
                data.Add(new CBBItem { Value = item.ChucVuID, Text = item.TenChucVu });
            }
            return data;
        }
    }
}
