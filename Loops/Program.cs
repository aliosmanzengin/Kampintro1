using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "1.Kurs", "2.kurs", "3.Kurs" };


            for (string kurslar = 0; kurslar < 3; kurslar++)
            {
                Console.WriteLine(kurslar);
            }
        }
    }
}
