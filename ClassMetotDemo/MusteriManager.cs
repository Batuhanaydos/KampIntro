using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TcNumarasi);
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TcNumarasi);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TcNumarasi);
        }
    }
}
