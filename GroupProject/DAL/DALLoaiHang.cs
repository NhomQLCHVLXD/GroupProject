using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALLoaiHang
    {
        QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALLoaiHang() { }

       public List<LOAIHANG> lstLoaiHang()
       {
           return qlvlxd.LOAIHANGs.Select(i => i).ToList<LOAIHANG>();
       }
    }
}
