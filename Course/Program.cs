using Course;
using System.Drawing;
using Rectangle = Course.Rectangle;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rec = new Course.Rectangle();
        
        Console.WriteLine("Entre a largura e altura do retângulo:");
        rec.Width = double.Parse(Console.ReadLine()!);
        rec.Heigth = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"AREA = {rec.Area()}");
        Console.WriteLine($"PERÍMETRO = {rec.Perimeter()}");
        Console.WriteLine($"DIAGONAL = {rec.Diagonal()}");
    }
}