using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public Form7(string connStr, int useridentifier)
        {
            InitializeComponent();
            connectionString = connStr;
            userId = useridentifier;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label30_Click(object sender, EventArgs e)
        {

        }
        private void label29_Click(object sender, EventArgs e)
        {

        }
        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form12 form12 = new Form12(connectionString, userId);
            this.Hide();
            form12.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum; // Reset to the minimum value
                }
            }

        }

        private void UpdateTotal()
        {
            // Initialize the total
            decimal total = 0;

            // Add values of all labels you want to include
            total += GetLabelValue(label17);
            total += GetLabelValue(label18); // Add the value of label18
            total += GetLabelValue(label19);
            total += GetLabelValue(label20);
            total += GetLabelValue(label21);
            total += GetLabelValue(label22);
            total += GetLabelValue(label23);
            total += GetLabelValue(label24);
            total += GetLabelValue(label25);
            total += GetLabelValue(label26);
            total += GetLabelValue(label27);



            // Display the total in label28
            label28.Text = "Rs. " + total.ToString("F2");

        }

        private decimal GetLabelValue(Label label)
        {
            // Try to parse the label text into a decimal
            if (decimal.TryParse(label.Text, out decimal value))
            {
                return value;
            }
            return 0; // Default to 0 if the label text is not a valid number
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Get the value from numericUpDown2
            decimal value = numericUpDown2.Value;

            // Multiply the value by 2
            decimal result = value * 2;

            // Display the result in label18
            label18.Text = result.ToString();
            UpdateTotal();
        }


        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown1.Value;

            decimal result = value * 1;

            label17.Text = result.ToString();
            UpdateTotal();
        }


        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown3.Value;

            decimal result = value * 5;

            label19.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

            decimal value = numericUpDown4.Value;

            decimal result = value * 10;

            label20.Text = result.ToString();
            UpdateTotal();
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
            UpdateTotal();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown7.Value;

            decimal result = value * 20;

            label22.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown6.Value;

            decimal result = value * 50;

            label23.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown5.Value;

            decimal result = value * 100;

            label24.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown12.Value;

            decimal result = value * 500;

            label25.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown11.Value;

            decimal result = value * 1000;

            label26.Text = result.ToString();
            UpdateTotal();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown10.Value;

            decimal result = value * 5000;

            label27.Text = result.ToString();
            UpdateTotal();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                decimal endAmount = decimal.Parse(label28.Text.Replace("Rs. ", "")); // Get the end amount for the shift

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch the last shift's StartAmount
                    string selectQuery = "SELECT TOP 1 StartAmount FROM CashDrawer WHERE EndTime IS NULL ORDER BY StartTime DESC";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        object result = selectCmd.ExecuteScalar();
                        decimal? lastStartAmount = result != DBNull.Value ? (decimal?)result : null;

                        // If the amounts do not match, show an error message
                        if (lastStartAmount != endAmount)
                        {
                            MessageBox.Show("Mismatch detected: End amount does not match the start amount of the next shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // If amounts match, update the database with EndTime and EndAmount
                        string updateQuery = "UPDATE CashDrawer SET EndAmount = @EndAmount, EndTime = GETDATE() WHERE EndTime IS NULL";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@EndAmount", endAmount);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Shift closed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





      

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal dayEndAmount = decimal.Parse(label28.Text.Replace("Rs. ", "")); // Get the total amount for the day

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Debug: Log the connection state
                    Console.WriteLine("Connection Open: " + conn.State);


                    // Update the last record to close the day
                    string updateQuery = "UPDATE CashDrawer SET EndAmount = @EndAmount, EndTime = GETDATE() WHERE EndTime IS NULL";
                    // Debug: Log the query being executed
                    Console.WriteLine("Query: " + updateQuery);
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EndAmount", dayEndAmount);
                        // Debug: Log parameter values
                        Console.WriteLine("Parameter EndAmount: " + dayEndAmount);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Debug: Log the rows affected
                        Console.WriteLine("Rows Affected: " + rowsAffected);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Day closed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Please check if there is an open day to close.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


