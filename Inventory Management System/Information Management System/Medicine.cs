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
    public partial class Medicine : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.


        public Medicine()
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
            DGVinventory.DataSource = dt;
            // Close the database connection
            conn.Close();
            DGVinventory.EnableHeadersVisualStyles = false;
            DGVinventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Make columns auto resize

            
            // Check if the column exists and then set the currency format
            if (DGVinventory.Columns.Contains("Purchase Cost"))
            {
                DGVinventory.Columns["Purchase Cost"].DefaultCellStyle.Format = "C2";  // Format as currency with 2 decimal places
            }

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            GetMeds();
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
            DGVinventory.DataSource = dt;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVinventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DGVinventory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            

            

        }
    }
}
