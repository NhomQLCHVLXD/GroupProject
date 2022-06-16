using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLNhanVien
    {
       DALNhanVien dalnv = new DALNhanVien();
       public BLLNhanVien() { }

       public List<NHANVIEN> lstNV()
       {
           return dalnv.lstNV();
       }
    }
}
