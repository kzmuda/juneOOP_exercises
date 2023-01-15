namespace juneOOP_exercises;

public class Product
{
    public string ProductName { get; }
    protected decimal unitPrice;

    public Product(string productName, decimal unitPrice)
    {
        this.ProductName = productName;
        this.unitPrice = unitPrice;
    }

    public override string ToString()
    {
        return $"Product: {ProductName}, Unit price: {unitPrice}";
    }

    public virtual decimal GetPrice()
    {
        return unitPrice;
    }
}