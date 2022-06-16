using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
   public class BLLHD_Nhap
    {
       DALHD_Nhap dalhdNhap = new DALHD_Nhap();
        public BLLHD_Nhap() { }

        public List<HD_NHAP> lstHD_Nhap()
        {
            return dalhdNhap.lstHD_Nhap();
        }
    }
}
