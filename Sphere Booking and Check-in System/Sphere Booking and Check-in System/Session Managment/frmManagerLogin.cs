﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    public partial class frmManagerLogin : Form
    {
        public frmManagerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mainDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                if (txtUsername.Text == String.Empty)
                {
                    MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Focus();
                }

                else if (txtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }

                else
                {
                    try
                    {
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Manager WHERE username=@uname and password=@pass", Connection);
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            frmSessionManagementMain main = new frmSessionManagementMain();
                            main.Show();
                            this.Hide();
                            Connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect login, please try again");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Do you really want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (closeResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            frmRecoveryManager recovery = new frmRecoveryManager();
            this.Hide();
            recovery.Show();
        }
    }
}
