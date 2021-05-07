using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL.DAL;
using PBL.DTO;

namespace PBL.BLL
{
    class BLL_QLVDP
    {
        private static BLL_QLVDP _instance;
        public static BLL_QLVDP Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_QLVDP();
                }
                return _instance;
            }
            private set { }
        }

        private BLL_QLVDP() { }

        public List<VATDUNGPHONG> GetListVatDungPhong(string s)
        {
            if (s == null)
            {
                return new QLKS().VATDUNGPHONGs.ToList();
            }
            return new QLKS().VATDUNGPHONGs.Where(vdp => vdp.PhongID == s).ToList();
        }
        public List<VatDungPhong_View> GetListVatDungPhong_View(List<VATDUNGPHONG> l)
        {
            return l.Select(p => new VatDungPhong_View
            {
                Phong = p.PhongID,
                VatDungID = p.VatDungID,
                TenVatDung = p.LOAIVATDUNG.TenVatDung,
                SoLuongBanDau = p.SoLuongBanDau,
                SoLuongHienTai = p.SoLuongHienTai,
                TrangThai = p.TRANGTHAIVATDUNG.TrangThaiVatDungID
            }).ToList();
        }
        public VATDUNGPHONG FindVatDungPhong(Keys k)
        {
            return new QLKS().VATDUNGPHONGs.Find(k.key1, k.key2);
        }
        public void AddVatDungPhong(VATDUNGPHONG vdp)
        {
            QLKS db = new QLKS();
            db.VATDUNGPHONGs.Add(vdp);
            db.SaveChanges();
        }
        public void UpdateVatDungPhong(VATDUNGPHONG vdp)
        {
            QLKS db = new QLKS();
            var a = db.VATDUNGPHONGs.Find(vdp.PhongID, vdp.VatDungID);
            a.SoLuongBanDau = vdp.SoLuongBanDau;
            a.SoLuongHienTai = vdp.SoLuongHienTai;
            a.TrangThaiVatDungID = vdp.TrangThaiVatDungID;
            db.SaveChanges();
        }
        public void DeleteVatDungPhong(List<Keys> l)
        {
            QLKS db = new QLKS();
            foreach(Keys i in l)
            {
                db.VATDUNGPHONGs.Remove(db.VATDUNGPHONGs.Find(i.key1, i.key2));
                db.SaveChanges();
            }
        }
    }
}
