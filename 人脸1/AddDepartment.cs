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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("部门名称不能为空", "提示");
            }
            else {
                string sql = "insert into DEPARTMENT (DEPARTMENTNAME,DEPARTMENTID) values(@DEPARTMENTNAME,@DEPARTMENTID)";
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@DEPARTMENTNAME", textBox1.Text.Trim()));
                paras.Add(new SqlParameter("@DEPARTMENTID", textBox2.Text.Trim()));
                SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                cmd.Parameters.AddRange(paras.ToArray());//添加
                var db = new DBHelper("MyCN");
                int i = db.ExecuteNonQuery(cmd);
                if (i != 0)
                {
                    MessageBox.Show("添加部门成功", "提示");
                    //这里；
                }
                else
                {
                    MessageBox.Show("添加部门失败", "提示");
                }
            }
        }
    }
}
