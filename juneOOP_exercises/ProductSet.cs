using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP_exercises
{
    public class ProductSet : Product
    {
        private List<Product> products;

        public ProductSet(string productName, decimal unitPrice, List<Product> products) 
            : base(productName, unitPrice)
        {
            this.products = products;
        }

        public override string ToString()
        {
            string ingredients = "";
            foreach (Product product in products)
            {
                ingredients += "   " + product.ProductName + Environment.NewLine;
            }
            return base.ToString() + Environment.NewLine + $"składowe: {ingredients}";
        }
    }
}
