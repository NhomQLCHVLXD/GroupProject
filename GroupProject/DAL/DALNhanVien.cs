using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
   public class DALNhanVien
    {
       QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALNhanVien() { }

       public List<NHANVIEN> lstNV()
       {
           return qlvlxd.NHANVIENs.Select(i => i).ToList<NHANVIEN>();
       }
    }
}
