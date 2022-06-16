using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLHangHoa
    {
       DALHangHoa dalhh = new DALHangHoa();
        public BLLHangHoa() { }

        public List<HANGHOA> lstHangHoa()
        {
            return dalhh.lstHangHoa();
        }
    }
}
