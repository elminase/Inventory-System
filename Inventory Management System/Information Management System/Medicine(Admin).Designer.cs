namespace Information_Management_System
{
    partial class Medicine_Admin_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine_Admin_));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxDeduct = new System.Windows.Forms.PictureBox();
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVmediAdmin = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmediAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxDeduct);
            this.panel1.Controls.Add(this.TBsearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 94);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picboxDeduct
            // 
            this.picboxDeduct.Image = ((System.Drawing.Image)(resources.GetObject("picboxDeduct.Image")));
            this.picboxDeduct.Location = new System.Drawing.Point(371, 44);
            this.picboxDeduct.Name = "picboxDeduct";
            this.picboxDeduct.Size = new System.Drawing.Size(61, 39);
            this.picboxDeduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDeduct.TabIndex = 5;
            this.picboxDeduct.TabStop = false;
            this.picboxDeduct.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TBsearch
            // 
            this.TBsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBsearch.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsearch.Location = new System.Drawing.Point(101, 49);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(234, 29);
            this.TBsearch.TabIndex = 4;
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            // 
            // DGVmediAdmin
            // 
            this.DGVmediAdmin.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGVmediAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVmediAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVmediAdmin.BackgroundColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVmediAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVmediAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVmediAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVmediAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVmediAdmin.GridColor = System.Drawing.Color.DarkMagenta;
            this.DGVmediAdmin.Location = new System.Drawing.Point(0, 94);
            this.DGVmediAdmin.Name = "DGVmediAdmin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVmediAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVmediAdmin.Size = new System.Drawing.Size(1076, 583);
            this.DGVmediAdmin.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // Medicine_Admin_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 677);
            this.Controls.Add(this.DGVmediAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicine_Admin_";
            this.Text = "Medicine_Admin_";
            this.Load += new System.EventHandler(this.Medicine_Admin__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmediAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVmediAdmin;
        private System.Windows.Forms.PictureBox picboxDeduct;
        private System.Windows.Forms.Timer timer1;
    }
}