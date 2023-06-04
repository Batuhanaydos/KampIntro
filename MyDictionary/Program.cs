using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Batuhan");
            Console.WriteLine(isimler.Length);
            isimler.Add("Aydos");
            Console.WriteLine(isimler.Length);
        }
    }
}
