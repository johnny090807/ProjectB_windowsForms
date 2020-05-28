namespace Luxefoods_WindowsForms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.VoornaamTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AchternaamTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.EmailTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.TelefoonTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.VerifyPasswordTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(21)))), ((int)(((byte)(1)))));
            this.RegisterBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.background_TxtBox;
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterBtn.Location = new System.Drawing.Point(171, 520);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(361, 74);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginBtn.Location = new System.Drawing.Point(36, 650);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(626, 23);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Already have an account? Click here...";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Image = global::Luxefoods_WindowsForms.Properties.Resources.logout;
            this.exitBtn.Location = new System.Drawing.Point(662, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // VoornaamTxtBox
            // 
            this.VoornaamTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(46)))), ((int)(((byte)(5)))));
            this.VoornaamTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VoornaamTxtBox.BackgroundImage")));
            this.VoornaamTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoornaamTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoornaamTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VoornaamTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("VoornaamTxtBox.Icon")));
            this.VoornaamTxtBox.Location = new System.Drawing.Point(142, 90);
            this.VoornaamTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoornaamTxtBox.Name = "VoornaamTxtBox";
            this.VoornaamTxtBox.Size = new System.Drawing.Size(424, 59);
            this.VoornaamTxtBox.TabIndex = 0;
            this.VoornaamTxtBox.text = "Voornaam";
            this.VoornaamTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.VoornaamTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(2)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 37);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(154, 37);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "LuxeFoods";
            // 
            // AchternaamTxtBox
            // 
            this.AchternaamTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(39)))), ((int)(((byte)(4)))));
            this.AchternaamTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AchternaamTxtBox.BackgroundImage")));
            this.AchternaamTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AchternaamTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchternaamTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AchternaamTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("AchternaamTxtBox.Icon")));
            this.AchternaamTxtBox.Location = new System.Drawing.Point(142, 159);
            this.AchternaamTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AchternaamTxtBox.Name = "AchternaamTxtBox";
            this.AchternaamTxtBox.Size = new System.Drawing.Size(424, 59);
            this.AchternaamTxtBox.TabIndex = 1;
            this.AchternaamTxtBox.text = "Achternaam";
            this.AchternaamTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.AchternaamTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(33)))), ((int)(((byte)(4)))));
            this.EmailTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailTxtBox.BackgroundImage")));
            this.EmailTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EmailTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("EmailTxtBox.Icon")));
            this.EmailTxtBox.Location = new System.Drawing.Point(142, 228);
            this.EmailTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(424, 59);
            this.EmailTxtBox.TabIndex = 2;
            this.EmailTxtBox.text = "Email";
            this.EmailTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.EmailTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // TelefoonTxtBox
            // 
            this.TelefoonTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(28)))), ((int)(((byte)(4)))));
            this.TelefoonTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TelefoonTxtBox.BackgroundImage")));
            this.TelefoonTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelefoonTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoonTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TelefoonTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("TelefoonTxtBox.Icon")));
            this.TelefoonTxtBox.Location = new System.Drawing.Point(142, 297);
            this.TelefoonTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelefoonTxtBox.Name = "TelefoonTxtBox";
            this.TelefoonTxtBox.Size = new System.Drawing.Size(424, 59);
            this.TelefoonTxtBox.TabIndex = 3;
            this.TelefoonTxtBox.text = "Telefoon nummer";
            this.TelefoonTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.TelefoonTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(23)))), ((int)(((byte)(3)))));
            this.PasswordTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.BackgroundImage")));
            this.PasswordTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.Icon")));
            this.PasswordTxtBox.Location = new System.Drawing.Point(142, 366);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(424, 59);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.text = "Wachtwoord";
            this.PasswordTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // VerifyPasswordTxtBox
            // 
            this.VerifyPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(23)))), ((int)(((byte)(3)))));
            this.VerifyPasswordTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerifyPasswordTxtBox.BackgroundImage")));
            this.VerifyPasswordTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyPasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyPasswordTxtBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VerifyPasswordTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("VerifyPasswordTxtBox.Icon")));
            this.VerifyPasswordTxtBox.Location = new System.Drawing.Point(142, 435);
            this.VerifyPasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerifyPasswordTxtBox.Name = "VerifyPasswordTxtBox";
            this.VerifyPasswordTxtBox.Size = new System.Drawing.Size(424, 59);
            this.VerifyPasswordTxtBox.TabIndex = 5;
            this.VerifyPasswordTxtBox.text = "Vul nog een keer het wachtwoord in";
            this.VerifyPasswordTxtBox.Enter += new System.EventHandler(this.EnterTxtBox);
            this.VerifyPasswordTxtBox.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 29);
            this.ErrorMessageLabel.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ErrorMessageLabel);
            this.panel2.Location = new System.Drawing.Point(171, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 31);
            this.panel2.TabIndex = 16;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.Register_background;
            this.ClientSize = new System.Drawing.Size(701, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.VerifyPasswordTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.TelefoonTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.AchternaamTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VoornaamTxtBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.RegisterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuTextbox VoornaamTxtBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox AchternaamTxtBox;
        private Bunifu.Framework.UI.BunifuTextbox EmailTxtBox;
        private Bunifu.Framework.UI.BunifuTextbox TelefoonTxtBox;
        private Bunifu.Framework.UI.BunifuTextbox PasswordTxtBox;
        private Bunifu.Framework.UI.BunifuTextbox VerifyPasswordTxtBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Panel panel2;
    }
}

