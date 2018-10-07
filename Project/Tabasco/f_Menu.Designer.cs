namespace Tabasco
{
    partial class f_Menu
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
            this.b_Menu = new System.Windows.Forms.Button();
            this.b_employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Menu
            // 
            this.b_Menu.Location = new System.Drawing.Point(35, 26);
            this.b_Menu.Name = "b_Menu";
            this.b_Menu.Size = new System.Drawing.Size(150, 130);
            this.b_Menu.TabIndex = 1;
            this.b_Menu.Text = "Menu";
            this.b_Menu.UseVisualStyleBackColor = true;
            this.b_Menu.Click += new System.EventHandler(this.b_Menu_Click);
            // 
            // b_employee
            // 
            this.b_employee.Location = new System.Drawing.Point(240, 26);
            this.b_employee.Name = "b_employee";
            this.b_employee.Size = new System.Drawing.Size(150, 130);
            this.b_employee.TabIndex = 2;
            this.b_employee.Text = "Employee Manegment";
            this.b_employee.UseVisualStyleBackColor = true;
            this.b_employee.Click += new System.EventHandler(this.b_employee_Click);
            // 
            // f_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.b_employee);
            this.Controls.Add(this.b_Menu);
            this.Name = "f_Menu";
            this.Text = "f_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Menu;
        private System.Windows.Forms.Button b_employee;
    }
}