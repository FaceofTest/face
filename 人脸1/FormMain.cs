using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using faceView;
using System.Data.SqlClient;

namespace 人脸1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.toolStripStatusLabel2.Text = "系统当前时间：" + DateTime.Now.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //这里
           // Form5 form5 = new Form5();
            //form5.Show();
            faceView.Form1 fvf =new faceView.Form1();
            fvf.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAdmin from6 = new FormAdmin();
            from6.Show();
        }

           private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出人脸管理考勤程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 查询信息_Click(object sender, EventArgs e)
        {
            FormAdmin form6 = new FormAdmin();
            form6.Show();
        }

        private void 初始化系统IToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("初始化系统将清除已经登记的所有数据，是否确认清除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                 );
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 清除过期数据TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void 备份数据库CtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "attBackup.mdb";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                }
            } 
        }

        private void 导入考勤数据CtrlIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void 导出考勤数据EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void uSB闪存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 公出请假ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void 忘签到CtrlKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void 集体迟到早退处理CtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void 出勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
        }

        private void 当前在岗情况CtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void 系统操作日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void 部门管理DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
        }

        private void 人员维护CtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
        }

        private void 管理员设置AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void 时间段维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Show();
        }

        private void 班次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
        }

        private void 人员排班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Show();
        }

        private void 节日维护HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.Show();
        }

        private void 考勤规则RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.Show();
        }

        private void 退出系统_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

  
    }
   
}
