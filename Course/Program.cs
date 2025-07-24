using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre os dados do produto:");

        Console.Write("Nome: ");
        string? name = Console.ReadLine();

        Console.Write("Preço: ");
        double price = double.Parse(Console.ReadLine()!);

        Product product = new Product(name!, price);

        Product product3 = new Product 
        { 
            Name = "TV", 
            Price = 500, 
            Quantity = 20 
        };

        Console.WriteLine($"\nDados do produto: " + product);

        product.AddProduct();

        Console.WriteLine($"\nDados atualizados: " + product);

        product.RemoveProduct();

        Console.WriteLine($"\nDados atualizados: " + product);

        Console.WriteLine(product);
    }
}