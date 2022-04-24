using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> dictonarys = new MyDictonary<string>();
            dictonarys.Add("Batuhan");

            Console.WriteLine(dictonarys.Length);

            dictonarys.Add("Ahmet");

            Console.WriteLine(dictonarys.Length);

            foreach (var dictonary in dictonarys.Items)
            {
                Console.WriteLine(dictonary);
            }
        }
    }
}
