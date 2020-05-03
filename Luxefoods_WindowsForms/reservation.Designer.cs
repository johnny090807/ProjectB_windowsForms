namespace Luxefoods_WindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Seats = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luxeFoodsDataSet = new Luxefoods_WindowsForms.LuxeFoodsDataSet();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutUsButton = new System.Windows.Forms.LinkLabel();
            this.reservationsButton = new System.Windows.Forms.LinkLabel();
            this.menuButton = new System.Windows.Forms.LinkLabel();
            this.contactUsButton = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.restaurantSelection = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantTableAdapter = new Luxefoods_WindowsForms.LuxeFoodsDataSetTableAdapters.restaurantTableAdapter();
            this.reserveringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveringTableAdapter = new Luxefoods_WindowsForms.LuxeFoodsDataSetTableAdapters.reserveringTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AvailabilityTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 503);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(505, 53);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Seats
            // 
            this.Seats.BackColor = System.Drawing.Color.Black;
            this.Seats.ForeColor = System.Drawing.Color.White;
            this.Seats.FormattingEnabled = true;
            this.Seats.Items.AddRange(new object[] {
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
            this.Seats.Location = new System.Drawing.Point(605, 403);
            this.Seats.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(351, 54);
            this.Seats.TabIndex = 1;
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
            this.availabilityButton.ForeColor = System.Drawing.Color.White;
            this.availabilityButton.Location = new System.Drawing.Point(605, 505);
            this.availabilityButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(351, 52);
            this.availabilityButton.TabIndex = 2;
            this.availabilityButton.Text = "Check Availability";
            this.availabilityButton.UseVisualStyleBackColor = false;
            this.availabilityButton.Click += new System.EventHandler(this.availabilityButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1013, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 545);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AvailabilityTable
            // 
            this.AvailabilityTable.BackColor = System.Drawing.Color.Black;
            this.AvailabilityTable.ColumnCount = 8;
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AvailabilityTable.Controls.Add(this.label9, 6, 0);
            this.AvailabilityTable.Controls.Add(this.label7, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label3, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label4, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 3, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label8, 7, 0);
            this.AvailabilityTable.Controls.Add(this.label10, 0, 1);
            this.AvailabilityTable.Controls.Add(this.label12, 0, 2);
            this.AvailabilityTable.Controls.Add(this.label13, 0, 3);
            this.AvailabilityTable.Controls.Add(this.label14, 0, 4);
            this.AvailabilityTable.Controls.Add(this.label15, 0, 5);
            this.AvailabilityTable.Controls.Add(this.label11, 0, 6);
            this.AvailabilityTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.AvailabilityTable.ForeColor = System.Drawing.Color.White;
            this.AvailabilityTable.Location = new System.Drawing.Point(23, 702);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 7;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AvailabilityTable.Size = new System.Drawing.Size(1748, 394);
            this.AvailabilityTable.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1311, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 40);
            this.label9.TabIndex = 12;
            this.label9.Text = "21:00-22:00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1093, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 40);
            this.label7.TabIndex = 10;
            this.label7.Text = "20:00-21:00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "16:00-17:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "17:00-18:00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "18:00-19:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "19:00-20:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1529, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 40);
            this.label8.TabIndex = 11;
            this.label8.Text = "22:00-23:00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 40);
            this.label10.TabIndex = 13;
            this.label10.Text = "Area 1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 40);
            this.label12.TabIndex = 15;
            this.label12.Text = "Area 2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 40);
            this.label13.TabIndex = 16;
            this.label13.Text = "Area 3";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 40);
            this.label14.TabIndex = 17;
            this.label14.Text = "Area 4";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 40);
            this.label15.TabIndex = 18;
            this.label15.Text = "Area 5";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 40);
            this.label11.TabIndex = 14;
            this.label11.Text = "Area 6";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "How many people will dine?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1925, 1282);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1713, 40);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(48, 51);
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
            this.MinimizeButton.Location = new System.Drawing.Point(1658, 40);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 51);
            this.MinimizeButton.TabIndex = 12;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_Hover_Enter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_Hover_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1316, 1102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "Place Reservation";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 64);
            this.label2.TabIndex = 14;
            this.label2.Text = "LuxeFoods";
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.aboutUsButton.AutoSize = true;
            this.aboutUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.aboutUsButton.LinkColor = System.Drawing.Color.White;
            this.aboutUsButton.Location = new System.Drawing.Point(399, 45);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(178, 46);
            this.aboutUsButton.TabIndex = 15;
            this.aboutUsButton.TabStop = true;
            this.aboutUsButton.Text = "About us";
            this.aboutUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsButton_LinkClicked);
            // 
            // reservationsButton
            // 
            this.reservationsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.reservationsButton.AutoSize = true;
            this.reservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.reservationsButton.LinkColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(637, 45);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(252, 46);
            this.reservationsButton.TabIndex = 16;
            this.reservationsButton.TabStop = true;
            this.reservationsButton.Text = "Reservations";
            this.reservationsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reservationsButton_LinkClicked);
            // 
            // menuButton
            // 
            this.menuButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.menuButton.LinkColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(1217, 48);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(119, 46);
            this.menuButton.TabIndex = 17;
            this.menuButton.TabStop = true;
            this.menuButton.Text = "Menu";
            // 
            // contactUsButton
            // 
            this.contactUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.contactUsButton.AutoSize = true;
            this.contactUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.contactUsButton.LinkColor = System.Drawing.Color.White;
            this.contactUsButton.Location = new System.Drawing.Point(948, 45);
            this.contactUsButton.Name = "contactUsButton";
            this.contactUsButton.Size = new System.Drawing.Size(212, 46);
            this.contactUsButton.TabIndex = 18;
            this.contactUsButton.TabStop = true;
            this.contactUsButton.Text = "Contact us";
            this.contactUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactUsButton_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.loginButton.LinkColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(1414, 45);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 46);
            this.loginButton.TabIndex = 19;
            this.loginButton.TabStop = true;
            this.loginButton.Text = "Login";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 635);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(311, 46);
            this.label16.TabIndex = 20;
            this.label16.Text = "Available Tables";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(25, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 46);
            this.label17.TabIndex = 8;
            this.label17.Text = "Which location?";
            // 
            // restaurantSelection
            // 
            this.restaurantSelection.BackColor = System.Drawing.Color.Black;
            this.restaurantSelection.DataSource = this.restaurantBindingSource;
            this.restaurantSelection.DisplayMember = "naam";
            this.restaurantSelection.ForeColor = System.Drawing.Color.White;
            this.restaurantSelection.FormattingEnabled = true;
            this.restaurantSelection.Location = new System.Drawing.Point(605, 319);
            this.restaurantSelection.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.restaurantSelection.Name = "restaurantSelection";
            this.restaurantSelection.Size = new System.Drawing.Size(351, 54);
            this.restaurantSelection.TabIndex = 1;
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
            // Reservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1800, 1200);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.contactUsButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailabilityTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.restaurantSelection);
            this.Controls.Add(this.Seats);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AvailabilityTable.ResumeLayout(false);
            this.AvailabilityTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Seats;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel AvailabilityTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel aboutUsButton;
        private System.Windows.Forms.LinkLabel reservationsButton;
        private System.Windows.Forms.LinkLabel menuButton;
        private System.Windows.Forms.LinkLabel contactUsButton;
        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox restaurantSelection;
        private LuxeFoodsDataSet luxeFoodsDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private LuxeFoodsDataSetTableAdapters.restaurantTableAdapter restaurantTableAdapter;
        private System.Windows.Forms.BindingSource reserveringBindingSource;
        private LuxeFoodsDataSetTableAdapters.reserveringTableAdapter reserveringTableAdapter;
        private System.Windows.Forms.BindingSource restaurantBindingSource1;
    }
}