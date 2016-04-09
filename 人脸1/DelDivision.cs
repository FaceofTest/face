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
    public partial class DelDivision : Form
    {
        public DelDivision(DivisionalManagement dm)
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
            if (!textBox1.Text.Equals(""))
            {
                DelByDepartmentName();
            }
            if (!textBox2.Text.Equals(""))
            {
                DelByDepartmentID();
            }
        }
        private void DelByDepartmentName()
        {
            string name = textBox1.Text.Trim();
            string commandText = @"delete from DEPARTMENT where DEPARTMENTNAME='"+name+"' ";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show( name + "部门删除成功");
                this.Close();
                int count = dm.treeView1.Nodes[0].Nodes.Count;
                if (count > 0)
                {
                    for (int m = 0; m <count; m++)
                    {
                        if (dm.treeView1.Nodes[0].Nodes[m].Name == name)
                        {
                          dm.treeView1.Nodes[0].Nodes[m].Remove();
                            break;
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("您还没有添加部门，因此没有部门可以删除","提示");
                }

                
            }
            else
            {
                MessageBox.Show("删除失败");
            } 
        }
        private void DelByDepartmentID()
        {
            string ID = textBox2.Text.Trim();
            string commandText = @"delete from DEPARTMENT where DEPARTMENTID=@name ";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("部门编号是" + ID + "的部门删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            } 
        }
    }
}
