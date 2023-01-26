using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.ProductName);

        }

        public void Add2(string productName, string productDescription, double productPrice, int productInStock)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + productName);
        }
    }
}
