using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALCT_HD_Nhap
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALCT_HD_Nhap() { }

       public List<CHITIET_HD_NHAP> lstCT_HD_Nhap()
       {
           return qlvlxd.CHITIET_HD_NHAPs.Select(i => i).ToList<CHITIET_HD_NHAP>();
       }
    }
}
