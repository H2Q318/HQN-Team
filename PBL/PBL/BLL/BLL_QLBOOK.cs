﻿using PBL.DAL;
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
            try
            {
                QLKS db = new QLKS();
                var t = db.BOOKs.Where(p => (p.PhongID == s.PhongID) && (p.NgayCheckIn_ThucTe != null) &&
                (p.NgayCheckOut_ThucTe == null)).Select(p => p.BookID).ToList();
                if (t.Count > 0)
                {
                    db.BOOKs.Find(t[0]).KHACHHANGs.Add(db.KHACHHANGs.Find(s.KhachHangID));
                   // db.KHACHHANGs.Find(s.KhachHangID).BOOKs1.Add(db.BOOKs.Find(t[0])); //cách 2
                    db.SaveChanges();
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
                    var v = db.BOOKs.Where(p => p.PhongID == s.PhongID && (p.NgayCheckIn != null) && (p.NgayCheckIn_ThucTe == null)).Select(p => p.NgayCheckIn).ToList();
                    if (v.Count > 0)
                    {
                        if (MessageBox.Show("Bạn có lịch đặt phòng vào lúc \n " + v[0] + "\n Bạn có muốn tiếp tục Checkin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
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
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
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
        
        public bool UpdateDatPhong(BOOK b)
        {
            try
            {
                QLKS db = new QLKS();
                var book = db.BOOKs.Find(b.BookID);
                book.NgayDat = b.NgayDat;
                book.NgayCheckIn = b.NgayCheckIn;
                book.NgayCheckOut = b.NgayCheckOut;
                book.NgayCheckIn_ThucTe = b.NgayCheckIn_ThucTe;
                book.NgayCheckOut_ThucTe = b.NgayCheckOut_ThucTe;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDatPhong(string b)
        {
            try
            {
                QLKS db = new QLKS();
                var book = db.BOOKs.Remove(db.BOOKs.Find(b));
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public BOOK Find(string s)
        {
            return new QLKS().BOOKs.Find(s);
        }
        public HOADON Checkout(string IDBook, DateTime t)
        {
                QLKS db = new QLKS();
                db.BOOKs.Find(IDBook).NgayCheckOut_ThucTe = t;
                db.sp_Cal_HoaDon(IDBook);
                db.SaveChanges();
                var s = db.HOADONs.Where(p => p.BookID == IDBook).First();
                return s;   
        }

        public List<Book_View> GetAllBook()
        {
            QLKS db = new QLKS();
            List<Book_View> data = new List<Book_View>();
            foreach(BOOK item in db.BOOKs.ToList())
            {
                data.Add(new Book_View(item));
            }
            return data;
        }
    }
}
