using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLNCC
    {
       DALNCC dalncc = new DALNCC();
       public BLLNCC() { }

       public List<NHACUNGCAP> lstNCC()
       {
           return dalncc.lstNCC();
       }
    }
}
