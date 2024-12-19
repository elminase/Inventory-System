namespace Information_Management_System
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.BTlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BTacc = new System.Windows.Forms.Button();
            this.InventoryCon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTInvent = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTmedi = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTequip = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BTmaterial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTdash = new System.Windows.Forms.Button();
            this.InventoryBar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.InventoryCon.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BTlogout
            // 
            this.BTlogout.BackColor = System.Drawing.SystemColors.Window;
            this.BTlogout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTlogout.Location = new System.Drawing.Point(-3, -10);
            this.BTlogout.Name = "BTlogout";
            this.BTlogout.Size = new System.Drawing.Size(174, 69);
            this.BTlogout.TabIndex = 0;
            this.BTlogout.Text = "Logout";
            this.BTlogout.UseVisualStyleBackColor = false;
            this.BTlogout.Click += new System.EventHandler(this.BTlogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.InventoryCon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 693);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(81, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.BTacc);
            this.panel8.Location = new System.Drawing.Point(8, 189);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 78);
            this.panel8.TabIndex = 4;
            // 
            // BTacc
            // 
            this.BTacc.BackColor = System.Drawing.SystemColors.Window;
            this.BTacc.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTacc.Location = new System.Drawing.Point(-7, -10);
            this.BTacc.Margin = new System.Windows.Forms.Padding(0);
            this.BTacc.Name = "BTacc";
            this.BTacc.Size = new System.Drawing.Size(286, 95);
            this.BTacc.TabIndex = 2;
            this.BTacc.Text = "Accounts";
            this.BTacc.UseVisualStyleBackColor = false;
            this.BTacc.Click += new System.EventHandler(this.BTacc_Click);
            // 
            // InventoryCon
            // 
            this.InventoryCon.BackColor = System.Drawing.SystemColors.Window;
            this.InventoryCon.Controls.Add(this.panel4);
            this.InventoryCon.Controls.Add(this.panel5);
            this.InventoryCon.Controls.Add(this.panel6);
            this.InventoryCon.Controls.Add(this.panel7);
            this.InventoryCon.Location = new System.Drawing.Point(8, 273);
            this.InventoryCon.Name = "InventoryCon";
            this.InventoryCon.Size = new System.Drawing.Size(258, 74);
            this.InventoryCon.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.BTInvent);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 69);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BTInvent
            // 
            this.BTInvent.BackColor = System.Drawing.SystemColors.Window;
            this.BTInvent.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInvent.Location = new System.Drawing.Point(-7, -10);
            this.BTInvent.Margin = new System.Windows.Forms.Padding(0);
            this.BTInvent.Name = "BTInvent";
            this.BTInvent.Size = new System.Drawing.Size(286, 91);
            this.BTInvent.TabIndex = 2;
            this.BTInvent.Text = "Inventory";
            this.BTInvent.UseVisualStyleBackColor = false;
            this.BTInvent.Click += new System.EventHandler(this.BTInvent_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BTmedi);
            this.panel5.Location = new System.Drawing.Point(3, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 78);
            this.panel5.TabIndex = 3;
            // 
            // BTmedi
            // 
            this.BTmedi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTmedi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTmedi.Location = new System.Drawing.Point(-7, -10);
            this.BTmedi.Margin = new System.Windows.Forms.Padding(0);
            this.BTmedi.Name = "BTmedi";
            this.BTmedi.Size = new System.Drawing.Size(286, 95);
            this.BTmedi.TabIndex = 2;
            this.BTmedi.Text = "Medicine";
            this.BTmedi.UseVisualStyleBackColor = false;
            this.BTmedi.Click += new System.EventHandler(this.BTmedi_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BTequip);
            this.panel6.Location = new System.Drawing.Point(3, 162);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 78);
            this.panel6.TabIndex = 3;
            // 
            // BTequip
            // 
            this.BTequip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTequip.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTequip.Location = new System.Drawing.Point(-7, -10);
            this.BTequip.Margin = new System.Windows.Forms.Padding(0);
            this.BTequip.Name = "BTequip";
            this.BTequip.Size = new System.Drawing.Size(286, 95);
            this.BTequip.TabIndex = 2;
            this.BTequip.Text = "Equipments";
            this.BTequip.UseVisualStyleBackColor = false;
            this.BTequip.Click += new System.EventHandler(this.BTequip_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BTmaterial);
            this.panel7.Location = new System.Drawing.Point(3, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 78);
            this.panel7.TabIndex = 3;
            // 
            // BTmaterial
            // 
            this.BTmaterial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BTmaterial.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTmaterial.Location = new System.Drawing.Point(-7, -10);
            this.BTmaterial.Margin = new System.Windows.Forms.Padding(0);
            this.BTmaterial.Name = "BTmaterial";
            this.BTmaterial.Size = new System.Drawing.Size(286, 95);
            this.BTmaterial.TabIndex = 2;
            this.BTmaterial.Text = "Materials";
            this.BTmaterial.UseVisualStyleBackColor = false;
            this.BTmaterial.Click += new System.EventHandler(this.BTmaterial_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BTlogout);
            this.panel2.Location = new System.Drawing.Point(-8, 647);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 49);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.BTdash);
            this.panel3.Location = new System.Drawing.Point(9, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 63);
            this.panel3.TabIndex = 1;
            // 
            // BTdash
            // 
            this.BTdash.BackColor = System.Drawing.SystemColors.Window;
            this.BTdash.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdash.Location = new System.Drawing.Point(-7, -12);
            this.BTdash.Name = "BTdash";
            this.BTdash.Size = new System.Drawing.Size(228, 88);
            this.BTdash.TabIndex = 2;
            this.BTdash.Text = "            Dashboard";
            this.BTdash.UseVisualStyleBackColor = false;
            this.BTdash.Click += new System.EventHandler(this.BTdash_Click);
            // 
            // InventoryBar
            // 
            this.InventoryBar.Interval = 1;
            this.InventoryBar.Tick += new System.EventHandler(this.InventoryBar_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(25, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 693);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.InventoryCon.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTlogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel InventoryCon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTInvent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BTmedi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BTequip;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BTmaterial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTdash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer InventoryBar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BTacc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}