namespace juneOOP_exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product radish = new Product();
            radish.ProductName = "Radish";
            radish.UnitPrice = 0.2m;//m na koncu dla decimal
            //Console.WriteLine(radish.ProductName);
            OrderItem line = new OrderItem();
            //Console.WriteLine(line.Item.ProductName);
            line.Quantity = 5;
            line.Item = radish;

            Product flower = new Product();
            flower.ProductName = "Flower";
            flower.UnitPrice = 15;
            OrderItem line2 = new OrderItem();
            line2.Quantity = 2;
            line2.Item = flower;

            
            ProductWithPackage milk = new ProductWithPackage();
            milk.ProductName = "Milk";
            milk.UnitPrice = 12m;
            milk.PackageName = "bottle";
            milk.PackagePrice = 1m;
            OrderItem line3 = new OrderItem();
            line3.Quantity = 2;
            line3.Item = milk;

            Receipt receipt = new Receipt(); //tu sie wywola konstuktor
            receipt.ReceiptLines.Add(line);
            receipt.ReceiptLines.Add(line2);
            receipt.ReceiptLines.Add(line3);
            //line.PrintOrderLine();            

            Console.WriteLine(receipt);
        }
    }

}