﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Check_in
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new Check_in.CheckIn();
            this.Close();
            checkin.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}