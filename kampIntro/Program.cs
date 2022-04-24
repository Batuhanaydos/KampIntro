using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            String urunAdi = "Elma";
            double fiyati = 15;
            String aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma", "Karpuz"};

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------------------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Add2("Elma", "Amasya Elması", 15, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 80, 8);
           
        }
    }
}
