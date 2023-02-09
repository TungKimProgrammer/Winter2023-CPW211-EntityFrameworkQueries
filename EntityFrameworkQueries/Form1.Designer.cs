namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectAllVendors = new System.Windows.Forms.Button();
            this.btnAllCAVendors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(67, 50);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(185, 23);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * From Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnAllCAVendors
            // 
            this.btnAllCAVendors.Location = new System.Drawing.Point(67, 108);
            this.btnAllCAVendors.Name = "btnAllCAVendors";
            this.btnAllCAVendors.Size = new System.Drawing.Size(453, 23);
            this.btnAllCAVendors.TabIndex = 1;
            this.btnAllCAVendors.Text = "Select * FROM Vendor WHERE VendorState = \'CA\' ORDER BY VendorName";
            this.btnAllCAVendors.UseVisualStyleBackColor = true;
            this.btnAllCAVendors.Click += new System.EventHandler(this.btnAllCAVendors_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAllCAVendors);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCAVendors;
        private Button button3;
    }
}