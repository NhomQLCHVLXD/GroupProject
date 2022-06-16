using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
   public class BLLCT_HD_Xuat
    {
        DALCT_HD_Xuat dalcthdXuat = new DALCT_HD_Xuat();
        public BLLCT_HD_Xuat() { }

        public List<CHITIET_HD_XUAT> lstCT_HD_Xuat()
        {
            return dalcthdXuat.lstCT_HD_Xuat();
        }
    }
}
