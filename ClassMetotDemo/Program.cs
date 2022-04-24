using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Aslan";
            musteri1.TcNumarasi = 111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Akman";
            musteri2.TcNumarasi = 222222222;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteris)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TcNumarasi);
            }

            Console.WriteLine("----------Metot--------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            musteriManager.List(musteri1);
            musteriManager.List(musteri2);

            musteriManager.Remove(musteri1);
            musteriManager.Remove(musteri2);

        }
    }
}