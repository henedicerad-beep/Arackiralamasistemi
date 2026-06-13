using System.Collections.Generic;
using System.IO;

namespace OtoGaleriOtomasyonu
{
    public class AracVeriYoneticisi
    {
        private readonly string dosyaYolu = "galeri_verileri.txt"; // Dosya adı da değişti

        public List<Araba> Yukle()
        {
            var liste = new List<Araba>();
            if (!File.Exists(dosyaYolu)) return liste;

            foreach (string satir in File.ReadAllLines(dosyaYolu))
            {
                if (!string.IsNullOrWhiteSpace(satir))
                {
                    var araba = Araba.DosyadanOku(satir);
                    if (araba != null) liste.Add(araba);
                }
            }
            return liste;
        }

        public void Kaydet(List<Araba> liste)
        {
            var satirlar = new List<string>();
            foreach (var a in liste)
            {
                satirlar.Add(a.DosyaYazi());
            }
            File.WriteAllLines(dosyaYolu, satirlar);
        }
    }
}