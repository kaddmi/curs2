﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Authorization aut = new Authorization();
            this.Hide();
            this.Opacity = 0;
            this.Enabled = false;
            timer1.Enabled = false;
            aut.Show();

        }
    }
}
