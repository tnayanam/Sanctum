﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerSessionClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient();
           MessageBox.Show( client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
           MessageBox.Show(client.IncrementNumber().ToString());
        }
    }
}
