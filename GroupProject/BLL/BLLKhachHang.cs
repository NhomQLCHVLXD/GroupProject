using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;


namespace BLL
{
   public class BLLKhachHang
    {
       DALKhachHang dalkh = new DALKhachHang();
        public BLLKhachHang() { }

        public List<KHACHHANG> lstKhachHang()
        {
            return dalkh.lstKhachHang();
        }
    }
}
