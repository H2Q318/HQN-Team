using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.DTO;

namespace PBL.BLL
{
    class BLL_QLBill
    {
        private static BLL_QLBill _instance;
        public static BLL_QLBill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLBill();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLBill() { }
        public List<HOADON> GetListHoaDon(string bookid = null)
        {
            if (string.IsNullOrEmpty(bookid))
            {
                return new QLKS().HOADONs.ToList();
            }
            return new QLKS().HOADONs.Where(p => p.BookID.Contains(bookid)).ToList();
        }
        public void DeleteHoaDon(List<string> l)
        {
            QLKS db = new QLKS();
            foreach(string s in l)
            {
                db.HOADONs.Remove(db.HOADONs.Find(s));
            }
            db.SaveChanges();
        }
        public HOADON FindHoaDon(string hoadonid)
        {
            return new QLKS().HOADONs.Find(hoadonid);
        }
        public List<BillDV_View> BillService(string hoadonid)
        {
            return BLL_QLBillDV.Instance.GetListBillDV_View(BLL_QLBillDV.Instance.GetListBillDV(new QLKS().HOADONs.Find(hoadonid).BookID));
        }
        public IQueryable<func_XemChiTietHoaDon_VatTu_Result> BillRoomSupplies(string hoadonid)
        {
            return new QLKS().func_XemChiTietHoaDon_VatTu(hoadonid);
        }
        public List<HOADON> Sort(string s, List<string> l)
        {
            QLKS db = new QLKS();
            List<HOADON> data = new List<HOADON>();
            foreach(string i in l)
            {
                data.Add(db.HOADONs.Find(i));
            }
            switch(s)
            {
                case "Mã book":
                    data = data.OrderByDescending(p => p.BookID).ToList();
                    break;
                case "Tổng tiền phòng":
                    data = data.OrderByDescending(p => p.TienPhong).ToList();
                    break;
                case "Tổng tiền dịch vụ":
                    data = data.OrderByDescending(p => p.TienDichVu).ToList();
                    break;
                case "Tổng tiền vật tư":
                    data = data.OrderByDescending(p => p.TienVatTu).ToList();
                    break;
                case "Tổng tiền":
                    data = data.OrderByDescending(p => p.TongTien).ToList();
                    break;
                case "Ngày thanh toán":
                    data = data.OrderByDescending(p => p.NgayThanhToan).ToList();
                    break;
            }
            return data;
        }

        public decimal[] GetRevenueDataInYear()
        {
            QLKS db = new QLKS();
            decimal[] data = new decimal[12];
            foreach (HOADON item in db.HOADONs.ToList())
            {
                if (item.TongTien != null)
                {
                    data[item.NgayThanhToan.Month - 1] += (decimal)item.TongTien;
                }
                else
                {
                    data[item.NgayThanhToan.Month - 1] += 0;
                }
            }
            return data;
        }

        public decimal[] GetRevenueDataInMonth(int month)
        {
            QLKS db = new QLKS();
            decimal[] data = new decimal[DateTime.DaysInMonth(DateTime.Now.Year, month)];
            foreach (HOADON item in db.HOADONs.ToList())
            {
                if (item.NgayThanhToan.Month == month)
                {
                    if (item.TongTien != null)
                    {
                        data[item.NgayThanhToan.Day - 1] += (decimal)item.TongTien;
                    }
                    else
                    {
                        data[item.NgayThanhToan.Day - 1] += 0;
                    }
                } 
            }
            return data;
        }
    }
}
