using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Product p = new Product("TV", 500, 10);
        p.Name = "T";

        Console.WriteLine(p.Name);
        Console.WriteLine(p.Price);
    }
}