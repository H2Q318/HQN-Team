using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class BLL_QLDV
    {
        public delegate bool Compare(object o1, object o2);
        public Compare cmp { get; set; }

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

        public List<object> GetListDichVuSorted(List<string> LdvId, int sortcase)
        {
            List<LOAIDICHVU> ldv = GetListDichVuByID(LdvId);
            List<object> data = new List<object>();
            foreach(LOAIDICHVU item in ldv)
            {
                data.Add(item);
            }
            switch (sortcase)
            {
                case 0: //Theo ten dich vu
                    cmp = DTO_DichVu.Compare_TenDichVu;
                    break;
                case 1: //Theo gia
                    cmp = DTO_DichVu.Compare_Gia;
                    break;
            }
            Sort(ref data, cmp);
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
    }
}
