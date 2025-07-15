using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre o valor do raio: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculator.Circumference(radius);
        double volume = Calculator.Volume(radius);
        Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("Valor de PI: " + Calculator.PI.ToString("F2", CultureInfo.InvariantCulture));
    }
}