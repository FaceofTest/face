using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人脸1
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num = textBox1.Text;
            String password = textBox2.Text;
            if (num != "1111111")
            {
                MessageBox.Show("输入用户编号错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (password != "1111111")
                {
                    MessageBox.Show("输入用户密码错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
                //到这里了
               Form2 form2 = new Form2();
               form2.Show();
            }
            
               
            

        }

    }
}
