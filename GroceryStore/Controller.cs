using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Controller
    {
        public Product FindByUPC(string upc)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { UPCCode = "0001", Name = "Bananas", Price = 1.99M },
                new Product() { UPCCode = "1313", Name = "Apples", Price = 3.49M },
                new Product() { UPCCode = "4249", Name = "Lettuce", Price = 0.78M }
            };

            foreach (var product in products)
            {
                if (product.UPCCode == upc)
                    return product;

                return null;
            }

            Dictionary<string, Product> products = new Dictionary<string, Product>();


        }
    }
}
