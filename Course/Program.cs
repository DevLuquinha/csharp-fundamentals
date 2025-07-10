using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product = new Product();

        Console.WriteLine("Entre os dados do produto:");
        
        Console.Write("Nome: ");
        product.Name = Console.ReadLine();

        Console.Write("Preço: ");
        product.Price = double.Parse(Console.ReadLine()!);

        Console.Write("Quantidade no estoque: ");
        product.Quantity = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nDados do produto: " + product);

        product.AddProduct();

        Console.WriteLine($"\nDados atualizados: " + product);

        product.RemoveProduct();

        Console.WriteLine($"\nDados atualizados: " + product);
    }
}