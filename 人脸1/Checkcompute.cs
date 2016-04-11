using DBHelpers;
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
    public partial class Checkcompute : Form
    {
        public Checkcompute()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


      

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            staffReport sr = new staffReport();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckReport bb = new CheckReport();
            bb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffReport sr = new staffReport();
            sr.Show();
        }
    }
}
