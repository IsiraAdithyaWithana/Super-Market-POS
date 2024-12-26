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
            numericUpDown1.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown2.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown3.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown4.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown8.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown7.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown6.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown5.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown12.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown11.ValueChanged += numericUpDown_ValueChanged;
            numericUpDown10.ValueChanged += numericUpDown_ValueChanged;

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
        }
    }
}
