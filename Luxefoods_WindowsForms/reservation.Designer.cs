using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Luxefoods_WindowsForms
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        PrivateFontCollection pfc = new PrivateFontCollection();
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

        /// <summary>
        ///         {
        //Create your private font collection object.
        ///PrivateFontCollection pfc = new PrivateFontCollection();

        //Select your font from the resources.
        //My font here is "Digireu.ttf"
        ///int fontLength = Properties.Resources.Lato_Light.Length;

        // create a buffer to read in to
        ///byte[] fontdata = Properties.Resources.Lato_Light;

        // create an unsafe memory block for the font data
        ///System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

        // copy the bytes to the unsafe memory block
        ///Marshal.Copy(fontdata, 0, data, fontLength);

        // pass the font to the font collection
        /// pfc.AddMemoryFont(data, fontLength);

        ///return pfc.Families;
        /// }s
        /// 
        /// </summary> FontFamily[] importCustomFont()


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
            this.SeatsComboBox = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luxeFoodsDataSet = new Luxefoods_WindowsForms.LuxeFoodsDataSet();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.layoutPicture = new System.Windows.Forms.PictureBox();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.PlaceReservationButton = new System.Windows.Forms.Button();
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
            this.GenerallistBox = new System.Windows.Forms.ListBox();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CheckReservationsBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LuxeFoodsLogoLabel = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.Label();
            this.hourCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 550);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(428, 39);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 20, 10, 56, 39, 0);
            // 
            // SeatsComboBox
            // 
            this.SeatsComboBox.BackColor = System.Drawing.Color.Black;
            this.SeatsComboBox.DisplayMember = "1";
            this.SeatsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeatsComboBox.ForeColor = System.Drawing.Color.White;
            this.SeatsComboBox.FormattingEnabled = true;
            this.SeatsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SeatsComboBox.Location = new System.Drawing.Point(576, 327);
            this.SeatsComboBox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.SeatsComboBox.Name = "SeatsComboBox";
            this.SeatsComboBox.Size = new System.Drawing.Size(406, 40);
            this.SeatsComboBox.TabIndex = 1;
            this.SeatsComboBox.Text = "Select amount of seats";
            this.SeatsComboBox.SelectedIndexChanged += new System.EventHandler(this.SeatsComboBox_SelectedIndexChanged);
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
            this.availabilityButton.AutoSize = true;
            this.availabilityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.availabilityButton.BackColor = System.Drawing.Color.Transparent;
            this.availabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availabilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.availabilityButton.ForeColor = System.Drawing.Color.White;
            this.availabilityButton.Location = new System.Drawing.Point(76, 708);
            this.availabilityButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(311, 52);
            this.availabilityButton.TabIndex = 2;
            this.availabilityButton.Text = "Check Availability";
            this.availabilityButton.UseVisualStyleBackColor = false;
            this.availabilityButton.Click += new System.EventHandler(this.availabilityButton_Click);
            // 
            // layoutPicture
            // 
            this.layoutPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutPicture.Image = ((System.Drawing.Image)(resources.GetObject("layoutPicture.Image")));
            this.layoutPicture.Location = new System.Drawing.Point(1157, 268);
            this.layoutPicture.Name = "layoutPicture";
            this.layoutPicture.Size = new System.Drawing.Size(682, 447);
            this.layoutPicture.TabIndex = 5;
            this.layoutPicture.TabStop = false;
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.BackColor = System.Drawing.Color.Transparent;
            this.PeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PeopleLabel.ForeColor = System.Drawing.Color.White;
            this.PeopleLabel.Location = new System.Drawing.Point(15, 327);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(463, 40);
            this.PeopleLabel.TabIndex = 8;
            this.PeopleLabel.Text = "How many people will dine?";
            // 
            // PlaceReservationButton
            // 
            this.PlaceReservationButton.AutoSize = true;
            this.PlaceReservationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlaceReservationButton.BackColor = System.Drawing.Color.Transparent;
            this.PlaceReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaceReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PlaceReservationButton.ForeColor = System.Drawing.Color.White;
            this.PlaceReservationButton.Location = new System.Drawing.Point(1518, 978);
            this.PlaceReservationButton.Name = "PlaceReservationButton";
            this.PlaceReservationButton.Size = new System.Drawing.Size(321, 52);
            this.PlaceReservationButton.TabIndex = 13;
            this.PlaceReservationButton.Text = "Place Reservation";
            this.PlaceReservationButton.UseVisualStyleBackColor = false;
            this.PlaceReservationButton.Click += new System.EventHandler(this.PlaceReservationButton_Click);
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.AvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AvailableLabel.ForeColor = System.Drawing.Color.White;
            this.AvailableLabel.Location = new System.Drawing.Point(699, 581);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(283, 42);
            this.AvailableLabel.TabIndex = 20;
            this.AvailableLabel.Text = "Available Tables";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LocationLabel.ForeColor = System.Drawing.Color.White;
            this.LocationLabel.Location = new System.Drawing.Point(14, 276);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(271, 40);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Which location?";
            // 
            // restaurantComboCox
            // 
            this.restaurantComboCox.BackColor = System.Drawing.Color.Black;
            this.restaurantComboCox.DataSource = this.restaurantBindingSource;
            this.restaurantComboCox.DisplayMember = "naam";
            this.restaurantComboCox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.restaurantComboCox.ForeColor = System.Drawing.Color.White;
            this.restaurantComboCox.FormattingEnabled = true;
            this.restaurantComboCox.Location = new System.Drawing.Point(576, 268);
            this.restaurantComboCox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.restaurantComboCox.Name = "restaurantComboCox";
            this.restaurantComboCox.Size = new System.Drawing.Size(406, 40);
            this.restaurantComboCox.TabIndex = 1;
            this.restaurantComboCox.SelectedIndexChanged += new System.EventHandler(this.restaurantComboCox_SelectedIndexChanged);
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
            this.AreaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AreaLabel.ForeColor = System.Drawing.Color.White;
            this.AreaLabel.Location = new System.Drawing.Point(12, 384);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(441, 40);
            this.AreaLabel.TabIndex = 8;
            this.AreaLabel.Text = "Which area do you prefer?";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.BackColor = System.Drawing.Color.Black;
            this.AreaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AreaComboBox.ForeColor = System.Drawing.Color.White;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Items.AddRange(new object[] {
            "Area 1",
            "Area 2",
            "Area 3",
            "Area 4",
            "Area 5",
            "Area 6"});
            this.AreaComboBox.Location = new System.Drawing.Point(576, 384);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(406, 40);
            this.AreaComboBox.TabIndex = 21;
            this.AreaComboBox.Text = "Select area";
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // Reservation_page_title
            // 
            this.Reservation_page_title.AutoSize = true;
            this.Reservation_page_title.BackColor = System.Drawing.Color.Transparent;
            this.Reservation_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservation_page_title.ForeColor = System.Drawing.Color.White;
            this.Reservation_page_title.Location = new System.Drawing.Point(648, 130);
            this.Reservation_page_title.Name = "Reservation_page_title";
            this.Reservation_page_title.Size = new System.Drawing.Size(751, 82);
            this.Reservation_page_title.TabIndex = 22;
            this.Reservation_page_title.Text = "Place your reservation";
            // 
            // GenerallistBox
            // 
            this.GenerallistBox.BackColor = System.Drawing.Color.Black;
            this.GenerallistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenerallistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GenerallistBox.ForeColor = System.Drawing.Color.White;
            this.GenerallistBox.FormattingEnabled = true;
            this.GenerallistBox.ItemHeight = 29;
            this.GenerallistBox.Location = new System.Drawing.Point(699, 624);
            this.GenerallistBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.GenerallistBox.Name = "GenerallistBox";
            this.GenerallistBox.Size = new System.Drawing.Size(283, 348);
            this.GenerallistBox.TabIndex = 0;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Luxefoods_WindowsForms.Reservation);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.CheckReservationsBtn);
            this.panel1.Controls.Add(this.ReservationsBtn);
            this.panel1.Controls.Add(this.AboutBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.FullscreenBtn);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.LuxeFoodsLogoLabel);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 117);
            this.panel1.TabIndex = 24;
            // 
            // MenuButton
            // 
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.MenuButton.Location = new System.Drawing.Point(503, 0);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(201, 117);
            this.MenuButton.TabIndex = 26;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.menuButton_LinkClicked);
            // 
            // CheckReservationsBtn
            // 
            this.CheckReservationsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckReservationsBtn.FlatAppearance.BorderSize = 0;
            this.CheckReservationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CheckReservationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CheckReservationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckReservationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckReservationsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CheckReservationsBtn.Location = new System.Drawing.Point(704, 0);
            this.CheckReservationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckReservationsBtn.Name = "CheckReservationsBtn";
            this.CheckReservationsBtn.Size = new System.Drawing.Size(290, 117);
            this.CheckReservationsBtn.TabIndex = 27;
            this.CheckReservationsBtn.Text = "My reservations";
            this.CheckReservationsBtn.UseVisualStyleBackColor = true;
            this.CheckReservationsBtn.Click += new System.EventHandler(this.linkLabel1_LinkClicked);
            // 
            // ReservationsBtn
            // 
            this.ReservationsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReservationsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReservationsBtn.FlatAppearance.BorderSize = 0;
            this.ReservationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ReservationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ReservationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ReservationsBtn.Location = new System.Drawing.Point(994, 0);
            this.ReservationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(332, 117);
            this.ReservationsBtn.TabIndex = 28;
            this.ReservationsBtn.Text = "Place a reservation";
            this.ReservationsBtn.UseVisualStyleBackColor = false;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AboutBtn.Location = new System.Drawing.Point(1326, 0);
            this.AboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(198, 117);
            this.AboutBtn.TabIndex = 29;
            this.AboutBtn.Text = "About us";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.aboutUsButton_LinkClicked);
            // 
            // ContactBtn
            // 
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ContactBtn.Location = new System.Drawing.Point(1524, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(198, 117);
            this.ContactBtn.TabIndex = 30;
            this.ContactBtn.Text = "Contact us";
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.contactUsButton_LinkClicked);
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.expand;
            this.FullscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FullscreenBtn.FlatAppearance.BorderSize = 0;
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullscreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.Color.White;
            this.FullscreenBtn.Location = new System.Drawing.Point(1838, 0);
            this.FullscreenBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(42, 39);
            this.FullscreenBtn.TabIndex = 34;
            this.FullscreenBtn.UseVisualStyleBackColor = true;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.minimize;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(1797, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(42, 39);
            this.MinimizeBtn.TabIndex = 33;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.logout__1_;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1878, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(42, 39);
            this.ExitBtn.TabIndex = 32;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LuxeFoodsLogoLabel
            // 
            this.LuxeFoodsLogoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LuxeFoodsLogoLabel.FlatAppearance.BorderSize = 0;
            this.LuxeFoodsLogoLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LuxeFoodsLogoLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LuxeFoodsLogoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LuxeFoodsLogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuxeFoodsLogoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.LuxeFoodsLogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LuxeFoodsLogoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.LuxeFoodsLogoLabel.Name = "LuxeFoodsLogoLabel";
            this.LuxeFoodsLogoLabel.Size = new System.Drawing.Size(387, 117);
            this.LuxeFoodsLogoLabel.TabIndex = 25;
            this.LuxeFoodsLogoLabel.Text = "LuxeFoods";
            this.LuxeFoodsLogoLabel.UseVisualStyleBackColor = true;
            this.LuxeFoodsLogoLabel.Click += new System.EventHandler(this.LuxeFoodsLogoLabel_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBtn.Location = new System.Drawing.Point(1722, 0);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(198, 117);
            this.LoginBtn.TabIndex = 31;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.loginButton_LinkClicked);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.BackColor = System.Drawing.Color.Transparent;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.hourLabel.ForeColor = System.Drawing.Color.White;
            this.hourLabel.Location = new System.Drawing.Point(15, 445);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(239, 40);
            this.hourLabel.TabIndex = 8;
            this.hourLabel.Text = "At what hour?";
            // 
            // hourCombobox
            // 
            this.hourCombobox.BackColor = System.Drawing.Color.Black;
            this.hourCombobox.DisplayMember = "1";
            this.hourCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hourCombobox.ForeColor = System.Drawing.Color.White;
            this.hourCombobox.FormattingEnabled = true;
            this.hourCombobox.Items.AddRange(new object[] {
            "16:00-17:00",
            "17:00-18:00",
            "18:00-19:00",
            "19:00-20:00",
            "20:00-21:00",
            "21:00-22:00",
            "22:00-23:00"});
            this.hourCombobox.Location = new System.Drawing.Point(576, 445);
            this.hourCombobox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.hourCombobox.Name = "hourCombobox";
            this.hourCombobox.Size = new System.Drawing.Size(406, 40);
            this.hourCombobox.TabIndex = 1;
            this.hourCombobox.Text = "Select time";
            this.hourCombobox.SelectedIndexChanged += new System.EventHandler(this.hourCombobox_SelectedIndexChanged);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Reservation_page_title);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.PlaceReservationButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.GenerallistBox);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.layoutPicture);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.restaurantComboCox);
            this.Controls.Add(this.hourCombobox);
            this.Controls.Add(this.SeatsComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "Reservation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox SeatsComboBox;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.PictureBox layoutPicture;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Button PlaceReservationButton;
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
        private System.Windows.Forms.ListBox GenerallistBox;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private Panel panel1;
        private Button LuxeFoodsLogoLabel;
        private Button MenuButton;
        private Button CheckReservationsBtn;
        private Button ReservationsBtn;
        private Button AboutBtn;
        private Button LoginBtn;
        private Button ContactBtn;
        private Button FullscreenBtn;
        private Button MinimizeBtn;
        private Button ExitBtn;
        private Label hourLabel;
        private ComboBox hourCombobox;
    }
}