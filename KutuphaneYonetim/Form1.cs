using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace KutuphaneYonetim
{
    public partial class Form1 : Form
    {
        private List<Kitap> kitaplar;
        private const string filePath = "kitaplar.csv";

        public Form1()
        {
            InitializeComponent();
            kitaplar = Kitap.LoadFromCsv(filePath);
            ListeyiGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri değişkenlere atama
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string isbn = txtISBN.Text;

            // Kitap sınıfı nesnesi oluşturma
            Kitap kitap = new Kitap(kitapAdi, yazar, isbn);

            // Kitap nesnesini listeye ekleme
            kitaplar.Add(kitap);

            // Kitap listesini CSV dosyasına kaydetme
            Kitap.SaveToCsv(kitaplar, filePath);

            // Kullanıcıya bilgi mesajı gösterme
            MessageBox.Show("Kitap başarıyla eklendi!");

            // Metin kutularını temizleme
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtISBN.Clear();

            // Listeyi güncelleme
            ListeyiGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // ListBox'ta seçili olan kitabı silme
            int selectedIndex = listBoxKitaplar.SelectedIndex;
            if (selectedIndex != -1)
            {
                kitaplar.RemoveAt(selectedIndex);

                // Kitap listesini CSV dosyasına kaydetme
                Kitap.SaveToCsv(kitaplar, filePath);

                MessageBox.Show("Kitap başarıyla silindi!");
                ListeyiGuncelle(); // Listeyi güncelle
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kitap seçin.");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // ListBox'ta seçili olan kitabı düzenleme
            int selectedIndex = listBoxKitaplar.SelectedIndex;
            if (selectedIndex != -1)
            {
                // Kullanıcıdan alınan bilgileri güncelleme
                string kitapAdi = txtKitapAdi.Text;
                string yazar = txtYazar.Text;
                string isbn = txtISBN.Text;

                // Seçili kitabı güncelleme
                kitaplar[selectedIndex].KitapAdi = kitapAdi;
                kitaplar[selectedIndex].Yazar = yazar;
                kitaplar[selectedIndex].ISBN = isbn;

                // Kitap listesini CSV dosyasına kaydetme
                Kitap.SaveToCsv(kitaplar, filePath);

                MessageBox.Show("Kitap başarıyla güncellendi!");

                // Metin kutularını temizleme
                txtKitapAdi.Clear();
                txtYazar.Clear();
                txtISBN.Clear();

                // Listeyi güncelleme
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir kitap seçin.");
            }
        }

        private void listBoxKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox'ta seçili olan kitabın bilgilerini metin kutularına doldurma
            int selectedIndex = listBoxKitaplar.SelectedIndex;
            if (selectedIndex != -1)
            {
                var selectedKitap = kitaplar[selectedIndex];
                txtKitapAdi.Text = selectedKitap.KitapAdi;
                txtYazar.Text = selectedKitap.Yazar;
                txtISBN.Text = selectedKitap.ISBN;
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            // ISBN'e göre filtreleme
            string isbn = txtISBN.Text;
            var filtrelenmisKitaplar = kitaplar.FindAll(k => k.ISBN == isbn);

            listBoxKitaplar.Items.Clear();

            foreach (var kitap in filtrelenmisKitaplar)
            {
                listBoxKitaplar.Items.Add(kitap.ToString());
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            // Listeyi güncelleme
            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            // ListBox'ı temizleme
            listBoxKitaplar.Items.Clear();

            // Listedeki kitapları ListBox'a ekleme
            foreach (var kitap in kitaplar)
            {
                listBoxKitaplar.Items.Add(kitap.ToString());
            }
        }
    }
}
