using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btlQlyNhanVien
{
    class NhanVienBLL
    {
        NhanVienDAL dalnv;
        public NhanVienBLL()
        {
            dalnv = new NhanVienDAL();
        }

        public DataTable getAllNhanVien()
        {
            return dalnv.getAllNhanVien();
        }

        public bool InsertNhanVien(tblNhanVien nv)
        {
            return dalnv.insertNhanVien(nv);
        }

        public bool updateNhanVien(tblNhanVien nv)
        {
            return dalnv.updateNhanVien(nv);
        }

        public bool deleteNhanVien(tblNhanVien nv)
        {
            return dalnv.deleteNhanVien(nv);
        }
    }
}
