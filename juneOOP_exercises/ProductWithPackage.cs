namespace juneOOP_exercises
{
    internal class ProductWithPackage : Product
    {
        private string packageName;
        private decimal packagePrice;

        public ProductWithPackage(string productName, decimal unitPrice, 
            string packageName, decimal packagePrice) 
            : base(productName, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public override string ToString()
        {
            return base.ToString() + $" Package: {packageName}, Package price: {packagePrice}";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + packagePrice;
        }

    }
}
