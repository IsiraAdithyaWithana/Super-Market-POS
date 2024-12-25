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
    }
}
