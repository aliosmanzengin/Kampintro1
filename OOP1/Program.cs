using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //ya da aşağıdaki gibi de yazabilirsin, sonuç aynı olur. aşağıdaki özellik c#'a sonradan eklenmiştir.:
            Product product2 = new Product {Id = 2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            ProductManager productManager = new ProductManager();
            //ProductManager x = new ProductManager();
            //yukarıdaki nedir?örneğin string isim = "Engin";  
            //class adları PascalCase ile yazılır. Class değişkenleri ise camelCase ile yazılır
            //referans tipleri heap'te oluşabilmesi için başına new yazıyoruz. (Sol taraf stake sağ taraf heap)
            productManager.Add(product1);
            //add parantez içine ne ekleyeceğini yazarsın (buna "parametre denir")
            //ne ekleyeceğin ise ProductManager.cs parametresinde mevcut
            Console.WriteLine(product1.ProductName);

                
        }
    }
}
