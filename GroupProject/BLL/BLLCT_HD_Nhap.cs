using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;


namespace BLL
{
   public class BLLCT_HD_Nhap
    {
       DALCT_HD_Nhap dalcthdNhap = new DALCT_HD_Nhap();
        public BLLCT_HD_Nhap() { }

        public List<CHITIET_HD_NHAP> lstCT_HD_Nhap()
        {
            return dalcthdNhap.lstCT_HD_Nhap();
        }
    }
}
