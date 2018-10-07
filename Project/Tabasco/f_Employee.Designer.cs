namespace Tabasco
{
    partial class f_Employee
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
            this.b_addEmployee = new System.Windows.Forms.Button();
            this.b_editEployee = new System.Windows.Forms.Button();
            this.b_employeeReportDetails = new System.Windows.Forms.Button();
            this.b_calculateWage = new System.Windows.Forms.Button();
            this.b_employeeReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_addEmployee
            // 
            this.b_addEmployee.Location = new System.Drawing.Point(43, 33);
            this.b_addEmployee.Name = "b_addEmployee";
            this.b_addEmployee.Size = new System.Drawing.Size(150, 130);
            this.b_addEmployee.TabIndex = 0;
            this.b_addEmployee.Text = "Add Employee";
            this.b_addEmployee.UseVisualStyleBackColor = true;
            this.b_addEmployee.Click += new System.EventHandler(this.b_addEmployee_Click);
            // 
            // b_editEployee
            // 
            this.b_editEployee.Location = new System.Drawing.Point(43, 169);
            this.b_editEployee.Name = "b_editEployee";
            this.b_editEployee.Size = new System.Drawing.Size(150, 130);
            this.b_editEployee.TabIndex = 0;
            this.b_editEployee.Text = "Edit Employee";
            this.b_editEployee.UseVisualStyleBackColor = true;
            // 
            // b_employeeReportDetails
            // 
            this.b_employeeReportDetails.Location = new System.Drawing.Point(199, 33);
            this.b_employeeReportDetails.Name = "b_employeeReportDetails";
            this.b_employeeReportDetails.Size = new System.Drawing.Size(150, 130);
            this.b_employeeReportDetails.TabIndex = 0;
            this.b_employeeReportDetails.Text = "Employee Report Details";
            this.b_employeeReportDetails.UseVisualStyleBackColor = true;
            // 
            // b_calculateWage
            // 
            this.b_calculateWage.Location = new System.Drawing.Point(199, 169);
            this.b_calculateWage.Name = "b_calculateWage";
            this.b_calculateWage.Size = new System.Drawing.Size(150, 130);
            this.b_calculateWage.TabIndex = 0;
            this.b_calculateWage.Text = "CalculateWage";
            this.b_calculateWage.UseVisualStyleBackColor = true;
            // 
            // b_employeeReport
            // 
            this.b_employeeReport.Location = new System.Drawing.Point(355, 33);
            this.b_employeeReport.Name = "b_employeeReport";
            this.b_employeeReport.Size = new System.Drawing.Size(150, 130);
            this.b_employeeReport.TabIndex = 0;
            this.b_employeeReport.Text = "Employee Report";
            this.b_employeeReport.UseVisualStyleBackColor = true;
            // 
            // f_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 360);
            this.Controls.Add(this.b_employeeReport);
            this.Controls.Add(this.b_calculateWage);
            this.Controls.Add(this.b_employeeReportDetails);
            this.Controls.Add(this.b_editEployee);
            this.Controls.Add(this.b_addEmployee);
            this.Name = "f_Employee";
            this.Text = "f_Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_addEmployee;
        private System.Windows.Forms.Button b_editEployee;
        private System.Windows.Forms.Button b_employeeReportDetails;
        private System.Windows.Forms.Button b_calculateWage;
        private System.Windows.Forms.Button b_employeeReport;
    }
}