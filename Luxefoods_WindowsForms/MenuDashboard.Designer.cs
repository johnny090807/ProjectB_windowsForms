namespace Luxefoods_WindowsForms
{
    partial class MenuDashboard
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
            this.menuItemsList = new System.Windows.Forms.ListBox();
            this.editMenuButton = new System.Windows.Forms.Button();
            this.createNewItemButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurantListBox
            // 
            this.restaurantListBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.restaurantListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.restaurantListBox.FormattingEnabled = true;
            this.restaurantListBox.ItemHeight = 24;
            this.restaurantListBox.Location = new System.Drawing.Point(32, 146);
            this.restaurantListBox.Name = "restaurantListBox";
            this.restaurantListBox.Size = new System.Drawing.Size(293, 436);
            this.restaurantListBox.TabIndex = 0;
            this.restaurantListBox.SelectedIndexChanged += new System.EventHandler(this.restaurantListBox_SelectedIndexChanged);
            // 
            // menuItemsList
            // 
            this.menuItemsList.BackColor = System.Drawing.SystemColors.InfoText;
            this.menuItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemsList.ForeColor = System.Drawing.SystemColors.Window;
            this.menuItemsList.FormattingEnabled = true;
            this.menuItemsList.ItemHeight = 24;
            this.menuItemsList.Location = new System.Drawing.Point(445, 146);
            this.menuItemsList.Name = "menuItemsList";
            this.menuItemsList.Size = new System.Drawing.Size(697, 580);
            this.menuItemsList.TabIndex = 1;
            this.menuItemsList.SelectedIndexChanged += new System.EventHandler(this.menuItemsList_SelectedIndexChanged);
            // 
            // editMenuButton
            // 
            this.editMenuButton.BackColor = System.Drawing.Color.Black;
            this.editMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editMenuButton.Location = new System.Drawing.Point(1266, 146);
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Size = new System.Drawing.Size(272, 78);
            this.editMenuButton.TabIndex = 2;
            this.editMenuButton.Text = "EDIT MENU";
            this.editMenuButton.UseVisualStyleBackColor = false;
            this.editMenuButton.Click += new System.EventHandler(this.EditMenuButton_Click);
            // 
            // createNewItemButton
            // 
            this.createNewItemButton.BackColor = System.Drawing.Color.Black;
            this.createNewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewItemButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createNewItemButton.Location = new System.Drawing.Point(1267, 352);
            this.createNewItemButton.Name = "createNewItemButton";
            this.createNewItemButton.Size = new System.Drawing.Size(271, 86);
            this.createNewItemButton.TabIndex = 4;
            this.createNewItemButton.Text = "Create New Gerecht";
            this.createNewItemButton.UseVisualStyleBackColor = false;
            this.createNewItemButton.Click += new System.EventHandler(this.createNewItemButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(32, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 16;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // MenuDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1623, 940);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.createNewItemButton);
            this.Controls.Add(this.editMenuButton);
            this.Controls.Add(this.menuItemsList);
            this.Controls.Add(this.restaurantListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDashboard";
            this.Text = "MenuDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox restaurantListBox;
        private System.Windows.Forms.ListBox menuItemsList;
        private System.Windows.Forms.Button editMenuButton;
        private System.Windows.Forms.Button createNewItemButton;
        private System.Windows.Forms.Button goBackButton;
    }
}