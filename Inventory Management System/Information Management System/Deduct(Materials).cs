﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Management_System
{
    public partial class Deduct_Materials_ : Form
    {
        // Connection string to connect to Access database
        private string accessConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ClinicTables.accdb;";

        public Deduct_Materials_()
        {
            InitializeComponent();
        }

        private void Deduct_Materials__Load(object sender, EventArgs e)
        {

        }

        private void BTdeduct_Click(object sender, EventArgs e)
        {
            // Initialize the reset flag
            bool resetFlag = false;

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(TBMatID.Text) ||    // Material ID
                string.IsNullOrWhiteSpace(TBquantity.Text))    // Quantity
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Ensure the connection is properly established
                using (OleDbConnection conn = new OleDbConnection(accessConnString))
                {
                    // Create the SQL query to get the current quantity of a product by ProductID
                    string selectQuery = "SELECT Quantity FROM Materials WHERE [Material ID] = ?";

                    // Create and configure the select command
                    using (OleDbCommand selectCmd = new OleDbCommand(selectQuery, conn))
                    {
                        // Parameter to prevent SQL injection
                        selectCmd.Parameters.AddWithValue("?", TBMatID.Text); // MaterialID

                        // Open the connection
                        conn.Open();

                        // Execute the select query and get the current quantity
                        object result = selectCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int currentQuantity = Convert.ToInt32(result);  // Get current quantity
                            int quantityToSubtract = Convert.ToInt32(TBquantity.Text);  // Get quantity to subtract

                            // Check if there is enough stock to subtract
                            if (currentQuantity >= quantityToSubtract)
                            {
                                // Create the SQL query to update the quantity by subtracting the input value
                                string updateQuery = "UPDATE Materials SET Quantity = ? WHERE [Material ID] = ?";

                                // Create and configure the update command
                                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                                {
                                    // Parameters to prevent SQL injection
                                    updateCmd.Parameters.AddWithValue("?", currentQuantity - quantityToSubtract); // Updated quantity
                                    updateCmd.Parameters.AddWithValue("?", TBMatID.Text); // ProductID

                                    // Execute the update command
                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    // Provide feedback to the user
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Material quantity updated successfully.");
                                        resetFlag = true; // Set the reset flag to true on success
                                    }
                                    else
                                    {
                                        MessageBox.Show("No material found with the provided Material ID.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Not enough stock available to subtract the specified quantity.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No material found with the provided Material ID.");
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // If the reset flag is true, reset the form
            if (resetFlag)
            {
                TBMatID.Clear();
                TBquantity.Clear();
                resetFlag = false;  // Reset the flag after use
            }
        }
    }
}