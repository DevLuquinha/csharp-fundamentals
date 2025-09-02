using Course;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Product[] products = new Product[n];

        for(int i = 0; i < n; i++)
        {
            Product product = new Product();
            product.Name = Console.ReadLine();
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            products[i] = product;
        }

        double sum = 0.0;

        for (int i = 0; i < n; i++)
            sum += products[i].Price;

        double avg = sum / n;

        Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}