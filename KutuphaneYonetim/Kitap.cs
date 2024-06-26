using System;
using System.Collections.Generic;
using System.IO;

namespace KutuphaneYonetim
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }

        public Kitap(string kitapAdi, string yazar, string isbn)
        {
            KitapAdi = kitapAdi;
            Yazar = yazar;
            ISBN = isbn;
        }

        // Kitap bilgilerini döndüren yöntem
        public override string ToString()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar: {Yazar}, ISBN: {ISBN}";
        }

        // Kitap bilgilerini CSV formatında döndüren yöntem
        public string ToCsvString()
        {
            return $"{KitapAdi},{Yazar},{ISBN}";
        }

        // CSV dosyasından kitap listesi okuma
        public static List<Kitap> LoadFromCsv(string filePath)
        {
            var kitaplar = new List<Kitap>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    if (values.Length == 3)
                    {
                        kitaplar.Add(new Kitap(values[0], values[1], values[2]));
                    }
                }
            }
            return kitaplar;
        }

        // Kitap listesini CSV dosyasına yazma
        public static void SaveToCsv(List<Kitap> kitaplar, string filePath)
        {
            var lines = new List<string>();
            foreach (var kitap in kitaplar)
            {
                lines.Add(kitap.ToCsvString());
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
