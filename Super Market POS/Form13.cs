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
        string connectionString;
        int userId;
        public Form13(string connStr, int user)
        {
            InitializeComponent();
            connectionString = connStr;
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
                U.UserID AS User_ID, 
                U.Full_Name AS Full_Name, 
                U.NIC AS NIC, 
                U.username AS Username, 
                UP.Phone_Number AS Phone_Number
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
    SELECT 
        U.UserID AS [User ID], 
        U.Full_Name AS [Full Name], 
        U.NIC, 
        U.username AS [Username], 
        UP.Phone_Number AS [Phone Number]
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
            Form12 form12 = new Form12(connectionString, userId);
            this.Hide();
            form12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter a full name to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Retrieve the UserID based on the Full Name
                    string getUserQuery = "SELECT UserID FROM Users WHERE Full_Name = @FullName";
                    SqlCommand getUserCommand = new SqlCommand(getUserQuery, connection, transaction);
                    getUserCommand.Parameters.AddWithValue("@FullName", fullName);

                    object result = getUserCommand.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int userId = Convert.ToInt32(result);

                    // Delete from User_Phone table
                    string deletePhoneQuery = "DELETE FROM User_Phone WHERE UserID = @UserID";
                    SqlCommand deletePhoneCommand = new SqlCommand(deletePhoneQuery, connection, transaction);
                    deletePhoneCommand.Parameters.AddWithValue("@UserID", userId);
                    deletePhoneCommand.ExecuteNonQuery();

                    // Delete from Users table
                    string deleteUserQuery = "DELETE FROM Users WHERE UserID = @UserID";
                    SqlCommand deleteUserCommand = new SqlCommand(deleteUserQuery, connection, transaction);
                    deleteUserCommand.Parameters.AddWithValue("@UserID", userId);
                    deleteUserCommand.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
