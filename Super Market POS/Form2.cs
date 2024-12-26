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
using System.Data.SqlClient;

namespace Super_Market_POS
{
    public partial class Form2 : Form
    {
        string connectionString;
        int userId;
        public Form2(string connStr, int user)
        {
            InitializeComponent();
            connectionString = connStr;
            userId = user;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false; // Prevent automatic column generation
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill the DataGridView width

            // Add columns manually
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID",
                HeaderText = "ID",
                DataPropertyName = "colID", // Must match the alias in the SQL query
                Width = 50, // Initial width; will stretch proportionally
                FillWeight = 10 // Weight for proportional width
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                DataPropertyName = "colName",
                Width = 150,
                FillWeight = 40 // Adjusted for proportional width
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMRP",
                HeaderText = "MRP",
                DataPropertyName = "colMRP",
                Width = 100,
                FillWeight = 30 // Adjusted for proportional width
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAvailableQuantity",
                HeaderText = "Available Quantity",
                DataPropertyName = "colAvailableQuantity",
                Width = 150,
                FillWeight = 20 // Adjusted for proportional width
            });

            // Optional: Center column headers
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false; // Disable default styles to apply custom styles


            // Optional: Center align cell content
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void LoadStockData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StockID AS colID, Price AS colMRP, Product_Name AS colName, Available_Quantity AS colAvailableQuantity FROM Stock";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the currently selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the TextBoxes with the data from the selected row
                txtName.Text = selectedRow.Cells["colName"].Value?.ToString() ?? string.Empty;
                txtMRP.Text = selectedRow.Cells["colMRP"].Value?.ToString() ?? string.Empty;
                txtAvailableQuantity.Text = selectedRow.Cells["colAvailableQuantity"].Value?.ToString() ?? string.Empty;
            }
        }



        

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMRP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAvailableQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtName.Text.Trim();
            decimal price;
            int quantity;

            // Validate inputs
            if (string.IsNullOrEmpty(productName) ||
                !decimal.TryParse(txtMRP.Text.Trim(), out price) ||
                !int.TryParse(txtAvailableQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("Please enter valid inputs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Stock (Product_Name, Price, Available_Quantity) VALUES (@ProductName, @Price, @Quantity)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally clear textboxes after successful insert
                            txtName.Clear();
                            txtMRP.Clear();
                            txtAvailableQuantity.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadStockData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["colID"].Value);

                // Get the updated values from the textboxes
                string updatedName = txtName.Text.Trim();
                decimal updatedPrice;
                int updatedQuantity;

                // Validate input
                if (!decimal.TryParse(txtMRP.Text.Trim(), out updatedPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAvailableQuantity.Text.Trim(), out updatedQuantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // SQL query to update the row
                    string query = @"
                UPDATE Stock
                SET Product_Name = @Name, 
                    Price = @Price, 
                    Available_Quantity = @Quantity
                WHERE StockID = @ID";

                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Set parameters
                            cmd.Parameters.AddWithValue("@ID", selectedID);
                            cmd.Parameters.AddWithValue("@Name", updatedName);
                            cmd.Parameters.AddWithValue("@Price", updatedPrice);
                            cmd.Parameters.AddWithValue("@Quantity", updatedQuantity);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView
                                LoadStockData();
                            }
                            else
                            {
                                MessageBox.Show("No record was updated. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["colID"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Stock WHERE StockID = @ID";

                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                // Set the parameter
                                cmd.Parameters.AddWithValue("@ID", selectedID);

                                // Execute the query
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh the DataGridView
                                    LoadStockData();

                                    // Clear textboxes
                                    txtName.Clear();
                                    txtMRP.Clear();
                                    txtAvailableQuantity.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("No record was deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMRP.Clear();
            txtAvailableQuantity.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStockData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStock();
        }

        private void SearchStock()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Get the search term from the textbox
                string searchValue = txtSearch.Text.Trim();

                // Define the SQL query with search conditions for ID or Name
                string query = @"
            SELECT 
                StockID AS colID, 
                Price AS colMRP, 
                Product_Name AS colName, 
                Available_Quantity AS colAvailableQuantity 
            FROM Stock
            WHERE 
                StockID LIKE @Search OR 
                Product_Name LIKE @Search";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Search", "%" + searchValue + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the filtered data to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            // Refresh the DataGridView by reloading the stock data
            LoadStockData();

            // Clear the textboxes to start fresh
            txtName.Clear();
            txtMRP.Clear();
            txtAvailableQuantity.Clear();
        }
    }
}
