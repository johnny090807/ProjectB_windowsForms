namespace Luxefoods_WindowsForms
{
    partial class RestaurantDashboardCreate
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.CreateItem = new System.Windows.Forms.Button();
            this.restaurantNaamInput = new System.Windows.Forms.TextBox();
            this.restaurantNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 31;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // CreateItem
            // 
            this.CreateItem.BackColor = System.Drawing.Color.ForestGreen;
            this.CreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateItem.ForeColor = System.Drawing.Color.White;
            this.CreateItem.Location = new System.Drawing.Point(475, 31);
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(279, 115);
            this.CreateItem.TabIndex = 32;
            this.CreateItem.Text = "CreateItem";
            this.CreateItem.UseVisualStyleBackColor = false;
            this.CreateItem.Click += new System.EventHandler(this.CreateItem_Click);
            // 
            // restaurantNaamInput
            // 
            this.restaurantNaamInput.Location = new System.Drawing.Point(121, 190);
            this.restaurantNaamInput.Name = "restaurantNaamInput";
            this.restaurantNaamInput.Size = new System.Drawing.Size(258, 20);
            this.restaurantNaamInput.TabIndex = 34;
            // 
            // restaurantNaam
            // 
            this.restaurantNaam.AutoSize = true;
            this.restaurantNaam.Location = new System.Drawing.Point(125, 162);
            this.restaurantNaam.Name = "restaurantNaam";
            this.restaurantNaam.Size = new System.Drawing.Size(96, 13);
            this.restaurantNaam.TabIndex = 33;
            this.restaurantNaam.Text = "Restaurant Naam: ";
            // 
            // RestaurantDashboardCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restaurantNaamInput);
            this.Controls.Add(this.restaurantNaam);
            this.Controls.Add(this.CreateItem);
            this.Controls.Add(this.goBackButton);
            this.Name = "RestaurantDashboardCreate";
            this.Text = "RestaurantDashboardCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button CreateItem;
        private System.Windows.Forms.TextBox restaurantNaamInput;
        private System.Windows.Forms.Label restaurantNaam;
    }
}