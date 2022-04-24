using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi);
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : " + musteri.Soyadi);
        }

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Kaldırıldı : " + musteri.TcNumarasi);
        }
    }
}