using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_POS
{
    public partial class Form13 : Form
    {
        private readonly string connectionString;
        private readonly int userId;
        public Form13()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            U.UserID, 
            U.Full_Name, 
            U.NIC, 
            U.username, 
            UP.Phone_Number
        FROM 
            Users U
        LEFT JOIN 
            User_Phone UP ON U.UserID = UP.UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable; // Ensure dataGridViewUsers is correctly named
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    U.UserID, 
                    U.Full_Name, 
                    U.NIC, 
                    U.username, 
                    UP.Phone_Number
                FROM 
                    Users U
                LEFT JOIN 
                    User_Phone UP ON U.UserID = UP.UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string nic = txtNIC.Text;
            string username = txtUsername.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert into Users table
                    string userQuery = "INSERT INTO Users (Full_Name, NIC, username, password) VALUES (@FullName, @NIC, @Username, @Password); SELECT SCOPE_IDENTITY();";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction);
                    userCommand.Parameters.AddWithValue("@FullName", fullName);
                    userCommand.Parameters.AddWithValue("@NIC", nic);
                    userCommand.Parameters.AddWithValue("@Username", username);
                    userCommand.Parameters.AddWithValue("@Password", "default_password");

                    int newUserId = Convert.ToInt32(userCommand.ExecuteScalar());

                    // Insert into User_Phone table
                    string phoneQuery = "INSERT INTO User_Phone (UserID, Phone_Number) VALUES (@UserID, @PhoneNumber)";
                    SqlCommand phoneCommand = new SqlCommand(phoneQuery, connection, transaction);
                    phoneCommand.Parameters.AddWithValue("@UserID", newUserId);
                    phoneCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    phoneCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
