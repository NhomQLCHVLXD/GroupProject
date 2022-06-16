using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;


namespace BLL
{
   public class BLLHD_Xuat
    {
        DALHD_Xuat dalhdXuat = new DALHD_Xuat();
        public BLLHD_Xuat() { }

        public List<HD_XUAT> lstHD_Xuat()
        {
            return dalhdXuat.lstHD_Xuat();
        }
    }
}
