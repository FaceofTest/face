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
        public FormMain(Admin ad,bool flag)
        {
            InitializeComponent();
            this.ad = ad;
            this.flag = flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            this.toolStripStatusLabel2.Text = "系统当前时间：" + DateTime.Now.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register form3 = new Register();
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
            Manage ma = new Manage();
            ma.Show();
        }

           private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出人脸管理考勤程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                this.ad.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 查询信息_Click(object sender, EventArgs e)
        {
            FormQuery form2 = new FormQuery();
            form2.Show();
        }

        private void 初始化系统IToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show("初始化系统将清除已经登记的所有数据，是否确认清除", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk
                 );
        }

        private void 清除过期数据TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearOldData form7 = new ClearOldData();
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
            ImportData form8 = new ImportData();
            form8.Show();
        }

        private void 导出考勤数据EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportData form9 = new ExportData();
            form9.Show();
        }

        private void uSB闪存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USBImEx form10 = new USBImEx();
            form10.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 公出请假ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveSet form11 = new LeaveSet();
            form11.Show();
        }

     



        private void 出勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Record form14 = new Record();
            form14.Show();
        }

        private void 当前在岗情况CtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workQuery form15 = new workQuery();
            form15.Show();
        }

        private void 系统操作日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogofSystem form16 = new LogofSystem();
            form16.Show();
        }

        private void 部门管理DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivisionalManagement dm = new DivisionalManagement();
            dm.Show();
        }

        private void 人员维护CtrlEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffMaintain form18 = new StaffMaintain();
            form18.Show();
        }

        private void 管理员设置AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSet form19 = new AdminSet();
            form19.Show();
        }

        private void 时间段维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SysHint form20 = new SysHint();
            form20.Show();
        }

        private void 节日维护HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FestivalSet form23 = new FestivalSet();
            form23.Show();
        }

        private void 考勤规则RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheakRuleSet form24 = new CheakRuleSet();
            form24.Show();
        }

        private void 退出系统_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 断开设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于考勤管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSys absys = new AboutSys();
            absys.Show();
        }

        private void 检查新版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已是最新版本","提示");
        }

        private void 查看帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"系统帮助.txt");
        }


        private void 统计报表ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {         
                Checkcompute cc = new Checkcompute();
                cc.Show();
        
        }

        private void 人员维护_Click(object sender, EventArgs e)
        {
            StaffMaintain sm = new StaffMaintain();
            sm.Show();
        }

        private void 出勤记录_Click(object sender, EventArgs e)
        {
            Record re = new Record();
            re.Show();
        }

        private void 统计报表_Click(object sender, EventArgs e)
        {
            Checkcompute cc = new Checkcompute();
            cc.Show();
        }

        private void 设备维护_Click(object sender, EventArgs e)
        {
            EquipmentManage em = new EquipmentManage();
            em.Show();
        }

  
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.Nodes[0].Nodes[0].IsSelected == true)
            {
                ImportData id = new ImportData();
                id.Show();
            }
            if (treeView1.Nodes[0].Nodes[1].IsSelected == true)
            {
                ExportData ed = new ExportData();
                ed.Show(); 
            }
            if (treeView1.Nodes[0].Nodes[2].IsSelected == true)
            {
                MessageBox.Show("王伏，这里没有做", "注意");
            }
            if (treeView1.Nodes[1].Nodes[0].IsSelected == true)
            {
                MessageBox.Show("没有连接设备", "注意");
            }
            if (treeView1.Nodes[1].Nodes[1].IsSelected == true)
            {
                MessageBox.Show("没有连接设备", "注意");
            }
            if (treeView1.Nodes[1].Nodes[2].IsSelected == true)
            {
                MessageBox.Show("没有连接设备", "注意");
            }
            if (treeView1.Nodes[1].Nodes[3].IsSelected == true)
            {
                MessageBox.Show("没有连接设备", "注意");
            }
            if (treeView1.Nodes[2].Nodes[0].IsSelected == true)
            {
                AdminSet ads = new AdminSet();
                ads.Show();
            }
            if (treeView1.Nodes[2].Nodes[1].IsSelected == true)
            {
                StaffMaintain sm = new StaffMaintain();
                sm.Show();
            }
            if (treeView1.Nodes[2].Nodes[2].IsSelected == true)
            {
                MessageBox.Show("王伏，这里没有做", "注意");
            }
            if (treeView1.Nodes[2].Nodes[3].IsSelected == true)
            {
                DivisionalManagement form17 = new DivisionalManagement();
                form17.Show();
            }
            if (treeView1.Nodes[3].Nodes[0].IsSelected == true)
            {

                TimeSet ts = new TimeSet();
                ts.Show();
            }
            if (treeView1.Nodes[3].Nodes[1].IsSelected == true)
            {

                StaffSchedu ss = new StaffSchedu();
                ss.Show();

            }
            if (treeView1.Nodes[3].Nodes[2].IsSelected == true)
            {
                CheakRuleSet crs = new CheakRuleSet();
                crs.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }

        private void 人员排班ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 假类设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HolidaySet hs = new HolidaySet();
            hs.Show();
        }

            
  
    }
   
}
