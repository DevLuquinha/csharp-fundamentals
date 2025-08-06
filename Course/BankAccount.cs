using System.Globalization;

namespace Course
{
    public class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        
        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public BankAccount(int number, string holder, double initialDeposit) : this(number, holder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void WithDrow(double value)
        {
            Balance -= value + 5;
        }
        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Holder}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
