using System;
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
    public partial class MainForm : Form
    {
        Dashboard dashboard;
        Medicine medicine;
        Equipments equipments;
        Materials materials;

        private OleDbConnection conn;
        private int UserID;

        public MainForm(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BTlogout_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ClinicTables.accdb;");
            conn.Open();

            // Format DateTime.Now to remove milliseconds
            string formattedTimeOut = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Update the LogTable with TimeOut
            string updateLogQuery = "UPDATE LogTable SET TimeOut = @timeOut WHERE UserID = @UserId AND TimeOut IS NULL";
            OleDbCommand updateCmd = new OleDbCommand(updateLogQuery, conn);
            updateCmd.Parameters.AddWithValue("@timeOut", formattedTimeOut);
            updateCmd.Parameters.AddWithValue("@UserId", UserID);

            updateCmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Logout Successful.");
            this.Hide();

            Login Login = new Login();  // Login Form
            Login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTdash_Click(object sender, EventArgs e) 
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();

            }
            else
            {
                dashboard.Activate();
            }

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        bool inventoryExpand = false;
        private void InventoryBar_Tick(object sender, EventArgs e)
        {
            if (inventoryExpand == false)
            {
                InventoryCon.Height += 10;
                if (InventoryCon.Height >= 327)
                {
                    InventoryBar.Stop();
                    inventoryExpand = true;

                }

            }
            else
            {
                InventoryCon.Height -= 10;
                if (InventoryCon.Height <= 74)
                {
                    InventoryBar.Stop();
                    inventoryExpand = false;
                }
            }
        }

        private void BTInvent_Click(object sender, EventArgs e)
        {
            InventoryBar.Start();
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            medicine = null;
            equipments = null;
            materials = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           //nothing
        }

        private void InventoryCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            InventoryBar.Start();
        }

        private void BTmedi_Click(object sender, EventArgs e)
        {
            if (medicine == null)
            {
                medicine = new Medicine();
                medicine.FormClosed += Inventory_FormClosed;
                medicine.MdiParent = this;
                medicine.Dock = DockStyle.Fill;
                medicine.Show();

            }
            else
            {
                medicine.Activate();
            }
        }

        private void BTequip_Click(object sender, EventArgs e)
        {
            if (equipments == null)
            {
                equipments = new Equipments();
                equipments.FormClosed += Inventory_FormClosed;
                equipments.MdiParent = this;
                equipments.Dock = DockStyle.Fill;
                equipments.Show();

            }
            else
            {
                equipments.Activate();
            }
        }

        private void BTmaterial_Click(object sender, EventArgs e)
        {
            if (materials == null)
            {
                materials = new Materials();
                materials.FormClosed += Inventory_FormClosed;
                materials.MdiParent = this;
                materials.Dock = DockStyle.Fill;
                materials.Show();

            }
            else
            {
                materials.Activate();
            }
        }
    }
}
