using Course;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        
        Console.Write("Nome: ");
        employee.Name = Console.ReadLine();

        Console.Write("Salário Bruto: ");
        employee.GrossSalary = double.Parse(Console.ReadLine()!);

        Console.Write("Imposto: ");
        employee.Tax = double.Parse(Console.ReadLine()!);

        Console.Write($"Funcionario: {employee}");

        Console.Write("\nDigite a procentagem para aumentar o salário: ");
        employee.SalaryIncrease(double.Parse(Console.ReadLine()!));

        Console.Write($"Dados Atualizados: {employee}");
    }
}