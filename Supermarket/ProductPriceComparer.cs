namespace Supermarket
{
    using System.Collections.Generic;

    class ProductPriceComparer : IComparer<Product>
    {

        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
