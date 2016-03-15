using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelpers;

namespace 人脸1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string judgeVaild()
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("姓名不能为空");
                return "姓名不能为空";
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("编号不能为空");
                return "编号不能为空";
            }
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("身份证号不能为空");
                return "身份证号不能为空";
            }
            else
            {
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;//为了确定是否向数据库输入信息成功
            string pathName = openFileDialog1.FileName;
            FileStream fs = new FileStream(pathName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] buffByte = new byte[fs.Length];
            fs.Read(buffByte, 0, (int)fs.Length);
            fs.Close();
            if (judgeVaild() == "")
            {

                string sql = "insert into FaceData (姓名,编号,性别,身份证号,照片) values(@姓名,@编号,@性别,@身份证号,@照片)";//往数据库FaceDate中插入数据
                List<SqlParameter> paras = new List<SqlParameter>(); 
                paras.Add(new SqlParameter("@姓名", textBox4.Text.Trim()));
                paras.Add(new SqlParameter("@编号", textBox3.Text.Trim()));
                paras.Add(new SqlParameter("@身份证号", textBox1.Text.Trim()));
                if (radioButtonMale.Checked)
                {
                    paras.Add(new SqlParameter("@性别", true));
                }
                else
                {
                    paras.Add(new SqlParameter("@性别", false));
                }
                if (pictureBox1.Image != null)
                {
                    if (pictureBox1.ImageLocation == null) 
                    {
                        paras.Add(new SqlParameter("@照片", DBNull.Value));
                    }
                      
                    else {
                        paras.Add(new SqlParameter("@照片",pictureBox1.ImageLocation));
                    }
                }
                else 
                {
                    MessageBox.Show("照片不能为空","提示");
                }
                SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                cmd.Parameters.AddRange(paras.ToArray());//添加
                var db = new DBHelper("MyCN");
                num++;
                db.ExecuteNonQuery(cmd);
                if (num != 0)
                {
                    MessageBox.Show("注册成功", "提示");
                }
                else {
                    MessageBox.Show("注册失败", "提示");
                }
                
                
            }
        }
        public bool UserNameIsExist(string Name)
        {
            return true;

            /* {
                 judgebutton1click = true;
                 String dir = @System.Environment.CurrentDirectory;
                 FileInfo file = new FileInfo("信息.txt");
                 if (Directory.Exists(dir))
                 {  
                     if (!file.Exists)
                     {
                         //使用“另存为”对话框中输入的文件名实例化FileStream对象
                         FileStream myStream = File.Create("信息.txt");
                         myStream.Flush();
                         myStream.Close();
                     }
                     else
                     {
                         StreamWriter myWriter = new StreamWriter("信息.txt", true);
                         //向创建的文件中写入内容
                         myWriter.Write(textBox4.Text + " ");
                         myWriter.Write(textBox1.Text + " ");
                         myWriter.Write(textBox3.Text + " ");
                         if (radioButton1.Text == "男")
                         {
                             myWriter.Write(" M ");
                         }
                         if (radioButton1.Text == "女")
                         {
                             myWriter.Write(" W ");
                         }
                         //关闭当前写入流
                         myWriter.Close();
                         //关闭当前文件流
                         textBox4.Text = string.Empty;
                         textBox3.Text = string.Empty;
                         textBox1.Text = string.Empty;
                     }
                 }
             }
            MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
