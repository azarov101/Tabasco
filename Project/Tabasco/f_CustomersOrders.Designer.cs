namespace Tabasco
{
    partial class f_CustomersOrders
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
            this.t_OrdersNumber = new System.Windows.Forms.TextBox();
            this.l_OrdersNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_OrdersNumber
            // 
            this.t_OrdersNumber.Location = new System.Drawing.Point(98, 38);
            this.t_OrdersNumber.Name = "t_OrdersNumber";
            this.t_OrdersNumber.Size = new System.Drawing.Size(100, 20);
            this.t_OrdersNumber.TabIndex = 0;
            this.t_OrdersNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_OrdersNumber
            // 
            this.l_OrdersNumber.AutoSize = true;
            this.l_OrdersNumber.Location = new System.Drawing.Point(12, 41);
            this.l_OrdersNumber.Name = "l_OrdersNumber";
            this.l_OrdersNumber.Size = new System.Drawing.Size(83, 13);
            this.l_OrdersNumber.TabIndex = 1;
            this.l_OrdersNumber.Text = "Order\'s Number:";
            this.l_OrdersNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // f_CustomersOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.l_OrdersNumber);
            this.Controls.Add(this.t_OrdersNumber);
            this.Name = "f_CustomersOrders";
            this.Text = "f_CustomersOrders";
            this.Load += new System.EventHandler(this.f_CustomersOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_OrdersNumber;
        private System.Windows.Forms.Label l_OrdersNumber;
    }
}