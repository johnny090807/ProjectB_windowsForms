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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // Reservation
            // 
            this.ClientSize = new System.Drawing.Size(298, 280);
            this.Name = "Reservation";
=======
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SeatsComboBox = new System.Windows.Forms.ComboBox();
            this.restaurantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.luxeFoodsDataSet = new Luxefoods_WindowsForms.LuxeFoodsDataSet();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.layoutPicture = new System.Windows.Forms.PictureBox();
            this.AvailabilityTable = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox2223 = new System.Windows.Forms.ListBox();
            this.listBox2122 = new System.Windows.Forms.ListBox();
            this.listBox1718 = new System.Windows.Forms.ListBox();
            this.listBox2021 = new System.Windows.Forms.ListBox();
            this.listBox1920 = new System.Windows.Forms.ListBox();
            this.listBox1819 = new System.Windows.Forms.ListBox();
            this.listBox1617 = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luxeFoodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPicture)).BeginInit();
            this.AvailabilityTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 305);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 29);
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
            this.SeatsComboBox.Location = new System.Drawing.Point(384, 218);
            this.SeatsComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SeatsComboBox.Name = "SeatsComboBox";
            this.SeatsComboBox.Size = new System.Drawing.Size(272, 32);
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
            this.availabilityButton.AutoSize = true;
            this.availabilityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.availabilityButton.BackColor = System.Drawing.Color.Transparent;
            this.availabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availabilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.availabilityButton.ForeColor = System.Drawing.Color.White;
            this.availabilityButton.Location = new System.Drawing.Point(507, 343);
            this.availabilityButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(212, 41);
            this.availabilityButton.TabIndex = 2;
            this.availabilityButton.Text = "Check Availability";
            this.availabilityButton.UseVisualStyleBackColor = false;
            this.availabilityButton.Click += new System.EventHandler(this.availabilityButton_Click);
            // 
            // layoutPicture
            // 
            this.layoutPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.layoutPicture.Image = ((System.Drawing.Image)(resources.GetObject("layoutPicture.Image")));
            this.layoutPicture.Location = new System.Drawing.Point(770, 81);
            this.layoutPicture.Margin = new System.Windows.Forms.Padding(2);
            this.layoutPicture.Name = "layoutPicture";
            this.layoutPicture.Size = new System.Drawing.Size(455, 298);
            this.layoutPicture.TabIndex = 5;
            this.layoutPicture.TabStop = false;
            // 
            // AvailabilityTable
            // 
            this.AvailabilityTable.AutoSize = true;
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
            this.AvailabilityTable.Controls.Add(this.label4, 1, 0);
            this.AvailabilityTable.Controls.Add(this.label5, 2, 0);
            this.AvailabilityTable.Controls.Add(this.label7, 4, 0);
            this.AvailabilityTable.Controls.Add(this.label9, 5, 0);
            this.AvailabilityTable.Controls.Add(this.label8, 6, 0);
            this.AvailabilityTable.Controls.Add(this.label6, 3, 0);
            this.AvailabilityTable.Controls.Add(this.label3, 0, 0);
            this.AvailabilityTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.AvailabilityTable.ForeColor = System.Drawing.Color.White;
            this.AvailabilityTable.Location = new System.Drawing.Point(10, 391);
            this.AvailabilityTable.Margin = new System.Windows.Forms.Padding(2);
            this.AvailabilityTable.Name = "AvailabilityTable";
            this.AvailabilityTable.RowCount = 1;
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AvailabilityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.AvailabilityTable.Size = new System.Drawing.Size(1239, 33);
            this.AvailabilityTable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(179, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "17:00-18:00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(355, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "18:00-19:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(707, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "20:00-21:00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label9.Location = new System.Drawing.Point(883, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "21:00-22:00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(1059, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "22:00-23:00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(531, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "19:00-20:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "16:00-17:00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.BackColor = System.Drawing.Color.Transparent;
            this.PeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PeopleLabel.ForeColor = System.Drawing.Color.White;
            this.PeopleLabel.Location = new System.Drawing.Point(10, 218);
            this.PeopleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(314, 29);
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
            this.PlaceReservationButton.Location = new System.Drawing.Point(1032, 673);
            this.PlaceReservationButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceReservationButton.Name = "PlaceReservationButton";
            this.PlaceReservationButton.Size = new System.Drawing.Size(220, 41);
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
            this.AvailableLabel.Location = new System.Drawing.Point(8, 348);
            this.AvailableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(194, 31);
            this.AvailableLabel.TabIndex = 20;
            this.AvailableLabel.Text = "Available Tables";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LocationLabel.ForeColor = System.Drawing.Color.White;
            this.LocationLabel.Location = new System.Drawing.Point(9, 184);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(181, 29);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Which location?";
            // 
            // restaurantComboCox
            // 
            this.restaurantComboCox.BackColor = System.Drawing.Color.Black;
            this.restaurantComboCox.DataSource = this.restaurantBindingSource;
            this.restaurantComboCox.DisplayMember = "naam";
            this.restaurantComboCox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurantComboCox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.restaurantComboCox.ForeColor = System.Drawing.Color.White;
            this.restaurantComboCox.FormattingEnabled = true;
            this.restaurantComboCox.Location = new System.Drawing.Point(384, 179);
            this.restaurantComboCox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.restaurantComboCox.Name = "restaurantComboCox";
            this.restaurantComboCox.Size = new System.Drawing.Size(272, 32);
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
            this.AreaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AreaLabel.ForeColor = System.Drawing.Color.White;
            this.AreaLabel.Location = new System.Drawing.Point(8, 256);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(293, 29);
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
            this.AreaComboBox.Location = new System.Drawing.Point(384, 256);
            this.AreaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(272, 32);
            this.AreaComboBox.TabIndex = 21;
            this.AreaComboBox.Text = "Select area";
            // 
            // Reservation_page_title
            // 
            this.Reservation_page_title.AutoSize = true;
            this.Reservation_page_title.BackColor = System.Drawing.Color.Transparent;
            this.Reservation_page_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.Reservation_page_title.ForeColor = System.Drawing.Color.White;
            this.Reservation_page_title.Location = new System.Drawing.Point(114, 81);
            this.Reservation_page_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reservation_page_title.Name = "Reservation_page_title";
            this.Reservation_page_title.Size = new System.Drawing.Size(363, 39);
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
            this.tableLayoutPanel1.Controls.Add(this.listBox2122, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1718, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox2021, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1920, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1819, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1617, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 428);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 233);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // listBox2223
            // 
            this.listBox2223.BackColor = System.Drawing.Color.Black;
            this.listBox2223.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2223.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2223.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox2223.ForeColor = System.Drawing.Color.White;
            this.listBox2223.FormattingEnabled = true;
            this.listBox2223.ItemHeight = 20;
            this.listBox2223.Location = new System.Drawing.Point(1064, 2);
            this.listBox2223.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox2223.Name = "listBox2223";
            this.listBox2223.Size = new System.Drawing.Size(173, 231);
            this.listBox2223.TabIndex = 0;
            this.listBox2223.SelectedIndexChanged += new System.EventHandler(this.listBox2223_SelectedIndexChanged);
            // 
            // listBox2122
            // 
            this.listBox2122.BackColor = System.Drawing.Color.Black;
            this.listBox2122.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2122.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2122.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox2122.ForeColor = System.Drawing.Color.White;
            this.listBox2122.FormattingEnabled = true;
            this.listBox2122.ItemHeight = 20;
            this.listBox2122.Location = new System.Drawing.Point(887, 2);
            this.listBox2122.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox2122.Name = "listBox2122";
            this.listBox2122.Size = new System.Drawing.Size(173, 231);
            this.listBox2122.TabIndex = 0;
            this.listBox2122.SelectedIndexChanged += new System.EventHandler(this.listBox2122_SelectedIndexChanged);
            // 
            // listBox1718
            // 
            this.listBox1718.BackColor = System.Drawing.Color.Black;
            this.listBox1718.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1718.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1718.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1718.ForeColor = System.Drawing.Color.White;
            this.listBox1718.FormattingEnabled = true;
            this.listBox1718.ItemHeight = 20;
            this.listBox1718.Location = new System.Drawing.Point(179, 2);
            this.listBox1718.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox1718.Name = "listBox1718";
            this.listBox1718.Size = new System.Drawing.Size(173, 231);
            this.listBox1718.TabIndex = 0;
            this.listBox1718.SelectedIndexChanged += new System.EventHandler(this.listBox1718_SelectedIndexChanged);
            // 
            // listBox2021
            // 
            this.listBox2021.BackColor = System.Drawing.Color.Black;
            this.listBox2021.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2021.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2021.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox2021.ForeColor = System.Drawing.Color.White;
            this.listBox2021.FormattingEnabled = true;
            this.listBox2021.ItemHeight = 20;
            this.listBox2021.Location = new System.Drawing.Point(710, 2);
            this.listBox2021.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox2021.Name = "listBox2021";
            this.listBox2021.Size = new System.Drawing.Size(173, 231);
            this.listBox2021.TabIndex = 0;
            this.listBox2021.SelectedIndexChanged += new System.EventHandler(this.listBox2021_SelectedIndexChanged);
            // 
            // listBox1920
            // 
            this.listBox1920.BackColor = System.Drawing.Color.Black;
            this.listBox1920.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1920.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1920.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1920.ForeColor = System.Drawing.Color.White;
            this.listBox1920.FormattingEnabled = true;
            this.listBox1920.ItemHeight = 20;
            this.listBox1920.Location = new System.Drawing.Point(533, 2);
            this.listBox1920.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox1920.Name = "listBox1920";
            this.listBox1920.Size = new System.Drawing.Size(173, 231);
            this.listBox1920.TabIndex = 0;
            this.listBox1920.SelectedIndexChanged += new System.EventHandler(this.listBox1920_SelectedIndexChanged);
            // 
            // listBox1819
            // 
            this.listBox1819.BackColor = System.Drawing.Color.Black;
            this.listBox1819.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1819.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1819.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1819.ForeColor = System.Drawing.Color.White;
            this.listBox1819.FormattingEnabled = true;
            this.listBox1819.ItemHeight = 20;
            this.listBox1819.Location = new System.Drawing.Point(356, 2);
            this.listBox1819.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox1819.Name = "listBox1819";
            this.listBox1819.Size = new System.Drawing.Size(173, 231);
            this.listBox1819.TabIndex = 0;
            this.listBox1819.SelectedIndexChanged += new System.EventHandler(this.listBox1819_SelectedIndexChanged);
            // 
            // listBox1617
            // 
            this.listBox1617.BackColor = System.Drawing.Color.Black;
            this.listBox1617.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1617.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1617.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1617.ForeColor = System.Drawing.Color.White;
            this.listBox1617.FormattingEnabled = true;
            this.listBox1617.ItemHeight = 20;
            this.listBox1617.Location = new System.Drawing.Point(2, 2);
            this.listBox1617.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.listBox1617.Name = "listBox1617";
            this.listBox1617.Size = new System.Drawing.Size(173, 231);
            this.listBox1617.TabIndex = 0;
            this.listBox1617.SelectedIndexChanged += new System.EventHandler(this.listBox1617_SelectedIndexChanged);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 78);
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
            this.MenuButton.Location = new System.Drawing.Point(336, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(134, 78);
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
            this.CheckReservationsBtn.Location = new System.Drawing.Point(470, 0);
            this.CheckReservationsBtn.Name = "CheckReservationsBtn";
            this.CheckReservationsBtn.Size = new System.Drawing.Size(193, 78);
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
            this.ReservationsBtn.Location = new System.Drawing.Point(663, 0);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(221, 78);
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
            this.AboutBtn.Location = new System.Drawing.Point(884, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(132, 78);
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
            this.ContactBtn.Location = new System.Drawing.Point(1016, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(132, 78);
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
            this.FullscreenBtn.Location = new System.Drawing.Point(1225, 0);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(28, 26);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(1198, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 26);
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
            this.ExitBtn.Location = new System.Drawing.Point(1252, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(28, 26);
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
            this.LuxeFoodsLogoLabel.Name = "LuxeFoodsLogoLabel";
            this.LuxeFoodsLogoLabel.Size = new System.Drawing.Size(258, 78);
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
            this.LoginBtn.Location = new System.Drawing.Point(1148, 0);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(132, 78);
            this.LoginBtn.TabIndex = 31;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.loginButton_LinkClicked);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Reservation_page_title);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.PlaceReservationButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.AvailabilityTable);
            this.Controls.Add(this.layoutPicture);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.restaurantComboCox);
            this.Controls.Add(this.SeatsComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1279, 692);
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
            ((System.ComponentModel.ISupportInitialize)(this.restaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveringBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
>>>>>>> dc8f0177a3b4853507edef8dc0f2e635ce0c676b
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1920;
        private System.Windows.Forms.ListBox listBox1819;
        private System.Windows.Forms.ListBox listBox1718;
        private System.Windows.Forms.ListBox listBox2021;
        private System.Windows.Forms.ListBox listBox2122;
        private System.Windows.Forms.ListBox listBox2223;
        private System.Windows.Forms.ListBox listBox1617;
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
    }
}