using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALChucVu
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALChucVu() { }

       public List<CHUCVU> lstChucVu()
       {
           return qlvlxd.CHUCVUs.Select(i => i).ToList<CHUCVU>();
       }
    }
}
