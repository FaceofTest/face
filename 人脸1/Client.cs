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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  String time = DateTime.Now.ToShortDateString();
            string commandText = "insert into CHECKDATA (STAFFID,NAME,ARRIVETIME,LEAVETIME,CHECKSUCCESS) values ('99999','王伏','2016-04-09 11:00','2016-04-09 12:00','1')";
            SqlCommand cmd = new SqlCommand(commandText);//执行sql语句
            var db = new DBHelper("MyCN");
            int i = db.ExecuteNonQuery(cmd);
            if (i != 0)
            {
                MessageBox.Show("考勤成功", "提示");
            }
            else
            {
                MessageBox.Show("考勤失败", "提示");
            }

            

        }
    }
}
