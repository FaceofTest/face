using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人脸1
{
    public partial class LeaveSetReport : Form
    {
        public LeaveSetReport()
        {
            InitializeComponent();
        }

        private void LeaveSetReport_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“DataSet２.LEAVE”中。您可以根据需要移动或删除它。
            this.LEAVETableAdapter.Fill(this.DataSet２.LEAVE);

            this.reportViewer1.RefreshReport();
        }
    }
}
