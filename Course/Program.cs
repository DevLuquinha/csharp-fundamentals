using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double xA, xB, xC, yA, yB, yC;

        // Gets the measures of the triangle X
        Console.WriteLine("Entre com as medidas do triangulo X: ");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Gets the measures of the triangle Y 
        Console.WriteLine("Entre com as medidas do triangulo Y: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double p = (xA + xB + xC) / 2;
        double xArea = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2;
        double yArea = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine("Área de X = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));

        if (xArea > yArea)
            Console.WriteLine("Maior área: X");
        else
            Console.WriteLine("Maior área: Y");
    }
}