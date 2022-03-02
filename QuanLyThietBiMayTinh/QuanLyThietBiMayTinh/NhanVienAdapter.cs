using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiMayTinh
{
    class NhanVienAdapter
    {
        public List<NhanVienDTO> getAll()
        {
            List<NhanVienDTO> nhanViens = new List<NhanVienDTO>();
            string connectionString = ConfigurationManager.ConnectionStrings["lienKetSQl"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                Cnn.Open();
                string query = "SELECT * FROM tblNhanVien";
                using (SqlCommand Cmd = new SqlCommand(query, Cnn))
                {
                    var reader = Cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nhanViens.Add(new NhanVienDTO((int)reader["iMaNV"],(string)reader["sTen"],(string)reader["sSDT"]));
                    }
                    Cnn.Close();
                }
            }
            return nhanViens; 
        }

        public void create()
        {

        }

        public void search()
        {

        }
        
    }
}
