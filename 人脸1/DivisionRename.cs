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
    public partial class DivisionRename : Form
    {
        public DivisionRename(DivisionalManagement dm)
        {
            InitializeComponent();
            this.dm = dm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oldname = textBox1.Text.Trim();
            String newname = textBox2.Text.Trim();
            string commandText = @"update DEPARTMENT set DEPARTMENTNAME='" + newname + "' where DEPARTMENTNAME='" + oldname + "'";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("部门更名成功");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("部门更名失败");
            }
            this.dm.Close();
        }
    }
}
