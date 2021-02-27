using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 01510;
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Info = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 01500;
            product2.Name = "Karpuz";
            product2.Price = 25;
            product2.Info = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };
           
            //type-safe -- tip güvenli (ney ile çalışacağını bilmek ister) ("var" da yazabilirsin)
            foreach (Product product in products)
            {
                Console.WriteLine("Id No:___________" + product.Id);
                Console.WriteLine("Ürün Adı:________" + product.Name);
                Console.WriteLine("Fiyat:___________" + product.Price);
                Console.WriteLine("Ürün Bilgisi:____" + product.Info);
                Console.WriteLine("-------");

            }

            Console.WriteLine("____METOTLAR____");
           
            //instance- class örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Deveci", 12);



        }
    }
}
