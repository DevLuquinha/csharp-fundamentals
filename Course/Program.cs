using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do dólar? ");
        double dollar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Quantos dólares vc vai comprar? ");
        double amountDollars = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double value = CurrencyConverter.CalculateValue(dollar, amountDollars);

        Console.WriteLine($"O valor a ser pago em reais = {value.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}