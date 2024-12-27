using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_POS
{
    public partial class Form8 : Form
    {
        string connectionString;
        public Form8(string connStr)
        {
            InitializeComponent();
            connectionString = connStr;
            LoadInvoiceNumber();
            btncusadd.Click += btncusadd_Click;

            txtcustomerid.TextChanged += txtcustomerid_TextChanged;


        }

        private void LoadInvoiceNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(SaleID), 0) + 1 FROM Sale";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    Invoice.Text = cmd.ExecuteScalar().ToString(); // Invoice No label
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading invoice number: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtitemcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndeleteline_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show a confirmation dialog
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected row?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Check the result of the dialog
                if (result == DialogResult.Yes)
                {
                    // Delete the selected row
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    // Recalculate the total
                    UpdateTotalAmount();
                }
            }
            else
            {
                // Optional: Show a message if no row is selected
                MessageBox.Show(
                    "Please select a row to delete.",
                    "No Row Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtqty.Text) && !string.IsNullOrEmpty(txtprice.Text))
            {
                try
                {
                    int quantity = int.Parse(txtqty.Text);
                    decimal price = decimal.Parse(txtprice.Text);
                    decimal total = quantity * price;
                    totallbl.Text = total.ToString("0.00"); // Update the total label for current item
                }
                catch
                {
                    totallbl.Text = "0.00";
                }
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            txtqty_TextChanged(sender, e); // Reuse the logic to update total dynamically
        }

        private void btnvoidbill_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to void the entire bill? This action cannot be undone.",
                "Confirm Void Bill",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Check the result of the dialog
            if (result == DialogResult.Yes)
            {
                // Clear the DataGridView
                dataGridView1.Rows.Clear();

                // Reset the total amount label
                lbltlamount.Text = "0.00";

                // Reset the quantity selector
                numericUpDownfullqty.Value = 0;
            }

            else
            {
                MessageBox.Show(
                    "The bill was not voided.",
                    "Action Canceled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void label3_Click(object sender, EventArgs e) //invoice
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateTotalQuantity()
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ensure the Quantity cell has a valid value
                if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity))
                {
                    totalQuantity += quantity;
                }
            }

            // Update numericUpDownfullqty with the calculated total quantity
            numericUpDownfullqty.Value = totalQuantity;
        }


        private void numericUpDownfullqty_ValueChanged(object sender, EventArgs e)
        {
            // Prevent changes in numericUpDown by directly reflecting the calculated quantity
            CalculateTotalQuantity();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmountWithDiscount();
        }

        private void UpdateTotalAmountWithDiscount()
        {
            decimal subtotal = 0;
            decimal discountPercentage = 0;
            decimal discountAmount = 0;
            decimal finalTotal = 0;

            // Calculate subtotal from grid
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            // Parse discount percentage
            if (!string.IsNullOrEmpty(txtdiscount.Text) && decimal.TryParse(txtdiscount.Text, out discountPercentage))
            {
                // Calculate discount amount
                discountAmount = (subtotal * discountPercentage) / 100;
                finalTotal = subtotal - discountAmount;
            }
            else
            {
                finalTotal = subtotal;
            }

            // Update the labels
          
            lbltlamount.Text = finalTotal.ToString("0.00");

            // Update total quantity
            CalculateTotalQuantity();

            // Calculate balance if paid amount exists
            if (!string.IsNullOrEmpty(txtpaid.Text) && decimal.TryParse(txtpaid.Text, out decimal paidAmount))
            {
                decimal balance = paidAmount - finalTotal;
                lbltotalbalance.Text = balance.ToString("0.00");
            }
        }



        private void lbltlamount_Click(object sender, EventArgs e)
        {

        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {

            UpdateTotalAmountWithDiscount();
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            // Ensure the total amount and paid amount are valid before calculating the balance
            if (decimal.TryParse(lbltlamount.Text, out decimal totalAmount) &&
                decimal.TryParse(txtpaid.Text, out decimal paidAmount))
            {
                // Calculate balance
                decimal balance = paidAmount - totalAmount;

                // Update the balance label
                lbltotalbalance.Text = balance.ToString("0.00");
            }
            else
            {
                // Handle invalid input or reset balance if needed
                lbltotalbalance.Text = "0.00";
            }
        }


        private void lbltotalbalance_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            SaveInvoice();

            if (MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
            {
                // Reset form
                dataGridView1.Rows.Clear();
                txtcustomerid.Clear();
                txtFirstName.Clear();
                txtcontact.Clear();
                txtdiscount.Clear();
                txtpaid.Clear();
                txtitemcode.Clear();
                txtitemname.Clear();
                txtqty.Clear();
                txtprice.Clear();
                lbltlamount.Text = "0.00";
                lbltotalbalance.Text = "0.00";
                totallbl.Text = "0.00";
                numericUpDownfullqty.Value = 0;

                // Load new invoice number
                LoadInvoiceNumber();
            }
        }



        private void button2_Click(object sender, EventArgs e) //update button
        {
            
        }

        private void tnadditem_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtitemcode.Text) || string.IsNullOrEmpty(txtitemname.Text) || string.IsNullOrEmpty(txtqty.Text) || string.IsNullOrEmpty(txtprice.Text))
                {
                    MessageBox.Show("Please fill in all item details");
                    return;
                }

                try
                {
                    decimal price = decimal.Parse(txtprice.Text);
                    int quantity = int.Parse(txtqty.Text);
                    decimal total = price * quantity;

                    // Add new row to DataGridView
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["ItemCode"].Value = txtitemcode.Text;
                    dataGridView1.Rows[rowIndex].Cells["ItemName"].Value = txtitemname.Text;
                    dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                    dataGridView1.Rows[rowIndex].Cells["Price"].Value = price;
                    dataGridView1.Rows[rowIndex].Cells["Total"].Value = total;

                    UpdateTotalAmount();  // This will update both totals
                    ClearItemInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding item: " + ex.Message);
                }

            }

        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            totallbl.Text = total.ToString("0.00");
            totallblinvoice.Text = total.ToString("0.00");

            // Update total quantity
            CalculateTotalQuantity();
        }

        private void ClearItemInputs()
        {
            txtitemcode.Clear();
            txtitemname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtitemcode.Focus();
        }


        private void SaveInvoice()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Step 1: Save Customer (if not already saved)
                    int customerID = SaveCustomer(conn, transaction);

                    // Step 2: Save Discount (if applicable)
                    decimal discount = 0;
                    int discountID = 0;  // To store the ID of the inserted discount
                    if (!string.IsNullOrEmpty(txtdiscount.Text) && decimal.TryParse(txtdiscount.Text, out discount))
                    {
                        discountID = SaveDiscount(conn, transaction, discount);
                    }

                    // Step 3: Save Sale
                    int saleID = SaveSale(conn, transaction, customerID, discountID);

                    // Step 4: Save Sales Details with DiscountID and Update Stock
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["ItemCode"].Value != null)
                        {
                            int stockID = Convert.ToInt32(row.Cells["ItemCode"].Value);
                            int quantitySold = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                            // Save Sales Details
                            SaveSalesDetails(conn, transaction, saleID, stockID, quantitySold, discountID);

                            // Update Stock quantity
                            UpdateStock(conn, transaction, stockID, quantitySold);
                        }
                    }

                    // Commit transaction if everything is successful
                    transaction.Commit();
                    MessageBox.Show("Invoice saved successfully.");
                }
                catch (Exception ex)
                {
                    // Rollback transaction in case of an error
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("Error saving invoice: " + ex.Message);
                }
            }
        }

        // Helper method to save customer and return CustomerID
        // Helper method to save or retrieve customer and return CustomerID
        private int SaveCustomer(SqlConnection conn, SqlTransaction transaction)
        {
            if (string.IsNullOrEmpty(txtcustomerid.Text))
            {
                MessageBox.Show("Customer ID cannot be empty.");
                throw new InvalidOperationException("Customer ID is required.");
            }

            int customerID = 0;

            // Retrieve the CustomerID from the database
            string checkCustomerQuery = "SELECT CustomerID FROM Customer WHERE CustomerID = @CustomerID";
            SqlCommand checkCmd = new SqlCommand(checkCustomerQuery, conn, transaction);
            checkCmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);

            object result = checkCmd.ExecuteScalar();
            if (result != null)
            {
                customerID = Convert.ToInt32(result);
            }
            else
            {
                MessageBox.Show("Customer does not exist in the database.");
                throw new InvalidOperationException("Customer not found.");
            }

            return customerID;
        }




        // Helper method to save discount and return DiscountID
        private int SaveDiscount(SqlConnection conn, SqlTransaction transaction, decimal discount)
        {
            int discountID = 0;
            string discountQuery = "INSERT INTO Discount (Discount_Value, Start_Date, End_Date) " +
                                   "VALUES (@DiscountValue, @StartDate, @EndDate); SELECT SCOPE_IDENTITY();";
            SqlCommand discountCmd = new SqlCommand(discountQuery, conn, transaction);
            discountCmd.Parameters.AddWithValue("@DiscountValue", discount);
            discountCmd.Parameters.AddWithValue("@StartDate", DateTime.Now);  // Adjust as needed
            discountCmd.Parameters.AddWithValue("@EndDate", DateTime.Now.AddDays(30)); // Adjust as needed

            discountID = Convert.ToInt32(discountCmd.ExecuteScalar());
            return discountID;
        }

        // Helper method to save sale and return SaleID
        private int SaveSale(SqlConnection conn, SqlTransaction transaction, int customerID, int discountID)
        {
            int saleID = 0;
            string saleQuery = "INSERT INTO Sale (CustomerID, Sale_Date, Total_Amount, UserID) " +
                               "VALUES (@CustomerID, @SaleDate, @TotalAmount, @UserID); SELECT SCOPE_IDENTITY();";
            SqlCommand saleCmd = new SqlCommand(saleQuery, conn, transaction);
            saleCmd.Parameters.AddWithValue("@CustomerID", customerID);
            saleCmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);
            saleCmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(lbltlamount.Text, System.Globalization.NumberStyles.Currency));
            saleCmd.Parameters.AddWithValue("@UserID", 1); // Replace with actual UserID

            saleID = Convert.ToInt32(saleCmd.ExecuteScalar());
            return saleID;
        }

        // Helper method to save sales details
        private void SaveSalesDetails(SqlConnection conn, SqlTransaction transaction, int saleID, int stockID, int quantitySold, int discountID)
        {
            string detailsQuery = "INSERT INTO Sales_Details (SaleID, StockID, Quantity_Sold, DiscountID) " +
                                  "VALUES (@SaleID, @StockID, @QuantitySold, @DiscountID)";
            SqlCommand detailsCmd = new SqlCommand(detailsQuery, conn, transaction);
            detailsCmd.Parameters.AddWithValue("@SaleID", saleID);
            detailsCmd.Parameters.AddWithValue("@StockID", stockID);
            detailsCmd.Parameters.AddWithValue("@QuantitySold", quantitySold);
            detailsCmd.Parameters.AddWithValue("@DiscountID", discountID);  // Link discount to item

            detailsCmd.ExecuteNonQuery();
        }

        // Helper method to update stock quantities
        private void UpdateStock(SqlConnection conn, SqlTransaction transaction, int stockID, int quantitySold)
        {
            // First check available quantity
            string checkQuantityQuery = "SELECT Available_Quantity FROM Stock WHERE StockID = @StockID";
            SqlCommand checkCmd = new SqlCommand(checkQuantityQuery, conn, transaction);
            checkCmd.Parameters.AddWithValue("@StockID", stockID);

            int availableQuantity = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (availableQuantity < quantitySold)
            {
                throw new InvalidOperationException($"Insufficient stock available. Only {availableQuantity} units available.");
            }

            // Update stock quantity
            string updateStockQuery = "UPDATE Stock SET Available_Quantity = Available_Quantity - @Quantity WHERE StockID = @StockID";
            SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn, transaction);
            updateStockCmd.Parameters.AddWithValue("@Quantity", quantitySold);
            updateStockCmd.Parameters.AddWithValue("@StockID", stockID);

            updateStockCmd.ExecuteNonQuery();
        }




        private void totallbl_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcustomerid.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Query to fetch FirstName from Customer table and PhoneNumber from Customer_Phone table
                        string query = @"
                         SELECT c.First_Name AS FirstName, cp.Phone_Number AS PhoneNumber
                         FROM Customer c
                         INNER JOIN Customer_Phone cp ON c.CustomerID = cp.CustomerID
                         WHERE c.CustomerID = @CustomerID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the FirstName and PhoneNumber fields
                                txtFirstName.Text = reader["FirstName"].ToString();
                                txtcontact.Text = reader["PhoneNumber"].ToString();
                            }
                            else
                            {
                                // Clear fields if no customer is found
                                txtFirstName.Clear();
                                txtcontact.Clear();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching customer details: " + ex.Message);
                    }
                }
            }
            else
            {
                // Clear fields if Customer ID is empty
                txtFirstName.Clear();
                txtcontact.Clear();
            }

        }

        private void btncusadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcustomerid.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = @"
                    SELECT c.First_Name AS FirstName, cp.Phone_Number AS PhoneNumber
                    FROM Customer c
                    LEFT JOIN Customer_Phone cp ON c.CustomerID = cp.CustomerID
                    WHERE c.CustomerID = @CustomerID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@CustomerID", txtcustomerid.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.Text = reader["FirstName"].ToString();
                                txtcontact.Text = reader["PhoneNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Customer not found!");
                                txtFirstName.Clear();
                                txtcontact.Clear();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID");
            }
        }
    }
}
