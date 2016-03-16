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
                default:
                    break;
            }
        }

        private void QueryByName()
        {

            string name = textBoxContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("请输入姓名", "提示");
            }
            else
            {
                string commandText = @"select * from FaceData where 姓名=@Name ";
                SqlParameter sqlParamater = new SqlParameter("@Name",SqlDbType.NVarChar) 
                {
                    Value = name
                };
                SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
                cmd.Parameters.Add(sqlParamater);
                var db = new DBHelper("MyCN");
                var dataTable = db.ExecuteDataTable(cmd);
                dataGridView1.DataSource = dataTable;
                Console.WriteLine(dataTable.Rows.Count);
                Form4 form4 = new Form4();
            }
        }

    }
}
