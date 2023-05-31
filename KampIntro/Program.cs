using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 145;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 20.00;
            double dolarBugun = 21.00;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if ( sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayaları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
