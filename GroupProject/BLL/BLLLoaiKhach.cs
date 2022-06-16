using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
    public class BLLLoaiKhach
    {
        DALLoaiKhach dallk = new DALLoaiKhach();
        public BLLLoaiKhach() { }

        public List<LOAIKHACH> lstLoaiKhach()
        {
            return dallk.lstLoaiKhach();
        }
    }
}
