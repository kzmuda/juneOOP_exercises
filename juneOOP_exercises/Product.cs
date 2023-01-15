namespace juneOOP_exercises;

public class Product
{
    public string ProductName { get; set;}
    public decimal UnitPrice { get; set; }


    public override string ToString()
    {
        return $"Product: {ProductName}, Unit price: {UnitPrice}";
    }

    public virtual decimal GetPrice()
    {
        return UnitPrice;
    }
}