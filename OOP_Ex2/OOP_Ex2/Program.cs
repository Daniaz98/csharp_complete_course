using System.Globalization;
using OOP_Ex2.Entities;

namespace OOP_Ex2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        
        List<Product> products = new List<Product>();

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Product #{i} data: ");
            Console.WriteLine("Common, used or imported (c/u/i)?");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Price: ");
            var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'i')
            {
                Console.Write("Customs fee: ");
                var fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(name, price, fee));
            }
            else if (ch == 'u')
            {
                Console.Write("Manufacture date (dd/MM/yyyy): ");
                var date = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                products.Add(new UsedProduct(date, name, price));
            }
            else
            {
                products.Add(new Product(name, price));
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("PRICE TAGS: ");

        foreach (var pd in products)
        {
            Console.WriteLine(pd.PriceTag());
        }
    }
}