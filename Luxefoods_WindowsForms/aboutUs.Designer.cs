namespace Luxefoods_WindowsForms
{
    partial class aboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutUs));
            this.Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckReservationsBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Controls.Add(this.button1);
            this.Header.Controls.Add(this.CheckReservationsBtn);
            this.Header.Controls.Add(this.ReservationsBtn);
            this.Header.Controls.Add(this.AboutBtn);
            this.Header.Controls.Add(this.ContactBtn);
            this.Header.Controls.Add(this.FullscreenBtn);
            this.Header.Controls.Add(this.MinimizeBtn);
            this.Header.Controls.Add(this.ExitBtn);
            this.Header.Controls.Add(this.button2);
            this.Header.Controls.Add(this.LoginBtn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1285, 80);
            this.Header.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(341, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 80);
            this.button1.TabIndex = 26;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.menuButton_LinkClicked);
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
            this.CheckReservationsBtn.Location = new System.Drawing.Point(475, 0);
            this.CheckReservationsBtn.Name = "CheckReservationsBtn";
            this.CheckReservationsBtn.Size = new System.Drawing.Size(193, 80);
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
            this.ReservationsBtn.Location = new System.Drawing.Point(668, 0);
            this.ReservationsBtn.Name = "ReservationsBtn";
            this.ReservationsBtn.Size = new System.Drawing.Size(221, 80);
            this.ReservationsBtn.TabIndex = 28;
            this.ReservationsBtn.Text = "Place a reservation";
            this.ReservationsBtn.UseVisualStyleBackColor = false;
            this.ReservationsBtn.Click += new System.EventHandler(this.reservationsButton_LinkClicked);
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
            this.AboutBtn.Location = new System.Drawing.Point(889, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(132, 80);
            this.AboutBtn.TabIndex = 29;
            this.AboutBtn.Text = "About us";
            this.AboutBtn.UseVisualStyleBackColor = true;
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
            this.ContactBtn.Location = new System.Drawing.Point(1021, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(132, 80);
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
            this.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FullscreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullscreenBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenBtn.ForeColor = System.Drawing.Color.White;
            this.FullscreenBtn.Location = new System.Drawing.Point(1230, 0);
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
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(1203, 0);
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
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1257, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(28, 26);
            this.ExitBtn.TabIndex = 32;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 80);
            this.button2.TabIndex = 25;
            this.button2.Text = "LuxeFoods";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LuxeFoodsLogoLabel_Click);
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
            this.LoginBtn.Location = new System.Drawing.Point(1153, 0);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(132, 80);
            this.LoginBtn.TabIndex = 31;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.loginButton_LinkClicked);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(534, 102);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(214, 55);
            this.HeaderLabel.TabIndex = 35;
            this.HeaderLabel.Text = "About us";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(965, 124);
            this.label1.TabIndex = 36;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1193, 486);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HeaderLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 817);
            this.panel1.TabIndex = 47;
            // 
            // aboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1285, 897);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "aboutUs";
            this.Text = "Make a aboutUs";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckReservationsBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}