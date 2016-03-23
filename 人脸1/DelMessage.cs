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
    public partial class DelMessage : Form
    {
        public DelMessage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
            {
                DelByName();
            }
            if (!textBox2.Text.Equals(""))
            {
                DelByNum();
            }
            if (!textBox3.Text.Equals(""))
            {
                DelByIdcardNum();
            }
        }
        private void  DelByName()
        {
            string name = textBox1.Text.Trim();
            string commandText = @"delete from FaceData where 姓名=@name ";
           SqlParameter sqlParamater = new SqlParameter("@name", SqlDbType.NVarChar)
            {
                Value = name
            };
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            cmd.Parameters.Add(sqlParamater);
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("姓名是"+name+"的员工信息删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            } 
            
            
        }
      
        private void DelByNum()
        {
            string num = textBox2.Text.Trim();
            string commandText = @"delete from FaceData where 编号=@num ";
         
            SqlParameter sqlParamater = new SqlParameter("@num", SqlDbType.Int)
            {
               Value = num
            };
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            cmd.Parameters.Add(sqlParamater);
            var db = new DBHelper("MyCN");
           int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("编号是"+num+"的员工信息删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            } 
            
        }

        private void DelByIdcardNum()
        {
            string Idnum = textBox2.Text.Trim();
            string commandText = @"delete from FaceData where 身份证号=@Idnum ";

            SqlParameter sqlParamater = new SqlParameter("@Idnum", SqlDbType.Int)
            {
                Value = Idnum
            };
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            cmd.Parameters.Add(sqlParamater);
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("身份证号是"+Idnum+"的员工信息删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            } 
            
        }

    }
}
