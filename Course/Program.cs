using System.Globalization;

internal class Program
{
    private static double PI = 3.14;

    private static void Main(string[] args)
    {
        Console.WriteLine("Entre o valor do raio: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Circumference(radius);
        double volume = Volume(radius);
        Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
    }

    private static double Circumference(double radius)
    {
        return 2 * PI * radius;
    }

    private static double Volume(double radius)
    {
        return (4.0 / 3.0) * PI * Math.Pow(radius, 3);
    }
}