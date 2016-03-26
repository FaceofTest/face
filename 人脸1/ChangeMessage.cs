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
    public partial class ChangeMessage : Form
    {
        public ChangeMessage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = comboBox1.Text.Trim();
            label4.Text = select;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition = comboBox1.Text;
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

            string name = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("请输入姓名", "提示");
            }
            else
            {
                string commandText = @"select * from FaceData where 姓名=@name ";
                SqlParameter sqlParamater = new SqlParameter("@name", SqlDbType.NVarChar)
                {
                    Value = name
                };
                SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                cmd.Parameters.Add(sqlParamater);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void QueryByNum()  //按编号查询
        {

            string Num = textBox1.Text.Trim();

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

            string IdcardNum = textBox1.Text.Trim();

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

        private void ChangeMessage_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“testDataSet.FaceData”中。您可以根据需要移动或删除它。
            this.faceDataTableAdapter.Fill(this.testDataSet.FaceData);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                ChangeName();
                MessageBox.Show("wewewe","werw");
            }
            if (!textBox3.Text.Equals(""))
            {
                ChangeNum();
            }
            if (!textBox4.Text.Equals(""))
            {
                ChangID();
            }
            if (pictureBox1.Image == null)
            {
                Changepic();
            }
        }

        private void ChangeName()
        {
            string oldname = textBox1.Text.Trim();   
            string newname = textBox2.Text.Trim();
            string commandText = @"update FaceData set 姓名='"+newname+"' where 姓名='"+oldname+"'";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("员工信息修改成功");
            }
            else
            {
                MessageBox.Show("信息修改失败");
            }  
        }
        private void ChangeNum()
        {
            string oldNum = textBox1.Text.Trim();
            string newNum = textBox3.Text.Trim();
            string commandText = @"update FaceData set 编号='" + newNum + "' where 编号='" + oldNum + "'";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("员工信息修改成功");
            }
            else
            {
                MessageBox.Show("信息修改失败");
            } 
        }
        private void ChangID()
        {
            string oldID = textBox1.Text.Trim();
            string newID = textBox4.Text.Trim();
            string commandText = @"update FaceData set 身份证号='" + newID + "' where 身份证号='" + oldID + "'";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("员工信息修改成功");
            }
            else
            {
                MessageBox.Show("信息修改失败");
            } 
        }
        private void Changepic()
        { 

        }
    }
}
