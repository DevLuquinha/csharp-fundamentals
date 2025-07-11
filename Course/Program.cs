using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();

        Console.Write("Nome do aluno: ");
        student.Name = Console.ReadLine()!;

        Console.WriteLine("Digite as três notas do aluno:");
        student.Score1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        student.Score2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        student.Score3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write($"NOTA FINAL = {student.FinalScore().ToString("F2")}");
        student.IsSuccessful();
    }
}