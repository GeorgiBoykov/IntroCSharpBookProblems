// 5. A big chain of supermarkets sell millions of products. Each of them has a
// unique number (barcode), producer, name and price. What data structure
// could we use in order to quickly find all products, which cost between
// 5 and 10 dollars?

namespace Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SupermarketMain
    {
        static void Main()
        {
            SortedSet<Product> products = new SortedSet<Product>(new ProductPriceComparer());

            for (decimal i = 0; i < 10000; i += 0.1m)
            {
                Product product = new Product
                {
                    Barcode = "456456456456",
                    Producer = string.Format("Producer{0}", i),
                    Name = string.Format("Name{0}", i),
                    Price = i
                };

                products.Add(product);
            }

            List<Product> productsBetween5And10Bucks = products.Where(p => p.Price > 5 && p.Price < 10).ToList();

            foreach (Product product in productsBetween5And10Bucks)
            {
                Console.WriteLine("{0} - Price: {1}", product.Name, product.Price);
            }
        }
    }
}
