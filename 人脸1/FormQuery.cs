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
            string condition = comboBoxCondition.Text;
            switch (condition)
            {
                case "姓名":
                    QueryByName();
                    break;
                case "编号":
                    QueryByNum();
                    break;
               case "身份证号":
                    QueryByIdcardNum();
                    break;
                default:
                    break;
            }
        }

        private void QueryByName()  //按姓名查询
        {

            string name = textBoxContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("请输入姓名", "提示");
            }
            else
            {
                string commandText = @"select * from FaceData where 姓名=@name ";
                SqlParameter sqlParamater = new SqlParameter("@name",SqlDbType.NVarChar) 
                {
                    Value = name
                };
                SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                cmd.Parameters.Add(sqlParamater);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
             //   Console.WriteLine(dataTable.Rows.Count);
            }
        }

        private void QueryByNum()  //按编号查询
        {

            string Num = textBoxContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(Num))
            {
                MessageBox.Show("请输入编号", "提示");
            }
            else
            {
                string commandText = @"select * from FaceData where 编号=@Num ";
                SqlParameter sqlParamater = new SqlParameter("@Num", SqlDbType.Int)
                {
                    Value = Num
                };
                SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                cmd.Parameters.Add(sqlParamater);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
                Console.WriteLine(dataTable.Rows.Count);
            }
        }
        private void QueryByIdcardNum()  //按身份证号查询 
        {

            string IdcardNum = textBoxContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(IdcardNum))
            {
                MessageBox.Show("请输入编号", "提示");
            }
            else
            {
                string commandText = @"select * from FaceData where 身份证号=@IdcardNum ";
                SqlParameter sqlParamater = new SqlParameter("@IdcardNum", SqlDbType.Int)
                {
                    Value = IdcardNum
                };
                SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                cmd.Parameters.Add(sqlParamater);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
                Console.WriteLine(dataTable.Rows.Count);
            }
        }  

        private void buttonConfirmAll_Click(object sender, EventArgs e) //显示全部信息
        {
            string name = textBoxContent.Text.Trim();
            string commandText = @"select * from FaceData ";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            dataGridView1.DataSource = dataTable;
           // Console.WriteLine(dataTable.Rows.Count);
         }

        
  

    }
}
