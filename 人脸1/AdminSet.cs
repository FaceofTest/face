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
    public partial class AdminSet : Form
    {
        public AdminSet()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("应用管理员权限,取消即无管理员权限","提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }

    }
}
