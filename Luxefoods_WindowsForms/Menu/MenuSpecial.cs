using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxefoods_WindowsForms
{
    public partial class MenuSpecial : Form
    {
        public Button clickedButton;
        public MenuSpecial(Button clickedButton)
        {
            this.clickedButton = clickedButton;
            InitializeComponent();
            CenterToScreen();
        }
        public void makeMenu(string Menu = "")
        {
            string q = $"SELECT * FROM restaurant where naam = '{clickedButton.Name}'";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int i = 0;
                    if (i == 0)
                    {
                        this.GerechtenPanel.Controls.Clear();
                        this.GerechtenPanel.Controls.Add(ErrorLabel);
                        ErrorLabel.Text = "Nothing has been added here yet.";
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        q = $"SELECT * FROM gerecht where menuId = '{(int)dr["menuId"]}' and categorie = '{Menu}'";
                        try
                        {
                            i++;
                            con = new SqlConnection("Data Source=luxefood.database.windows.net;Initial Catalog=LuxeFoods;User ID=Klees;Password=Johnny69;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                            con.Open();
                            if (con.State == System.Data.ConnectionState.Open)
                            {
                                cmd = new SqlCommand(q, con);
                                cmd.ExecuteNonQuery();

                                con.Close();
                                da = new SqlDataAdapter(cmd);
                                dt = new DataTable();
                                da.Fill(dt);
                                int j = 0;
                                if(dt.Rows[0] != null)
                                {
                                    this.GerechtenPanel.Controls.Clear();
                                }
                                foreach (DataRow dr2 in dt.Rows)
                                {
                                    Panel naamPanel = new Panel();
                                    Label naamLabel = new Label();

                                    naamPanel.Controls.Add(naamLabel);
                                    naamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                                    naamPanel.Location = new System.Drawing.Point(0, 0);
                                    naamPanel.Name = $"NaamPanel + {j}";
                                    naamPanel.Size = new System.Drawing.Size(540, 82);

                                    naamLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
                                    naamLabel.AutoSize = true;
                                    naamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                    naamLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                                    naamLabel.Location = new System.Drawing.Point(20, 7);
                                    naamLabel.Margin = new System.Windows.Forms.Padding(20);
                                    naamLabel.Name = $"naamLabel + {j}";
                                    naamLabel.MaximumSize = new System.Drawing.Size(540, 0);
                                    naamLabel.Size = new System.Drawing.Size(60, 24);
                                    naamLabel.Text = $"{dr2["naam"].ToString()}";

                                    Panel PrijsPanel = new Panel();
                                    Label prijsLabel = new Label();

                                    PrijsPanel.Controls.Add(prijsLabel);
                                    PrijsPanel.Dock = System.Windows.Forms.DockStyle.Right;
                                    PrijsPanel.Location = new System.Drawing.Point(540, 0);
                                    PrijsPanel.Name = $"PrijsPanel + {j}";
                                    PrijsPanel.Size = new System.Drawing.Size(128, 82);
                                    PrijsPanel.TabIndex = j;

                                    prijsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
                                    prijsLabel.AutoSize = true;
                                    prijsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                    prijsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                                    prijsLabel.Location = new System.Drawing.Point(0, 27);
                                    prijsLabel.Margin = new System.Windows.Forms.Padding(0);
                                    prijsLabel.Name = $"prijsLabel + {j}";
                                    prijsLabel.Size = new System.Drawing.Size(60, 24);
                                    prijsLabel.Text = $"€{dr2["prijs"].ToString()}.-";

                                    Panel MelkAlergiePanel = new Panel();

                                    if ((bool)dr2["melkalergieen"] == true)
                                    {
                                        MelkAlergiePanel.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.milk;
                                        MelkAlergiePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                                        MelkAlergiePanel.Dock = System.Windows.Forms.DockStyle.Right;
                                        MelkAlergiePanel.Location = new System.Drawing.Point(500, 0);
                                        MelkAlergiePanel.Name = "MelkAlergiePanel";
                                        MelkAlergiePanel.Size = new System.Drawing.Size(92, 82);
                                    }
                                    else
                                    {
                                        MelkAlergiePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                                        MelkAlergiePanel.Dock = System.Windows.Forms.DockStyle.Right;
                                        MelkAlergiePanel.Location = new System.Drawing.Point(500, 0);
                                        MelkAlergiePanel.Name = "MelkAlergiePanel";
                                        MelkAlergiePanel.Size = new System.Drawing.Size(92, 82);
                                    }

                                    Panel NotenAlergiePanel = new Panel();

                                    if ((bool)dr2["notenalergieen"] == true)
                                    {
                                        NotenAlergiePanel.BackgroundImage = global::Luxefoods_WindowsForms.Properties.Resources.peanut;
                                        NotenAlergiePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                                        NotenAlergiePanel.Dock = System.Windows.Forms.DockStyle.Right;
                                        NotenAlergiePanel.Location = new System.Drawing.Point(600, 0);
                                        NotenAlergiePanel.Name = "NotenAlergiePanel";
                                        NotenAlergiePanel.Size = new System.Drawing.Size(85, 82);
                                    }
                                    else
                                    {
                                        NotenAlergiePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                                        NotenAlergiePanel.Dock = System.Windows.Forms.DockStyle.Right;
                                        NotenAlergiePanel.Location = new System.Drawing.Point(600, 0);
                                        NotenAlergiePanel.Name = "NotenAlergiePanel";
                                        NotenAlergiePanel.Size = new System.Drawing.Size(85, 82);

                                    }

                                    Panel newPanel = new Panel();

                                    newPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
                                    newPanel.Controls.Add(naamPanel);
                                    newPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                    newPanel.Controls.Add(PrijsPanel);
                                    newPanel.Controls.Add(MelkAlergiePanel);
                                    newPanel.Controls.Add(NotenAlergiePanel);
                                    newPanel.Location = new System.Drawing.Point(0, 0 + (82 * j));
                                    newPanel.Margin = new System.Windows.Forms.Padding(0);
                                    newPanel.Name = "GerechtItemPanel";
                                    newPanel.Size = new System.Drawing.Size(815, 82);
                                    newPanel.TabIndex = 2;
                                    GerechtenPanel.Controls.Add(newPanel);
                                    j++;

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void HoofdmenuBtn_Click(object sender, EventArgs e)
        {
            clearAllControls((Button)sender);
            makeMenu("Hoofdmenu");
        }

        private void NagerechtBtn_Click(object sender, EventArgs e)
        {
            clearAllControls((Button)sender);
            makeMenu("Nagerecht");
        }
        private void clearAllControls(Button sender)
        {
            foreach (Control control in HeaderPanel.Controls)
            {
                control.BackColor = Color.Transparent;
            }
            sender.BackColor = Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(0)))));
        }

        private void VoorgerechtBtn_Click(object sender, EventArgs e)
        {
            clearAllControls((Button)sender);
            makeMenu("Voorgerecht");
        }

        private void DrankBtn_Click(object sender, EventArgs e)
        {
            clearAllControls((Button)sender);
            makeMenu("Dranken");
        }

        private void WijnBtn_Click(object sender, EventArgs e)
        {
            clearAllControls((Button)sender);
            makeMenu("Wijnen");
        }
    }
}
