﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人脸1
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alterlog al = new Alterlog();
            al.Show();
        }
    }
}
