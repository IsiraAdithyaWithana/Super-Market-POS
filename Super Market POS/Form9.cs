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
    public partial class Form9 : Form
    {
        string connectionString;
        int userId;
        

     
        public Form9(string connStr)
        {
            InitializeComponent();
  
           


        }

        public Form9()
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(connectionString,userId);
            this.Hide();
            form12.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void label28_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal total = (numericUpDown1.Value * 1) +
                    (numericUpDown2.Value * 2) +
                    (numericUpDown3.Value * 5) +
                    (numericUpDown4.Value * 10) +
                    (numericUpDown8.Value * 10) +
                    (numericUpDown7.Value * 20) +
                    (numericUpDown6.Value * 50) +
                    (numericUpDown5.Value * 100) +
                    (numericUpDown12.Value * 500) +
                    (numericUpDown11.Value * 1000) +
                    (numericUpDown10.Value * 5000);

            label28.Text = "Rs. " + total.ToString("N2");

            // 
            NumericUpDown numericUpDown = sender as NumericUpDown;

            // Check which NumericUpDown triggered the event and update the corresponding Label
            if (numericUpDown == numericUpDown1)
            {
                label17.Text = (numericUpDown1.Value * 1).ToString();
            }
            else if (numericUpDown == numericUpDown2)
            {
                label18.Text = (numericUpDown2.Value * 2).ToString();
            }
            else if (numericUpDown == numericUpDown3)
            {
                label19.Text = (numericUpDown3.Value * 5).ToString();
            }
            else if (numericUpDown == numericUpDown4)
            {
                label20.Text = (numericUpDown4.Value * 10).ToString();
            }
            else if (numericUpDown == numericUpDown8)
            {
                label21.Text = (numericUpDown8.Value * 10).ToString();
            }
            else if (numericUpDown == numericUpDown7)
            {
                label22.Text = (numericUpDown.Value * 20).ToString();
            }
            else if (numericUpDown == numericUpDown6)
            {
                label23.Text = (numericUpDown6.Value * 50).ToString();
            }
            else if (numericUpDown == numericUpDown5)
            {
                label24.Text = (numericUpDown5.Value * 100).ToString();
            }
            else if (numericUpDown == numericUpDown12)
            {
                label25.Text = (numericUpDown12.Value * 500).ToString();
            }
            else if (numericUpDown == numericUpDown11)
            {
                label26.Text = (numericUpDown11.Value * 1000).ToString();
            }
            else if (numericUpDown == numericUpDown10)
            {
                label27.Text = (numericUpDown10.Value * 5000).ToString();
            }
        }
    }
}
