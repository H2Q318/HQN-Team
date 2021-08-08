using PBL.DAL;
using PBL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

        public string getStringEncoded(string input)
        {
            MD5 md = MD5.Create();
            byte[] inputString = Encoding.ASCII.GetBytes(input);
            byte[] hash = md.ComputeHash(inputString);
            StringBuilder stringAfter = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                stringAfter.Append(hash[i].ToString("X"));
            }
            return stringAfter.ToString();
        }

        public List<DANGNHAP> GetAllDangNhap()
        {
            return new QLKS().DANGNHAPs.ToList();
        }

        public bool isLogin(string username)
        {
            QLKS db = new QLKS();
            var user = db.DANGNHAPs.Find(username);
            return user.TrangThai;
        }

        public bool CheckPassword(string username, string password)
        {
            if (password == "") return true;
            QLKS db = new QLKS();
            string passwordEncoded = getStringEncoded(password);
            var user = db.DANGNHAPs.Find(username);
            if (passwordEncoded.Equals(user.MatKhau))
            {
                return true;
            }
            return false;
        }

        public void SetStatusAccount(string username, bool status)
        {
            try
            {
                QLKS db = new QLKS();
                var user = db.DANGNHAPs.Find(username);
                user.TrangThai = status;
                db.SaveChanges();
            }
            catch { }
        }

        public bool AddAccount(string username, string password = "1")
        {
            try
            {
                QLKS db = new QLKS();
                string passwordEncoded = getStringEncoded(password);
                DANGNHAP dn = new DANGNHAP
                {
                    NhanVienID = username,
                    MatKhau = passwordEncoded,
                    TrangThai = false
                };
                db.DANGNHAPs.Add(dn);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePassword(string username, string password = "1")
        {
            try
            {
                QLKS db = new QLKS();
                string passwordEncoded = getStringEncoded(password);
                var nhanVienAccount = db.DANGNHAPs.Find(username);
                nhanVienAccount.MatKhau = passwordEncoded;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Account_View> GetListAccount_View()
        {
            return GetAllDangNhap().Select(p => new Account_View
            {
                NhanVienID = p.NhanVienID,
                Ten = p.NHANVIEN.Ten,
                ChucVu = p.NHANVIEN.CHUCVU.TenChucVu,
                TrangThai = p.TrangThai
            }).ToList();
        }
        public List<LICHSUDANGNHAP> GetListLichSuDangNhap(string nhanvienid)
        {
            return new QLKS().LICHSUDANGNHAPs.Where(p => p.NhanVienID == nhanvienid).OrderByDescending(p => p.ThoiGian).ToList();
        }
    }
}
