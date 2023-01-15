namespace juneOOP_exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product radish = new Product("Radish", 0.2m);
            // radish.ProductName = "Radish";
            // radish.unitPrice = 0.2m;//m na koncu dla decimal
            //Console.WriteLine(radish.ProductName);
            OrderItem line = new OrderItem();
            //Console.WriteLine(line.Item.ProductName);
            line.Quantity = 5;
            line.Item = radish;

            Product flower = new Product("Flower", 15);
            // flower.ProductName = "Flower";
            // flower.unitPrice = 15;
            OrderItem line2 = new OrderItem();
            line2.Quantity = 2;
            line2.Item = flower;

            
            ProductWithPackage milk = 
                new ProductWithPackage("Milk", 12m, "bottle", 1m);
            //milk.ProductName = "Milk";
            // milk.unitPrice = 12m;
            // milk.PackageName = "bottle";
            // milk.PackagePrice = 1m;
            OrderItem line3 = new OrderItem();
            line3.Quantity = 2;
            line3.Item = milk;

            ProductSet set = new ProductSet("zestaw świąteczny", 20m,
                new List<Product> { radish, flower }
            );
            OrderItem line4 = new OrderItem();
            line4.Quantity = 3;
            line4.Item = set;

            Receipt receipt = new Receipt(); //tu sie wywola konstuktor
            receipt.ReceiptLines.Add(line);
            receipt.ReceiptLines.Add(line2);
            receipt.ReceiptLines.Add(line3);
            receipt.ReceiptLines.Add(line4);
            //line.PrintOrderLine();            
            Console.WriteLine(receipt);
        }
    }

}