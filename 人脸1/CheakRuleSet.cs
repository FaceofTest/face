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
    public partial class CheakRuleSet : Form
    {
        public CheakRuleSet()
        {
            InitializeComponent();
        }

        private void CheakRuleSet_Load(object sender, EventArgs e)
        {
            String sq = @"select * from CHECKRULESET";
            SqlCommand cmd1 = new SqlCommand(sq);
            var db = new DBHelper("MyCN");
            var table = db.ExecuteDataTable(cmd1);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("您已经设置过考勤，如要重新设置，请点击重新设置按钮","提示");
                button1.Enabled = false;
                tabControl1.Enabled = false;
                   button4.Visible = false;
            }
            else
            {
                button4.Visible = false;
            }
        }

        private string judgeVaild()
        {
            if(textBox1.Text == String.Empty)
            {
                MessageBox.Show("单位名称不能为空","提示");
                return "单位名称不能为空";
            }
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("单位编号不能为空", "提示");
                return "单位编号不能为空";
            }
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("每周开始时间不能为空", "提示");
                return "每周开始时间不能为空";
            }
            if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("每月开始时间不能为空", "提示");
                return "每月开始时间不能为空";
            }
            if (comboBox5.Text == String.Empty)
            {
                MessageBox.Show("间隔时间不能为空", "提示");
                return "间隔时间不能为空";
            }
            if ((!radioButton6.Checked) && (!radioButton7.Checked) && (!radioButton8.Checked) && (!radioButton9.Checked))
            {
                MessageBox.Show("外出状态选择不能为空", "提示");
                return "外出状态选择不能为空";
            }
            if ((!radioButton3.Checked) && (!radioButton4.Checked) && (!radioButton5.Checked))
            {
                MessageBox.Show("加班状态选择不能为空", "提示");
                return "加班状态选择不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String sq = @"select * from CHECKRULESET";
            SqlCommand cmd1 = new SqlCommand(sq);
            var db = new DBHelper("MyCN");
            var table = db.ExecuteDataTable(cmd1);
            if (table.Rows.Count == 0)
            {
               
                if (judgeVaild() == "")
                {
                    string sql = "insert into CHECKRULESET (DEPARTMENTNAME,DEPARTMENTID,TIMESTART,MONTHTIMESTART,INTERVALTIME,LEAVEINGORECHECK,LEAVEOUT,WORKOUT,LEAVEASSESS,OVERWORKINGORECHECK,SETOVERWORK,OVERWORKASSESS) values( @DEPARTMENTNAME,@DEPARTMENTID,@TIMESTART,@MONTHTIMESTART,@INTERVALTIME,@LEAVEINGORECHECK,@LEAVEOUT,@WORKOUT,@LEAVEASSESS,@OVERWORKINGORECHECK,@SETOVERWORK,@OVERWORKASSESS)";
                    List<SqlParameter> paras = new List<SqlParameter>();
                    paras.Add(new SqlParameter("@DEPARTMENTNAME", textBox1.Text.Trim()));
                    paras.Add(new SqlParameter("@DEPARTMENTID", textBox2.Text.Trim()));
                    paras.Add(new SqlParameter("@TIMESTART", comboBox1.Text.Trim()));
                    paras.Add(new SqlParameter("@MONTHTIMESTART", comboBox2.Text.Trim()));
                    paras.Add(new SqlParameter("@INTERVALTIME", comboBox5.Text.Trim()));
                    if (radioButton6.Checked)
                    {
                        paras.Add(new SqlParameter("@LEAVEINGORECHECK", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@LEAVEINGORECHECK", false));
                    }
                    if (radioButton7.Checked)
                    {
                        paras.Add(new SqlParameter("@LEAVEOUT", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@LEAVEOUT", false));
                    }
                    if (radioButton8.Checked)
                    {
                        paras.Add(new SqlParameter("@WORKOUT", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@WORKOUT", false));
                    }
                    if (radioButton9.Checked)
                    {
                        paras.Add(new SqlParameter("@LEAVEASSESS", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@LEAVEASSESS", false));
                    }
                    if (radioButton3.Checked)
                    {
                        paras.Add(new SqlParameter("@OVERWORKINGORECHECK", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@OVERWORKINGORECHECK", false));
                    }
                    if (radioButton4.Checked)
                    {
                        paras.Add(new SqlParameter("@SETOVERWORK", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@SETOVERWORK", false));
                    }
                    if (radioButton5.Checked)
                    {
                        paras.Add(new SqlParameter("@OVERWORKASSESS", true));
                    }
                    else
                    {
                        paras.Add(new SqlParameter("@OVERWORKASSESS", false));
                    }

                    SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                    cmd.Parameters.AddRange(paras.ToArray());//添加
                    var db1 = new DBHelper("MyCN");
                    int i = db1.ExecuteNonQuery(cmd);
                    if (i != 0)
                    {
                        MessageBox.Show("注册成功", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败", "提示");
                    }

                }
            }

        }

       private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            tabControl1.Enabled = true;
            button2.Enabled = false;
           button4.Visible = true;
        }

       private void button4_Click(object sender, EventArgs e)
       {
           if (judgeVaild() == "")
           {
                  String Departmentname = textBox1.Text.Trim();
                  String id = textBox2.Text.Trim();
                  String timestart = comboBox1.Text.Trim();
                  String monthstart = comboBox2.Text.Trim();
                  String intervaltime = comboBox5.Text.Trim();
                  string sql = "update  CHECKRULESET set DEPARTMENTNAME = '"+Departmentname+"',DEPARTMENTID = '"+id+"',TIMESTART= '"+timestart+"',MONTHTIMESTART= '"+monthstart+"',INTERVALTIME = '"+intervaltime+"',LEAVEINGORECHECK = '"+radioButton6.Checked+"',LEAVEOUT= '"+radioButton7.Checked+"',WORKOUT= '"+radioButton8.Checked+"',LEAVEASSESS = '"+radioButton9.Checked+"',OVERWORKINGORECHECK = '"+radioButton3.Checked+"',SETOVERWORK= '"+radioButton4.Checked+"',OVERWORKASSESS = '"+radioButton5.Checked+"'";
                  SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                  var db = new DBHelper("MyCN");
                  int i = db.ExecuteNonQuery(cmd);
                  if (i != 0)
                  {
                      MessageBox.Show("考勤设置成功", "提示");
                      this.Close();
                  }
                  else
                  {
                      MessageBox.Show("考勤设置失败", "提示");
                  }
       }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           this.Close();
       }
    }
}
