using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace DAL
{
   public class DALLoaiKhach
    {
        QL_CHVLXDDataContext qlvlxd = new QL_CHVLXDDataContext();
       public DALLoaiKhach() { }

       public List<LOAIKHACH> lstLoaiKhach()
       {
           return qlvlxd.LOAIKHACHes.Select(i => i).ToList<LOAIKHACH>();
       }
    }
}
