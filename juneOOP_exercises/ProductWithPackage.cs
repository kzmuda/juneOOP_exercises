using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP_exercises
{
    internal class ProductWithPackage : Product
    {
        public string PackageName;
        public decimal PackagePrice;

        public override string ToString()
        {
            return base.ToString() + $" Package: {PackageName}, Package price: {PackagePrice}";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + PackagePrice;
        }

    }
}
