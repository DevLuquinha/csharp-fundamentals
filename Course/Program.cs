using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Make a program to read the name and salary of two employees. Then display the average salary of the employees.
        Employee employee1, employee2;
        employee1 = new Employee();
        employee2 = new Employee();

        double average;

        // First employee
        Console.Write("Dados do primeira funcionario:\nNome: ");
        employee1.Name = Console.ReadLine();

        Console.Write("Salário: ");
        employee1.Salary = double.Parse(Console.ReadLine());

        // Second employee
        Console.Write("Dados do segundo funcionario:\nNome: ");
        employee2.Name = Console.ReadLine();

        Console.Write("Salário: ");
        employee2.Salary = double.Parse(Console.ReadLine());

        average = (employee1.Salary + employee2.Salary) / 2;

        Console.WriteLine($"Salário médio: " + average.ToString("N2"));
    }
}