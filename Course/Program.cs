using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros vc vai digitar? ");
        int amount = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= amount; i++)
        {
            Console.Write($"Valor #{i}: ");
            sum += int.Parse(Console.ReadLine());
        }

        Console.Write($"Soma = {sum}");
    }
}