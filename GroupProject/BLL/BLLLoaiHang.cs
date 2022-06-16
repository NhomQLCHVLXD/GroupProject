using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLLoaiHang
    {
       DALLoaiHang dallh = new DALLoaiHang();
        public BLLLoaiHang() { }

        public List<LOAIHANG> lstLoaiHang()
        {
            return dallh.lstLoaiHang();
        }
    }
}
