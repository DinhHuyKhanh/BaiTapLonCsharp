using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh
{
    public partial class FRMQuanLyHoaDonNhap : Form
    {
        private NhanVienAdapter nhanVienAdapter;
        private HoaDonNhapAdapter hoaDonNhapAdapter;
        public FRMQuanLyHoaDonNhap()
        {
            this.nhanVienAdapter = new NhanVienAdapter();
            hoaDonNhapAdapter = new HoaDonNhapAdapter();
      
            InitializeComponent();
        }
        private void fillComBoBox()
        {
            DataTable tblnhanVien = nhanVienAdapter.findAllNV();
            DataView dvNV = new DataView(tblnhanVien);
            ListNV.DataSource = dvNV;
            ListNV.DisplayMember = "sTen";
            ListNV.ValueMember = "iMaNV";
        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTenNCC.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn cập nhật không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.No)
            {
                return;
            }
            int iMaHD = (int)grxlistHoaDon.Rows[grxlistHoaDon.CurrentRow.Index].Cells[0].Value;
            string tenNCC = txtTenNCC.Text.ToString();
            int result = hoaDonNhapAdapter.update(tenNCC, iMaHD);
            if (result == 0)
            {
                MessageBox.Show("Bạn đã cập nhật thành công");
                loadListHoaDon();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thực hiện lại");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int iMaNV = int.Parse( ListNV.SelectedValue.ToString());
            string tenNCC = txtTenNCC.Text;
            int result = hoaDonNhapAdapter.create(iMaNV, tenNCC);
            if (result == 0)
            {
                MessageBox.Show("Bạn đã thêm 1 hóa đơn mới");
                loadListHoaDon();
                txtTenNCC.Text = "";

            }
            else
            {
               MessageBox.Show("Có lỗi xảy ra vui lòng thực hiện lại");
            }
        }

        private void FRMQuanLyHoaDonNhap_Load(object sender, EventArgs e)
        {
            loadListHoaDon();
            fillComBoBox();
        }

       

        private void loadListHoaDon()
        {
            grxlistHoaDon.DataSource = hoaDonNhapAdapter.getAll().Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.No)
            {
                return;
            }
           
            int iMaHD = (int)grxlistHoaDon.Rows[grxlistHoaDon.CurrentRow.Index].Cells[0].Value;
            int result = hoaDonNhapAdapter.delete(iMaHD);
            if (result == 0)
            {
                MessageBox.Show("Bạn đã xóa 1 hóa đơn");
                loadListHoaDon();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thực hiện lại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form findForm(string formName)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name.Equals(formName))
                    return f;
            return null;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int iMaHD = (int)grxlistHoaDon.Rows[grxlistHoaDon.CurrentRow.Index].Cells[0].Value;
            Form f = findForm("FRMQuanLyChiTietHoaDonNhap");
            if (f == null)
                f = new FRMQuanLyChiTietHoaDonNhap(iMaHD);
            this.Close();
            f.Show();
        }
    }
}
