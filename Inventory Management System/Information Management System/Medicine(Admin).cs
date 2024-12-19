using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // For connecting to Access databases
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // For handling file and memory streams
using System.Windows.Forms;

namespace Information_Management_System
{
    public partial class Medicine_Admin_ : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.

        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.

        public Medicine_Admin_()
        {
            InitializeComponent();
        }

        void GetMeds()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=ClinicTables.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Medicine", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            DGVmediAdmin.DataSource = dt;
            // Close the database connection
            conn.Close();
            DGVmediAdmin.EnableHeadersVisualStyles = false;
            DGVmediAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Make columns auto resize

            // Check if the column exists and then set the currency format
            if (DGVmediAdmin.Columns.Contains("Purchase Cost"))
            {
                DGVmediAdmin.Columns["Purchase Cost"].DefaultCellStyle.Format = "C2";  // Format as currency with 2 decimal places
            }

        }

        private void Medicine_Admin__Load(object sender, EventArgs e)
        {
            GetMeds();

            // Initialize and start the Timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 2000; // Set the interval to 2000 milliseconds (2 seconds)
            refreshTimer.Tick += new EventHandler(RefreshDataGrid); // Attach the event handler
            refreshTimer.Start(); // Start the timer
        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            // SQL query to search for users by ID using a partial match
            string searchQuery = "SELECT * FROM Medicine WHERE [Generic Name] LIKE @i OR [Brand] like @i OR [Type] LIKE @i";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adapter = new OleDbDataAdapter(searchQuery, conn);

            // Add the search parameter with the value from the search textbox
            adapter.SelectCommand.Parameters.AddWithValue("@i", TBsearch.Text + "%"); // Add '%' for partial matching

            dt = new DataTable(); // Create a new DataTable to hold the search results

            // Open the connection, fill the DataTable with search results, and close the connection
            conn.Open(); // Open the connection to the database
            adapter.Fill(dt); // Fill the DataTable with search results
            conn.Close(); // Close the connection to the database

            // Bind the DataTable to the DataGridView
            DGVmediAdmin.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) //Deduct
        {
            Deduct Deduct = new Deduct();  // Deduct Form
            Deduct.Show();
        }
        // Declare a Timer in your form
        private Timer refreshTimer;

        private void RefreshDataGrid(object sender, EventArgs e)
        {
            // Reload the data every time the timer ticks
            GetMeds(); // Re-load the data into the DataGridView
        }
    }
}
