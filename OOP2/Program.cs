using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadı = "Demiroğ";
            musteri1.TcNo = "12345648954";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "546156";
            musteri2.SirketAdi = "SASA";
            musteri2.VergiNo = "541352";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID = L



            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


        }
    }
}
