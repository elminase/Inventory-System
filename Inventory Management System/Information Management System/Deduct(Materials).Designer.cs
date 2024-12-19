namespace Information_Management_System
{
    partial class Deduct_Materials_
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
            this.BTdeduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMatID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTdeduct
            // 
            this.BTdeduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdeduct.Location = new System.Drawing.Point(71, 125);
            this.BTdeduct.Name = "BTdeduct";
            this.BTdeduct.Size = new System.Drawing.Size(95, 38);
            this.BTdeduct.TabIndex = 10;
            this.BTdeduct.Text = "Deduct";
            this.BTdeduct.UseVisualStyleBackColor = true;
            this.BTdeduct.Click += new System.EventHandler(this.BTdeduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // TBquantity
            // 
            this.TBquantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBquantity.Location = new System.Drawing.Point(120, 64);
            this.TBquantity.Name = "TBquantity";
            this.TBquantity.Size = new System.Drawing.Size(100, 27);
            this.TBquantity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Material ID";
            // 
            // TBMatID
            // 
            this.TBMatID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMatID.Location = new System.Drawing.Point(120, 29);
            this.TBMatID.Name = "TBMatID";
            this.TBMatID.Size = new System.Drawing.Size(100, 27);
            this.TBMatID.TabIndex = 6;
            // 
            // Deduct_Materials_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(244, 192);
            this.Controls.Add(this.BTdeduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBMatID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Deduct_Materials_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deduct";
            this.Load += new System.EventHandler(this.Deduct_Materials__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTdeduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMatID;
    }
}