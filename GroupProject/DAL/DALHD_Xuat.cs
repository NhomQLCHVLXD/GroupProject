using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALHD_Xuat
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALHD_Xuat() { }

       public List<HD_XUAT> lstHD_Xuat()
       {
           return qlvlxd.HD_XUATs.Select(i => i).ToList<HD_XUAT>();
       }
    }
}
