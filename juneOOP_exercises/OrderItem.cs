namespace juneOOP_exercises;

public class OrderItem
{
    public int Quantity { get; set; }
    public Product Item { get; set; } //ten Item ma wszystkie property/metody klasy Product (z innego pliku. mozna sie odwolac przez Item.)


    public override string ToString()
    {
        return $" {Item}, Quantity: {Quantity}, Total value: {GetValue()}";
    }

    public decimal GetValue()
    {
        return Quantity * Item.GetPrice();
    }


}