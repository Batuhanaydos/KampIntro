using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Batuhan";
            musteri1.Soyadi = "Aydos";
            musteri1.TcNumarasi = 1111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Arslan";
            musteri2.TcNumarasi = 222222222;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Alimzade";
            musteri3.TcNumarasi = 333333333;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListeleme(musteri2);
            musteriManager.MusteriSilme(musteri3);
        }
    }
}
