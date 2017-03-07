﻿using System;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_UI.frmMainLogin login = new Main_UI.frmMainLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking.BookingForm booking = new Booking.BookingForm();
            booking.MdiParent = this;
            booking.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_in.CheckIn check = new Check_in.CheckIn();
            check.MdiParent = this;
            check.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Session_Managment.frmManagerLogin login = new Session_Managment.frmManagerLogin();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff_Scheduling.frmStaff staff = new Staff_Scheduling.frmStaff();
            staff.MdiParent = this;
            staff.Show();
        }
    }
}
