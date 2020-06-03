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
            this.HeaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HoofdmenuBtn = new System.Windows.Forms.Button();
            this.NagerechtBtn = new System.Windows.Forms.Button();
            this.GerechtenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GerechtItemPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.FullscreenPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.GerechtenPanel.SuspendLayout();
            this.GerechtItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullscreenPanel
            // 
            this.FullscreenPanel.BackColor = System.Drawing.Color.Transparent;
            this.FullscreenPanel.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.Register_background;
            this.FullscreenPanel.Controls.Add(this.GerechtenPanel);
            this.FullscreenPanel.Controls.Add(this.HeaderPanel);
            this.FullscreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullscreenPanel.Location = new System.Drawing.Point(0, 0);
            this.FullscreenPanel.Name = "FullscreenPanel";
            this.FullscreenPanel.Size = new System.Drawing.Size(845, 607);
            this.FullscreenPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.HoofdmenuBtn);
            this.HeaderPanel.Controls.Add(this.NagerechtBtn);
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
            this.HoofdmenuBtn.Location = new System.Drawing.Point(0, 0);
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
            this.NagerechtBtn.Location = new System.Drawing.Point(143, 0);
            this.NagerechtBtn.Margin = new System.Windows.Forms.Padding(0);
            this.NagerechtBtn.Name = "NagerechtBtn";
            this.NagerechtBtn.Size = new System.Drawing.Size(135, 57);
            this.NagerechtBtn.TabIndex = 1;
            this.NagerechtBtn.Text = "Nagerecht";
            this.NagerechtBtn.UseVisualStyleBackColor = true;
            this.NagerechtBtn.Click += new System.EventHandler(this.NagerechtBtn_Click);
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
            this.GerechtItemPanel.Size = new System.Drawing.Size(808, 82);
            this.GerechtItemPanel.TabIndex = 7;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorLabel.Location = new System.Drawing.Point(96, 19);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(20);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(612, 33);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "Klik boven in het menu voor een van de opties";
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
            this.HeaderPanel.ResumeLayout(false);
            this.GerechtenPanel.ResumeLayout(false);
            this.GerechtItemPanel.ResumeLayout(false);
            this.GerechtItemPanel.PerformLayout();
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
    }
}