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
    public partial class Admin : Form
    {
        Dashboard dashboard;
        Medicine_Admin_ medicine_admin;
        Equipment_Admin_ equipment_admin;
        Materials_Admin_ materials_admin;
        Accounts accounts;

        private OleDbConnection conn;
        private int UserID;

        public Admin (int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
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

        private void Admin_Load(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InventoryBar.Start();
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            medicine_admin = null;
            accounts = null;
            equipment_admin = null;
        }

        private void BTmedi_Click(object sender, EventArgs e)
        {
            if (medicine_admin == null)
            {
                medicine_admin = new Medicine_Admin_();
                medicine_admin.FormClosed += Inventory_FormClosed;
                medicine_admin.MdiParent = this;
                medicine_admin.Dock = DockStyle.Fill;
                medicine_admin.Show();

            }
            else
            {
                medicine_admin.Activate();
            }
        }

        private void BTacc_Click(object sender, EventArgs e)
        {
            if (accounts == null)
            {
                accounts = new Accounts();
                accounts.FormClosed += Inventory_FormClosed;
                accounts.MdiParent = this;
                accounts.Dock = DockStyle.Fill;
                accounts.Show();

            }
            else
            {
                accounts.Activate();
            }
        }

        private void BTequip_Click(object sender, EventArgs e)
        {
            if (equipment_admin == null)
            {
                equipment_admin = new Equipment_Admin_();
                equipment_admin.FormClosed += Inventory_FormClosed;
                equipment_admin.MdiParent = this;
                equipment_admin.Dock = DockStyle.Fill;
                equipment_admin.Show();

            }
            else
            {
                equipment_admin.Activate();
            }
        }

        private void BTmaterial_Click(object sender, EventArgs e)
        {
            if (materials_admin == null)
            {
                materials_admin = new Materials_Admin_();
                materials_admin.FormClosed += Inventory_FormClosed;
                materials_admin.MdiParent = this;
                materials_admin.Dock = DockStyle.Fill;
                materials_admin.Show();

            }
            else
            {
                materials_admin.Activate();
            }
        }
    }
}
