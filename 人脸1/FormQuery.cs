using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelpers;

namespace 人脸1
{
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(comboBox1.Text == "姓名")
            {
                string name = textBoxContent.Text.Trim();
                
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("请输入姓名","提示");
                }     
                else
                {
                    string sqlStr = "select 姓名 from FaceData where 姓名='name' ";
                    SqlCommand cmd = new SqlCommand(sqlStr);//执行sql语句

                    var db = new DBHelper("MyCN");    
                    //MessageBox.Show("" + cmd.ExecuteScalar().ToString(), "提示");
                    Form4 form4 = new Form4();
                    //db.ExecuteNonQuery(cmd);
                   var dataTable = db.ExecuteDataTable(cmd);

                   MessageBox.Show("" + dataTable, "提示");
                 //   form4.textBox4.Text = cmd.ExecuteScalar().ToString(); ;
                }
            }

           
        }

     
        }
}
