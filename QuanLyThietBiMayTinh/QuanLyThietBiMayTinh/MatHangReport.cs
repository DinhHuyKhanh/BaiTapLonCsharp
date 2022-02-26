using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh
{
    public partial class MatHangReport : Form
    {
        public MatHangReport()
        {
            InitializeComponent();
        }

        private void MatHangReport_Load(object sender, EventArgs e)
        {
            showReport();
        }
        private void showReport()
        {
            ReportDocument rpt = new ReportDocument();
            string path = string.Format("{0}\\Reports\\MatHangReport.rpt", Application.StartupPath);
            rpt.Load(path);

            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = ".\\SQLEXPRESS";
            logOnInfo.ConnectionInfo.DatabaseName = "db_QuanLyHangHoa";

            foreach (Table t in rpt.Database.Tables)
                t.ApplyLogOnInfo(logOnInfo);

            rpt.SummaryInfo.ReportTitle = "BÁO CÁO MẶT HÀNG";

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
