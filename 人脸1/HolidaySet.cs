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
    public partial class HolidaySet : Form
    {
        public HolidaySet()
        {
            InitializeComponent();
        }

        private void HolidaySet_Load(object sender, EventArgs e)
        {
            String sql = @"select ID as '序号',HOLIDAYNAME as '假名称' from HOLIDAYSET";
            SqlCommand cmd = new SqlCommand(sql);
            var db = new DBHelper("MyCN");
            var dataTable1 = db.ExecuteDataTable(cmd);
            dataGridView1.DataSource = dataTable1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String HolidayName = textBox1.Text.Trim();
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("假名称不能为空", "提示");
            }
            else
            {
                String sql = "insert into HOLIDAYSET (HOLIDAYNAME) values('" + HolidayName + "')";
                SqlCommand cmd = new SqlCommand(sql);
                var db = new DBHelper("MyCN");
                int i = db.ExecuteNonQuery(cmd);
                if (i != 0)
                {
                    MessageBox.Show("添加假类成功", "提示");
                    HolidaySet_Load(null, null); 
                }
                else
                {
                    MessageBox.Show("添加假类失败", "提示");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
