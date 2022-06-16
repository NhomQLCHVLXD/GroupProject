using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALCT_HD_Xuat
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALCT_HD_Xuat() { }

       public List<CHITIET_HD_XUAT> lstCT_HD_Xuat()
       {
           return qlvlxd.CHITIET_HD_XUATs.Select(i => i).ToList<CHITIET_HD_XUAT>();
       }
    }
}
