using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.Write("Entre o valor do raio: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = calculator.Circumference(radius);
        double volume = calculator.Volume(radius);
        Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("Valor de PI: " + calculator.PI.ToString("F2", CultureInfo.InvariantCulture));
    }
}