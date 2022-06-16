using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALKhachHang
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALKhachHang() { }

       public List<KHACHHANG> lstKhachHang()
       {
           return qlvlxd.KHACHHANGs.Select(i => i).ToList<KHACHHANG>();
       }
    }
}
