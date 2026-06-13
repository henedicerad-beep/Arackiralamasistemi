using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace OtoGaleriOtomasyonu
{
    public partial class KayitForm : Form
    {
        private AracVeriYoneticisi veriYoneticisi;

        public KayitForm()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                veriYoneticisi = new AracVeriYoneticisi();
            }
        }

        private bool GirdileriDenetle()
        {
            bool sonuc = true;

            if (string.IsNullOrWhiteSpace(txtPlaka.Text)) { errorProvider1.SetError(txtPlaka, "Plaka boş geçilemez!"); sonuc = false; }
            else if (!IsPlakaValid(txtPlaka.Text)) { errorProvider1.SetError(txtPlaka, "Geçersiz plaka formatı! Örnek: 34 AB 1234 veya 06ABC123"); sonuc = false; }
            else errorProvider1.SetError(txtPlaka, "");
            if (string.IsNullOrWhiteSpace(txtMarkaModel.Text)) { errorProvider1.SetError(txtMarkaModel, "Marka/Model boş geçilemez!"); sonuc = false; } else errorProvider1.SetError(txtMarkaModel, "");
            if (cboDurum.SelectedIndex == -1) { errorProvider1.SetError(cboDurum, "Durum seçilmelidir!"); sonuc = false; } else errorProvider1.SetError(cboDurum, "");
            if (string.IsNullOrWhiteSpace(txtMusteri.Text)) { errorProvider1.SetError(txtMusteri, "Müşteri adı boş geçilemez!"); sonuc = false; } else errorProvider1.SetError(txtMusteri, "");

            if (!string.IsNullOrWhiteSpace(txtTel.Text) && !Regex.IsMatch(txtTel.Text, @"^05\d{9}$"))
            { errorProvider1.SetError(txtTel, "Format: 05XXXXXXXXX"); sonuc = false; }
            else errorProvider1.SetError(txtTel, "");

            if (!string.IsNullOrWhiteSpace(txtMail.Text) && !Regex.IsMatch(txtMail.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            { errorProvider1.SetError(txtMail, "Geçersiz e-posta!"); sonuc = false; }
            else errorProvider1.SetError(txtMail, "");

            return sonuc;
        }

        private void AraciSistemeKaydet_Click(object sender, EventArgs e)
        {
            if (!GirdileriDenetle()) return;

            var liste = veriYoneticisi.Yukle();

            var a = new Araba
            {
                Plaka = NormalizePlaka(txtPlaka.Text.Trim()),
                MarkaModel = txtMarkaModel.Text.Trim(),
                Durum = cboDurum.Text,
                MusteriAdSoyad = txtMusteri.Text.Trim(),
                Telefon = txtTel.Text.Trim(),
                Eposta = txtMail.Text.Trim(),
                KayitTarihi = dtpTarih.Value.ToString("yyyy-MM-dd"),
                // TeslimTarihi kaldırıldı
            };

            int idx = liste.FindIndex(x => x.Plaka == a.Plaka);
            if (idx >= 0)
            {
                liste[idx] = a;
                MessageBox.Show("Sözleşme ve araç bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                liste.Add(a);
                MessageBox.Show("Yeni araç kaydı başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            veriYoneticisi.Kaydet(liste);
            this.Close();
        }

        private void CboDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private bool IsPlakaValid(string plaka)
        {
            if (string.IsNullOrWhiteSpace(plaka)) return false;
            var cleaned = Regex.Replace(plaka, "[\\s-]", "");
            var pattern = "^(\\d{2})([A-Za-zÇĞİÖŞÜçğıöşü]{1,3})(\\d{1,4})$";
            return Regex.IsMatch(cleaned, pattern, RegexOptions.IgnoreCase);
        }

        private string NormalizePlaka(string plaka)
        {
            if (string.IsNullOrWhiteSpace(plaka)) return plaka;
            var cleaned = Regex.Replace(plaka, "[^0-9A-Za-zÇĞİÖŞÜçğıöşü]", "");
            var m = Regex.Match(cleaned, "^(\\d{2})([A-Za-zÇĞİÖŞÜçğıöşü]{1,3})(\\d{1,4})$", RegexOptions.IgnoreCase);
            if (!m.Success) return plaka.ToUpper(new CultureInfo("tr-TR"));

            var province = m.Groups[1].Value;
            var letters = m.Groups[2].Value.ToUpper(new CultureInfo("tr-TR"));
            var numbers = m.Groups[3].Value;

            return $"{province} {letters} {numbers}";
        }

        private void FormuSifirla_Click(object sender, EventArgs e)
        {
            txtPlaka.Clear();
            txtMarkaModel.Clear();
            txtMusteri.Clear();
            txtTel.Clear();
            txtMail.Clear();
            cboDurum.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Today;
            errorProvider1.Clear();
        }

        public void SetAraba(Araba a)
        {
            if (a == null) return;
            txtPlaka.Text = a.Plaka;
            txtMarkaModel.Text = a.MarkaModel;
            cboDurum.Text = a.Durum;
            txtMusteri.Text = a.MusteriAdSoyad;
            txtTel.Text = a.Telefon;
            txtMail.Text = a.Eposta;
            DateTime dt;
            if (DateTime.TryParse(a.KayitTarihi, out dt)) dtpTarih.Value = dt;
            else dtpTarih.Value = DateTime.Today;
        }
    }
}