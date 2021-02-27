using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tumKurslar = new string[] { "Yazılım kursu",
                "Giriş",
                "Kurs3",
                "nibbatric"};


            for (int i = 0; i<tumKurslar.Length; i=i+1)
            {
                Console.WriteLine(tumKurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in tumKurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
