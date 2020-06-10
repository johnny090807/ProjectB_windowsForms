namespace Luxefoods_WindowsForms
{
    partial class RestaurantenDashboardReview
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
            this.label1 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNoButton = new System.Windows.Forms.Button();
            this.panelYesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant ID: ";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Chocolate;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(160, 52);
            this.goBackButton.TabIndex = 19;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(436, 102);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(279, 115);
            this.EditButton.TabIndex = 21;
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
            this.DeleteButton.Location = new System.Drawing.Point(436, 246);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(279, 115);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete Order";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panelNoButton);
            this.panel2.Controls.Add(this.panelYesButton);
            this.panel2.Location = new System.Drawing.Point(12, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 179);
            this.panel2.TabIndex = 23;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Are you sure that you want to delete this order?";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Huidige Naam:";
            // 
            // RestaurantenDashboardReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantenDashboardReview";
            this.Text = "RestaurantenDashboardReview";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panelNoButton;
        private System.Windows.Forms.Button panelYesButton;
        private System.Windows.Forms.Label label3;
    }
}