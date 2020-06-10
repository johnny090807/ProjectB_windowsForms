namespace Luxefoods_WindowsForms
{
    partial class MenuDashboardCreateItem
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.gerechtCategorieSelector = new System.Windows.Forms.ComboBox();
            this.gerechtNotenSelector = new System.Windows.Forms.ComboBox();
            this.gerechtMelkSelector = new System.Windows.Forms.ComboBox();
            this.gerechtPrijsInput = new System.Windows.Forms.TextBox();
            this.gerechtNaamInput = new System.Windows.Forms.TextBox();
            this.gerechtCategorie = new System.Windows.Forms.Label();
            this.gerechtNoten = new System.Windows.Forms.Label();
            this.gerechtMelk = new System.Windows.Forms.Label();
            this.gerechtPrijs = new System.Windows.Forms.Label();
            this.gerechtNaam = new System.Windows.Forms.Label();
            this.CreateItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(57, 50);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 30;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // gerechtCategorieSelector
            // 
            this.gerechtCategorieSelector.FormattingEnabled = true;
            this.gerechtCategorieSelector.Items.AddRange(new object[] {
            "Hoofdmenu",
            "Nagerecht"});
            this.gerechtCategorieSelector.Location = new System.Drawing.Point(269, 494);
            this.gerechtCategorieSelector.Name = "gerechtCategorieSelector";
            this.gerechtCategorieSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtCategorieSelector.TabIndex = 29;
            this.gerechtCategorieSelector.Text = "Select The Category";
            this.gerechtCategorieSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtNotenSelector
            // 
            this.gerechtNotenSelector.FormattingEnabled = true;
            this.gerechtNotenSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtNotenSelector.Location = new System.Drawing.Point(269, 391);
            this.gerechtNotenSelector.Name = "gerechtNotenSelector";
            this.gerechtNotenSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtNotenSelector.TabIndex = 28;
            this.gerechtNotenSelector.Text = "Select True Or False";
            this.gerechtNotenSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtMelkSelector
            // 
            this.gerechtMelkSelector.FormattingEnabled = true;
            this.gerechtMelkSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtMelkSelector.Location = new System.Drawing.Point(269, 326);
            this.gerechtMelkSelector.Name = "gerechtMelkSelector";
            this.gerechtMelkSelector.Size = new System.Drawing.Size(121, 21);
            this.gerechtMelkSelector.TabIndex = 27;
            this.gerechtMelkSelector.Text = "Select True Or False";
            this.gerechtMelkSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtPrijsInput
            // 
            this.gerechtPrijsInput.Location = new System.Drawing.Point(269, 259);
            this.gerechtPrijsInput.MaxLength = 10;
            this.gerechtPrijsInput.Name = "gerechtPrijsInput";
            this.gerechtPrijsInput.Size = new System.Drawing.Size(258, 20);
            this.gerechtPrijsInput.TabIndex = 25;
            this.gerechtPrijsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gerechtPrijsInput_KeyPress);
            // 
            // gerechtNaamInput
            // 
            this.gerechtNaamInput.Location = new System.Drawing.Point(262, 167);
            this.gerechtNaamInput.Name = "gerechtNaamInput";
            this.gerechtNaamInput.Size = new System.Drawing.Size(258, 20);
            this.gerechtNaamInput.TabIndex = 26;
            // 
            // gerechtCategorie
            // 
            this.gerechtCategorie.AutoSize = true;
            this.gerechtCategorie.Location = new System.Drawing.Point(266, 463);
            this.gerechtCategorie.Name = "gerechtCategorie";
            this.gerechtCategorie.Size = new System.Drawing.Size(222, 13);
            this.gerechtCategorie.TabIndex = 24;
            this.gerechtCategorie.Text = "In welke categorie hoort deze gerecht te zijn?";
            // 
            // gerechtNoten
            // 
            this.gerechtNoten.AutoSize = true;
            this.gerechtNoten.Location = new System.Drawing.Point(266, 375);
            this.gerechtNoten.Name = "gerechtNoten";
            this.gerechtNoten.Size = new System.Drawing.Size(159, 13);
            this.gerechtNoten.TabIndex = 23;
            this.gerechtNoten.Text = "Heeft Gerecht Noten Alergieen?";
            // 
            // gerechtMelk
            // 
            this.gerechtMelk.AutoSize = true;
            this.gerechtMelk.Location = new System.Drawing.Point(266, 310);
            this.gerechtMelk.Name = "gerechtMelk";
            this.gerechtMelk.Size = new System.Drawing.Size(153, 13);
            this.gerechtMelk.TabIndex = 22;
            this.gerechtMelk.Text = "Heeft Gerecht Melk Alergieen?";
            // 
            // gerechtPrijs
            // 
            this.gerechtPrijs.AutoSize = true;
            this.gerechtPrijs.Location = new System.Drawing.Point(266, 231);
            this.gerechtPrijs.Name = "gerechtPrijs";
            this.gerechtPrijs.Size = new System.Drawing.Size(70, 13);
            this.gerechtPrijs.TabIndex = 21;
            this.gerechtPrijs.Text = "Gerecht Prijs:";
            // 
            // gerechtNaam
            // 
            this.gerechtNaam.AutoSize = true;
            this.gerechtNaam.Location = new System.Drawing.Point(266, 139);
            this.gerechtNaam.Name = "gerechtNaam";
            this.gerechtNaam.Size = new System.Drawing.Size(79, 13);
            this.gerechtNaam.TabIndex = 20;
            this.gerechtNaam.Text = "Gerecht Naam:";
            // 
            // CreateItem
            // 
            this.CreateItem.BackColor = System.Drawing.Color.ForestGreen;
            this.CreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateItem.ForeColor = System.Drawing.Color.White;
            this.CreateItem.Location = new System.Drawing.Point(847, 120);
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(279, 115);
            this.CreateItem.TabIndex = 31;
            this.CreateItem.Text = "CreateItem";
            this.CreateItem.UseVisualStyleBackColor = false;
            this.CreateItem.Click += new System.EventHandler(this.CreateItem_Click);
            // 
            // MenuDashboardCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1301, 794);
            this.Controls.Add(this.CreateItem);
            this.Controls.Add(this.goBackButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDashboardCreateItem";
            this.Text = "/;.";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.ComboBox gerechtCategorieSelector;
        private System.Windows.Forms.ComboBox gerechtNotenSelector;
        private System.Windows.Forms.ComboBox gerechtMelkSelector;
        private System.Windows.Forms.TextBox gerechtPrijsInput;
        private System.Windows.Forms.TextBox gerechtNaamInput;
        private System.Windows.Forms.Label gerechtCategorie;
        private System.Windows.Forms.Label gerechtNoten;
        private System.Windows.Forms.Label gerechtMelk;
        private System.Windows.Forms.Label gerechtPrijs;
        private System.Windows.Forms.Label gerechtNaam;
        private System.Windows.Forms.Button CreateItem;
    }
}