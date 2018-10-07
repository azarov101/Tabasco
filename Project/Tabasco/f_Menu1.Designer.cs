namespace Tabasco
{
    partial class f_Menu1
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
            this.b_General = new System.Windows.Forms.Button();
            this.b_Vegeterian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_General
            // 
            this.b_General.Location = new System.Drawing.Point(145, 157);
            this.b_General.Name = "b_General";
            this.b_General.Size = new System.Drawing.Size(150, 130);
            this.b_General.TabIndex = 2;
            this.b_General.Text = "General";
            this.b_General.UseVisualStyleBackColor = true;
            this.b_General.Click += new System.EventHandler(this.b_General_Click);
            // 
            // b_Vegeterian
            // 
            this.b_Vegeterian.Location = new System.Drawing.Point(348, 157);
            this.b_Vegeterian.Name = "b_Vegeterian";
            this.b_Vegeterian.Size = new System.Drawing.Size(150, 130);
            this.b_Vegeterian.TabIndex = 3;
            this.b_Vegeterian.Text = "Vegeterian";
            this.b_Vegeterian.UseVisualStyleBackColor = true;
            this.b_Vegeterian.Click += new System.EventHandler(this.b_Vegeterian_Click);
            // 
            // f_Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.b_Vegeterian);
            this.Controls.Add(this.b_General);
            this.Name = "f_Menu1";
            this.Text = "f_Menu1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_General;
        private System.Windows.Forms.Button b_Vegeterian;
    }
}