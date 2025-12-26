using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string departamentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker: ");
            int contractsCount = int.Parse(Console.ReadLine());

            Worker worker = new Worker(workerName, workerLevel, baseSalary);

            for (int i = 0; i < contractsCount; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(
                    Console.ReadLine(),
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(
                    date,
                    valuePerHour,
                    hours);

                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string dateIncomeStr = Console.ReadLine();

            int month = int.Parse(dateIncomeStr.Split("/")[0]);
            int year = int.Parse(dateIncomeStr.Split("/")[1]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {departamentName}");
            Console.WriteLine($"Income for {dateIncomeStr}: {worker.Income(year, month)}");
        }
    }
}