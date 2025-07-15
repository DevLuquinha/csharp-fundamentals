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

        Console.Write("Quantidade no estoque: ");
        int quantity = int.Parse(Console.ReadLine()!);

        Product product = new Product(name!, price, quantity);

        Console.WriteLine($"\nDados do produto: " + product);

        product.AddProduct();

        Console.WriteLine($"\nDados atualizados: " + product);

        product.RemoveProduct();

        Console.WriteLine($"\nDados atualizados: " + product);

        Console.WriteLine(product);
    }
}