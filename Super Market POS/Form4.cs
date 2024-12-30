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
    public partial class Form4 : Form
    {
        string connectionString;
        int userId;
        public Form4(string connStr,int user)
        {
            InitializeComponent();
            connectionString = connStr;
            userId = user;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(connectionString, userId);
            this.Hide();
            form12.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
