namespace Luxefoods_WindowsForms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.restaurantListBox = new System.Windows.Forms.ListBox();
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.EditReservationButton = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Location = new System.Drawing.Point(1004, 48);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.SaddleBrown;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 7D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Customers";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(992, 370);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello Kacper!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(403, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 398);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Restaurant";
            // 
            // restaurantListBox
            // 
            this.restaurantListBox.BackColor = System.Drawing.Color.Black;
            this.restaurantListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.restaurantListBox.FormattingEnabled = true;
            this.restaurantListBox.ItemHeight = 31;
            this.restaurantListBox.Location = new System.Drawing.Point(20, 451);
            this.restaurantListBox.Name = "restaurantListBox";
            this.restaurantListBox.Size = new System.Drawing.Size(361, 283);
            this.restaurantListBox.TabIndex = 8;
            this.restaurantListBox.SelectedIndexChanged += new System.EventHandler(this.listIndexChange);
            // 
            // ordersListBox
            // 
            this.ordersListBox.BackColor = System.Drawing.Color.Black;
            this.ordersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.ItemHeight = 24;
            this.ordersListBox.Location = new System.Drawing.Point(20, 767);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(1810, 364);
            this.ordersListBox.TabIndex = 9;
            this.ordersListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // EditReservationButton
            // 
            this.EditReservationButton.BackColor = System.Drawing.Color.Coral;
            this.EditReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditReservationButton.ForeColor = System.Drawing.Color.White;
            this.EditReservationButton.Location = new System.Drawing.Point(1484, 261);
            this.EditReservationButton.Name = "EditReservationButton";
            this.EditReservationButton.Size = new System.Drawing.Size(319, 75);
            this.EditReservationButton.TabIndex = 10;
            this.EditReservationButton.Text = "Edit Reservation";
            this.EditReservationButton.UseVisualStyleBackColor = false;
            this.EditReservationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputField
            // 
            this.inputField.BackColor = System.Drawing.Color.Black;
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.inputField.ForeColor = System.Drawing.Color.White;
            this.inputField.Location = new System.Drawing.Point(820, 38);
            this.inputField.MaxLength = 250;
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(316, 38);
            this.inputField.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1168, 38);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(116, 39);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.SearchComboBox.Location = new System.Drawing.Point(527, 37);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(262, 39);
            this.SearchComboBox.TabIndex = 13;
            this.SearchComboBox.Text = "Search User By:";
            this.SearchComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // logoutButton
            // 
            this.logoutButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.logoutButton.LinkColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(1617, 44);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(97, 31);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Logout";
            this.logoutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutButton_LinkClicked);
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
            this.label3.TabIndex = 22;
            this.label3.Text = "LuxeFoods";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1790, 24);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 61);
            this.MinimizeButton.TabIndex = 21;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(1838, 24);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(55, 61);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1335, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 48);
            this.button2.TabIndex = 29;
            this.button2.Text = "Restauranten";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2083, 1145);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.EditReservationButton);
            this.Controls.Add(this.ordersListBox);
            this.Controls.Add(this.restaurantListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox restaurantListBox;
        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.Button EditReservationButton;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}