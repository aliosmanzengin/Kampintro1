using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# kursu";
            kurs1.Egitmen = "Engin Demirov";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Paytın kursu";
            kurs2.Egitmen = "Suleyman";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java kursu";
            kurs3.Egitmen = "Vladimir Putin";
            kurs3.IzlenmeOrani = 99;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + "izlenme orannı:" + kurs.IzlenmeOrani);
            }

        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
