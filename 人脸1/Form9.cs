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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            String dir = @System.Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = dir;
            openFileDialog1.Filter = "加密考勤签到数据（*.ABT)|考勤签到数据（*.txt)|备份数据库文件（attBackup.mdb)|考勤系统数据库文件（*.mdb)";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog1.FileName;
                textBox1.Text = fName;
            }
        }
    }
}
