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
            string id = textBoxId.Text;
            string password = textBoxPassword.Text;
            if (id.Equals("1111111") == false)
            {
                MessageBox.Show("输入用户编号错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (password.Equals("1111111") == false)
                {
                    MessageBox.Show("输入用户密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
                //到这里了
                FormQuery form2 = new FormQuery();
                form2.Show();
            }
            
               
            

        }

    }
}
