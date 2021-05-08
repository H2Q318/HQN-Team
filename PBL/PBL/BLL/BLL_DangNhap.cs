using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL
{
    class BLL_DangNhap
    {
        private static BLL_DangNhap _instance;
        public static BLL_DangNhap Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_DangNhap();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_DangNhap() { }


        public List<DANGNHAP> GetAllDangNhap()
        {
            return new QLKS().DANGNHAPs.ToList();
        }

        public bool CheckLogin(string username, string password)
        {
            QLKS db = new QLKS();
            foreach(DANGNHAP item in GetAllDangNhap())
            {
                if (username.Equals(item.NhanVienID) && password.Equals(item.MatKhau) && item.TrangThai == false)
                {
                    SetStatusAccount(item.NhanVienID, true);
                    return true;
                }
            }
            return false;
        }

        public void SetStatusAccount(string username, bool status)
        {
            try
            {
                QLKS db = new QLKS();
                var temp = db.DANGNHAPs.Find(username);
                temp.TrangThai = status;
                db.SaveChanges();
            }
            catch { }
        }

        public bool UpdatePassword(string username, string password = "1")
        {
            try
            {
                QLKS db = new QLKS();
                var nhanVienAccount = db.DANGNHAPs.Find(username);
                nhanVienAccount.MatKhau = password;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
