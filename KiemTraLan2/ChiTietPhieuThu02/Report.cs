using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChiTietPhieuThu02
{
    public partial class Report : Form
    {
        private string maPhieuThu;

        public Report(string maPT)
        {
            InitializeComponent();
            maPhieuThu = maPT;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
        private void LoadReportData()
        {
            try
            {
                CrystalReport1 reportDoc = new CrystalReport1();
                reportDoc.Load(@"Path\To\Your\CrystalReport1.rpt"); 
                reportDoc.SetParameterValue("MaPT", maPhieuThu);
                crystalReportViewer1.ReportSource = reportDoc;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
