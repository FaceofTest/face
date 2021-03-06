﻿using DBHelpers;
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
        int flag = 1;   //背景色移动时是从 （1，1）开始移动
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
            if (textBox2.Text == null)
            {
                MessageBox.Show("所属部门不能为空");
                return "所属部门不能为空";
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
                // 初始化人员信息密码
                string sq = "insert into STAFFPASSWORD(STAFFID,NAME,PASSWORD) values(@STAFFID,@NAME,@PASSWORD)";
                List<SqlParameter> paras1 = new List<SqlParameter>();
                paras1.Add(new SqlParameter("@STAFFID", textBox1.Text.Trim())); //人员编号
                paras1.Add(new SqlParameter("@NAME", textBox6.Text.Trim()));    //姓名
                paras1.Add(new SqlParameter("@PASSWORD", textBox1.Text.Trim()));    //密码为初始密码 即人员编号
                SqlCommand cmd1 = new SqlCommand(sq);//执行sql语句
                cmd1.Parameters.AddRange(paras1.ToArray());//添加
                var db1 = new DBHelper("MyCN");
                db1.ExecuteNonQuery(cmd1);
                //注册
                string sql = "insert into STAFFINFORMATION (STAFFID,NAME,GENDER,MINZU,BIRTHDAY,TITLE,OPHONE,PHOTO,DEPARTMENTNAME) values(@STAFFID,@NAME,@GENDER,@MINZU,@BIRTHDAY,@TITLE,@OPHONE,@PHOTO,@DEPARTMENTNAME)";//往数据库FaceDate中插入数据
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@STAFFID", textBox1.Text.Trim())); //人员编号
                paras.Add(new SqlParameter("@NAME", textBox6.Text.Trim()));    //姓名
                paras.Add(new SqlParameter("@MINZU", textBox3.Text.Trim()));   //民族
                paras.Add(new SqlParameter("@BIRTHDAY", dateTimePicker2.Value));  // 出生日期
                paras.Add(new SqlParameter("@TITLE", textBox4.Text.Trim()));     //职务
                paras.Add(new SqlParameter("@OPHONE", textBox8.Text.Trim()));    //办公电话
                paras.Add(new SqlParameter("@DEPARTMENTNAME", textBox2.Text.Trim()));  //所属部门
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
            //树显示
            string commandText = @"select DEPARTMENTNAME from DEPARTMENT;";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i = dataTable.Rows.Count;              //将姓名放在datatable中 并加载到treeview中
            for (int m = 0; m < i; m++)
            {
                TreeNode tn = new TreeNode(dataTable.Rows[m][0].ToString());
                tn.Name = dataTable.Rows[m][0].ToString();
                treeView1.Nodes[0].Nodes.Add(tn);
            }

            //信息显示
           informationshow();
        }

        private void informationshow()
        {
            string commandText1 = @"select STAFFID as '人员编号',NAME as '姓名',GENDER as '性别',MINZU as '民族',BIRTHDAY as '出生日期',TITLE as '职务',OPHONE as '电话号码',PHOTO as '照片',DEPARTMENTNAME as '部门名称' from STAFFINFORMATION;";
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd1);
            dataGridView1.DataSource = dataTable1;
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

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            String judge = toolStripTextBox1.Text.Trim();
            int i = toolStripTextBox1.Text.Length;
            int j = 0,m = 0;
            if (toolStripTextBox1.Text == String.Empty)
            {
                MessageBox.Show("请先输入查询条件","提示");
            }
            foreach (char c in judge)
            {
                if ( char.IsNumber(c))  //若输入的全是数字 则按照人员编号查找
                {
                    j++;
                }
            }
            foreach (char c in judge)
            {
                if (char.IsLetter(c))  //若输入的全是汉字 则按照人员编号查找
                {
                    m++;
                }
            }
            if (j == i)
            {
                FundFtaffID();
            }
            else if (m == i)
            {
                FundStaffName();
            }
            else 
            {
                MessageBox.Show("请输入人员编号 [纯数字] 或姓名 [纯汉字]","提示");
                toolStripTextBox1.Text = String.Empty;
            }
           

        }
        private void FundFtaffID()
        {
            String Id = toolStripTextBox1.Text.Trim();
            if (toolStripTextBox1.Text.Trim() != String.Empty)
            {
                String sql = @"select  STAFFID as '人员编号',NAME as '姓名',GENDER as '性别',MINZU as '民族',BIRTHDAY as '出生日期',TITLE as '职务',OPHONE as '电话号码',PHOTO as '照片',DEPARTMENTNAME as '部门名称' from STAFFINFORMATION where STAFFID = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(sql);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("您查询的员工不存在", "提示");
                    informationshow();

                }
            }
            
            
        }


        private void FundStaffName()
        {
            String name = toolStripTextBox1.Text.Trim();
            String sql = @"select  STAFFID as '人员编号',NAME as '姓名',GENDER as '性别',MINZU as '民族',BIRTHDAY as '出生日期',TITLE as '职务',OPHONE as '电话号码',PHOTO as '照片',DEPARTMENTNAME as '部门名称' from STAFFINFORMATION where NAME = '"+name+"'";
            SqlCommand cmd = new SqlCommand(sql);
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            dataGridView1.DataSource = dataTable;
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("您查询的员工不存在", "提示");
                informationshow();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            if (tn.IsSelected)
            {
                String DepartmentName = tn.Name;
                String sql = @"select  STAFFID as '人员编号',NAME as '姓名',GENDER as '性别',MINZU as '民族',BIRTHDAY as '出生日期',TITLE as '职务',OPHONE as '电话号码',PHOTO as '照片',DEPARTMENTNAME as '部门名称' from STAFFINFORMATION where DEPARTMENTNAME = '" + DepartmentName + "'";
                SqlCommand cmd = new SqlCommand(sql);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;

            }
            if (treeView1.Nodes[0].IsSelected)
            {
                String sql = @"select STAFFID as '人员编号',NAME as '姓名',GENDER as '性别',MINZU as '民族',BIRTHDAY as '出生日期',TITLE as '职务',OPHONE as '电话号码',PHOTO as '照片',DEPARTMENTNAME as '部门名称' from STAFFINFORMATION;";
                SqlCommand cmd = new SqlCommand(sql);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DelMessage dm = new DelMessage();
            dm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在下方的基本信息中输入","提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camera ca = new Camera(this);
            ca.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.ColumnCount-2;
            if (count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, flag++];
                if (flag == count)
                {
                    flag = 0;
                 }
            }
            if (count == 0)
            {
                 MessageBox.Show("请确保输入了人员信息", "提示");
            }
        }

        private void StaffMaintain_FormClosed(object sender, FormClosedEventArgs e)
        {
            toolStripTextBox1.Text = String.Empty;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      
       
    }
}