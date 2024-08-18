using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKütüphane
{
    public class Kitap  //İlk olarak kitabın özelliklerini atıyoruz.
    {
        public string Ad { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayınevi { get; set; }
        public DateTime KayitTarihi { get; private set; }

        // Default constructor
        public Kitap()
        {
            KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik olarak atanır
        }

        // Parametreli constructor
        public Kitap(string ad, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayınevi)
        {
            Ad = ad;
            YazarAd = yazarAd;
            YazarSoyad = yazarSoyad;
            SayfaSayisi = sayfaSayisi;
            Yayınevi = yayınevi;
            KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik olarak atanır

        }

        // Kitap bilgilerini ekrana yazdırma metodu
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Yazar: {YazarAd} {YazarSoyad}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayınevi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");

        }
    }
}








        
    
