namespace Tabasco
{
    partial class f_AddSupplier
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
            this.t_Email = new System.Windows.Forms.TextBox();
            this.t_Address = new System.Windows.Forms.TextBox();
            this.t_PhoneNumber = new System.Windows.Forms.TextBox();
            this.t_FullName = new System.Windows.Forms.TextBox();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.l_Email = new System.Windows.Forms.Label();
            this.l_Address = new System.Windows.Forms.Label();
            this.l_PhoneNumber = new System.Windows.Forms.Label();
            this.l_FullName = new System.Windows.Forms.Label();
            this.l_ID = new System.Windows.Forms.Label();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.b_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_Email
            // 
            this.t_Email.Location = new System.Drawing.Point(131, 183);
            this.t_Email.Name = "t_Email";
            this.t_Email.Size = new System.Drawing.Size(208, 20);
            this.t_Email.TabIndex = 5;
            // 
            // t_Address
            // 
            this.t_Address.AcceptsReturn = true;
            this.t_Address.Location = new System.Drawing.Point(131, 148);
            this.t_Address.Name = "t_Address";
            this.t_Address.Size = new System.Drawing.Size(208, 20);
            this.t_Address.TabIndex = 4;
            // 
            // t_PhoneNumber
            // 
            this.t_PhoneNumber.Location = new System.Drawing.Point(131, 112);
            this.t_PhoneNumber.Name = "t_PhoneNumber";
            this.t_PhoneNumber.Size = new System.Drawing.Size(208, 20);
            this.t_PhoneNumber.TabIndex = 3;
            // 
            // t_FullName
            // 
            this.t_FullName.Location = new System.Drawing.Point(131, 75);
            this.t_FullName.Name = "t_FullName";
            this.t_FullName.Size = new System.Drawing.Size(208, 20);
            this.t_FullName.TabIndex = 2;
            this.t_FullName.TextChanged += new System.EventHandler(this.t_FullName_TextChanged);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(131, 35);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(208, 20);
            this.t_ID.TabIndex = 1;
            this.t_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_Email
            // 
            this.l_Email.AutoSize = true;
            this.l_Email.Location = new System.Drawing.Point(41, 186);
            this.l_Email.Name = "l_Email";
            this.l_Email.Size = new System.Drawing.Size(35, 13);
            this.l_Email.TabIndex = 9;
            this.l_Email.Text = "Email:";
            // 
            // l_Address
            // 
            this.l_Address.AutoSize = true;
            this.l_Address.Location = new System.Drawing.Point(41, 151);
            this.l_Address.Name = "l_Address";
            this.l_Address.Size = new System.Drawing.Size(48, 13);
            this.l_Address.TabIndex = 7;
            this.l_Address.Text = "Address:";
            // 
            // l_PhoneNumber
            // 
            this.l_PhoneNumber.AutoSize = true;
            this.l_PhoneNumber.Location = new System.Drawing.Point(41, 115);
            this.l_PhoneNumber.Name = "l_PhoneNumber";
            this.l_PhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.l_PhoneNumber.TabIndex = 8;
            this.l_PhoneNumber.Text = "Phone Number:";
            this.l_PhoneNumber.Click += new System.EventHandler(this.l_PhoneNumber_Click);
            // 
            // l_FullName
            // 
            this.l_FullName.AutoSize = true;
            this.l_FullName.Location = new System.Drawing.Point(41, 78);
            this.l_FullName.Name = "l_FullName";
            this.l_FullName.Size = new System.Drawing.Size(57, 13);
            this.l_FullName.TabIndex = 7;
            this.l_FullName.Text = "Full Name:";
            // 
            // l_ID
            // 
            this.l_ID.AutoSize = true;
            this.l_ID.Location = new System.Drawing.Point(41, 38);
            this.l_ID.Name = "l_ID";
            this.l_ID.Size = new System.Drawing.Size(21, 13);
            this.l_ID.TabIndex = 11;
            this.l_ID.Text = "ID:";
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(240, 222);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(99, 30);
            this.b_Cancel.TabIndex = 9;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // b_Submit
            // 
            this.b_Submit.Location = new System.Drawing.Point(131, 222);
            this.b_Submit.Name = "b_Submit";
            this.b_Submit.Size = new System.Drawing.Size(99, 30);
            this.b_Submit.TabIndex = 0;
            this.b_Submit.Text = "Submit";
            this.b_Submit.UseVisualStyleBackColor = true;
            this.b_Submit.Click += new System.EventHandler(this.b_Submit_Click);
            // 
            // f_AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 264);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Submit);
            this.Controls.Add(this.t_Email);
            this.Controls.Add(this.t_Address);
            this.Controls.Add(this.t_PhoneNumber);
            this.Controls.Add(this.t_FullName);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.l_Email);
            this.Controls.Add(this.l_Address);
            this.Controls.Add(this.l_PhoneNumber);
            this.Controls.Add(this.l_FullName);
            this.Controls.Add(this.l_ID);
            this.Name = "f_AddSupplier";
            this.Text = "f_AddSupplier";
            this.Load += new System.EventHandler(this.f_AddSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Email;
        private System.Windows.Forms.TextBox t_Address;
        private System.Windows.Forms.TextBox t_PhoneNumber;
        private System.Windows.Forms.TextBox t_FullName;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label l_Email;
        private System.Windows.Forms.Label l_Address;
        private System.Windows.Forms.Label l_PhoneNumber;
        private System.Windows.Forms.Label l_FullName;
        private System.Windows.Forms.Label l_ID;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Button b_Submit;
    }
}