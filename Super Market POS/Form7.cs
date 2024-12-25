using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_POS
{
    public partial class Form7 : Form
    {

        string connectionString;
        int userId;
        public Form7()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form12 form12 = new Form12(connectionString,userId);
            this.Hide();
            form12.Show();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Get the value from numericUpDown2
            decimal value = numericUpDown2.Value;

            // Multiply the value by 2
            decimal result = value * 2;

            // Display the result in label18
            label18.Text = result.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            decimal value = numericUpDown1.Value;
           
            decimal result = value * 1;

            label17.Text = result.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown3.Value;

            decimal result = value * 5;

            label19.Text = result.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown4.Value;

            decimal result = value * 10;

            label20.Text = result.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown8.Value;

            decimal result = value * 10;

            label21.Text = result.ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown7.Value;

            decimal result = value * 20;

            label22.Text = result.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown6.Value;

            decimal result = value * 50;

            label23.Text = result.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown5.Value;

            decimal result = value * 100;

            label24.Text = result.ToString();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown12.Value;

            decimal result = value * 500;

            label25.Text = result.ToString();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown11.Value;

            decimal result = value * 1000;

            label26.Text = result.ToString();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown10.Value;

            decimal result = value * 5000;

            label27.Text = result.ToString();
        }
    }
}
