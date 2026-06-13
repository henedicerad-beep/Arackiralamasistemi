using System.Windows.Forms;

namespace OtoGaleriOtomasyonu
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private ListView lst;
        private Button btnYeni, btnDuzenle, btnSil, btnYenile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lst = new System.Windows.Forms.ListView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();

            // MainForm
            this.Text = "Araçlar - Liste";
            this.Width = 800;
            this.Height = 500;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // lst
            this.lst.View = System.Windows.Forms.View.Details;
            this.lst.FullRowSelect = true;
            this.lst.MultiSelect = false;
            this.lst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lst.Height = 360;
            this.lst.Columns.Add("Plaka", 120);
            this.lst.Columns.Add("Marka/Model", 200);
            this.lst.Columns.Add("Durum", 80);
            this.lst.Columns.Add("Müşteri", 180);
            this.lst.Columns.Add("Tarih", 100);

            // Buttons
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Left = 20;
            this.btnYeni.Top = 380;
            this.btnYeni.Width = 100;

            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Left = 140;
            this.btnDuzenle.Top = 380;
            this.btnDuzenle.Width = 100;

            this.btnSil.Text = "Sil";
            this.btnSil.Left = 260;
            this.btnSil.Top = 380;
            this.btnSil.Width = 100;

            this.btnYenile.Text = "Yenile";
            this.btnYenile.Left = 380;
            this.btnYenile.Top = 380;
            this.btnYenile.Width = 100;

            // Events
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            this.btnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            this.btnYenile.Click += new System.EventHandler(this.BtnYenile_Click);

            this.Load += new System.EventHandler(this.MainForm_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lst, this.btnYeni, this.btnDuzenle, this.btnSil, this.btnYenile });
        }
    }
}
