﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = user_field.Text;
            string password = password_field.Text;
            if (username == "Malook" && password == "123")
            {
                login_error.Visible = false;
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                login_error.Visible=true;
                password_field.Clear();
            }
        }
    }
}
