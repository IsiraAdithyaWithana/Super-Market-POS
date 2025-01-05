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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Super_Market_POS
{
    public partial class Form5 : Form
    {
        string connectionString;
        int userId;

        public Form5(string connStr, int user)
        {
            InitializeComponent();
            connectionString = connStr;
            userId = user;
            InitializeDataGridView();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load data into DataGridView
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select CustomerID, First_Name, Last_Name, Address, Email, RegisterDate, Phone_Number FROM ViewCustomerDetails";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtFname.Text = selectedRow.Cells["First_Name"].Value?.ToString() ?? string.Empty;
                txtLname.Text = selectedRow.Cells["Last_Name"].Value?.ToString() ?? string.Empty;
                txtContact.Text = selectedRow.Cells["Phone_Number"].Value?.ToString() ?? string.Empty;
                txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string phoneNumber = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime registerDate = DateTime.Now;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("First Name and Last Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone Number must be 10 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string ProcedureInsertCustomerDetails = "InsertCustomerDetails";

                using (SqlCommand cmd = new SqlCommand(ProcedureInsertCustomerDetails, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Add parameters with explicit types
                    cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = firstName;
                    cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = lastName;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 150).Value = address;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                    cmd.Parameters.Add("@RegisterDate", SqlDbType.DateTime).Value = registerDate;
                    cmd.Parameters.Add("@Phone_Number", SqlDbType.VarChar, 10).Value = phoneNumber;

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            txtFname.Clear();
                            txtLname.Clear();
                            txtContact.Clear();
                            txtAddress.Clear();
                            txtEmail.Clear();

                            // Refresh data (assuming LoadData() updates the customer data grid)
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                    }
                }
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            if (ValidateInputs())
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string ProcedureUpdateCustomerDetails = "UpdateCustomerDetails";
                        SqlCommand command = new SqlCommand(
                            ProcedureUpdateCustomerDetails,
                            connection
                        );

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@First_Name", txtFname.Text);
                        command.Parameters.AddWithValue("@Last_Name", txtLname.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Phone_Number", txtContact.Text);
                     


                        command.ExecuteNonQuery();
                        MessageBox.Show("Customer updated successfully.");

                        LoadData();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating customer: " + ex.Message);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CustomerID"].Value);

                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string ProcedureRemoveCustomerDetails = "RemoveCustomerDetails";

                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(ProcedureRemoveCustomerDetails, conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@CustomerID", selectedID);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                    ClearFields();
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
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearFields()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

        }

        private bool ValidateInputs()
        {
            // Check if any text field is null or whitespace
            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Show an error message
                MessageBox.Show("All fields are required.");
                return false;
            }

            return NewMethod();

            bool NewMethod()
            {
                return true; // Validation succeeded
            }
        }


        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerID",
                HeaderText = "Customer ID",
                DataPropertyName = "CustomerID",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "First_Name",
                HeaderText = "First Name",
                DataPropertyName = "First_Name",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Last_Name",
                HeaderText = "Last Name",
                DataPropertyName = "Last_Name",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Address",
                DataPropertyName = "Address",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RegisterDate",
                HeaderText = "RegisterDate",
                DataPropertyName = "RegisterDate",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone_Number",
                HeaderText = "Phone Number",
                DataPropertyName = "Phone_Number",
            });

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer();

        }

        private void SearchCustomer()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Get the search term from the textbox
                string searchValue = txtSearch.Text.Trim();

                // Define the SQL query with search conditions for ID or Name
                string query = @"
                select CustomerID, First_Name, Last_Name, Address, Email, RegisterDate, Phone_Number FROM ViewCustomerDetails
            
            WHERE 
                CustomerID LIKE @Search OR 
                First_Name LIKE @Search OR
                Last_Name  LIKE @Search OR
                Phone_Number LIKE @Search";

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12(connectionString, userId);
            this.Hide();
            form12.Show();
        }
    }
}



