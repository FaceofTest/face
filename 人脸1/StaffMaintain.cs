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
                paras.Add(new SqlParameter("@STAFFID", textBox1.Text.Trim()));
                paras.Add(new SqlParameter("@NAME", textBox6.Text.Trim()));
                paras.Add(new SqlParameter("@MINZU", textBox3.Text.Trim()));
                paras.Add(new SqlParameter("@BIRTHDAY", dateTimePicker2.Value));  // dateTimePicker2.Value
                paras.Add(new SqlParameter("@TITLE", textBox4.Text.Trim()));
                paras.Add(new SqlParameter("@OPHONE", textBox8.Text.Trim()));
                paras.Add(new SqlParameter("@DEFAULTDEPTNAME", textBox2.Text.Trim()));  
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

   


    
    }
}
