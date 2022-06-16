using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLDonVi
    {
       DALDonVi daldonvi = new DALDonVi();
        public BLLDonVi() { }

        public List<DONVITINH> lstDonVi()
        {
            return daldonvi.lstDonVi();
        }
    }
}
