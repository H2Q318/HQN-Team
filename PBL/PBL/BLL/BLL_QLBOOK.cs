using PBL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         
         var s   = new QLKS().BOOKs
                .Where(p => p.NgayCheckIn_ThucTe != null && p.NgayCheckOut_ThucTe == null && p.PhongID==id)
                .Select(p => p.BookID).ToList();
            if(s.Count==0)
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
            db.BOOKs.Add(s);
            db.SaveChanges();
        }
       
    }
}
