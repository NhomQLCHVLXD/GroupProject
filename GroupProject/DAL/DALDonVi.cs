using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALDonVi
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALDonVi() { }

       public List<DONVITINH> lstDonVi()
       {
           return qlvlxd.DONVITINHs.Select(i => i).ToList<DONVITINH>();
       }
    }
}
