using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btlQlyNhanVien
{
    class DataConnection
    {
        string constr;
        public DataConnection()
        {
            constr = "Data Source=DESKTOP-TKHK1KE\\SQLEXPRESS;Initial Catalog=db_QuanLyHangHoa;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(constr);
        }
    }
}
