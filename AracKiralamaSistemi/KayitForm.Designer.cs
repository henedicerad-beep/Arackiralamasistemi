using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OtoGaleriOtomasyonu
{
    public partial class KayitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.cboDurum = new System.Windows.Forms.ComboBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpArac = new System.Windows.Forms.GroupBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblIslem = new System.Windows.Forms.Label();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpArac.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(115, 32);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 20);
            this.txtPlaka.TabIndex = 3;
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(115, 72);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(200, 20);
            this.txtMarkaModel.TabIndex = 4;
            // 
            // cboDurum
            // 
            this.cboDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDurum.Items.AddRange(new object[] {
            "Kiralık",
            "Satılık"});
            this.cboDurum.Location = new System.Drawing.Point(115, 112);
            this.cboDurum.Name = "cboDurum";
            this.cboDurum.Size = new System.Drawing.Size(200, 21);
            this.cboDurum.TabIndex = 5;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(115, 32);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(200, 20);
            this.txtMusteri.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(115, 72);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 112);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(115, 152);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(210, 240);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Sisteme Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.AraciSistemeKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(380, 240);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.FormuSifirla_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpArac
            // 
            this.grpArac.Controls.Add(this.lblPlaka);
            this.grpArac.Controls.Add(this.lblMarka);
            this.grpArac.Controls.Add(this.lblIslem);
            this.grpArac.Controls.Add(this.txtPlaka);
            this.grpArac.Controls.Add(this.txtMarkaModel);
            this.grpArac.Controls.Add(this.cboDurum);
            this.grpArac.Location = new System.Drawing.Point(15, 15);
            this.grpArac.Name = "grpArac";
            this.grpArac.Size = new System.Drawing.Size(340, 200);
            this.grpArac.TabIndex = 0;
            this.grpArac.TabStop = false;
            this.grpArac.Text = " Araç Detayları ";
            // 
            // lblPlaka
            // 
            this.lblPlaka.Location = new System.Drawing.Point(15, 35);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(90, 20);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Araç Plakası:";
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(15, 75);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(90, 20);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka / Model:";
            // 
            // lblIslem
            // 
            this.lblIslem.Location = new System.Drawing.Point(15, 115);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(90, 20);
            this.lblIslem.TabIndex = 2;
            this.lblIslem.Text = "İşlem Türü:";
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.lblMusteri);
            this.grpMusteri.Controls.Add(this.lblTel);
            this.grpMusteri.Controls.Add(this.lblMail);
            this.grpMusteri.Controls.Add(this.lblTarih);
            this.grpMusteri.Controls.Add(this.txtMusteri);
            this.grpMusteri.Controls.Add(this.txtTel);
            this.grpMusteri.Controls.Add(this.txtMail);
            this.grpMusteri.Controls.Add(this.dtpTarih);
            this.grpMusteri.Location = new System.Drawing.Point(375, 15);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(340, 200);
            this.grpMusteri.TabIndex = 1;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = " Müşteri ve Sözleşme Bilgileri ";
            // 
            // lblMusteri
            // 
            this.lblMusteri.Location = new System.Drawing.Point(15, 35);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(90, 20);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Adı Soyadı:";
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(15, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(90, 20);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Telefon No:";
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(15, 115);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(90, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-Posta:";
            // 
            // lblTarih
            // 
            this.lblTarih.Location = new System.Drawing.Point(15, 155);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(90, 20);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "İşlem Tarihi:";
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 305);
            this.Controls.Add(this.grpArac);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vip Oto Galeri Satış ve Kiralama Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpArac.ResumeLayout(false);
            this.grpArac.PerformLayout();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboDurum;
        private System.Windows.Forms.DateTimePicker dtpTarih;

        private System.Windows.Forms.GroupBox grpArac;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTarih;

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}