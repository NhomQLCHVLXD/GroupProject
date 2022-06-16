using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALHangHoa
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALHangHoa() { }

       public List<HANGHOA> lstHangHoa()
       {
           return qlvlxd.HANGHOAs.Select(i => i).ToList<HANGHOA>();
       }
    }
}
