using System.Globalization;

namespace Course
{
    internal class Employee
    {
        public string? Name;
        public double GrossSalary;
        public double Tax;

        public double LiquidSalary()
        {
            return GrossSalary - Tax;
        }

        public void SalaryIncrease(double percent)
        {
            GrossSalary += GrossSalary * (percent / 100);
        }

        public override string ToString()
        {
            return $"{Name}, $ {LiquidSalary().ToString("F2", CultureInfo.InvariantCulture)}";
             
        }
    }
}
