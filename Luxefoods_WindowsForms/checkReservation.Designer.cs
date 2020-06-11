using System;

namespace Luxefoods_WindowsForms
{
    partial class checkReservation
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
            this.Title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckReservationsBtn = new System.Windows.Forms.Button();
            this.ReservationsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.FullscreenBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LuxeFoodsLogoLabel = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 79);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1603, 92);
            this.Title.TabIndex = 18;
            this.Title.Text = "Choose your reservation";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(188, 142);
            this.listBox1.Margin = new System.Windows.Forms.Padding(50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1233, 500);
            this.listBox1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
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
            this.panel1.Size = new System.Drawing.Size(1603, 79);
            this.panel1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(659, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 79);
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
            this.CheckReservationsBtn.Location = new System.Drawing.Point(793, 0);
            this.CheckReservationsBtn.Name = "CheckReservationsBtn";
            this.CheckReservationsBtn.Size = new System.Drawing.Size(193, 79);
            this.CheckReservationsBtn.TabIndex = 27;
            this.CheckReservationsBtn.Text = "My reservations";
            this.CheckReservationsBtn.UseVisualStyleBackColor = true;
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
            this.AboutBtn.Location = new System.Drawing.Point(1207, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(132, 79);
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
            this.ContactBtn.Location = new System.Drawing.Point(1339, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(132, 79);
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
            this.FullscreenBtn.Location = new System.Drawing.Point(1548, 0);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(1521, 0);
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
            this.ExitBtn.Location = new System.Drawing.Point(1575, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(28, 26);
            this.ExitBtn.TabIndex = 32;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            this.LuxeFoodsLogoLabel.Size = new System.Drawing.Size(258, 79);
            this.LuxeFoodsLogoLabel.TabIndex = 25;
            this.LuxeFoodsLogoLabel.Text = "LuxeFoods";
            this.LuxeFoodsLogoLabel.UseVisualStyleBackColor = true;
            this.LuxeFoodsLogoLabel.Click += new System.EventHandler(this.homePageBtn_Click);
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
            this.LoginBtn.Location = new System.Drawing.Point(1471, 0);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(132, 79);
            this.LoginBtn.TabIndex = 31;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.loginButton_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1603, 803);
            this.panel2.TabIndex = 33;
            // 
            // checkReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1603, 882);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "checkReservation";
            this.Text = "Make a reservation_template1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckReservationsBtn;
        private System.Windows.Forms.Button ReservationsBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button FullscreenBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LuxeFoodsLogoLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel2;
    }
}