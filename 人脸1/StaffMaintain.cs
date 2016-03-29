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
    public partial class StaffMaintain : Form
    {
        public StaffMaintain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DivisionalManagement form17 = new DivisionalManagement();
            form17.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string judgeVaild()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("登记号码不能为空");
                return "登记号码不能为空";
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("民族不能为空");
                return "民族不能为空";
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("职务不能为空");
                return "职务不能为空";
            }
            if (dateTimePicker2.Text == string.Empty)
            {
                MessageBox.Show("出生日期不能为空");
                return "出生日期不能为空";
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("姓名不能为空");
                return "姓名不能为空";
            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("办公电话不能为空");
                return "办公电话不能为空";
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("照片不能为空");
                return "照片不能为空";
            }
            else
            {
                return "";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (judgeVaild() == "")
            {
                string sql = "insert into STAFFINFORMATION (STAFFID,NAME,GENDER,MINZU,BIRTHDAY,TITLE,OPHONE,PHOTO,DEFAULTDEPTNAME) values(@STAFFID,@NAME,@GENDER,@MINZU,@BIRTHDAY,@TITLE,@OPHONE,@PHOTO,@DEFAULTDEPTNAME)";//往数据库FaceDate中插入数据
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@STAFFID", textBox1.Text.Trim())); //人员编号
                paras.Add(new SqlParameter("@NAME", textBox6.Text.Trim()));    //姓名
                paras.Add(new SqlParameter("@MINZU", textBox3.Text.Trim()));   //民族
                paras.Add(new SqlParameter("@BIRTHDAY", dateTimePicker2.Value));  // 出生日期
                paras.Add(new SqlParameter("@TITLE", textBox4.Text.Trim()));     //职务
                paras.Add(new SqlParameter("@OPHONE", textBox8.Text.Trim()));    //办公电话
                paras.Add(new SqlParameter("@DEFAULTDEPTNAME", textBox2.Text.Trim()));  //所属部门
                if (radioButtonMale.Checked)
                {
                    paras.Add(new SqlParameter("@GENDER", true));
                }
                if (radioButtonWomen.Checked)
                {
                    paras.Add(new SqlParameter("@GENDER", false));
                }

                if (pictureBox1.ImageLocation == null)
                {
                    paras.Add(new SqlParameter("@PHOTO", DBNull.Value));
                }

                else
                {
                    paras.Add(new SqlParameter("@PHOTO", pictureBox1.ImageLocation));
                }

                SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                cmd.Parameters.AddRange(paras.ToArray());//添加
                var db = new DBHelper("MyCN");
                try
                {
                    int i = db.ExecuteNonQuery(cmd);
                    if (i != 0)
                    {
                        MessageBox.Show("注册成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("注册失败", "提示");
                    }
                }
                catch (SqlException)                                       //这个try-catch 比较笼统些 为了判断主键重复
                {
                    MessageBox.Show("输入的人员编号重复，请重新输入", "提示");
                    textBox1.Text = String.Empty;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String dir = @System.Environment.CurrentDirectory;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = dir;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.ImageLocation = @openFileDialog1.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void StaffMaintain_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“faceDataDataSet.STAFFINFORMATION”中。您可以根据需要移动或删除它。
            this.sTAFFINFORMATIONTableAdapter.Fill(this.faceDataDataSet.STAFFINFORMATION);
            string commandText = @"select DEPARTMENTNAME from DEPARTMENT ";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i = dataTable.Rows.Count;              //将姓名放在datatable中 并加载到treeview中
            for (int m = 0; m < i; m++)
            {
                TreeNode tn = new TreeNode(dataTable.Rows[0][m].ToString());
                tn.Name = dataTable.Rows[0][m].ToString();
                treeView1.Nodes[0].Nodes.Add(tn);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String num = textBox1.Text.Trim();
            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("请选择上班是否需要签到", "提示");
            }
            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("请选择下班是否需要签到", "提示");
            }
            else
            {
                    int b3=1, b4=1, b5=1, b6=1;
                    if (radioButton3.Checked)
                    {
                         b3 = 0;     //0真 1假
                    }
                    if (radioButton4.Checked)
                    {
                         b4 = 1;
                    }
                    if (radioButton5.Checked)
                    {
                         b5 = 0;
                    }
                    if (radioButton6.Checked)
                    {
                         b6 = 1;
                    }
                    string sql = "update STAFFINFORMATION set WORKSET ='"+b3+"',WORKNOTSET='"+b4+"',LEAVESET='"+b5+"',LEAVENOTSET='"+b6+"' where STAFFID = '"+num+"'";
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
    }
}