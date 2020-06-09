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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkReservation));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.loginButton = new System.Windows.Forms.LinkLabel();
            this.contactUsButton = new System.Windows.Forms.LinkLabel();
            this.menuButton = new System.Windows.Forms.LinkLabel();
            this.reservationsButton = new System.Windows.Forms.LinkLabel();
            this.aboutUsButton = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1925, 1282);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1823, 30);
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
            this.MinimizeButton.Location = new System.Drawing.Point(1757, 30);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 37);
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
            this.button2.Location = new System.Drawing.Point(746, 1081);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 65);
            this.button2.TabIndex = 14;
            this.button2.Text = "Place Reservation";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(550, 169);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(804, 92);
            this.Title.TabIndex = 18;
            this.Title.Text = "Choose your reservation";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(186, 319);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1551, 686);
            this.listBox1.TabIndex = 19;
            // 
            // loginButton
            // 
            this.loginButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.loginButton.LinkColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(1532, 48);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 31);
            this.loginButton.TabIndex = 31;
            this.loginButton.TabStop = true;
            this.loginButton.Text = "Login";
            this.loginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginButton_LinkClicked);
            // 
            // contactUsButton
            // 
            this.contactUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.contactUsButton.AutoSize = true;
            this.contactUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.contactUsButton.LinkColor = System.Drawing.Color.White;
            this.contactUsButton.Location = new System.Drawing.Point(1015, 48);
            this.contactUsButton.Name = "contactUsButton";
            this.contactUsButton.Size = new System.Drawing.Size(145, 31);
            this.contactUsButton.TabIndex = 30;
            this.contactUsButton.TabStop = true;
            this.contactUsButton.Text = "Contact us";
            this.contactUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactUsButton_LinkClicked);
            // 
            // menuButton
            // 
            this.menuButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.menuButton.LinkColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(1319, 48);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(81, 31);
            this.menuButton.TabIndex = 29;
            this.menuButton.TabStop = true;
            this.menuButton.Text = "Menu";
            this.menuButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.menuButton_LinkClicked);
            // 
            // reservationsButton
            // 
            this.reservationsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.reservationsButton.AutoSize = true;
            this.reservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.reservationsButton.LinkColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(686, 45);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(174, 31);
            this.reservationsButton.TabIndex = 28;
            this.reservationsButton.TabStop = true;
            this.reservationsButton.Text = "Reservations";
            this.reservationsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reservationsButton_LinkClicked);
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.aboutUsButton.AutoSize = true;
            this.aboutUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
            this.aboutUsButton.LinkColor = System.Drawing.Color.White;
            this.aboutUsButton.Location = new System.Drawing.Point(431, 45);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(121, 31);
            this.aboutUsButton.TabIndex = 27;
            this.aboutUsButton.TabStop = true;
            this.aboutUsButton.Text = "About us";
            this.aboutUsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUsButton_LinkClicked_1);
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
            this.label2.Size = new System.Drawing.Size(207, 44);
            this.label2.TabIndex = 26;
            this.label2.Text = "LuxeFoods";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1181);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.contactUsButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.reservationsButton);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "checkReservation";
            this.Text = "Make a reservation_template1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.LinkLabel contactUsButton;
        private System.Windows.Forms.LinkLabel menuButton;
        private System.Windows.Forms.LinkLabel reservationsButton;
        private System.Windows.Forms.LinkLabel aboutUsButton;
        private System.Windows.Forms.Label label2;
    }
}