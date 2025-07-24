using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Product p = new Product("TV", 500, 10);

        Console.WriteLine(p.GetName());
    }
}