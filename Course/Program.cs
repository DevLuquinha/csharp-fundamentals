using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangle x, y;

        x = new Triangle();
        y = new Triangle();

        // Gets the measures of the triangle X
        Console.WriteLine("Entre com as medidas do triangulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Gets the measures of the triangle Y 
        Console.WriteLine("Entre com as medidas do triangulo Y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double xArea = x.Area();
        double yArea = y.Area();

        Console.WriteLine("Área de X = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));

        if (xArea > yArea)
            Console.WriteLine("Maior área: X");
        else
            Console.WriteLine("Maior área: Y");
    }
}