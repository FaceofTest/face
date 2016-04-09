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
    public partial class HireStaff : Form
    {
        public HireStaff(DivisionalManagement dm)
        {
            InitializeComponent();
            this.dm = dm;
        }

        private void HireStaff_Load(object sender, EventArgs e)
        {
            HirestaffShow();
            DepartmentStaffshow();
        }

        private void HirestaffShow()
        {
            string commandText1 = @"select STAFFID as '人员编号',NAME as '姓名' from STAFFINFORMATION;";
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd1);
            dataGridView1.DataSource = dataTable1;
        }
        private void DepartmentStaffshow()
        {
            String DepartName = dm.treeView1.SelectedNode.Name;
            string commandText1 = @"select STAFFID as '人员编号',NAME as '姓名' from STAFFINFORMATION where DEPARTMENTNAME='" + DepartName + "'";
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd1);
            dataGridView2.DataSource = dataTable1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String DepartNewName = dm.treeView1.SelectedNode.Name;
            string commandText1 = @"update STAFFINFORMATION set DEPARTMENTNAME='" + DepartNewName + "' where STAFFID='" + num + "'"; ;
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            db.ExecuteDataTable(cmd1);
            HireStaff_Load(null,null);   //相当于窗口刷新
            DepartmentStaffshow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string commandText1 = @"update STAFFINFORMATION set DEPARTMENTNAME='" + "总公司" + "' where STAFFID='" + num + "'"; ;
            SqlCommand cmd1 = new SqlCommand(commandText1);//执行sql语句
            var db = new DBHelper("MyCN");
            db.ExecuteDataTable(cmd1);
            HireStaff_Load(null, null);
            HirestaffShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
