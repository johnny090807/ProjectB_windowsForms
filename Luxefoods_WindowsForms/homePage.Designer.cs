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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.ExitButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 108);
            this.label1.TabIndex = 14;
            this.label1.Text = "LuxeFoods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(60, 574);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 31);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Place a reservation";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(221, 700);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(206, 31);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "My reservations";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(713, 700);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(212, 31);
            this.linkLabel3.TabIndex = 15;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Check our menu";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Black;
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(941, 813);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(121, 31);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "About us";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Black;
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(404, 813);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(145, 31);
            this.linkLabel5.TabIndex = 15;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Contact us";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Black;
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(588, 574);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(227, 31);
            this.linkLabel6.TabIndex = 15;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Log in or Register";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "homePage";
            this.Text = "Make a homePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
    }
}