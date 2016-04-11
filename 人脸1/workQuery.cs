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
    public partial class workQuery : Form
    {
        public workQuery()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("王伏注意  这里是要生成报表的","提示");
        }

        private void workQuery_Load(object sender, EventArgs e)
        {
            String sql = @"select DEPARTMENTNAME from DEPARTMENT";
            SqlCommand cmd = new SqlCommand(sql);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i = dataTable.Rows.Count;              //将姓名放在datatable中 并加载到treeview中
            for (int m = 0; m < i; m++)
            {
                comboBox1.Items.Add(dataTable.Rows[m][0].ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getRadioButton() == "全部")
           {
               if (comboBox1.Text.Equals("总公司"))
               {
                   String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA";
                   // AND select * from CHECKDATA where (ARRIVALTIME <= '" + DateStart + "' AND LEAVETIME >= '" +DateEnd+ "')";
                   SqlCommand cmd1 = new SqlCommand(sql1);
                   var db1 = new DBHelper("MyCN");
                   var dataTable1 = db1.ExecuteDataTable(cmd1);
                   int m1 = dataTable1.Rows.Count;
                   if (m1 == 0)
                   {
                       MessageBox.Show("请注册人员", "提示");
                   }
                   else
                   {
                       dataGridView1.DataSource = dataTable1;
                   }
               }
               else
               {
                   String DepartmentName = comboBox1.Text;
                   String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称' from STAFFINFORMATION where STAFFINFORMATION.DEPARTMENTNAME = '" + DepartmentName + "'";
                   SqlCommand cmd1 = new SqlCommand(sql1);
                   var db1 = new DBHelper("MyCN");
                   var dataTable1 = db1.ExecuteDataTable(cmd1);
                   int m1 = dataTable1.Rows.Count;
                   if (m1 == 0)
                   {
                       MessageBox.Show("该部门没有人员", "提示");
                   }
                   else
                   {
                       dataGridView1.DataSource = dataTable1;
                   }

               }

           }
            if (getRadioButton() == "在岗")
            {
                DateTime Date = dateTimePicker1.Value;
                String DepartmentName = comboBox1.SelectedItem.ToString();
                String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA where STAFFINFORMATION.DEPARTMENTNAME = '" + DepartmentName + "' AND CHECKDATA.NAME = STAFFINFORMATION.NAME AND CHECKDATA.ARRIVETIME>='" + Date + "' AND CHECKDATA.LEAVETIME >= '" + Date + "'";
                // AND select * from CHECKDATA where (ARRIVALTIME <= '" + DateStart + "' AND LEAVETIME >= '" +DateEnd+ "')";
                SqlCommand cmd1 = new SqlCommand(sql1);
                var db1 = new DBHelper("MyCN");
                var dataTable1 = db1.ExecuteDataTable(cmd1);
                int m1 = dataTable1.Rows.Count;
                if (m1 == 0)
                {
                    MessageBox.Show("这个时间点没有人在岗", "提示");
                }
                else
                {
                    dataGridView1.DataSource = dataTable1;
                }

            }
            if (getRadioButton() == "不在岗")
            {
                DateTime Date = dateTimePicker1.Value;
                String DepartmentName = comboBox1.SelectedItem.ToString();
                String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA where STAFFINFORMATION.DEPARTMENTNAME = '" + DepartmentName + "' AND CHECKDATA.NAME = STAFFINFORMATION.NAME AND CHECKDATA.ARRIVETIME !='" + Date + "' AND CHECKDATA.LEAVETIME != '" + Date + "'";
                // AND select * from CHECKDATA where (ARRIVALTIME <= '" + DateStart + "' AND LEAVETIME >= '" +DateEnd+ "')";
                SqlCommand cmd1 = new SqlCommand(sql1);
                var db1 = new DBHelper("MyCN");
                var dataTable1 = db1.ExecuteDataTable(cmd1);
                int m1 = dataTable1.Rows.Count;
                if (m1 == 0)
                {
                    MessageBox.Show("这个时间点全部人在岗", "提示");
                }
                else
                {
                    dataGridView1.DataSource = dataTable1;
                }

            }
       
        }

        private String getRadioButton()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            else
            {
                return "";
            }
        }
      
    }
}
