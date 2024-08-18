
using PatikaKütüphane;
using System;

class Program
{
    static void Main()
    {
        // Parametreli constructor kullanarak kitap oluşturma
        Kitap kitap1 = new Kitap("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        kitap1.BilgileriYazdir();

        // Default constructor kullanarak kitap oluşturma
        Kitap kitap2 = new Kitap();
        kitap2.Ad = "Bir Kitap";
        kitap2.YazarAd = "Ahmet";
        kitap2.YazarSoyad = "YILMAZ";
        kitap2.SayfaSayisi = 320;
        kitap2.Yayınevi = "Alfa Yayınları";
        kitap2.BilgileriYazdir();
    }
}