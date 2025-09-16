using Course;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("How many employees will be registered? ");
        int employeeAmount = int.Parse(Console.ReadLine()); 
        
        for(int i = 0; i < employeeAmount; i++)
        {
            Employee employee = new Employee();
            Console.WriteLine($"Employee #{i+1}:");
            
            Console.Write("Id: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());

            employees.Add(employee);
            Console.WriteLine();
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int id = int.Parse(Console.ReadLine());

        List<Employee> query = employees.FindAll(e => e.Id == id);
        if (query.Count > 0)
        {
            Console.Write("Enter the percentage: ");
            query[0].IncreaseSalary(double.Parse(Console.ReadLine()));
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine("\nUpdated list of employees:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }

    }
}