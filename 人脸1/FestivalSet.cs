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
    public partial class FestivalSet : Form
    {
        public FestivalSet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkcompute cp = new Checkcompute();
            cp.Show();
        }

        private string judgeVaild()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("节日名称不能为空");
                return "节日名称不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Text.Equals(dateTimePicker2.Text))
            {
                DialogResult result = MessageBox.Show("放假时间和收假时间一样", "警告", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (judgeVaild() == "")
                {
                    string sql = "insert into FESTIVALSET (FESTIVALNAME,FESTIVALSTART,FESTIVALEND) values(@FESTIVALNAME,@FESTIVALSTART,@FESTIVALEND)";//往数据库FaceDate中插入数据
                    List<SqlParameter> paras = new List<SqlParameter>();
                    paras.Add(new SqlParameter("@FESTIVALNAME", textBox1.Text.Trim()));
                    paras.Add(new SqlParameter("@FESTIVALSTART", dateTimePicker1.Value));
                    paras.Add(new SqlParameter("@FESTIVALEND", dateTimePicker2.Value));
                    SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                    cmd.Parameters.AddRange(paras.ToArray());//添加
                    var db = new DBHelper("MyCN");
                    int i = db.ExecuteNonQuery(cmd);
                    if (i != 0)
                    {
                        MessageBox.Show("节日设置成功", "提示");
                        this.textBox1.Text = String.Empty;
                    }
                    else
                    {
                        MessageBox.Show("节日设置失败", "提示");
                    }
                }
            }
        }
    }
    }

