using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人脸1
{
    public partial class CheckReport : Form
    {
        public CheckReport()
        {
            InitializeComponent();
        }

        private void baobiao_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“DataSet1.CHECKDATA”中。您可以根据需要移动或删除它。
            this.CHECKDATATableAdapter.Fill(this.DataSet1.CHECKDATA);
　　　　　　this.reportViewer1.RefreshReport();
            SqlConnection conn = new SqlConnection("server=ACER-PC;database=FaceData;uid=sa;pwd=123456");
            SqlDataAdapter sda = new SqlDataAdapter("select * from  CHECKDATA ", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "bm");
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
            this.reportViewer1.RefreshReport();
        }
    }
}
