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
    public partial class FestivalSetReport : Form
    {
        public FestivalSetReport()
        {
            InitializeComponent();
        }

        private void FestivalSetReport_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“FaceDataDataSet.FESTIVALSET”中。您可以根据需要移动或删除它。
            this.FESTIVALSETTableAdapter.Fill(this.FaceDataDataSet.FESTIVALSET);
            this.reportViewer1.RefreshReport();
        }
    }
}
