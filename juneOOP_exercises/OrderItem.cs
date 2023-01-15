namespace juneOOP_exercises;

public class OrderItem
{
    public int Quantity { get; set; }
    public Product Item { get; set; } //ten Item ma wszystkie property/metody klasy Product (z innego pliku. mozna sie odwolac przez Item.)

    public void PrintOrderLine()
    {
        
        Console.WriteLine($"{Item.ProductName},{Item.UnitPrice},{Quantity},{GetValue()}");
    }

    public decimal GetValue()
    {
        return Quantity * Item.UnitPrice;
    }
    
    
}