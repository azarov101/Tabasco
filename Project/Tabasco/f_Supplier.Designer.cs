namespace Tabasco
{
    partial class f_Supplier
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
            this.b_SupplierReport = new System.Windows.Forms.Button();
            this.b_EditSupplier = new System.Windows.Forms.Button();
            this.b_AddSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_SupplierReport
            // 
            this.b_SupplierReport.Location = new System.Drawing.Point(201, 33);
            this.b_SupplierReport.Name = "b_SupplierReport";
            this.b_SupplierReport.Size = new System.Drawing.Size(150, 130);
            this.b_SupplierReport.TabIndex = 1;
            this.b_SupplierReport.Text = "Supplier Report";
            this.b_SupplierReport.UseVisualStyleBackColor = true;
            this.b_SupplierReport.Click += new System.EventHandler(this.b_SupplierReport_Click);
            // 
            // b_EditSupplier
            // 
            this.b_EditSupplier.Location = new System.Drawing.Point(45, 169);
            this.b_EditSupplier.Name = "b_EditSupplier";
            this.b_EditSupplier.Size = new System.Drawing.Size(150, 130);
            this.b_EditSupplier.TabIndex = 2;
            this.b_EditSupplier.Text = "Edit Supplier";
            this.b_EditSupplier.UseVisualStyleBackColor = true;
            this.b_EditSupplier.Click += new System.EventHandler(this.b_EditSupplier_Click);
            // 
            // b_AddSupplier
            // 
            this.b_AddSupplier.Location = new System.Drawing.Point(45, 33);
            this.b_AddSupplier.Name = "b_AddSupplier";
            this.b_AddSupplier.Size = new System.Drawing.Size(150, 130);
            this.b_AddSupplier.TabIndex = 0;
            this.b_AddSupplier.Text = "Add Supplier";
            this.b_AddSupplier.UseVisualStyleBackColor = true;
            this.b_AddSupplier.Click += new System.EventHandler(this.b_AddSupplier_Click);
            // 
            // f_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.b_SupplierReport);
            this.Controls.Add(this.b_EditSupplier);
            this.Controls.Add(this.b_AddSupplier);
            this.Name = "f_Supplier";
            this.Text = "f_Supplier";
            this.Load += new System.EventHandler(this.f_Supplier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_SupplierReport;
        private System.Windows.Forms.Button b_EditSupplier;
        private System.Windows.Forms.Button b_AddSupplier;
    }
}