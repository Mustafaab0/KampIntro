using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.ProductPrice = 15;
            product1.ProductDescription = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 50;
            product2.ProductDescription = "Diyabakır Karpuzu";

            Product[] products= new Product[] { product1, product2 };

            foreach (Product product in products) 
            {
                Console.WriteLine("Ürün Adı : " +   product.ProductName);
                Console.WriteLine("Ürün Fiyatı : " + product.ProductPrice);
                Console.WriteLine("Ürün Açıklama : " + product.ProductDescription);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("----------Metodlar---------");

            CartManager cartManager= new CartManager();

            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Armut", "Deveci", 12, 5);
            cartManager.Add2("Elma", "Arjantin", 12, 7);
            cartManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 3);
        }
    }
}