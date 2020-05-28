namespace Luxefoods_WindowsForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.PasswordCheck = new Bunifu.Framework.UI.BunifuTextbox();
            this.EmailCheck = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(21)))), ((int)(((byte)(1)))));
            this.LoginBtn.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.background_TxtBox;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Location = new System.Drawing.Point(88, 366);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(477, 69);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegisterBtn.Location = new System.Drawing.Point(12, 457);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(614, 38);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.TabStop = false;
            this.RegisterBtn.Text = "Not registered yet? Click here...";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
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
            this.panel1.Size = new System.Drawing.Size(638, 37);
            this.panel1.TabIndex = 15;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(154, 37);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "LuxeFoods";
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
            this.exitBtn.Location = new System.Drawing.Point(599, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(39)))), ((int)(((byte)(4)))));
            this.PasswordCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordCheck.BackgroundImage")));
            this.PasswordCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCheck.ForeColor = System.Drawing.Color.White;
            this.PasswordCheck.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordCheck.Icon")));
            this.PasswordCheck.Location = new System.Drawing.Point(88, 203);
            this.PasswordCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(477, 59);
            this.PasswordCheck.TabIndex = 1;
            this.PasswordCheck.text = "Wachtwoord";
            this.PasswordCheck.Enter += new System.EventHandler(this.EnterTxtBox);
            this.PasswordCheck.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // EmailCheck
            // 
            this.EmailCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(46)))), ((int)(((byte)(5)))));
            this.EmailCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailCheck.BackgroundImage")));
            this.EmailCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailCheck.ForeColor = System.Drawing.Color.White;
            this.EmailCheck.Icon = ((System.Drawing.Image)(resources.GetObject("EmailCheck.Icon")));
            this.EmailCheck.Location = new System.Drawing.Point(88, 86);
            this.EmailCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailCheck.Name = "EmailCheck";
            this.EmailCheck.Size = new System.Drawing.Size(477, 59);
            this.EmailCheck.TabIndex = 0;
            this.EmailCheck.text = "Email";
            this.EmailCheck.Enter += new System.EventHandler(this.EnterTxtBox);
            this.EmailCheck.Leave += new System.EventHandler(this.LeaveTxtBox);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ErrorMessageLabel);
            this.panel2.Location = new System.Drawing.Point(204, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 31);
            this.panel2.TabIndex = 17;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.Register_background;
            this.ClientSize = new System.Drawing.Size(638, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasswordCheck);
            this.Controls.Add(this.EmailCheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button exitBtn;
        private Bunifu.Framework.UI.BunifuTextbox PasswordCheck;
        private Bunifu.Framework.UI.BunifuTextbox EmailCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}