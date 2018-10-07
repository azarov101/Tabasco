namespace Tabasco
{
    partial class f_Gmenu
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
            this.b_Appetisers = new System.Windows.Forms.Button();
            this.b_MainDishes = new System.Windows.Forms.Button();
            this.b_Desserts = new System.Windows.Forms.Button();
            this.b_Drinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Appetisers
            // 
            this.b_Appetisers.Location = new System.Drawing.Point(360, 69);
            this.b_Appetisers.Name = "b_Appetisers";
            this.b_Appetisers.Size = new System.Drawing.Size(150, 130);
            this.b_Appetisers.TabIndex = 5;
            this.b_Appetisers.Text = "Appetisers";
            this.b_Appetisers.UseVisualStyleBackColor = true;
            // 
            // b_MainDishes
            // 
            this.b_MainDishes.Location = new System.Drawing.Point(157, 69);
            this.b_MainDishes.Name = "b_MainDishes";
            this.b_MainDishes.Size = new System.Drawing.Size(150, 130);
            this.b_MainDishes.TabIndex = 4;
            this.b_MainDishes.Text = "Main Dishes";
            this.b_MainDishes.UseVisualStyleBackColor = true;
            // 
            // b_Desserts
            // 
            this.b_Desserts.Location = new System.Drawing.Point(360, 250);
            this.b_Desserts.Name = "b_Desserts";
            this.b_Desserts.Size = new System.Drawing.Size(150, 130);
            this.b_Desserts.TabIndex = 7;
            this.b_Desserts.Text = "Desserts";
            this.b_Desserts.UseVisualStyleBackColor = true;
            // 
            // b_Drinks
            // 
            this.b_Drinks.Location = new System.Drawing.Point(157, 250);
            this.b_Drinks.Name = "b_Drinks";
            this.b_Drinks.Size = new System.Drawing.Size(150, 130);
            this.b_Drinks.TabIndex = 6;
            this.b_Drinks.Text = "Drinks";
            this.b_Drinks.UseVisualStyleBackColor = true;
            // 
            // Gmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.b_Desserts);
            this.Controls.Add(this.b_Drinks);
            this.Controls.Add(this.b_Appetisers);
            this.Controls.Add(this.b_MainDishes);
            this.Name = "Gmenu";
            this.Text = "Gmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Appetisers;
        private System.Windows.Forms.Button b_MainDishes;
        private System.Windows.Forms.Button b_Desserts;
        private System.Windows.Forms.Button b_Drinks;
    }
}