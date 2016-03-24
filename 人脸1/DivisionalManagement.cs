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
    public partial class DivisionalManagement : Form
    {
        public DivisionalManagement()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddDepartment ad = new AddDepartment();
            ad.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HireStaff hs = new HireStaff();
            hs.Show();
        }
    }
}
