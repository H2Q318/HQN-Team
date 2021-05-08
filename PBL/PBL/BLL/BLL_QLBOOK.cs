using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.BLL
{
    class BLL_QLBOOK
    {
        private static BLL_QLBOOK _instance;
        public static BLL_QLBOOK Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLBOOK();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLBOOK() { }
        public string GetIdCheckinByIDRoom(string id)
        {

            var s = new QLKS().BOOKs
                   .Where(p => p.NgayCheckIn_ThucTe != null && p.NgayCheckOut_ThucTe == null && p.PhongID == id)
                   .Select(p => p.BookID).ToList();
            if (s.Count == 0)
            {
                return "-1";

            }
            else
            {
                return s[0].ToString();
            }

        }
        public void AddBook(BOOK s)
        {
            QLKS db = new QLKS();
            if (db.BOOKs.Where(p => (p.PhongID == s.PhongID) && (p.NgayCheckIn_ThucTe != null) && (p.NgayCheckOut_ThucTe == null)).Select(p => p.BookID).ToList().Count > 0)
            {
                MessageBox.Show("Phòng đang được book");
                return;
            }
            var z = db.BOOKs.Where(p => p.PhongID == s.PhongID && (p.NgayCheckIn != null) && (p.NgayCheckIn_ThucTe == null) && (p.KhachHangID == s.KhachHangID)).Select(p => p.BookID).ToList();
            if (z.Count > 0)
            {
                db.BOOKs.Find(z[0]).NgayCheckIn_ThucTe = s.NgayCheckIn_ThucTe;
                db.SaveChanges();
            }
            else
            {
                var t = db.BOOKs.Where(p => p.PhongID == s.PhongID && (p.NgayCheckIn != null) && (p.NgayCheckIn_ThucTe == null)).Select(p => p.NgayCheckIn).ToList();
                if (t.Count > 0)
                {
                    if (MessageBox.Show("Bạn có lịch đặt phòng vào lúc \n " + t[0] + "\n Bạn có muốn tiếp tục Checkin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        db.BOOKs.Add(s);
                        db.SaveChanges();
                    }
                }
                else
                {
                    db.BOOKs.Add(s);
                    db.SaveChanges();
                }
            }

        }
        public void AddDatPhong(BOOK s)
        {
            try
            {
                QLKS db = new QLKS();
                db.BOOKs.Add(s);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đặt phòng không thành công");
            }
        }
        public BOOK Find(string s)
        {
            return new QLKS().BOOKs.Find(s);
        }
        public HOADON Checkout(string IDBook, DateTime t)
        {
            QLKS db = new QLKS();
            db.sp_Cal_HoaDon(IDBook);
            db.BOOKs.Find(IDBook).NgayCheckOut_ThucTe = t;
            var s = db.HOADONs.Where(p => p.BookID == IDBook).First();
            db.SaveChanges();
            return s;
        }
    }
}
