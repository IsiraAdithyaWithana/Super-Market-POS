using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Super_Market_POS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            comboType.Items.Add("Units");
            comboType.Items.Add("Gram");
            comboType.Items.Add("Pieces");
            comboType.Items.Add("Box");
            comboType.Items.Add("Case");
            comboType.Items.Add("Kg");
            comboType.Items.Add("Litre");
            comboType.Items.Add("m");

            comboType.Items.Insert(0, "Select an option...");

            comboType.SelectedIndex = 0;
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
