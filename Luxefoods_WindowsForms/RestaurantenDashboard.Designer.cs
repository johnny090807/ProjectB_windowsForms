namespace Luxefoods_WindowsForms
{
    partial class RestaurantenDashboard
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
            this.restaurantListBox = new System.Windows.Forms.ListBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.editMenuButton = new System.Windows.Forms.Button();
            this.createNewItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantListBox
            // 
            this.restaurantListBox.FormattingEnabled = true;
            this.restaurantListBox.Location = new System.Drawing.Point(108, 174);
            this.restaurantListBox.Name = "restaurantListBox";
            this.restaurantListBox.Size = new System.Drawing.Size(293, 446);
            this.restaurantListBox.TabIndex = 1;
            this.restaurantListBox.SelectedIndexChanged += new System.EventHandler(this.restaurantListBox_SelectedIndexChanged);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(137, 58);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 17;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // editMenuButton
            // 
            this.editMenuButton.Location = new System.Drawing.Point(648, 174);
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Size = new System.Drawing.Size(212, 78);
            this.editMenuButton.TabIndex = 18;
            this.editMenuButton.Text = "EDIT RESTAURANT";
            this.editMenuButton.UseVisualStyleBackColor = true;
            this.editMenuButton.Click += new System.EventHandler(this.editMenuButton_Click);
            // 
            // createNewItemButton
            // 
            this.createNewItemButton.Location = new System.Drawing.Point(649, 399);
            this.createNewItemButton.Name = "createNewItemButton";
            this.createNewItemButton.Size = new System.Drawing.Size(211, 93);
            this.createNewItemButton.TabIndex = 19;
            this.createNewItemButton.Text = "Create New Restaurant";
            this.createNewItemButton.UseVisualStyleBackColor = true;
            this.createNewItemButton.Click += new System.EventHandler(this.createNewItemButton_Click);
            // 
            // RestaurantenDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 707);
            this.Controls.Add(this.createNewItemButton);
            this.Controls.Add(this.editMenuButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.restaurantListBox);
            this.Name = "RestaurantenDashboard";
            this.Text = "RestaurantenDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox restaurantListBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button editMenuButton;
        private System.Windows.Forms.Button createNewItemButton;
    }
}