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
            this.VoornaamTxtBox = new System.Windows.Forms.TextBox();
            this.AchternaamTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefoonTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VoornaamTxtBox
            // 
            this.VoornaamTxtBox.Location = new System.Drawing.Point(12, 25);
            this.VoornaamTxtBox.Name = "VoornaamTxtBox";
            this.VoornaamTxtBox.Size = new System.Drawing.Size(100, 20);
            this.VoornaamTxtBox.TabIndex = 0;
            // 
            // AchternaamTxtBox
            // 
            this.AchternaamTxtBox.Location = new System.Drawing.Point(12, 64);
            this.AchternaamTxtBox.Name = "AchternaamTxtBox";
            this.AchternaamTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AchternaamTxtBox.TabIndex = 1;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(12, 103);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtBox.TabIndex = 2;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(632, 415);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(713, 415);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(12, 181);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '€';
            this.PasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxtBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefoon nummer";
            // 
            // TelefoonTxtBox
            // 
            this.TelefoonTxtBox.Location = new System.Drawing.Point(12, 142);
            this.TelefoonTxtBox.Name = "TelefoonTxtBox";
            this.TelefoonTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TelefoonTxtBox.TabIndex = 3;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TelefoonTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.AchternaamTxtBox);
            this.Controls.Add(this.VoornaamTxtBox);
            this.Name = "Register";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VoornaamTxtBox;
        private System.Windows.Forms.TextBox AchternaamTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefoonTxtBox;
    }
}

