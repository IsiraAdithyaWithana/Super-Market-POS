﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Super_Market_POS
{
    public partial class Form12 : Form
    {
        string connectionString;
        int userId;
        public Form12(string connStr,int user)
        {
            InitializeComponent();
            connectionString = connStr;
            this.userId = user;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(connectionString);
            this.Hide();
            form1.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {   
            Form9 form9 = new Form9(connectionString,userId);
            this.Hide();
            form9.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(connectionString,userId);
            this.Hide();
            form7.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(connectionString,userId);
            this.Hide();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(connectionString,userId);
            this.Hide();
            form8.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(connectionString,userId);
            this.Hide(); 
            form5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(connectionString, userId);
            this.Hide();
            form4.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            Form13 form13 = new Form13(connectionString, userId);
            form13.Show();
            this.Hide();
        }
    }
}
