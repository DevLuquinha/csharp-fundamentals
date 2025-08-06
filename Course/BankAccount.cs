using System.Globalization;

namespace Course
{
    public class BankAccount
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        
        public BankAccount()
        {
            Balance = 0;
        }


        public void Deposit(double value)
        {
            Balance += value;
        }

        public void WithDrow(double value)
        {
            Balance -= (value+5);
        }
        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Holder}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
