using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.DTO;

namespace PBL.BLL
{
    class BLL_QLBillDV
    {
        private static BLL_QLBillDV _instance;
        public static BLL_QLBillDV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLBillDV();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLBillDV() { }
        public List<HOADON_DUNG_DICHVU> GetListBillDV(string s = null)
        {
            if (s == null)
            {
                return new QLKS().HOADON_DUNG_DICHVU.ToList();
            }
            return new QLKS().HOADON_DUNG_DICHVU.Where(p => p.BookID.Contains(s)).ToList();
        }
        public HOADON_DUNG_DICHVU FindBillDV(int s)
        {
            return new QLKS().HOADON_DUNG_DICHVU.Find(s);
        }
        public List<BillDV_View> GetListBillDV_View(List<HOADON_DUNG_DICHVU> l)
        {
            return l.Select(p => new BillDV_View
            {
                ID = p.ID,
                BookID = p.BookID,
                TenNhanVien = p.NHANVIEN.Ten,
                TenDichVu = p.LOAIDICHVU.TenDichVu,
                Ngay = p.Ngay,
                SoLuong = p.SoLuong,
                ThanhTien = p.ThanhTien
            }).ToList();
        }
        public void AddBillDV(HOADON_DUNG_DICHVU p)
        {
            QLKS db = new QLKS();
            db.HOADON_DUNG_DICHVU.Add(p);
            db.SaveChanges();
        }
        public void UpdateBillDV(HOADON_DUNG_DICHVU p)
        {
            QLKS db = new QLKS();
            var p1 = db.HOADON_DUNG_DICHVU.Find(p.ID);
            p1.NhanVienID = p.NhanVienID;
            p1.BookID = p.BookID;
            p1.DichVuID = p.DichVuID;
            p1.Ngay = p.Ngay;
            p1.SoLuong = p.SoLuong;
            p1.ThanhTien = p.ThanhTien;
            db.SaveChanges();
        }
        public void DeleteBillDV(List<int> l)
        {
            QLKS db = new QLKS();
            foreach(int s in l)
            {
                db.HOADON_DUNG_DICHVU.Remove(db.HOADON_DUNG_DICHVU.Find(s));
                db.SaveChanges();
            }
        }
    }
}
