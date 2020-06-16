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
            this.goBackButton.Location = new System.Drawing.Point(33, 8);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 30;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // gerechtCategorieSelector
            // 
            this.gerechtCategorieSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtCategorieSelector.FormattingEnabled = true;
            this.gerechtCategorieSelector.Items.AddRange(new object[] {
            "Voorgerecht",
            "Hoofdmenu",
            "Nagerecht",
            "Dranken",
            "Wijnen"});
            this.gerechtCategorieSelector.Location = new System.Drawing.Point(36, 437);
            this.gerechtCategorieSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerechtCategorieSelector.Name = "gerechtCategorieSelector";
            this.gerechtCategorieSelector.Size = new System.Drawing.Size(739, 39);
            this.gerechtCategorieSelector.TabIndex = 29;
            this.gerechtCategorieSelector.Text = "Select The Category";
            this.gerechtCategorieSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtNotenSelector
            // 
            this.gerechtNotenSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtNotenSelector.FormattingEnabled = true;
            this.gerechtNotenSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtNotenSelector.Location = new System.Drawing.Point(36, 357);
            this.gerechtNotenSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerechtNotenSelector.Name = "gerechtNotenSelector";
            this.gerechtNotenSelector.Size = new System.Drawing.Size(739, 39);
            this.gerechtNotenSelector.TabIndex = 28;
            this.gerechtNotenSelector.Text = "Select True Or False";
            this.gerechtNotenSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtMelkSelector
            // 
            this.gerechtMelkSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtMelkSelector.FormattingEnabled = true;
            this.gerechtMelkSelector.Items.AddRange(new object[] {
            "True",
            "False"});
            this.gerechtMelkSelector.Location = new System.Drawing.Point(36, 277);
            this.gerechtMelkSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerechtMelkSelector.Name = "gerechtMelkSelector";
            this.gerechtMelkSelector.Size = new System.Drawing.Size(739, 39);
            this.gerechtMelkSelector.TabIndex = 27;
            this.gerechtMelkSelector.Text = "Select True Or False";
            this.gerechtMelkSelector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchComboBoxKeyPress);
            // 
            // gerechtPrijsInput
            // 
            this.gerechtPrijsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtPrijsInput.Location = new System.Drawing.Point(36, 198);
            this.gerechtPrijsInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerechtPrijsInput.MaxLength = 10;
            this.gerechtPrijsInput.Name = "gerechtPrijsInput";
            this.gerechtPrijsInput.Size = new System.Drawing.Size(739, 38);
            this.gerechtPrijsInput.TabIndex = 25;
            this.gerechtPrijsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gerechtPrijsInput_KeyPress);
            // 
            // gerechtNaamInput
            // 
            this.gerechtNaamInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtNaamInput.Location = new System.Drawing.Point(36, 119);
            this.gerechtNaamInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerechtNaamInput.Name = "gerechtNaamInput";
            this.gerechtNaamInput.Size = new System.Drawing.Size(739, 38);
            this.gerechtNaamInput.TabIndex = 26;
            // 
            // gerechtCategorie
            // 
            this.gerechtCategorie.AutoSize = true;
            this.gerechtCategorie.BackColor = System.Drawing.Color.Transparent;
            this.gerechtCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtCategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gerechtCategorie.Location = new System.Drawing.Point(26, 398);
            this.gerechtCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gerechtCategorie.Name = "gerechtCategorie";
            this.gerechtCategorie.Size = new System.Drawing.Size(656, 37);
            this.gerechtCategorie.TabIndex = 24;
            this.gerechtCategorie.Text = "In welke categorie hoort deze gerecht te zijn?";
            // 
            // gerechtNoten
            // 
            this.gerechtNoten.AutoSize = true;
            this.gerechtNoten.BackColor = System.Drawing.Color.Transparent;
            this.gerechtNoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtNoten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gerechtNoten.Location = new System.Drawing.Point(26, 318);
            this.gerechtNoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gerechtNoten.Name = "gerechtNoten";
            this.gerechtNoten.Size = new System.Drawing.Size(505, 37);
            this.gerechtNoten.TabIndex = 23;
            this.gerechtNoten.Text = "Heeft het gerecht noten alergieen?";
            // 
            // gerechtMelk
            // 
            this.gerechtMelk.AutoSize = true;
            this.gerechtMelk.BackColor = System.Drawing.Color.Transparent;
            this.gerechtMelk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtMelk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gerechtMelk.Location = new System.Drawing.Point(26, 238);
            this.gerechtMelk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gerechtMelk.Name = "gerechtMelk";
            this.gerechtMelk.Size = new System.Drawing.Size(492, 37);
            this.gerechtMelk.TabIndex = 22;
            this.gerechtMelk.Text = "Heeft het gerecht melk alergieen?";
            // 
            // gerechtPrijs
            // 
            this.gerechtPrijs.AutoSize = true;
            this.gerechtPrijs.BackColor = System.Drawing.Color.Transparent;
            this.gerechtPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtPrijs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gerechtPrijs.Location = new System.Drawing.Point(26, 159);
            this.gerechtPrijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gerechtPrijs.Name = "gerechtPrijs";
            this.gerechtPrijs.Size = new System.Drawing.Size(210, 37);
            this.gerechtPrijs.TabIndex = 21;
            this.gerechtPrijs.Text = "Gerecht Prijs:";
            // 
            // gerechtNaam
            // 
            this.gerechtNaam.AutoSize = true;
            this.gerechtNaam.BackColor = System.Drawing.Color.Transparent;
            this.gerechtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerechtNaam.ForeColor = System.Drawing.Color.White;
            this.gerechtNaam.Location = new System.Drawing.Point(26, 80);
            this.gerechtNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gerechtNaam.Name = "gerechtNaam";
            this.gerechtNaam.Size = new System.Drawing.Size(235, 37);
            this.gerechtNaam.TabIndex = 20;
            this.gerechtNaam.Text = "Gerecht Naam:";
            // 
            // CreateItem
            // 
            this.CreateItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateItem.ForeColor = System.Drawing.Color.White;
            this.CreateItem.Location = new System.Drawing.Point(36, 534);
            this.CreateItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(985, 75);
            this.CreateItem.TabIndex = 31;
            this.CreateItem.Text = "CreateItem";
            this.CreateItem.UseVisualStyleBackColor = false;
            this.CreateItem.Click += new System.EventHandler(this.CreateItem_Click);
            // 
            // MenuDashboardCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.pictureBox2_BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1049, 627);
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