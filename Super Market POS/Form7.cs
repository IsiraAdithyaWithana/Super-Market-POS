using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            Form12 form12 = new Form12(connectionString,userId);
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
            label28.Text = total.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the total cash from label28
                decimal shiftCloseAmount = decimal.Parse(label28.Text);

                // Fetch the Shift Open Amount from the database
                decimal shiftOpenAmount = GetShiftOpenAmount();

                // Handle cases where fetching the open amount fails
                if (shiftOpenAmount == -1)
                {
                    return; // Stop further execution
                }

                // Compare Shift Close Amount with Shift Open Amount
                if (shiftCloseAmount != shiftOpenAmount)
                {
                    MessageBox.Show(
                        "Shift Close Amount does not match the Shift Open Amount. Please verify the values.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return; // Stop further execution
                }
                // If amounts match, update the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = @"
                UPDATE CashDrawer
                SET EndTime = GETDATE(), EndAmount = @EndAmount, IsMatched = 1
                WHERE UserID = @UserID AND EndTime IS NULL";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EndAmount", shiftCloseAmount);
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Shift closed successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "No active shift found to close.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                              
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while closing the shift: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private decimal GetShiftOpenAmount()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Get the Total Cash (Shift Close Amount) from label28
                decimal shiftCloseAmount = decimal.Parse(label28.Text);

                // Step 2: Fetch the Shift Open Amount from the database
                decimal shiftOpenAmount = GetShiftOpenAmount();

                // If the open amount couldn't be retrieved, stop further execution
                if (shiftOpenAmount == -1)
                {
                    return;
                }

                // Step 3: Compare Shift Close Amount with Shift Open Amount
                if (shiftCloseAmount != shiftOpenAmount)
                {
                    MessageBox.Show(
                        "Shift Close Amount does not match the Shift Open Amount. Please verify and try again.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Step 4: Update the database to close the shift
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = @"
                UPDATE CashDrawer
                SET EndTime = GETDATE(), EndAmount = @EndAmount, IsMatched = 1
                WHERE UserID = @UserID AND EndTime IS NULL";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EndAmount", shiftCloseAmount);
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Success: Shift closed successfully
                            MessageBox.Show(
                                "Shift closed successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            ResetFields(); // Clear inputs and reset the form
                        }
                        else
                        {
                            // No active shift found to close
                            MessageBox.Show(
                                "No active shift found for this user. Please start a shift first.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show(
                    $"An error occurred while closing the shift: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void ResetFields()
        {
            throw new NotImplementedException();
        }
    }
}
