using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALHD_Nhap
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALHD_Nhap() { }

       public List<HD_NHAP> lstHD_Nhap()
       {
           return qlvlxd.HD_NHAPs.Select(i => i).ToList<HD_NHAP>();
       }
    }
}
