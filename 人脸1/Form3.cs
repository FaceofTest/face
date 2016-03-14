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
            if (judgeVaild() == "")
            {

                string sql = "insert into 人脸数据 (姓名,编号,性别,身份证号) values(@姓名,@编号,@性别,@身份证号)";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@姓名", textBox4.Text.Trim()));
                paras.Add(new SqlParameter("@编号", textBox3.Text.Trim()));
                paras.Add(new SqlParameter("@性别", radioButton1.Text.Trim()));
                paras.Add(new SqlParameter("@身份证号", textBox1.Text.Trim()));
                string ConStr = "Data Source=(local);Initial Catalog=Test;Integrated Security=True";//用的是windows用户验证  好吧我把sql 身份验证密码忘了
                SqlConnection conn = new SqlConnection(ConStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(paras.ToArray());
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("连接数据库失败");
                }
           
                else
                {
                    MessageBox.Show("注册成功");
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



    }

}
