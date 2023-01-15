namespace juneOOP_exercises;

public class Receipt
{
    public List<OrderItem> ReceiptLines { get; set; }



    public Receipt() //konstruktor - dzieje sie  w momencie tworzenia obiektu - poczatkowe jakies
    {
        ReceiptLines = new List<OrderItem>();
    }

    public void PrintAllLines()
    {
        Console.WriteLine($"Receipt from {DateTime.Today}  ");
        foreach (OrderItem item in ReceiptLines)
        {
            item.PrintOrderLine();
            
            
        }
        Console.WriteLine($"Total of receipt is {GetValueReceipt()}");
    }

    public decimal GetValueReceipt()

    {
        decimal totalReceipt = 0;
        foreach (var item in ReceiptLines)
        {
            totalReceipt += item.GetValue();

        }

        return totalReceipt;

    }
}