namespace Luxefoods_WindowsForms
{
    partial class SearchPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchResultsList = new System.Windows.Forms.ListBox();
            this.EditReservationButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Option";
            // 
            // searchResultsList
            // 
            this.searchResultsList.BackColor = System.Drawing.Color.Black;
            this.searchResultsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsList.ForeColor = System.Drawing.Color.White;
            this.searchResultsList.FormattingEnabled = true;
            this.searchResultsList.ItemHeight = 24;
            this.searchResultsList.Location = new System.Drawing.Point(39, 198);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(1823, 796);
            this.searchResultsList.TabIndex = 2;
            this.searchResultsList.SelectedIndexChanged += new System.EventHandler(this.searchResultsList_SelectedIndexChanged);
            // 
            // EditReservationButton
            // 
            this.EditReservationButton.BackColor = System.Drawing.Color.Coral;
            this.EditReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.EditReservationButton.ForeColor = System.Drawing.Color.White;
            this.EditReservationButton.Location = new System.Drawing.Point(1546, 1156);
            this.EditReservationButton.Name = "EditReservationButton";
            this.EditReservationButton.Size = new System.Drawing.Size(335, 83);
            this.EditReservationButton.TabIndex = 3;
            this.EditReservationButton.Text = "Edit Reservation";
            this.EditReservationButton.UseVisualStyleBackColor = false;
            this.EditReservationButton.Click += new System.EventHandler(this.EditReservationButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.BackColor = System.Drawing.Color.Black;
            this.SearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SearchComboBox.ForeColor = System.Drawing.Color.White;
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Name",
            "ID",
            "E-Mail",
            "Phone Number"});
            this.SearchComboBox.Location = new System.Drawing.Point(526, 47);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(231, 39);
            this.SearchComboBox.TabIndex = 16;
            this.SearchComboBox.Text = "Search User By:";
            this.SearchComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1218, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 39);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // inputField
            // 
            this.inputField.BackColor = System.Drawing.Color.Black;
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.inputField.ForeColor = System.Drawing.Color.White;
            this.inputField.Location = new System.Drawing.Point(776, 47);
            this.inputField.MaxLength = 250;
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(419, 38);
            this.inputField.TabIndex = 14;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(313, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(162, 47);
            this.goBackButton.TabIndex = 17;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 44);
            this.label3.TabIndex = 24;
            this.label3.Text = "LuxeFoods";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1809, 32);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 61);
            this.MinimizeButton.TabIndex = 26;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(1857, 32);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(55, 61);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.BackColor = System.Drawing.Color.Coral;
            this.EditOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.EditOrderButton.Location = new System.Drawing.Point(1441, 135);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(255, 47);
            this.EditOrderButton.TabIndex = 27;
            this.EditOrderButton.Text = "Edit Reservation";
            this.EditOrderButton.UseVisualStyleBackColor = false;
            this.EditOrderButton.Click += new System.EventHandler(this.EditReservationButton_Click);
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1925, 1100);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.EditReservationButton);
            this.Controls.Add(this.searchResultsList);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox searchResultsList;
        private System.Windows.Forms.Button EditReservationButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Button EditOrderButton;
    }
}