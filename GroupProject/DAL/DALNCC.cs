using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALNCC
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALNCC() { }

       public List<NHACUNGCAP> lstNCC()
       {
           return qlvlxd.NHACUNGCAPs.Select(i => i).ToList<NHACUNGCAP>();
       }
    }
}
