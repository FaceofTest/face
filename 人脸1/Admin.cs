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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private string judgeVaild()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("用户名不能为空");
                return "用户名不能为空";
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空");
                return "密码不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (judgeVaild() == "")
            {
                String name = textBox1.Text;
                String password = textBox2.Text;
                string commandText1 = @"select STAFFID from STAFFPASSWORD where STAFFID='" + name + "'";
                SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
                var db = new DBHelper("MyCN");
                var dataTable1 = db.ExecuteDataTable(cmd1);
                if (dataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("用户名不正确", "提示");
                }
                else
                {
                    string commandText = @"select PASSWORD  from STAFFPASSWORD where PASSWORD='" + password + "'";
                    SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                    var db1 = new DBHelper("MyCN");
                    var dataTable = db.ExecuteDataTable(cmd);
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("密码不正确", "提示");
                    }
                    else
                    {
                        FormMain fm = new FormMain(this,false);
                        fm.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string judgeVaild1()
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("用户名不能为空");
                return "用户名不能为空";
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空");
                return "密码不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (judgeVaild1() == "")
            {
                String name = textBox3.Text;
                String password = textBox4.Text;
                string commandText1 = @"select STAFFID from ADMINSET where STAFFID='" + name + "'";
                SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
                var db = new DBHelper("MyCN");
                var dataTable1 = db.ExecuteDataTable(cmd1);
                if (dataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("用户名不正确", "提示");
                }
                else
                {
                    string commandText = @"select PASSWORD  from ADMINSET where PASSWORD='" + password + "'";
                    SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                    var db1 = new DBHelper("MyCN");
                    var dataTable = db.ExecuteDataTable(cmd);
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("密码不正确", "提示");
                    }
                    else
                    {
                        FormMain fm = new FormMain(this,true);
                        fm.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("用户名和初始化密码是为您的编号", textBox1);
        }

    

      
    }
}
