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
using Microsoft.Office.Interop.Excel;

namespace 人脸1
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
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
            if (dataGridView1.RowCount == 0)
            {
                button4.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("总公司"))
            {
                comboBox2.Text = "全体员工";
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text.Equals(dateTimePicker2.Text))
            {
                DialogResult result = MessageBox.Show("请设定好查询的起止时间", "提示", MessageBoxButtons.OKCancel);
            }
            else
            {
                String DepartmentName = comboBox1.SelectedItem.ToString();
                String Name = comboBox2.SelectedItem.ToString();
                DateTime DateStart = dateTimePicker1.Value;
                DateTime DateEnd = dateTimePicker2.Value;
                if (comboBox1.Text.Equals("总公司") && comboBox2.Text.Equals("全体员工"))
                {
                    String sql = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA where CHECKDATA.ARRIVETIME>='" + DateStart + "' AND CHECKDATA.LEAVETIME <= '" + DateEnd + "'";
                    // AND select * from CHECKDATA where (ARRIVALTIME <= '" + DateStart + "' AND LEAVETIME >= '" +DateEnd+ "')";
                    SqlCommand cmd = new SqlCommand(sql);
                    var db = new DBHelper("MyCN");
                    var dataTable = db.ExecuteDataTable(cmd);
                    int m = dataTable.Rows.Count;
                    if (m == 0)
                    {
                        MessageBox.Show("您查选的全部人员都没有进行考勤", "提示");
                    }
                    else
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                }
                else  if (!comboBox1.Text.Equals("总公司") && comboBox2.Text.Equals("全体员工"))
                {
                    String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA where  STAFFINFORMATION.DEPARTMENTNAME = '" + DepartmentName + "' AND CHECKDATA.ARRIVETIME>='" + DateStart + "' AND CHECKDATA.LEAVETIME <= '" + DateEnd + "'";
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
                    String sql1 = @"select STAFFINFORMATION.STAFFID as '人员编号',STAFFINFORMATION.NAME as '姓名',STAFFINFORMATION.DEPARTMENTNAME as '部门名称',CHECKDATA.ARRIVETIME as '到达时间',CHECKDATA.LEAVETIME as '离开时间',CHECKDATA.CHECKSUCCESS as '考勤成功'  from STAFFINFORMATION,CHECKDATA where STAFFINFORMATION.NAME = '" + Name + "' AND STAFFINFORMATION.DEPARTMENTNAME = '" + DepartmentName + "' AND CHECKDATA.NAME = STAFFINFORMATION.NAME AND CHECKDATA.ARRIVETIME>='" + DateStart + "' AND CHECKDATA.LEAVETIME <= '" + DateEnd + "'";
                    // AND select * from CHECKDATA where (ARRIVALTIME <= '" + DateStart + "' AND LEAVETIME >= '" +DateEnd+ "')";
                    SqlCommand cmd1 = new SqlCommand(sql1);
                    var db1 = new DBHelper("MyCN");
                    var dataTable1 = db1.ExecuteDataTable(cmd1);
                    int m1 = dataTable1.Rows.Count;
                    if (m1 == 0)
                    {
                        MessageBox.Show("您查选的人员在指定的起止时间段内没有上班", "提示");
                    }
                    else
                    {
                        dataGridView1.DataSource = dataTable1;
                    }
                }
            }
            if (dataGridView1.RowCount != 0)
            {
                button4.Enabled = true;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导入到excel 失败","提醒王伏");
            ExportDataGridview(dataGridView1, true);
        }
        public bool ExportDataGridview(DataGridView gridView, bool isShowExcle)
        {
            if (gridView.Rows.Count == 0)
            {
                return false;
            }
            //创建Excel对象
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            //生成字段名称
     /*       for (int i = 0; i < gridView.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
            }
            //填充数据
            for (int i = 0; i < gridView.RowCount - 1; i++)   //循环行
            {
                for (int j = 0; j < gridView.ColumnCount; j++) //循环列
                {
                    if (gridView[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + gridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = gridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            //设置禁止弹出保存和覆盖的询问提示框  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.AlertBeforeOverwriting = false;

            //保存到临时工作簿
            //excel.Application.Workbooks.Add(true).Save();
            //保存文件
      */
            excel.Save("导出.xls");
            excel.Quit();
            return true;
        }
    }
}
