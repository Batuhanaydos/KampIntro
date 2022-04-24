using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Add(Product product)
        {
            Console.WriteLine("Sepete Ekle :" + product.Adi);

        }

        public void Add2(string productAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler , Sepete Ekelendi: " + productAdi);
        }


    }
}
