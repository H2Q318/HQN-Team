using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<CHUCVU> SearchChucVu(string s)
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
                return true;.
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
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
