using System;
using System.Globalization;

namespace OtoGaleriOtomasyonu
{
    public class Araba
    {
        public string Plaka { get; set; }
        public string MarkaModel { get; set; }
        public string Durum { get; set; } // "Kiralık" veya "Satılık"
        public string MusteriAdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string KayitTarihi { get; set; }

        public string DosyaYazi()
        {
            return $"{Plaka},{MarkaModel},{Durum},{MusteriAdSoyad},{Telefon},{Eposta},{KayitTarihi}";
        }

        public static Araba DosyadanOku(string satir)
        {
            string[] p = satir.Split(',');
            if (p.Length < 7) return null;

            string durum = NormalizeDurum(p[2]);
            string tarih = NormalizeTarih(p[6]);

            return new Araba
            {
                Plaka = p[0],
                MarkaModel = p[1],
                Durum = durum,
                MusteriAdSoyad = p[3],
                Telefon = p[4],
                Eposta = p[5],
                KayitTarihi = tarih
            };
        }

        private static string NormalizeDurum(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;
            var s = raw.Trim().ToLowerInvariant();
            if (s.Contains("sat")) return "Satılık";
            if (s.Contains("kiral")) return "Kiralık";
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(raw.Trim());
        }

        private static string NormalizeTarih(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;
            string s = raw.Trim();
            DateTime dt;
            if (DateTime.TryParse(s, new CultureInfo("tr-TR"), DateTimeStyles.None, out dt) ||
                DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                return dt.ToString("yyyy-MM-dd");
            }

            try
            {
                var tr = new CultureInfo("tr-TR");
                var formats = new[] { "d MMMM yyyy", "dd MMMM yyyy", "MMMM d yyyy", "MMMM dd yyyy" };
                foreach (var f in formats)
                {
                    if (DateTime.TryParseExact(s, f, tr, DateTimeStyles.None, out dt))
                        return dt.ToString("yyyy-MM-dd");
                }
            }
            catch
            {
            }

            return raw;
        }
    }
}