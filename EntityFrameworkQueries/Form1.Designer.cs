﻿namespace EntityFrameworkQueries
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
            this.btnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.btnMiscQueries = new System.Windows.Forms.Button();
            this.btnVendorsAndInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(102, 50);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(185, 23);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * From Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnAllCAVendors
            // 
            this.btnAllCAVendors.Location = new System.Drawing.Point(102, 109);
            this.btnAllCAVendors.Name = "btnAllCAVendors";
            this.btnAllCAVendors.Size = new System.Drawing.Size(453, 23);
            this.btnAllCAVendors.TabIndex = 1;
            this.btnAllCAVendors.Text = "Select * FROM Vendor WHERE VendorState = \'CA\' ORDER BY VendorName";
            this.btnAllCAVendors.UseVisualStyleBackColor = true;
            this.btnAllCAVendors.Click += new System.EventHandler(this.btnAllCAVendors_Click);
            // 
            // btnSelectSpecificColumns
            // 
            this.btnSelectSpecificColumns.Location = new System.Drawing.Point(102, 168);
            this.btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            this.btnSelectSpecificColumns.Size = new System.Drawing.Size(453, 23);
            this.btnSelectSpecificColumns.TabIndex = 2;
            this.btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState from Vendors";
            this.btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.btnSelectSpecificColumns.Click += new System.EventHandler(this.btnSelectSpecificColumns_Click);
            // 
            // btnMiscQueries
            // 
            this.btnMiscQueries.Location = new System.Drawing.Point(102, 227);
            this.btnMiscQueries.Name = "btnMiscQueries";
            this.btnMiscQueries.Size = new System.Drawing.Size(185, 23);
            this.btnMiscQueries.TabIndex = 3;
            this.btnMiscQueries.Text = "Misc. Queries";
            this.btnMiscQueries.UseVisualStyleBackColor = true;
            this.btnMiscQueries.Click += new System.EventHandler(this.btnMiscQueries_Click);
            // 
            // btnVendorsAndInvoices
            // 
            this.btnVendorsAndInvoices.Location = new System.Drawing.Point(102, 285);
            this.btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
            this.btnVendorsAndInvoices.Size = new System.Drawing.Size(357, 23);
            this.btnVendorsAndInvoices.TabIndex = 4;
            this.btnVendorsAndInvoices.Text = "Select all Vendors with their Invoices";
            this.btnVendorsAndInvoices.UseVisualStyleBackColor = true;
            this.btnVendorsAndInvoices.Click += new System.EventHandler(this.btnVendorsAndInvoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendorsAndInvoices);
            this.Controls.Add(this.btnMiscQueries);
            this.Controls.Add(this.btnSelectSpecificColumns);
            this.Controls.Add(this.btnAllCAVendors);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCAVendors;
        private Button btnSelectSpecificColumns;
        private Button btnMiscQueries;
        private Button btnVendorsAndInvoices;
    }
}