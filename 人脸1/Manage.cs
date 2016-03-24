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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeMessage cm = new ChangeMessage();
            cm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQuery formquery = new FormQuery();
            formquery.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DelMessage dm = new DelMessage();
            dm.Show();
        }

     
    }
}
