namespace Luxefoods_WindowsForms
{
    partial class MenuSpecial
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
            this.FullscreenPanel = new System.Windows.Forms.Panel();
            this.GerechtenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GerechtItemPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HoofdmenuBtn = new System.Windows.Forms.Button();
            this.NagerechtBtn = new System.Windows.Forms.Button();
            this.VoorgerechtBtn = new System.Windows.Forms.Button();
            this.DrankBtn = new System.Windows.Forms.Button();
            this.WijnBtn = new System.Windows.Forms.Button();
            this.FullscreenPanel.SuspendLayout();
            this.GerechtenPanel.SuspendLayout();
            this.GerechtItemPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullscreenPanel
            // 
            this.FullscreenPanel.BackColor = System.Drawing.Color.Black;
            this.FullscreenPanel.Controls.Add(this.GerechtenPanel);
            this.FullscreenPanel.Controls.Add(this.HeaderPanel);
            this.FullscreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullscreenPanel.Location = new System.Drawing.Point(0, 0);
            this.FullscreenPanel.Name = "FullscreenPanel";
            this.FullscreenPanel.Size = new System.Drawing.Size(845, 607);
            this.FullscreenPanel.TabIndex = 0;
            // 
            // GerechtenPanel
            // 
            this.GerechtenPanel.AutoScroll = true;
            this.GerechtenPanel.Controls.Add(this.GerechtItemPanel);
            this.GerechtenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GerechtenPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.GerechtenPanel.Location = new System.Drawing.Point(0, 57);
            this.GerechtenPanel.Name = "GerechtenPanel";
            this.GerechtenPanel.Size = new System.Drawing.Size(845, 550);
            this.GerechtenPanel.TabIndex = 1;
            this.GerechtenPanel.WrapContents = false;
            // 
            // GerechtItemPanel
            // 
            this.GerechtItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GerechtItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GerechtItemPanel.Controls.Add(this.ErrorLabel);
            this.GerechtItemPanel.Location = new System.Drawing.Point(0, 0);
            this.GerechtItemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GerechtItemPanel.Name = "GerechtItemPanel";
            this.GerechtItemPanel.Size = new System.Drawing.Size(845, 82);
            this.GerechtItemPanel.TabIndex = 7;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorLabel.Location = new System.Drawing.Point(114, 19);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(20);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(612, 33);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Klik boven in het menu voor een van de opties";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.VoorgerechtBtn);
            this.HeaderPanel.Controls.Add(this.HoofdmenuBtn);
            this.HeaderPanel.Controls.Add(this.NagerechtBtn);
            this.HeaderPanel.Controls.Add(this.DrankBtn);
            this.HeaderPanel.Controls.Add(this.WijnBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(845, 57);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HoofdmenuBtn
            // 
            this.HoofdmenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HoofdmenuBtn.FlatAppearance.BorderSize = 0;
            this.HoofdmenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.HoofdmenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(19)))), ((int)(((byte)(3)))));
            this.HoofdmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoofdmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoofdmenuBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HoofdmenuBtn.Location = new System.Drawing.Point(149, 0);
            this.HoofdmenuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HoofdmenuBtn.Name = "HoofdmenuBtn";
            this.HoofdmenuBtn.Size = new System.Drawing.Size(143, 57);
            this.HoofdmenuBtn.TabIndex = 0;
            this.HoofdmenuBtn.Text = "Hoofdmenu";
            this.HoofdmenuBtn.UseVisualStyleBackColor = true;
            this.HoofdmenuBtn.Click += new System.EventHandler(this.HoofdmenuBtn_Click);
            // 
            // NagerechtBtn
            // 
            this.NagerechtBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NagerechtBtn.FlatAppearance.BorderSize = 0;
            this.NagerechtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.NagerechtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(19)))), ((int)(((byte)(3)))));
            this.NagerechtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NagerechtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NagerechtBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NagerechtBtn.Location = new System.Drawing.Point(292, 0);
            this.NagerechtBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NagerechtBtn.Name = "NagerechtBtn";
            this.NagerechtBtn.Size = new System.Drawing.Size(135, 57);
            this.NagerechtBtn.TabIndex = 1;
            this.NagerechtBtn.Text = "Nagerecht";
            this.NagerechtBtn.UseVisualStyleBackColor = true;
            this.NagerechtBtn.Click += new System.EventHandler(this.NagerechtBtn_Click);
            // 
            // VoorgerechtBtn
            // 
            this.VoorgerechtBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VoorgerechtBtn.FlatAppearance.BorderSize = 0;
            this.VoorgerechtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.VoorgerechtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(19)))), ((int)(((byte)(3)))));
            this.VoorgerechtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoorgerechtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoorgerechtBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VoorgerechtBtn.Location = new System.Drawing.Point(0, 0);
            this.VoorgerechtBtn.Margin = new System.Windows.Forms.Padding(0);
            this.VoorgerechtBtn.Name = "VoorgerechtBtn";
            this.VoorgerechtBtn.Size = new System.Drawing.Size(149, 57);
            this.VoorgerechtBtn.TabIndex = 2;
            this.VoorgerechtBtn.Text = "Voorgerecht";
            this.VoorgerechtBtn.UseVisualStyleBackColor = true;
            this.VoorgerechtBtn.Click += new System.EventHandler(this.VoorgerechtBtn_Click);
            // 
            // DrankBtn
            // 
            this.DrankBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DrankBtn.FlatAppearance.BorderSize = 0;
            this.DrankBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.DrankBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(19)))), ((int)(((byte)(3)))));
            this.DrankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrankBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrankBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DrankBtn.Location = new System.Drawing.Point(427, 0);
            this.DrankBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DrankBtn.Name = "DrankBtn";
            this.DrankBtn.Size = new System.Drawing.Size(135, 57);
            this.DrankBtn.TabIndex = 3;
            this.DrankBtn.Text = "Dranken";
            this.DrankBtn.UseVisualStyleBackColor = true;
            this.DrankBtn.Click += new System.EventHandler(this.DrankBtn_Click);
            // 
            // WijnBtn
            // 
            this.WijnBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WijnBtn.FlatAppearance.BorderSize = 0;
            this.WijnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
            this.WijnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(19)))), ((int)(((byte)(3)))));
            this.WijnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WijnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WijnBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WijnBtn.Location = new System.Drawing.Point(562, 0);
            this.WijnBtn.Margin = new System.Windows.Forms.Padding(0);
            this.WijnBtn.Name = "WijnBtn";
            this.WijnBtn.Size = new System.Drawing.Size(135, 57);
            this.WijnBtn.TabIndex = 4;
            this.WijnBtn.Text = "Wijnen";
            this.WijnBtn.UseVisualStyleBackColor = true;
            this.WijnBtn.Click += new System.EventHandler(this.WijnBtn_Click);
            // 
            // MenuSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 607);
            this.Controls.Add(this.FullscreenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSpecial";
            this.Text = "MenuSpecial";
            this.FullscreenPanel.ResumeLayout(false);
            this.GerechtenPanel.ResumeLayout(false);
            this.GerechtItemPanel.ResumeLayout(false);
            this.GerechtItemPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FullscreenPanel;
        private System.Windows.Forms.FlowLayoutPanel HeaderPanel;
        private System.Windows.Forms.Button HoofdmenuBtn;
        private System.Windows.Forms.Button NagerechtBtn;
        private System.Windows.Forms.FlowLayoutPanel GerechtenPanel;
        private System.Windows.Forms.Panel GerechtItemPanel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button VoorgerechtBtn;
        private System.Windows.Forms.Button DrankBtn;
        private System.Windows.Forms.Button WijnBtn;
    }
}