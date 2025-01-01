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
    public partial class Form4 : Form
    {
        string connectionString;
        int userId;
        DataTable dt;
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

        private void LoadData(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    dt = new DataTable();

                    // Clear the DataGridView before loading new data
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridView(string tableName)
        {
            // Clear existing columns and styles
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Customize headers and styles
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Example: Adding columns dynamically based on the table name
            if (tableName == "ViewCustomerDetails")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "CustomerID",
                    HeaderText = "ID",
                    DataPropertyName = "CustomerID",
                    Width = 50,
                    FillWeight = 10
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FirstName",
                    HeaderText = "First Name",
                    DataPropertyName = "First_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "LastName",
                    HeaderText = "Last Name",
                    DataPropertyName = "Last_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Address",
                    HeaderText = "Address",
                    DataPropertyName = "Address"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Email",
                    HeaderText = "Email",
                    DataPropertyName = "Email"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "RegisterDate",
                    HeaderText = "Register Date",
                    DataPropertyName = "RegisterDate"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "PhoneNumber",
                    HeaderText = "Phone Number",
                    DataPropertyName = "Phone_Number"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Last_Purchase_Date",
                    HeaderText = "Last Purchase Date",
                    DataPropertyName = "Last_Purchase_Date"
                });
            }
            else if (tableName == "ViewUserDetails")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "UserID",
                    HeaderText = "User ID",
                    DataPropertyName = "UserID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FullName",
                    HeaderText = "Full Name",
                    DataPropertyName = "Full_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NIC",
                    HeaderText = "NIC",
                    DataPropertyName = "NIC"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Username",
                    HeaderText = "Username",
                    DataPropertyName = "username"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Phone_Number",
                    HeaderText = "Phone Number",
                    DataPropertyName = "Phone_Number"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Total_Sales",
                    HeaderText = "Total Sales Amount",
                    DataPropertyName = "Total_Sales"
                });
            }
            else if (tableName == "ViewSalesSummary")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SaleID",
                    HeaderText = "Sale ID",
                    DataPropertyName = "SaleID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Sale_Date",
                    HeaderText = "Sale Date",
                    DataPropertyName = "Sale_Date"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Total_Amount",
                    HeaderText = "Total Amount",
                    DataPropertyName = "Total_Amount"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Full_Name",
                    HeaderText = "Full Name",
                    DataPropertyName = "Full_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Customer_Name",
                    HeaderText = "Customer Name",
                    DataPropertyName = "Customer_Name"
                });
            }
            else if (tableName == "ViewSalesDetails")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Sales_DetailsID",
                    HeaderText = "Sale Detail ID",
                    DataPropertyName = "Sales_DetailsID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SaleID",
                    HeaderText = "Sale ID",
                    DataPropertyName = "SaleID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Product_Name",
                    HeaderText = "Product Name",
                    DataPropertyName = "Product_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Quantity_Sold",
                    HeaderText = "Quantity Sold",
                    DataPropertyName = "Quantity_Sold"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Price",
                    HeaderText = "Price",
                    DataPropertyName = "Price"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Subtotal",
                    HeaderText = "Sub Total",
                    DataPropertyName = "Subtotal"
                });
            }
            else if (tableName == "ViewStockOverview")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "StockID",
                    HeaderText = "Stock ID",
                    DataPropertyName = "StockID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Product_Name",
                    HeaderText = "Product Name",
                    DataPropertyName = "Product_Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Price",
                    HeaderText = "Price",
                    DataPropertyName = "Price"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Available_Quantity",
                    HeaderText = "Available Quantity",
                    DataPropertyName = "Available_Quantity"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "WarningMessage",
                    HeaderText = "Warning Message",
                    DataPropertyName = "WarningMessage"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "WarningCreated",
                    HeaderText = "Warning Created",
                    DataPropertyName = "WarningCreated"
                });
            }
            else if (tableName == "ViewCashDrawerSummary")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DrawerID",
                    HeaderText = "Drawer ID",
                    DataPropertyName = "DrawerID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "UserName",
                    HeaderText = "User Name",
                    DataPropertyName = "UserName"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "StartTime",
                    HeaderText = "Start Time",
                    DataPropertyName = "StartTime"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "EndTime",
                    HeaderText = "End Time",
                    DataPropertyName = "EndTime"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "StartAmount",
                    HeaderText = "Start Amount",
                    DataPropertyName = "StartAmount"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "EndAmount",
                    HeaderText = "End Amount",
                    DataPropertyName = "EndAmount"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "IsMatched",
                    HeaderText = "Is Matched",
                    DataPropertyName = "IsMatched"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Remarks",
                    HeaderText = "Remarks",
                    DataPropertyName = "Remarks"
                });
            }
            else if (tableName == "Discount")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DiscountID",
                    HeaderText = "Discount ID",
                    DataPropertyName = "DiscountID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Discount_Value",
                    HeaderText = "Discount Value",
                    DataPropertyName = "Discount_Value"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Date",
                    HeaderText = "Date",
                    DataPropertyName = "Date"
                });
            }
            else if (tableName == "MismatchLog")
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "LogID",
                    HeaderText = "Log ID",
                    DataPropertyName = "LogID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "DrawerID",
                    HeaderText = "Drawer ID",
                    DataPropertyName = "DrawerID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Expected_Amount",
                    HeaderText = "Expected Amount",
                    DataPropertyName = "Expected_Amount"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Actual_Amount",
                    HeaderText = "Actual Amount",
                    DataPropertyName = "Actual_Amount"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Time_Stamp",
                    HeaderText = "Time Stamp",
                    DataPropertyName = "Time_Stamp"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "UserID",
                    HeaderText = "User ID",
                    DataPropertyName = "UserID"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Remarks",
                    HeaderText = "Remarks",
                    DataPropertyName = "Remarks"
                });
            }
            // Add similar blocks for other tables like Sale, Stock, Discount, etc.

            // Optional: Center align cell content
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewCustomerDetails");
            InitializeDataGridView("ViewCustomerDetails");
            lblReport.Text = "Customer Details Report";
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewUserDetails");
            InitializeDataGridView("ViewUserDetails");
            lblReport.Text = "User Details Report";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewSalesSummary");
            InitializeDataGridView("ViewSalesSummary");
            lblReport.Text = "Sales Summary Report";
        }

        private void btnSalesDetails_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewSalesDetails");
            InitializeDataGridView("ViewSalesDetails");
            lblReport.Text = "Sales Details Report";
        }

        private void btnCashDrawer_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewCashDrawerSummary");
            InitializeDataGridView("ViewCashDrawerSummary");
            lblReport.Text = "Cash Drawer Report";
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM Discount");
            InitializeDataGridView("Discount");
            lblReport.Text = "Discounts Report";
        }

        private void btnStockOverview_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewStockOverview");
            InitializeDataGridView("ViewStockOverview");
            lblReport.Text = "Stock Report";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM ViewCustomerDetails");
            InitializeDataGridView("ViewCustomerDetails");
            lblReport.Text = "Customer Details Report";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("No data loaded to search.");
                return;
            }

            string searchValue = txtSearch.Text.Trim(); // Assume txtSearch is the TextBox for input
            if (string.IsNullOrEmpty(searchValue))
            {
                // Reset the filter if no search value is entered
                dt.DefaultView.RowFilter = string.Empty;
                return;
            }

            try
            {
                // Generate filter expression dynamically based on column names
                string filter = string.Join(" OR ",
                    dt.Columns.Cast<DataColumn>()
                        .Where(col => col.DataType == typeof(string)) // Only search in string columns
                        .Select(col => $"{col.ColumnName} LIKE '%{searchValue}%'"));

                dt.DefaultView.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM MismatchLog");
            InitializeDataGridView("MismatchLog");
            lblReport.Text = "Mismatch Report";
        }
    }
}
