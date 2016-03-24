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
    public partial class StaffMaintain : Form
    {
        public StaffMaintain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DivisionalManagement form17 = new DivisionalManagement();
            form17.Show();
        }

   


    
    }
}
