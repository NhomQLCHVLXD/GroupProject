using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLChucVu
    {
        DALChucVu dalchucvu = new DALChucVu();
        public BLLChucVu() { }

        public List<CHUCVU> lstChucVu()
        {
            return dalchucvu.lstChucVu();
        }
    }
}
