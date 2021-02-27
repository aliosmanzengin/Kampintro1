using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.Name + ", Added to Chart");
        }

        public void Add2(string productName, string aciklama, double price)
        {
            Console.WriteLine(productName + ", Added to Chart");
        }
    }
}
