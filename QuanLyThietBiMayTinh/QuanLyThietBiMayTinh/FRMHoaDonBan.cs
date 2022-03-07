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
    public partial class FRMHoaDonBan : Form
    {
        private string connectionString;
        private NhanVienAdapter nhanVienAdapter;
        public FRMHoaDonBan()
        {
            connectionString = ConfigurationManager.ConnectionStrings["lienKetSQl"].ConnectionString;
            nhanVienAdapter = new NhanVienAdapter();
            InitializeComponent();
        }

        private void FRMHoaDonBan_Load(object sender, EventArgs e)
        {
            fillcomboBoxNhanVien();
            findAllHD();
        }

        private void fillcomboBoxNhanVien()
        {
            DataTable tblnhanVien = nhanVienAdapter.findAllNV();
            DataView dvNV = new DataView(tblnhanVien);
            cbNhanVien.DataSource = dvNV;
            cbNhanVien.DisplayMember = "sTen";
            cbNhanVien.ValueMember = "iMaNV";
        }
        private void findAllHD()
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                using (SqlCommand Cmd = new SqlCommand("prFindAllHDBan", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(Cmd))
                    {
                        DataSet tbl = new DataSet();
                        adapter.Fill(tbl);
                        grvHDBan.DataSource = tbl.Tables[0];
                        Cnn.Close();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    Cnn.Open();
                    using (SqlCommand Cmd = new SqlCommand("prInsertHDban", Cnn))
                    {
                        int iMaNV =  int.Parse(cbNhanVien.SelectedValue.ToString());
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@iMaNV", iMaNV);
                        int result = Cmd.ExecuteNonQuery();
                        if(result >0)
                        {
                            MessageBox.Show("Bạn đã thêm 1 bản ghi mới");
                            findAllHD();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau");
                        }
                    }
                 }
            }catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi không mong muốn vui lòng thử lại sau! ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    Cnn.Open();
                    using (SqlCommand Cmd = new SqlCommand("prUpdateHDban", Cnn))
                    {
                        int iMaNV = int.Parse(cbNhanVien.SelectedValue.ToString());
                        int iMaHD = int.Parse(grvHDBan.Rows[grvHDBan.CurrentRow.Index].Cells[0].Value.ToString()) ;
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@iMaNV", iMaNV);
                        Cmd.Parameters.AddWithValue("@iMaHD", iMaHD);
                        int result = Cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Bạn đã cập nhật 1 bản ghi mới");
                            findAllHD();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi không mong muốn vui lòng thử lại sau! ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    Cnn.Open();
                    using (SqlCommand Cmd = new SqlCommand("prDeleteHDban", Cnn))
                    {
                        int iMaNV = int.Parse(cbNhanVien.SelectedValue.ToString());
                        int iMaHD = int.Parse(grvHDBan.Rows[grvHDBan.CurrentRow.Index].Cells[0].Value.ToString());
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@iMaHD", iMaHD);
                        int result = Cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Bạn đã xóa 1 bản ghi");
                            findAllHD();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi không mong muốn vui lòng thử lại sau! ");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                int numberMin = ((int)numericMin.Value);
                int numberMax = ((int)numericMax.Value);
                if(numberMin > numberMax)
                {
                    int tmp = numberMin;
                    numberMin = numberMax;
                    numberMax = tmp;
                }
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    Cnn.Open();
                    using (SqlCommand Cmd = new SqlCommand("prSearchHDban", Cnn))
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@numberMin", numberMin);
                        Cmd.Parameters.AddWithValue("@numberMax", numberMax);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(Cmd))
                        {
                            DataSet tbl = new DataSet();
                            adapter.Fill(tbl);
                            grvHDBan.DataSource = tbl.Tables[0];
                            Cnn.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
