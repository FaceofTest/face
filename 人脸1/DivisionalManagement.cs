﻿using DBHelpers;
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
    public partial class DivisionalManagement : Form
    {
        public DivisionalManagement()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddDepartment ad = new AddDepartment(this);
            ad.Show();
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HireStaff hs = new HireStaff(this);
            hs.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DelDivision dd = new DelDivision(this);
           dd.Show();
        }

        private void DivisionalManagement_Load(object sender, EventArgs e)
        {
            string commandText = @"select DEPARTMENTNAME from DEPARTMENT ";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            var dataTable = db.ExecuteDataTable(cmd);
            int i =dataTable.Rows.Count;              //将姓名放在datatable中 并加载到treeview中
            for (int m = 0; m <i; m++)
            {
                TreeNode tn = new TreeNode(dataTable.Rows[m][0].ToString());
                tn.Name = dataTable.Rows[m][0].ToString();
                treeView1.Nodes[0].Nodes.Add(tn);    
            }
            toolStripButton4.Enabled = false; 
          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DivisionRename dr = new DivisionRename(this);
            dr.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes[0].Nodes.Count != 0 && !treeView1.Nodes[0].IsSelected)
            {
                toolStripButton4.Enabled = true;
            }
            if (treeView1.Nodes[0].IsSelected)
            {
                toolStripButton4.Enabled = false;
            }
        }

    }
}
