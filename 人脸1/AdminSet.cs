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
    public partial class AdminSet : Form
    {
        public AdminSet()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            String sql = @"select STAFFID as '员工编号',NAME as '姓名' from ADMINSET";
            SqlCommand cmd = new SqlCommand(sql);
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd);
            dataGridView1.DataSource = dataTable1;
        }

        private string judgeVaild()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("姓名不能为空");
                return "姓名不能为空";
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("员工编号不能为空");
                return "员工编号不能为空";
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空");
                return "密码不能为空";
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("请重新输入密码");
                return "重新输入密码不能为空";
            }
            if (!textBox3.Text.Equals(textBox4.Text))
            {
                MessageBox.Show("密码不一致");
                textBox4.Text = String.Empty;
                textBox3.Text = String.Empty;
                return "重新输入密码不能为空";
            }
            else
            {
                return "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String  id = textBox2.Text;
            if (judgeVaild() == "")
            {
                String sql = @"select STAFFID from STAFFINFORMATION where STAFFID = '" + id + "'";
                 SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                 var db = new DBHelper("MyCN");
                 var dataTable1 = db.ExecuteDataTable(cmd);
                
                if(dataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("你输入的人员信息错误（不属于本公司）","提示");
                    this.textBox1.Text = String.Empty;
                    this.textBox2.Text = String.Empty;
                    this.textBox3.Text = String.Empty;
                    this.textBox4.Text = String.Empty;

                }
                else
                {
                string sql1 = "insert into ADMINSET (STAFFID,NAME,PASSWORD) values(@STAFFID,@NAME,@PASSWORD)";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@STAFFID", textBox2.Text.Trim()));
                paras.Add(new SqlParameter("@NAME", textBox1.Text.Trim()));
                paras.Add(new SqlParameter("@PASSWORD", textBox3.Text));
                SqlCommand cmd1 = new SqlCommand(sql1);//执行sql语句
                cmd1.Parameters.AddRange(paras.ToArray());//添加
                var db1 = new DBHelper("MyCN");
                int i = db.ExecuteNonQuery(cmd1);
                if (i != 0)
                {
                    MessageBox.Show("管理员设置成功", "提示");
                    this.textBox1.Text = String.Empty;
                    this.textBox2.Text = String.Empty;
                    this.textBox3.Text = String.Empty;
                    this.textBox4.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("管理员设置失败", "提示");
                }

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sql = @"delete from ADMINSET where STAFFID='" + num + "' ";
            SqlCommand cmd = new SqlCommand(sql);
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd);
            dataGridView1.DataSource = dataTable1;
        }
        private string judgeVaild1()
        {
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("姓名不能为空");
                return "姓名不能为空";
            }
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("员工编号不能为空");
                return "员工编号不能为空";
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("原始密码不能为空");
                return "原始密码不能为空";
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("新密码不能为空");
                return "新密码不能为空";
            }
            if (textBox9.Text == string.Empty)
            {
                MessageBox.Show("确定的新密码不能为空");
                return "确定的新密码不能为空";
            }
            if (!textBox5.Text.Equals(textBox9.Text))
            {
                MessageBox.Show("密码不一致");
                textBox5.Text = String.Empty;
                textBox9.Text = String.Empty;
                return "重新输入密码不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button4.Enabled = false;
            button1.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            button4.Enabled = true;
            button1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String newPassword = textBox5.Text;
            String Id = textBox7.Text;

            if (judgeVaild1() == "")
            {

              String sql = @"select STAFFID from ADMINSET where STAFFID = '" + Id + "'";
                 SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                 var db = new DBHelper("MyCN");
                 var dataTable1 = db.ExecuteDataTable(cmd);
                
                if(dataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("你要修改的管理员不存在,您可以参考辅助信息","提示");
                    this.textBox1.Text = String.Empty;
                    this.textBox2.Text = String.Empty;
                    this.textBox3.Text = String.Empty;
                    this.textBox4.Text = String.Empty;

                }
                else
                {
                    string sql1 = @"update  PASSWORD = '" + newPassword + "' from ADMINSET";
                    SqlCommand cmd1 = new SqlCommand(sql);//执行sql语句
                    var db1 = new DBHelper("MyCN");
                    int i = db.ExecuteNonQuery(cmd1);
                    if (i != 0)
                    {
                        MessageBox.Show("修改指令成功", "提示");
                        this.textBox5.Text = String.Empty;
                        this.textBox6.Text = String.Empty;
                        this.textBox7.Text = String.Empty;
                        this.textBox8.Text = String.Empty;
                        this.textBox9.Text = String.Empty;

                    }
                    else
                    {
                        MessageBox.Show("修改指令失败", "提示");
                    }
                }
            }

        }

        private void AdminSet_Load(object sender, EventArgs e) 
        {
            string sql = @"select STAFFID as '人员编号',NAME as '姓名'from STAFFINFORMATION;";
            SqlCommand cmd = new SqlCommand(sql);
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd);
            dataGridView2.DataSource = dataTable1;
        }
    }
}
