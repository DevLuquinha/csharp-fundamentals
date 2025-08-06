using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount();

        Console.Write("Entre o número da conta: ");
        bankAccount.Number = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        bankAccount.Holder = Console.ReadLine();

        Console.Write("haverá depósito inicial (s/n)? ");
        string hasInitialDeposit = Console.ReadLine();
        if(hasInitialDeposit == "s")
        {
            Console.Write("Entre o valor de depósito inicial: ");
            bankAccount.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        }

        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(bankAccount.ToString());

        Console.Write("Entre um valor para depósito: ");
        bankAccount.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine("\nDados da conta atualizados:");
        Console.WriteLine(bankAccount.ToString());

        Console.Write("\nEntre um valor para saque: ");
        bankAccount.WithDrow(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(bankAccount.ToString());
    }
}