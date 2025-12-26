using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Worker
    {
        public string Name { get; }
        public WorkerLevel Level { get; }
        public double BaseSalary { get; }
        
        private readonly List<HourContract> _contracts;
        public Worker(
            string name, 
            WorkerLevel level, 
            double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;

            _contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            _contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            _contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            var contractsFiltered  = _contracts
                .Where(c => c.Date.Year == year && c.Date.Month == month);

            return contractsFiltered.Sum(c => c.TotalValue()) + BaseSalary;
        }
    }
}
