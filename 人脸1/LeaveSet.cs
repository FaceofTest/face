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
    public partial class LeaveSet : Form
    {
        public LeaveSet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaveSet_Load(object sender, EventArgs e)
        {

            String sql = @"select DEPARTMENTNAME from DEPARTMENT";
            SqlCommand cmd = new SqlCommand(sql);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i = dataTable.Rows.Count;             
            for (int m = 0; m < i; m++)
            {
                comboBox1.Items.Add(dataTable.Rows[m][0].ToString());

            }
        }
   

        private string judgeVaild()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("部门不能为空");
                return "部门不能为空";
            }
            if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("员工不能为空");
                return "员工不能为空";
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("请假理由不能为空");
                return "请假理由不能为空";
            }
            else {
                return "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Equals(dateTimePicker2.Text))
            {
                DialogResult result = MessageBox.Show("请设定好查询的起止时间", "提示", MessageBoxButtons.OKCancel);
            }
            else
            { 
                if (judgeVaild() == "")
                {
                    string sql = "insert into LEAVE (NAME,DEPARTMENTNAME,TIMESTART,TIMEEND,REASON) values(@NAME,@DEPARTMENTNAME,@TIMESTART,@TIMEEND,@REASON)";//往数据库FaceDate中插入数据
                    List<SqlParameter> paras = new List<SqlParameter>();
                    paras.Add(new SqlParameter("@NAME",comboBox2.Text.Trim())); 
                    paras.Add(new SqlParameter("@DEPARTMENTNAME",comboBox1.Text.Trim()));    
                    paras.Add(new SqlParameter("@TIMESTART",dateTimePicker1.Value)); 
                    paras.Add(new SqlParameter("@TIMEEND",dateTimePicker1.Value )); 
                    paras.Add(new SqlParameter("@REASON",textBox2.Text.Trim()));
                    SqlCommand cmd = new SqlCommand(sql);//执行sql语句
                    cmd.Parameters.AddRange(paras.ToArray());//添加
                    var db = new DBHelper("MyCN");
                    int i = db.ExecuteNonQuery(cmd);
                    if (i != 0)
                    {
                         MessageBox.Show("请假成功", "提示");
                         this.comboBox1.Text = String.Empty;
                         this.comboBox2.Text = String.Empty;
                         this.textBox2.Text = String.Empty;
                    }
                    else
                    {
                          MessageBox.Show("请假失败", "提示");
                    }

                }
            
            }
        }

 

        private void button3_Click(object sender, EventArgs e)
        {
            string commandText1 = @"select ID as '序号', NAME as '姓名',DEPARTMENTNAME as '部门名称',TIMESTART as '请假开始时间',TIMEEND as '请假截止时间',REASON as '请假理由' from LEAVE;";
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd1);
            dataGridView1.DataSource = dataTable1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String DepartmentName = comboBox1.SelectedItem.ToString();
            String sql = @"select NAME from STAFFINFORMATION Where DEPARTMENTNAME = '" + DepartmentName + "'";
            SqlCommand cmd = new SqlCommand(sql);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i = dataTable.Rows.Count;              //将姓名放在datatable中 并加载到treeview中
            for (int m = 0; m < i; m++)
            {
                comboBox2.Items.Add(dataTable.Rows[m][0].ToString());

            }
        }

    }
}
