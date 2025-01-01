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
            form12.Show();
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

                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    conn1.Open();

                    // Fetch the last shift's StartAmount and StartTime
                    string selectQuery = "SELECT TOP 1 StartAmount, StartTime FROM CashDrawer WHERE EndTime IS NULL ORDER BY StartTime DESC";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn1))
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal startAmount = reader.GetDecimal(0);
                            DateTime startTime = reader.GetDateTime(1);

                            // Use a new connection for the sales query
                            using (SqlConnection conn2 = new SqlConnection(connectionString))
                            {
                                conn2.Open();

                                // Calculate total sales during the shift
                                string salesQuery = @"
                            SELECT SUM(Total_Amount) 
                            FROM Sale 
                            WHERE Sale_Date >= @StartTime AND Sale_Date <= GETDATE()";
                                using (SqlCommand salesCmd = new SqlCommand(salesQuery, conn2))
                                {
                                    salesCmd.Parameters.AddWithValue("@StartTime", startTime);
                                    object salesResult = salesCmd.ExecuteScalar();
                                    decimal totalSales = salesResult != DBNull.Value ? Convert.ToDecimal(salesResult) : 0;

                                    // Calculate the expected EndAmount
                                    decimal expectedEndAmount = startAmount + totalSales;

                                    // If the amounts do not match, show an error message
                                    if (endAmount != expectedEndAmount)
                                    {
                                        MessageBox.Show($"Mismatch detected: Expected End Amount is {expectedEndAmount:C}, but received {endAmount:C}.",
                                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    // Update the CashDrawer table
                                    string updateQuery = "UPDATE CashDrawer SET EndAmount = @EndAmount, EndTime = GETDATE(), IsMatched = 1 WHERE EndTime IS NULL";
                                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn2))
                                    {
                                        updateCmd.Parameters.AddWithValue("@EndAmount", endAmount);
                                        updateCmd.ExecuteNonQuery();

                                        MessageBox.Show("Shift closed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No active shift found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                decimal endAmount = decimal.Parse(label28.Text.Replace("Rs. ", "")); // Get the end amount for the shift

                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    conn1.Open();

                    // Fetch the last shift's StartAmount and StartTime
                    string selectQuery = "SELECT TOP 1 StartAmount, StartTime FROM CashDrawer WHERE EndTime IS NULL ORDER BY StartTime DESC";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn1))
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal startAmount = reader.GetDecimal(0);
                            DateTime startTime = reader.GetDateTime(1);

                            // Use a new connection for the sales query
                            using (SqlConnection conn2 = new SqlConnection(connectionString))
                            {
                                conn2.Open();

                                // Calculate total sales during the shift
                                string salesQuery = @"
                            SELECT SUM(Total_Amount) 
                            FROM Sale 
                            WHERE Sale_Date >= @StartTime AND Sale_Date <= GETDATE()";
                                using (SqlCommand salesCmd = new SqlCommand(salesQuery, conn2))
                                {
                                    salesCmd.Parameters.AddWithValue("@StartTime", startTime);
                                    object salesResult = salesCmd.ExecuteScalar();
                                    decimal totalSales = salesResult != DBNull.Value ? Convert.ToDecimal(salesResult) : 0;

                                    // Calculate the expected EndAmount
                                    decimal expectedEndAmount = startAmount + totalSales;

                                    // If the amounts do not match, show an error message
                                    if (endAmount != expectedEndAmount)
                                    {
                                        MessageBox.Show($"Mismatch detected: Expected End Amount is {expectedEndAmount:C}, but received {endAmount:C}.",
                                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    // Update the CashDrawer table
                                    string updateQuery = "UPDATE CashDrawer SET EndAmount = @EndAmount, EndTime = GETDATE(), IsMatched = 1 WHERE EndTime IS NULL";
                                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn2))
                                    {
                                        updateCmd.Parameters.AddWithValue("@EndAmount", endAmount);
                                        updateCmd.ExecuteNonQuery();

                                        MessageBox.Show("Shift closed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No active shift found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


