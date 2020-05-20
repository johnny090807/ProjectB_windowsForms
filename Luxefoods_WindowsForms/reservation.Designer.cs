﻿namespace Luxefoods_WindowsForms
{
    partial class Reservation
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SeatsComboBox = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luxeFoodsDataSet = new Luxefoods_WindowsForms.LuxeFoodsDataSet();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.layoutPicture = new System.Windows.Forms.PictureBox();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.PlaceReservationButton = new System.Windows.Forms.Button();
            this.LuxeFoodsLogoLabel = new System.Windows.Forms.Label();
            this.aboutUsButton = new System.Windows.Forms.LinkLabel();
            this.reservationsButton = new System.Windows.Forms.LinkLabel();
            this.menuButton = new System.Windows.Forms.LinkLabel();
            this.contactUsButton = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.LinkLabel();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.restaurantComboCox = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantTableAdapter = new Luxefoods_WindowsForms.LuxeFoodsDataSetTableAdapters.restaurantTableAdapter();
            this.reserveringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveringTableAdapter = new Luxefoods_WindowsForms.LuxeFoodsDataSetTableAdapters.reserveringTableAdapter();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.Reservation_page_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox2223 = new System.Windows.Forms.ListBox();
            this.listBox1617 = new System.Windows.Forms.ListBox();
            this.listBox2122 = new System.Windows.Forms.ListBox();
            this.listBox1718 = new System.Windows.Forms.ListBox();
            this.listBox2021 = new System.Windows.Forms.ListBox();
            this.listBox1819 = new System.Windows.Forms.ListBox();
            this.listBox1920 = new System.Windows.Forms.ListBox();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPicture)).BeginInit();
            this.AvailabilityTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.Location = new System.Drawing.Point(490, 804);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(666, 38);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // SeatsComboBox
            // 
            this.SeatsComboBox.BackColor = System.Drawing.Color.Black;
            this.SeatsComboBox.DisplayMember = "1";
            this.SeatsComboBox.ForeColor = System.Drawing.Color.White;
            this.SeatsComboBox.FormattingEnabled = true;
            this.SeatsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.SeatsComboBox.Location = new System.Drawing.Point(1030, 546);
            this.SeatsComboBox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.SeatsComboBox.Name = "SeatsComboBox";
            this.SeatsComboBox.Size = new System.Drawing.Size(592, 39);
            this.SeatsComboBox.TabIndex = 1;
            this.SeatsComboBox.Text = "Select amount of seats";
            // 
            // restaurantBindingSource1
            // 
            this.restaurantBindingSource1.DataMember = "restaurant";
            this.restaurantBindingSource1.DataSource = this.luxeFoodsDataSet;
            // 
            // luxeFoodsDataSet
            // 
            this.luxeFoodsDataSet.DataSetName = "LuxeFoodsDataSet";
            this.luxeFoodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availabilityButton
            // 
            this.availabilityButton.BackColor = System.Drawing.Color.Black;
            this.availabilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityButton.ForeColor = System.Drawing.Color.White;
            this.availabilityButton.Location = new System.Drawing.Point(1044, 922);
            this.availabilityButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(580, 87);
            this.availabilityButton.TabIndex = 2;
            this.availabilityButton.Text = "Check Availability";
            this.availabilityButton.UseVisualStyleBackColor = false;
            this.availabilityButton.Click += new System.EventHandler(this.availabilityButton_Click);
            // 
            // layoutPicture
            // 
            this.layoutPicture.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.restaurant_floorplan_example;
            this.layoutPicture.Location = new System.Drawing.Point(1694, 276);
            this.layoutPicture.Name = "layoutPicture";
            this.layoutPicture.Size = new System.Drawing.Size(1138, 708);
            this.layoutPicture.TabIndex = 5;
            this.layoutPicture.TabStop = false;
            // 
            // AvailabilityTable
            // 
            this.AvailabilityTable.BackColor = System.Drawing.Color.Black;
            this.AvailabilityTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.AvailabilityTable.ColumnCount = 7;
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.Controls.Add(this.label3, 0, 0);
            this.AvailabilityTable.Controls.Add(this.label4, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 3, 0);
            this.AvailabilityTable.Controls.Add(this.label7, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label9, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label8, 6, 0);
            this.AvailabilityTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.AvailabilityTable.ForeColor = System.Drawing.Color.White;
            this.AvailabilityTable.Location = new System.Drawing.Point(36, 1042);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 1;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.AvailabilityTable.Size = new System.Drawing.Size(2800, 60);
            this.AvailabilityTable.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "16:00-17:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "17:00-18:00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "18:00-19:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1201, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "19:00-20:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1600, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "20:00-21:00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1999, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "21:00-22:00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2398, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "22:00-23:00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.BackColor = System.Drawing.Color.Black;
            this.PeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleLabel.ForeColor = System.Drawing.Color.White;
            this.PeopleLabel.Location = new System.Drawing.Point(24, 546);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(480, 42);
            this.PeopleLabel.TabIndex = 8;
            this.PeopleLabel.Text = "How many people will dine?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3840, 2160);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(2786, 48);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 37);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_Hover_Enter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_Hover_Leave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(2718, 48);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 37);
            this.MinimizeButton.TabIndex = 12;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_Hover_Enter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_Hover_Leave);
            // 
            // PlaceReservationButton
            // 
            this.PlaceReservationButton.BackColor = System.Drawing.Color.Black;
            this.PlaceReservationButton.ForeColor = System.Drawing.Color.White;
            this.PlaceReservationButton.Location = new System.Drawing.Point(2374, 1678);
            this.PlaceReservationButton.Name = "PlaceReservationButton";
            this.PlaceReservationButton.Size = new System.Drawing.Size(460, 76);
            this.PlaceReservationButton.TabIndex = 13;
            this.PlaceReservationButton.Text = "Place Reservation";
            this.PlaceReservationButton.UseVisualStyleBackColor = false;
            this.PlaceReservationButton.Click += new System.EventHandler(this.PlaceReservationButton_Click);
            // 
            // LuxeFoodsLogoLabel
            // 
            this.LuxeFoodsLogoLabel.AutoSize = true;
            this.LuxeFoodsLogoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.LuxeFoodsLogoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LuxeFoodsLogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuxeFoodsLogoLabel.ForeColor = System.Drawing.Color.White;
            this.LuxeFoodsLogoLabel.Location = new System.Drawing.Point(12, 30);
            this.LuxeFoodsLogoLabel.Name = "LuxeFoodsLogoLabel";
            this.LuxeFoodsLogoLabel.Size = new System.Drawing.Size(351, 73);
            this.LuxeFoodsLogoLabel.TabIndex = 14;
            this.LuxeFoodsLogoLabel.Text = "LuxeFoods";
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.aboutUsButton.AutoSize = true;
            this.aboutUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.aboutUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsButton.LinkColor = System.Drawing.Color.White;
            this.aboutUsButton.Location = new System.Drawing.Point(1809, 55);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(153, 39);
            this.aboutUsButton.TabIndex = 15;
            this.aboutUsButton.TabStop = true;
            this.aboutUsButton.Text = "About us";
            this.aboutUsButton.VisitedLinkColor = System.Drawing.Color.White;
            this.aboutUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsButton_LinkClicked);
            // 
            // reservationsButton
            // 
            this.reservationsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.reservationsButton.AutoSize = true;
            this.reservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.reservationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsButton.LinkColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(1279, 55);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(314, 39);
            this.reservationsButton.TabIndex = 16;
            this.reservationsButton.TabStop = true;
            this.reservationsButton.Text = "Place a reservation";
            this.reservationsButton.VisitedLinkColor = System.Drawing.Color.White;
            this.reservationsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reservationsButton_LinkClicked);
            // 
            // menuButton
            // 
            this.menuButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.LinkColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(616, 55);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(103, 39);
            this.menuButton.TabIndex = 17;
            this.menuButton.TabStop = true;
            this.menuButton.Text = "Menu";
            this.menuButton.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // contactUsButton
            // 
            this.contactUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.contactUsButton.AutoSize = true;
            this.contactUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.contactUsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsButton.LinkColor = System.Drawing.Color.White;
            this.contactUsButton.Location = new System.Drawing.Point(2091, 55);
            this.contactUsButton.Name = "contactUsButton";
            this.contactUsButton.Size = new System.Drawing.Size(183, 39);
            this.contactUsButton.TabIndex = 18;
            this.contactUsButton.TabStop = true;
            this.contactUsButton.Text = "Contact us";
            this.contactUsButton.VisitedLinkColor = System.Drawing.Color.White;
            this.contactUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactUsButton_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.LinkColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(2414, 52);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 42);
            this.loginButton.TabIndex = 19;
            this.loginButton.TabStop = true;
            this.loginButton.Text = "Login";
            this.loginButton.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.BackColor = System.Drawing.Color.Black;
            this.AvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLabel.ForeColor = System.Drawing.Color.White;
            this.AvailableLabel.Location = new System.Drawing.Point(36, 942);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(402, 63);
            this.AvailableLabel.TabIndex = 20;
            this.AvailableLabel.Text = "Available Tables";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Black;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.White;
            this.LocationLabel.Location = new System.Drawing.Point(26, 440);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(282, 42);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Which location?";
            // 
            // restaurantComboCox
            // 
            this.restaurantComboCox.BackColor = System.Drawing.Color.Black;
            this.restaurantComboCox.DataSource = this.restaurantBindingSource;
            this.restaurantComboCox.DisplayMember = "naam";
            this.restaurantComboCox.ForeColor = System.Drawing.Color.White;
            this.restaurantComboCox.FormattingEnabled = true;
            this.restaurantComboCox.Location = new System.Drawing.Point(1030, 440);
            this.restaurantComboCox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.restaurantComboCox.Name = "restaurantComboCox";
            this.restaurantComboCox.Size = new System.Drawing.Size(592, 39);
            this.restaurantComboCox.TabIndex = 1;
            // 
            // restaurantBindingSource
            // 
            this.restaurantBindingSource.DataMember = "restaurant";
            this.restaurantBindingSource.DataSource = this.luxeFoodsDataSet;
            // 
            // restaurantTableAdapter
            // 
            this.restaurantTableAdapter.ClearBeforeFill = true;
            // 
            // reserveringBindingSource
            // 
            this.reserveringBindingSource.DataMember = "reservering";
            this.reserveringBindingSource.DataSource = this.luxeFoodsDataSet;
            // 
            // reserveringTableAdapter
            // 
            this.reserveringTableAdapter.ClearBeforeFill = true;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.BackColor = System.Drawing.Color.Black;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.ForeColor = System.Drawing.Color.White;
            this.AreaLabel.Location = new System.Drawing.Point(26, 658);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(458, 42);
            this.AreaLabel.TabIndex = 8;
            this.AreaLabel.Text = "Which area do you prefer?";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.BackColor = System.Drawing.Color.Black;
            this.AreaComboBox.ForeColor = System.Drawing.Color.White;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Items.AddRange(new object[] {
            "Area 1",
            "Area 2",
            "Area 3",
            "Area 4",
            "Area 5",
            "Area 6"});
            this.AreaComboBox.Location = new System.Drawing.Point(1030, 658);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(592, 39);
            this.AreaComboBox.TabIndex = 21;
            this.AreaComboBox.Text = "Select area";
            // 
            // Reservation_page_title
            // 
            this.Reservation_page_title.BackColor = System.Drawing.Color.Black;
            this.Reservation_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation_page_title.ForeColor = System.Drawing.Color.White;
            this.Reservation_page_title.Location = new System.Drawing.Point(388, 231);
            this.Reservation_page_title.Name = "Reservation_page_title";
            this.Reservation_page_title.Size = new System.Drawing.Size(1006, 123);
            this.Reservation_page_title.TabIndex = 22;
            this.Reservation_page_title.Text = "Place your reservation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.listBox2223, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1617, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox2122, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1718, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox2021, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1819, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1920, 3, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 1108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2800, 528);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // listBox2223
            // 
            this.listBox2223.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2223.BackColor = System.Drawing.Color.Black;
            this.listBox2223.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2223.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2223.ForeColor = System.Drawing.Color.White;
            this.listBox2223.FormattingEnabled = true;
            this.listBox2223.ItemHeight = 20;
            this.listBox2223.Location = new System.Drawing.Point(2403, 3);
            this.listBox2223.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox2223.Name = "listBox2223";
            this.listBox2223.Size = new System.Drawing.Size(394, 520);
            this.listBox2223.TabIndex = 0;
            this.listBox2223.SelectedIndexChanged += new System.EventHandler(this.listBox2223_SelectedIndexChanged);
            // 
            // listBox1617
            // 
            this.listBox1617.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1617.BackColor = System.Drawing.Color.Black;
            this.listBox1617.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1617.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1617.ForeColor = System.Drawing.Color.White;
            this.listBox1617.FormattingEnabled = true;
            this.listBox1617.ItemHeight = 20;
            this.listBox1617.Location = new System.Drawing.Point(3, 3);
            this.listBox1617.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox1617.Name = "listBox1617";
            this.listBox1617.Size = new System.Drawing.Size(394, 520);
            this.listBox1617.TabIndex = 0;
            this.listBox1617.SelectedIndexChanged += new System.EventHandler(this.listBox1617_SelectedIndexChanged);
            // 
            // listBox2122
            // 
            this.listBox2122.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2122.BackColor = System.Drawing.Color.Black;
            this.listBox2122.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2122.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2122.ForeColor = System.Drawing.Color.White;
            this.listBox2122.FormattingEnabled = true;
            this.listBox2122.ItemHeight = 20;
            this.listBox2122.Location = new System.Drawing.Point(2003, 3);
            this.listBox2122.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox2122.Name = "listBox2122";
            this.listBox2122.Size = new System.Drawing.Size(394, 520);
            this.listBox2122.TabIndex = 0;
            this.listBox2122.SelectedIndexChanged += new System.EventHandler(this.listBox2122_SelectedIndexChanged);
            // 
            // listBox1718
            // 
            this.listBox1718.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1718.BackColor = System.Drawing.Color.Black;
            this.listBox1718.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1718.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1718.ForeColor = System.Drawing.Color.White;
            this.listBox1718.FormattingEnabled = true;
            this.listBox1718.ItemHeight = 20;
            this.listBox1718.Location = new System.Drawing.Point(403, 3);
            this.listBox1718.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox1718.Name = "listBox1718";
            this.listBox1718.Size = new System.Drawing.Size(394, 520);
            this.listBox1718.TabIndex = 0;
            this.listBox1718.SelectedIndexChanged += new System.EventHandler(this.listBox1718_SelectedIndexChanged);
            // 
            // listBox2021
            // 
            this.listBox2021.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2021.BackColor = System.Drawing.Color.Black;
            this.listBox2021.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2021.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2021.ForeColor = System.Drawing.Color.White;
            this.listBox2021.FormattingEnabled = true;
            this.listBox2021.ItemHeight = 20;
            this.listBox2021.Location = new System.Drawing.Point(1603, 3);
            this.listBox2021.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox2021.Name = "listBox2021";
            this.listBox2021.Size = new System.Drawing.Size(394, 520);
            this.listBox2021.TabIndex = 0;
            this.listBox2021.SelectedIndexChanged += new System.EventHandler(this.listBox2021_SelectedIndexChanged);
            // 
            // listBox1819
            // 
            this.listBox1819.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1819.BackColor = System.Drawing.Color.Black;
            this.listBox1819.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1819.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1819.ForeColor = System.Drawing.Color.White;
            this.listBox1819.FormattingEnabled = true;
            this.listBox1819.ItemHeight = 20;
            this.listBox1819.Location = new System.Drawing.Point(803, 3);
            this.listBox1819.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox1819.Name = "listBox1819";
            this.listBox1819.Size = new System.Drawing.Size(394, 520);
            this.listBox1819.TabIndex = 0;
            this.listBox1819.SelectedIndexChanged += new System.EventHandler(this.listBox1819_SelectedIndexChanged);
            // 
            // listBox1920
            // 
            this.listBox1920.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1920.BackColor = System.Drawing.Color.Black;
            this.listBox1920.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1920.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1920.ForeColor = System.Drawing.Color.White;
            this.listBox1920.FormattingEnabled = true;
            this.listBox1920.ItemHeight = 20;
            this.listBox1920.Location = new System.Drawing.Point(1203, 3);
            this.listBox1920.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBox1920.Name = "listBox1920";
            this.listBox1920.Size = new System.Drawing.Size(394, 520);
            this.listBox1920.TabIndex = 0;
            this.listBox1920.SelectedIndexChanged += new System.EventHandler(this.listBox1920_SelectedIndexChanged);
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Luxefoods_WindowsForms.Reservation);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(828, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 39);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My reservations";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2884, 1420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Reservation_page_title);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.contactUsButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.LuxeFoodsLogoLabel);
            this.Controls.Add(this.PlaceReservationButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.AvailabilityTable);
            this.Controls.Add(this.layoutPicture);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.restaurantComboCox);
            this.Controls.Add(this.SeatsComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Reservation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPicture)).EndInit();
            this.AvailabilityTable.ResumeLayout(false);
            this.AvailabilityTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox SeatsComboBox;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.PictureBox layoutPicture;
        private System.Windows.Forms.TableLayoutPanel AvailabilityTable;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Button PlaceReservationButton;
        private System.Windows.Forms.Label LuxeFoodsLogoLabel;
        private System.Windows.Forms.LinkLabel aboutUsButton;
        private System.Windows.Forms.LinkLabel reservationsButton;
        private System.Windows.Forms.LinkLabel menuButton;
        private System.Windows.Forms.LinkLabel contactUsButton;
        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox restaurantComboCox;
        private LuxeFoodsDataSet luxeFoodsDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private LuxeFoodsDataSetTableAdapters.restaurantTableAdapter restaurantTableAdapter;
        private System.Windows.Forms.BindingSource reserveringBindingSource;
        private LuxeFoodsDataSetTableAdapters.reserveringTableAdapter reserveringTableAdapter;
        private System.Windows.Forms.BindingSource restaurantBindingSource1;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label Reservation_page_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1920;
        private System.Windows.Forms.ListBox listBox1819;
        private System.Windows.Forms.ListBox listBox1718;
        private System.Windows.Forms.ListBox listBox2021;
        private System.Windows.Forms.ListBox listBox2122;
        private System.Windows.Forms.ListBox listBox2223;
        private System.Windows.Forms.ListBox listBox1617;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}