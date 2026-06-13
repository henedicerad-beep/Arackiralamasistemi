using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OtoGaleriOtomasyonu
{
    public partial class MainForm : Form
    {
        private AracVeriYoneticisi veri;

        public MainForm()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                veri = new AracVeriYoneticisi();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lst.Items.Clear();
            var items = veri.Yukle();
            foreach (var a in items)
            {
                var l = new ListViewItem(new[] { a.Plaka, a.MarkaModel, a.Durum, a.MusteriAdSoyad, a.KayitTarihi });
                lst.Items.Add(l);
            }
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            var f = new KayitForm();
            f.FormClosed += (s, ev) => RefreshList();
            f.ShowDialog(this);
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            if (lst.SelectedItems.Count == 0) return;
            var plaka = lst.SelectedItems[0].SubItems[0].Text;
            var items = veri.Yukle();
            var a = items.Find(x => x.Plaka == plaka);
            if (a == null) return;

            var f = new KayitForm();
            f.SetAraba(a);
            f.FormClosed += (s, ev) => RefreshList();
            f.ShowDialog(this);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lst.SelectedItems.Count == 0) return;
            var plaka = lst.SelectedItems[0].SubItems[0].Text;
            var items = veri.Yukle();
            var idx = items.FindIndex(x => x.Plaka == plaka);
            if (idx >= 0)
            {
                if (MessageBox.Show("Seçili araç silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    items.RemoveAt(idx);
                    veri.Kaydet(items);
                    RefreshList();
                }
            }
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
