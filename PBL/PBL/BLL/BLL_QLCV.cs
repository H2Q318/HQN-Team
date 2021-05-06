using PBL.DAL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class BLL_QLCV
    {
        public delegate bool Compare(object o1, object o2);
        public Compare cmp { get; set; }

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

        public void Sort(ref List<object> data, Compare cmp)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        object temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }

        public List<object> GetListChucVuSorted(List<string> LcvID, int sortcase)
        {
            List<CHUCVU> lcv = GetListChucVuByID(LcvID);
            List<object> data = new List<object>();
            foreach(CHUCVU item in lcv)
            {
                data.Add(item);
            }
            switch (sortcase)
            {
                case 0:
                    cmp = DTO_ChucVu.Compare_TenChucVu;
                    break;
                case 1:
                    cmp = DTO_ChucVu.Compare_QuyenHan;
                    break;
            }
            Sort(ref data, cmp);
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
