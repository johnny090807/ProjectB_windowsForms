namespace Luxefoods_WindowsForms
{
    partial class AdminOrderReviewDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrderReviewDashboard));
            this.OrderId = new System.Windows.Forms.Label();
            this.RestaurantPicker = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CustomerId = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.Label();
            this.CustomerPhone = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AcceptChangeButton = new System.Windows.Forms.Button();
            this.CancelChangeButton = new System.Windows.Forms.Button();
            this.EditCustomerInfoButton = new System.Windows.Forms.Button();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.availableSeatsListBox = new System.Windows.Forms.ListBox();
            this.OriginalTimeLabel = new System.Windows.Forms.Label();
            this.OriginalSeatNr = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNoButton = new System.Windows.Forms.Button();
            this.panelYesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.OriginalRestaurantLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderId
            // 
            this.OrderId.AutoSize = true;
            this.OrderId.BackColor = System.Drawing.Color.Black;
            this.OrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderId.ForeColor = System.Drawing.Color.White;
            this.OrderId.Location = new System.Drawing.Point(128, 218);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(143, 42);
            this.OrderId.TabIndex = 0;
            this.OrderId.Text = "OrderId";
            this.OrderId.Click += new System.EventHandler(this.label1_Click);
            // 
            // RestaurantPicker
            // 
            this.RestaurantPicker.BackColor = System.Drawing.Color.Black;
            this.RestaurantPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.RestaurantPicker.ForeColor = System.Drawing.Color.White;
            this.RestaurantPicker.FormattingEnabled = true;
            this.RestaurantPicker.Location = new System.Drawing.Point(98, 385);
            this.RestaurantPicker.Name = "RestaurantPicker";
            this.RestaurantPicker.Size = new System.Drawing.Size(351, 39);
            this.RestaurantPicker.TabIndex = 1;
            this.RestaurantPicker.SelectedIndexChanged += new System.EventHandler(this.RestaurantPicker_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "dddd dd MMM  yyyy  HH:00:00";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(459, 38);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTimePickerKeyPress);
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.ForeColor = System.Drawing.Color.White;
            this.CustomerId.Location = new System.Drawing.Point(27, 56);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(197, 39);
            this.CustomerId.TabIndex = 3;
            this.CustomerId.Text = "CustomerId";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.White;
            this.CustomerName.Location = new System.Drawing.Point(28, 100);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(262, 39);
            this.CustomerName.TabIndex = 4;
            this.CustomerName.Text = "CustomerName";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSize = true;
            this.CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.ForeColor = System.Drawing.Color.White;
            this.CustomerEmail.Location = new System.Drawing.Point(27, 157);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(257, 39);
            this.CustomerEmail.TabIndex = 5;
            this.CustomerEmail.Text = "CustomerEmail";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.AutoSize = true;
            this.CustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhone.ForeColor = System.Drawing.Color.White;
            this.CustomerPhone.Location = new System.Drawing.Point(27, 213);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(268, 39);
            this.CustomerPhone.TabIndex = 6;
            this.CustomerPhone.Text = "CustomerPhone";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(1574, 1136);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(279, 115);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete Order";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(1574, 938);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(279, 115);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit Order";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AcceptChangeButton);
            this.panel1.Controls.Add(this.CancelChangeButton);
            this.panel1.Controls.Add(this.CustomerId);
            this.panel1.Controls.Add(this.CustomerName);
            this.panel1.Controls.Add(this.CustomerEmail);
            this.panel1.Controls.Add(this.CustomerPhone);
            this.panel1.Controls.Add(this.EditCustomerInfoButton);
            this.panel1.Controls.Add(this.customerPhoneTextBox);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.customerEmailTextBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1222, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 502);
            this.panel1.TabIndex = 10;
            // 
            // AcceptChangeButton
            // 
            this.AcceptChangeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AcceptChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.AcceptChangeButton.ForeColor = System.Drawing.Color.White;
            this.AcceptChangeButton.Location = new System.Drawing.Point(328, 404);
            this.AcceptChangeButton.Name = "AcceptChangeButton";
            this.AcceptChangeButton.Size = new System.Drawing.Size(273, 70);
            this.AcceptChangeButton.TabIndex = 9;
            this.AcceptChangeButton.Text = "Accept Change";
            this.AcceptChangeButton.UseVisualStyleBackColor = false;
            this.AcceptChangeButton.Visible = false;
            this.AcceptChangeButton.Click += new System.EventHandler(this.AcceptChangeButton_Click);
            // 
            // CancelChangeButton
            // 
            this.CancelChangeButton.BackColor = System.Drawing.Color.Red;
            this.CancelChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.CancelChangeButton.ForeColor = System.Drawing.Color.White;
            this.CancelChangeButton.Location = new System.Drawing.Point(24, 404);
            this.CancelChangeButton.Name = "CancelChangeButton";
            this.CancelChangeButton.Size = new System.Drawing.Size(271, 70);
            this.CancelChangeButton.TabIndex = 8;
            this.CancelChangeButton.Text = "Cancel Change";
            this.CancelChangeButton.UseVisualStyleBackColor = false;
            this.CancelChangeButton.Visible = false;
            this.CancelChangeButton.Click += new System.EventHandler(this.CancelChangeButton_Click);
            // 
            // EditCustomerInfoButton
            // 
            this.EditCustomerInfoButton.BackColor = System.Drawing.Color.Coral;
            this.EditCustomerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomerInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.EditCustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.EditCustomerInfoButton.Location = new System.Drawing.Point(24, 404);
            this.EditCustomerInfoButton.Name = "EditCustomerInfoButton";
            this.EditCustomerInfoButton.Size = new System.Drawing.Size(323, 70);
            this.EditCustomerInfoButton.TabIndex = 7;
            this.EditCustomerInfoButton.Text = "Edit Customer Info";
            this.EditCustomerInfoButton.UseVisualStyleBackColor = false;
            this.EditCustomerInfoButton.Click += new System.EventHandler(this.EditCustomerInfoButton_Click);
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.BackColor = System.Drawing.Color.Black;
            this.customerPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.customerPhoneTextBox.ForeColor = System.Drawing.Color.White;
            this.customerPhoneTextBox.Location = new System.Drawing.Point(24, 211);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(577, 47);
            this.customerPhoneTextBox.TabIndex = 12;
            this.customerPhoneTextBox.Visible = false;
            this.customerPhoneTextBox.TextChanged += new System.EventHandler(this.customerPhoneTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.Color.Black;
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.customerNameTextBox.ForeColor = System.Drawing.Color.White;
            this.customerNameTextBox.Location = new System.Drawing.Point(24, 98);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(577, 47);
            this.customerNameTextBox.TabIndex = 10;
            this.customerNameTextBox.Visible = false;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.BackColor = System.Drawing.Color.Black;
            this.customerEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.customerEmailTextBox.ForeColor = System.Drawing.Color.White;
            this.customerEmailTextBox.Location = new System.Drawing.Point(24, 155);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(577, 47);
            this.customerEmailTextBox.TabIndex = 11;
            this.customerEmailTextBox.Visible = false;
            this.customerEmailTextBox.TextChanged += new System.EventHandler(this.customerEmailTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 705);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 546);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // availableSeatsListBox
            // 
            this.availableSeatsListBox.BackColor = System.Drawing.Color.Black;
            this.availableSeatsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.availableSeatsListBox.ForeColor = System.Drawing.Color.White;
            this.availableSeatsListBox.FormattingEnabled = true;
            this.availableSeatsListBox.ItemHeight = 31;
            this.availableSeatsListBox.Location = new System.Drawing.Point(846, 532);
            this.availableSeatsListBox.Name = "availableSeatsListBox";
            this.availableSeatsListBox.Size = new System.Drawing.Size(282, 717);
            this.availableSeatsListBox.TabIndex = 12;
            this.availableSeatsListBox.SelectedIndexChanged += new System.EventHandler(this.availableSeatsListBox_SelectedIndexChanged);
            // 
            // OriginalTimeLabel
            // 
            this.OriginalTimeLabel.AutoSize = true;
            this.OriginalTimeLabel.BackColor = System.Drawing.Color.Black;
            this.OriginalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OriginalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.OriginalTimeLabel.Location = new System.Drawing.Point(491, 310);
            this.OriginalTimeLabel.Name = "OriginalTimeLabel";
            this.OriginalTimeLabel.Size = new System.Drawing.Size(174, 31);
            this.OriginalTimeLabel.TabIndex = 13;
            this.OriginalTimeLabel.Text = "Original Time";
            // 
            // OriginalSeatNr
            // 
            this.OriginalSeatNr.AutoSize = true;
            this.OriginalSeatNr.BackColor = System.Drawing.Color.Black;
            this.OriginalSeatNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OriginalSeatNr.ForeColor = System.Drawing.Color.White;
            this.OriginalSeatNr.Location = new System.Drawing.Point(817, 498);
            this.OriginalSeatNr.Name = "OriginalSeatNr";
            this.OriginalSeatNr.Size = new System.Drawing.Size(192, 31);
            this.OriginalSeatNr.TabIndex = 14;
            this.OriginalSeatNr.Text = "OriginalSeatNr";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(269, 27);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 15;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelNoButton);
            this.panel2.Controls.Add(this.panelYesButton);
            this.panel2.Location = new System.Drawing.Point(497, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 179);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure that you want to delete this order?";
            // 
            // panelNoButton
            // 
            this.panelNoButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.panelNoButton.ForeColor = System.Drawing.Color.White;
            this.panelNoButton.Location = new System.Drawing.Point(464, 112);
            this.panelNoButton.Name = "panelNoButton";
            this.panelNoButton.Size = new System.Drawing.Size(85, 45);
            this.panelNoButton.TabIndex = 1;
            this.panelNoButton.Text = "No";
            this.panelNoButton.UseVisualStyleBackColor = false;
            this.panelNoButton.Click += new System.EventHandler(this.panelNoButton_Click);
            // 
            // panelYesButton
            // 
            this.panelYesButton.BackColor = System.Drawing.Color.Red;
            this.panelYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.panelYesButton.ForeColor = System.Drawing.Color.White;
            this.panelYesButton.Location = new System.Drawing.Point(229, 112);
            this.panelYesButton.Name = "panelYesButton";
            this.panelYesButton.Size = new System.Drawing.Size(89, 45);
            this.panelYesButton.TabIndex = 0;
            this.panelYesButton.Text = "Yes";
            this.panelYesButton.UseVisualStyleBackColor = false;
            this.panelYesButton.Click += new System.EventHandler(this.panelYesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 44);
            this.label3.TabIndex = 23;
            this.label3.Text = "LuxeFoods";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1809, 20);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 61);
            this.MinimizeButton.TabIndex = 23;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(1857, 20);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(55, 61);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OriginalRestaurantLabel
            // 
            this.OriginalRestaurantLabel.AutoSize = true;
            this.OriginalRestaurantLabel.BackColor = System.Drawing.Color.Black;
            this.OriginalRestaurantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OriginalRestaurantLabel.ForeColor = System.Drawing.Color.White;
            this.OriginalRestaurantLabel.Location = new System.Drawing.Point(92, 310);
            this.OriginalRestaurantLabel.Name = "OriginalRestaurantLabel";
            this.OriginalRestaurantLabel.Size = new System.Drawing.Size(248, 31);
            this.OriginalRestaurantLabel.TabIndex = 24;
            this.OriginalRestaurantLabel.Text = "Original Restaurant";
            // 
            // AdminOrderReviewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1925, 1282);
            this.Controls.Add(this.OriginalRestaurantLabel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.OriginalSeatNr);
            this.Controls.Add(this.OriginalTimeLabel);
            this.Controls.Add(this.availableSeatsListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RestaurantPicker);
            this.Controls.Add(this.OrderId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminOrderReviewDashboard";
            this.Text = "AdminOrderReviewDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.ComboBox RestaurantPicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CustomerEmail;
        private System.Windows.Forms.Label CustomerPhone;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AcceptChangeButton;
        private System.Windows.Forms.Button CancelChangeButton;
        private System.Windows.Forms.Button EditCustomerInfoButton;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox availableSeatsListBox;
        private System.Windows.Forms.Label OriginalTimeLabel;
        private System.Windows.Forms.Label OriginalSeatNr;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button panelNoButton;
        private System.Windows.Forms.Button panelYesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label OriginalRestaurantLabel;
    }
}