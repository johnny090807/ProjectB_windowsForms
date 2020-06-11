namespace Luxefoods_WindowsForms
{
    partial class MenuDashboardGerechtOverview
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
            this.gerechtId = new System.Windows.Forms.Label();
            this.gerechtNaam = new System.Windows.Forms.Label();
            this.gerechtPrijs = new System.Windows.Forms.Label();
            this.gerechtMelk = new System.Windows.Forms.Label();
            this.gerechtNoten = new System.Windows.Forms.Label();
            this.gerechtCategorie = new System.Windows.Forms.Label();
            this.gerechtNaamInput = new System.Windows.Forms.TextBox();
            this.gerechtMelkSelector = new System.Windows.Forms.ComboBox();
            this.gerechtNotenSelector = new System.Windows.Forms.ComboBox();
            this.gerechtCategorieSelector = new System.Windows.Forms.ComboBox();
            this.gerechtPrijsInput = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNoButton = new System.Windows.Forms.Button();
            this.panelYesButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gerechtId
            // 
            this.gerechtId.AutoSize = true;
            this.gerechtId.Location = new System.Drawing.Point(62, 117);
            this.gerechtId.Name = "gerechtId";
            this.gerechtId.Size = new System.Drawing.Size(52, 13);
            this.gerechtId.TabIndex = 0;
            this.gerechtId.Text = "gerechtId";
            // 
            // gerechtNaam
            // 
            this.gerechtNaam.AutoSize = true;
            this.gerechtNaam.Location = new System.Drawing.Point(261, 117);
            this.gerechtNaam.Name = "gerechtNaam";
            this.gerechtNaam.Size = new System.Drawing.Size(71, 13);
            this.gerechtNaam.TabIndex = 1;
            this.gerechtNaam.Text = "gerechtNaam";
            // 
            // gerechtPrijs
            // 
            this.gerechtPrijs.AutoSize = true;
            this.gerechtPrijs.Location = new System.Drawing.Point(261, 209);
            this.gerechtPrijs.Name = "gerechtPrijs";
            this.gerechtPrijs.Size = new System.Drawing.Size(62, 13);
            this.gerechtPrijs.TabIndex = 2;
            this.gerechtPrijs.Text = "gerechtPrijs";
            // 
            // gerechtMelk
            // 
            this.gerechtMelk.AutoSize = true;
            this.gerechtMelk.Location = new System.Drawing.Point(261, 288);
            this.gerechtMelk.Name = "gerechtMelk";
            this.gerechtMelk.Size = new System.Drawing.Size(66, 13);
            this.gerechtMelk.TabIndex = 3;
            this.gerechtMelk.Text = "gerechtMelk";
            // 
            // gerechtNoten
            // 
            this.gerechtNoten.AutoSize = true;
            this.gerechtNoten.Location = new System.Drawing.Point(261, 353);
            this.gerechtNoten.Name = "gerechtNoten";
            this.gerechtNoten.Size = new System.Drawing.Size(72, 13);
            this.gerechtNoten.TabIndex = 4;
            this.gerechtNoten.Text = "gerechtNoten";
            // 
            // gerechtCategorie
            // 
            this.gerechtCategorie.AutoSize = true;
            this.gerechtCategorie.Location = new System.Drawing.Point(261, 441);
            this.gerechtCategorie.Name = "gerechtCategorie";
            this.gerechtCategorie.Size = new System.Drawing.Size(88, 13);
            this.gerechtCategorie.TabIndex = 5;
            this.gerechtCategorie.Text = "gerechtCategorie";
            // 
            // gerechtNaamInput
            // 
            this.gerechtNaamInput.Location = new System.Drawing.Point(257, 145);
            this.gerechtNaamInput.Name = "gerechtNaamInput";
            this.gerechtNaamInput.Size = new System.Drawing.Size(258, 20);
            this.gerechtNaamInput.TabIndex = 6;
            this.gerechtNaamInput.TextChanged += new System.EventHandler(this.gerechtNaamInput_TextChanged);
            // 
            // gerechtMelkSelector
            // 
            this.gerechtMelkSelector.FormattingEnabled = true;
            this.gerechtMelkSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtMelkSelector.Location = new System.Drawing.Point(264, 304);
            this.gerechtMelkSelector.Name = "gerechtMelkSelector";
            this.gerechtMelkSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtMelkSelector.TabIndex = 8;
            this.gerechtMelkSelector.SelectedIndexChanged += new System.EventHandler(this.gerechtMelkSelector_SelectedIndexChanged);
            // 
            // gerechtNotenSelector
            // 
            this.gerechtNotenSelector.FormattingEnabled = true;
            this.gerechtNotenSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtNotenSelector.Location = new System.Drawing.Point(264, 369);
            this.gerechtNotenSelector.Name = "gerechtNotenSelector";
            this.gerechtNotenSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtNotenSelector.TabIndex = 9;
            this.gerechtNotenSelector.SelectedIndexChanged += new System.EventHandler(this.gerechtNotenSelector_SelectedIndexChanged);
            // 
            // gerechtCategorieSelector
            // 
            this.gerechtCategorieSelector.FormattingEnabled = true;
            this.gerechtCategorieSelector.Items.AddRange(new object[] {
            "Hoofdmenu",
            "Nagerecht"});
            this.gerechtCategorieSelector.Location = new System.Drawing.Point(264, 472);
            this.gerechtCategorieSelector.Name = "gerechtCategorieSelector";
            this.gerechtCategorieSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtCategorieSelector.TabIndex = 10;
            this.gerechtCategorieSelector.SelectedIndexChanged += new System.EventHandler(this.gerechtCategorieSelector_SelectedIndexChanged);
            // 
            // gerechtPrijsInput
            // 
            this.gerechtPrijsInput.Location = new System.Drawing.Point(264, 237);
            this.gerechtPrijsInput.Name = "gerechtPrijsInput";
            this.gerechtPrijsInput.Size = new System.Drawing.Size(258, 20);
            this.gerechtPrijsInput.TabIndex = 6;
            this.gerechtPrijsInput.TextChanged += new System.EventHandler(this.gerechtPrijsInput_TextChanged);
            this.gerechtPrijsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gerechtPrijsInput_KeyPress);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(857, 145);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(279, 115);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Edit Order";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(878, 393);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(279, 115);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete Order";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelNoButton);
            this.panel2.Controls.Add(this.panelYesButton);
            this.panel2.Location = new System.Drawing.Point(257, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 179);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure that you want to delete this order?";
            // 
            // panelNoButton
            // 
            this.panelNoButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.panelNoButton.ForeColor = System.Drawing.Color.White;
            this.panelNoButton.Location = new System.Drawing.Point(464, 112);
            this.panelNoButton.Name = "panelNoButton";
            this.panelNoButton.Size = new System.Drawing.Size(85, 45);
            this.panelNoButton.TabIndex = 1;
            this.panelNoButton.Text = "No";
            this.panelNoButton.UseVisualStyleBackColor = false;
            this.panelNoButton.Click += new System.EventHandler(this.panelNoButton_Click);
            // 
            // panelYesButton
            // 
            this.panelYesButton.BackColor = System.Drawing.Color.Red;
            this.panelYesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.panelYesButton.ForeColor = System.Drawing.Color.White;
            this.panelYesButton.Location = new System.Drawing.Point(229, 112);
            this.panelYesButton.Name = "panelYesButton";
            this.panelYesButton.Size = new System.Drawing.Size(89, 45);
            this.panelYesButton.TabIndex = 0;
            this.panelYesButton.Text = "Yes";
            this.panelYesButton.UseVisualStyleBackColor = false;
            this.panelYesButton.Click += new System.EventHandler(this.panelYesButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(52, 28);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 18;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // MenuDashboardGerechtOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 809);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.gerechtCategorieSelector);
            this.Controls.Add(this.gerechtNotenSelector);
            this.Controls.Add(this.gerechtMelkSelector);
            this.Controls.Add(this.gerechtPrijsInput);
            this.Controls.Add(this.gerechtNaamInput);
            this.Controls.Add(this.gerechtCategorie);
            this.Controls.Add(this.gerechtNoten);
            this.Controls.Add(this.gerechtMelk);
            this.Controls.Add(this.gerechtPrijs);
            this.Controls.Add(this.gerechtNaam);
            this.Controls.Add(this.gerechtId);
            this.Name = "MenuDashboardGerechtOverview";
            this.Text = "MenuDashboardGerechtOverview";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gerechtId;
        private System.Windows.Forms.Label gerechtNaam;
        private System.Windows.Forms.Label gerechtPrijs;
        private System.Windows.Forms.Label gerechtMelk;
        private System.Windows.Forms.Label gerechtNoten;
        private System.Windows.Forms.Label gerechtCategorie;
        private System.Windows.Forms.TextBox gerechtNaamInput;
        private System.Windows.Forms.ComboBox gerechtMelkSelector;
        private System.Windows.Forms.ComboBox gerechtNotenSelector;
        private System.Windows.Forms.ComboBox gerechtCategorieSelector;
        private System.Windows.Forms.TextBox gerechtPrijsInput;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button panelNoButton;
        private System.Windows.Forms.Button panelYesButton;
        private System.Windows.Forms.Button goBackButton;
    }
}