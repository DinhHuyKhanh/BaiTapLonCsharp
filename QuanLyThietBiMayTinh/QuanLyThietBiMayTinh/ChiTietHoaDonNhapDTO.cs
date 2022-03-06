using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiMayTinh
{
    class ChiTietHoaDonNhapDTO
    {
        private int iMaMH;
        private int iSoLuong;
        private float fDonGia;

        public int IMaMH { get => iMaMH; set => iMaMH = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public float FDonGia { get => fDonGia; set => fDonGia = value; }
    }
}
