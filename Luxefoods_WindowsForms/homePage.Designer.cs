namespace Luxefoods_WindowsForms
{
    partial class homePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CheckReservationsBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "LuxeFoods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Controls.Add(this.MenuButton);
            this.Header.Controls.Add(this.CheckReservationsBtn);
            this.Header.Controls.Add(this.ReservationsBtn);
            this.Header.Controls.Add(this.AboutBtn);
            this.Header.Controls.Add(this.ContactBtn);
            this.Header.Controls.Add(this.FullscreenBtn);
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.ExitBtn);
            this.Header.Controls.Add(this.HomeBtn);
            this.Header.Controls.Add(this.LoginBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1270, 80);
            this.Header.TabIndex = 48;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.Color.Transparent;
            this.MenuButton.Location = new System.Drawing.Point(326, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(134, 80);
            this.MenuButton.TabIndex = 26;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuClick);
            // 
            // CheckReservationsBtn
            // 
            this.CheckReservationsBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckReservationsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckReservationsBtn.FlatAppearance.BorderSize = 0;
            this.CheckReservationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CheckReservationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CheckReservationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckReservationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckReservationsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CheckReservationsBtn.Location = new System.Drawing.Point(460, 0);
            this.CheckReservationsBtn.Name = "CheckReservationsBtn";
            this.CheckReservationsBtn.Size = new System.Drawing.Size(193, 80);
            this.CheckReservationsBtn.TabIndex = 27;
            this.CheckReservationsBtn.Text = "My reservations";
            this.CheckReservationsBtn.UseVisualStyleBackColor = true;
            this.CheckReservationsBtn.Click += new System.EventHandler(this.CheckReservation);
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
            this.ReservationsBtn.Location = new System.Drawing.Point(653, 0);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(221, 80);
            this.ReservationsBtn.TabIndex = 28;
            this.ReservationsBtn.Text = "Place a reservation";
            this.ReservationsBtn.UseVisualStyleBackColor = false;
            this.ReservationsBtn.Click += new System.EventHandler(this.Reservation);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AboutBtn.Location = new System.Drawing.Point(874, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(132, 80);
            this.AboutBtn.TabIndex = 29;
            this.AboutBtn.Text = "About us";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutClick);
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ContactBtn.Location = new System.Drawing.Point(1006, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(132, 80);
            this.ContactBtn.TabIndex = 30;
            this.ContactBtn.Text = "Contact us";
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.Contact);
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenBtn.BackColor = System.Drawing.Color.Transparent;
            this.FullscreenBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.expand;
            this.FullscreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FullscreenBtn.FlatAppearance.BorderSize = 0;
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FullscreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.Color.White;
            this.FullscreenBtn.Location = new System.Drawing.Point(1215, 0);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.Size = new System.Drawing.Size(28, 26);
            this.FullscreenBtn.TabIndex = 34;
            this.FullscreenBtn.UseVisualStyleBackColor = true;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.minimize;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(1188, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 26);
            this.MinimizeBtn.TabIndex = 33;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.logout__1_;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1242, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(28, 26);
            this.ExitBtn.TabIndex = 32;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(258, 80);
            this.HomeBtn.TabIndex = 25;
            this.HomeBtn.Text = "LuxeFoods";
            this.HomeBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBtn.Location = new System.Drawing.Point(1138, 0);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(132, 80);
            this.LoginBtn.TabIndex = 31;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 670);
            this.panel1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 356);
            this.label2.MaximumSize = new System.Drawing.Size(650, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 124);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reserving a table without the hassle of calling? Without the chance of hearing th" +
    "ere are no abailable tables? Welcome to LuxeFoods, the new way of reserving a ta" +
    "ble.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.ballentine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 670);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "homePage";
            this.Text = "Make a homePage";
            this.Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button CheckReservationsBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}