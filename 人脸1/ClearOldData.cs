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

namespace 人脸1
{
    public partial class ClearOldData : Form
    {
        public ClearOldData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            String dir = @System.Environment.CurrentDirectory;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = dir;
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
              string  fName = openFileDialog.FileName;
              textBox1.Text = fName;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string time = System.DateTime.Now.ToString().Replace("/", "_").Substring(0, 8);
            textBox1.Text = "Checkinout" + time + ".txt";
            String dir = @System.Environment.CurrentDirectory;
            string filepath = "Checkinout" + time + ".txt";
            FileInfo myfile = new FileInfo(filepath);
            if(Directory.Exists(dir)){
                if (!myfile.Exists)
                {
                    FileStream myStream = File.Create("Checkinout" + time + ".txt");
                }
                else
                {
                    StreamWriter myWriter = new StreamWriter(filepath, true);
                }
            }

            textBox2.Text = "Checkinout" + time + ".aex";
            string filepath1 = "Checkinout" + time + ".aex";
            FileInfo myfile1 = new FileInfo(filepath);
            if (Directory.Exists(dir))
            {
                if (!myfile1.Exists)
                {
                    FileStream myStream = File.Create("Checkinout" + time + ".aex");
                }
                else
                {
                    StreamWriter myWriter = new StreamWriter(filepath1, true);
                }
            }
           
         
        }
    }
}
