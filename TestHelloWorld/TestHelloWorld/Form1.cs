﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Item - " + (comboBox1.Items.Count + 1).ToString());

        }
    }
}
