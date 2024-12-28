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

        public Form5(string connStr)
        {
            InitializeComponent();
            connectionString = connStr;
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
                string query = "SELECT CustomerID, First_Name, Last_Name, Phone_Number, Address, Email, RegisterDate, CreditAmount FROM Customer";

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
                txtdate.Text = selectedRow.Cells["RegisterDate"].Value?.ToString() ?? string.Empty;
                txtCamount.Text = selectedRow.Cells["CreditAmount"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Call the stored procedure to get a new CustomerID
                        SqlCommand getIdCommand = new SqlCommand("AutoGenerateCustomerID", connection);
                        getIdCommand.CommandType = CommandType.StoredProcedure;
                        int newCustomerId = (int)getIdCommand.ExecuteScalar();

                        string query = @"
                        INSERT INTO Customer 
                            (CustomerID, First_Name, Last_Name, Phone_Number, Address, Email, RegisterDate, CreditAmount)
                        VALUES
                            (@CustomerID, @First_Name, @Last_Name, @Phone_Number, @Address, @Email, @RegisterDate, @CreditAmount)";

                        SqlCommand insertCommand = new SqlCommand(query, connection);

                        insertCommand.Parameters.AddWithValue("@CustomerID", newCustomerId);
                        insertCommand.Parameters.AddWithValue("@First_Name", txtFname.Text);
                        insertCommand.Parameters.AddWithValue("@Last_Name", txtLname.Text);
                        insertCommand.Parameters.AddWithValue("@Phone_Number", txtContact.Text);
                        insertCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                        insertCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                        insertCommand.Parameters.AddWithValue("@RegisterDate", DateTime.Now);
                        insertCommand.Parameters.AddWithValue("@CreditAmount", decimal.Parse(txtCamount.Text));

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Customer added successfully with CustomerID: " + newCustomerId);

                        LoadData();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message);
                    }
                }
            }
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
                        SqlCommand command = new SqlCommand(
                            "UPDATE Customer SET First_Name = @First_Name, Last_Name = @Last_Name, Phone_Number = @Phone_Number, " +
                            "Address = @Address, Email = @Email, RegisterDate = @RegisterDate, CreditAmount = @CreditAmount " +
                            "WHERE CustomerID = @CustomerID",
                            connection
                        );

                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@First_Name", txtFname.Text);
                        command.Parameters.AddWithValue("@Last_Name", txtLname.Text);
                        command.Parameters.AddWithValue("@Phone_Number", txtContact.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@RegisterDate", DateTime.Now);
                        command.Parameters.AddWithValue("@CreditAmount", Convert.ToDecimal(txtCamount.Text));

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
                        string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT * FROM Customer WHERE First_Name LIKE @SearchText OR Last_Name LIKE @SearchText OR Email LIKE @SearchText",
                        connection
                    );

                    adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + txtSearch.Text + "%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching data: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtCamount.Clear();
            txtdate.Clear();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtCamount.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            if (!decimal.TryParse(txtCamount.Text, out _))
            {
                MessageBox.Show("Credit Amount must be a valid number.");
                return false;
            }

            return true;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerID",
                HeaderText = "CustomerID",
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
                Name = "Phone_Number",
                HeaderText = "Phone Number",
                DataPropertyName = "Phone_Number",
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
                HeaderText = "Register Date",
                DataPropertyName = "RegisterDate",
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreditAmount",
                HeaderText = "Credit Amount",
                DataPropertyName = "CreditAmount",
            });

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}



