﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float varInt = float.Parse(txtBox1.Text);
            varInt += float.Parse(txtBox2.Text);
            varInt += float.Parse(txtBox3.Text);


            MessageBox.Show(varInt.ToString());

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            float varInt = float.Parse(txtBox1.Text);
            varInt += float.Parse(txtBox2.Text);
            varInt += float.Parse(txtBox3.Text);

            varInt = varInt / 3;

            MessageBox.Show(varInt.ToString());
        }
    }
}
