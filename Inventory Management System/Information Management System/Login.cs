using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_System
{
    public partial class Login : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        


        private int loginAttempts = 0; // Counter for login attempts

        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTsign_Click(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=ClinicTables.accdb");

            // SQL query to check if the username and password match and retrieve the UserID and Type
            string query = "SELECT UserID, [Position] FROM UserAcc WHERE Username = @username AND [Password] = @password";

            // Create and configure the command
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", TBuser.Text);
            cmd.Parameters.AddWithValue("@password", TBpass.Text);

            try
            {
                // Open the connection
                conn.Open();

                // Execute the query and get the result using ExecuteReader()
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Check if a record is returned
                {
                    int UserID = reader.GetInt32(0);  // Get the UserID from the first column
                    string UserPosition = reader.GetString(1); // Get the Type (Admin/Staff) from the second column

                    // Format DateTime.Now to remove milliseconds
                    string formattedTimeIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Insert the TimeIn value as Date/Time in LogTable
                    string insertLogQuery = "INSERT INTO LogTable (UserID, TimeIn) VALUES (@UserId, @timeIn)";
                    OleDbCommand insertCmd = new OleDbCommand(insertLogQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserId", UserID);
                    insertCmd.Parameters.AddWithValue("@timeIn", formattedTimeIn); // Use formatted time without milliseconds

                    insertCmd.ExecuteNonQuery(); // Log the login time

                    MessageBox.Show("Login Successfully");

                    // Check the user type and open the corresponding form
                    this.Hide();

                    if (UserPosition == "Admin")
                    {
                        Admin Admin = new Admin(UserID);  // Admin Form
                        Admin.Show();
                    }
                    else if (UserPosition == "Staff")
                    {
                        MainForm MainForm = new MainForm(UserID);  // Staff Form
                        MainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show(); // Show the login form again if type is unrecognized
                    }
                }
                else
                {
                    // Increment the login attempts and show an error message
                    loginAttempts++;
                    MessageBox.Show("Invalid username or password.");

                    if (loginAttempts >= 3)
                    {
                        // Close the application if 3 failed login attempts
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);  // Show the error message
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
