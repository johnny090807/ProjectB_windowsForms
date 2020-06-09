using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Luxefoods_WindowsForms
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        PrivateFontCollection pfc = new PrivateFontCollection();
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

        /// <summary>
        ///         {
        //Create your private font collection object.
        ///PrivateFontCollection pfc = new PrivateFontCollection();

        //Select your font from the resources.
        //My font here is "Digireu.ttf"
        ///int fontLength = Properties.Resources.Lato_Light.Length;

        // create a buffer to read in to
        ///byte[] fontdata = Properties.Resources.Lato_Light;

        // create an unsafe memory block for the font data
        ///System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

        // copy the bytes to the unsafe memory block
        ///Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
           /// pfc.AddMemoryFont(data, fontLength);

            ///return pfc.Families;
       /// }s
    /// 
    /// </summary> FontFamily[] importCustomFont()


    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Reservation
            // 
            this.ClientSize = new System.Drawing.Size(298, 280);
            this.Name = "Reservation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox SeatsComboBox;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.PictureBox layoutPicture;
        private System.Windows.Forms.TableLayoutPanel AvailabilityTable;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Button PlaceReservationButton;
        private System.Windows.Forms.Label LuxeFoodsLogoLabel;
        private System.Windows.Forms.LinkLabel aboutUsButton;
        private System.Windows.Forms.LinkLabel reservationsButton;
        private System.Windows.Forms.LinkLabel menuButton;
        private System.Windows.Forms.LinkLabel contactUsButton;
        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox restaurantComboCox;
        private LuxeFoodsDataSet luxeFoodsDataSet;
        private System.Windows.Forms.BindingSource restaurantBindingSource;
        private LuxeFoodsDataSetTableAdapters.restaurantTableAdapter restaurantTableAdapter;
        private System.Windows.Forms.BindingSource reserveringBindingSource;
        private LuxeFoodsDataSetTableAdapters.reserveringTableAdapter reserveringTableAdapter;
        private System.Windows.Forms.BindingSource restaurantBindingSource1;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label Reservation_page_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1920;
        private System.Windows.Forms.ListBox listBox1819;
        private System.Windows.Forms.ListBox listBox1718;
        private System.Windows.Forms.ListBox listBox2021;
        private System.Windows.Forms.ListBox listBox2122;
        private System.Windows.Forms.ListBox listBox2223;
        private System.Windows.Forms.ListBox listBox1617;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}