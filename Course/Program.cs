using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount account;

        Console.Write("Entre o número da conta: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string holder = Console.ReadLine();

        Console.Write("haverá depósito inicial (s/n)? ");
        char hasInitialDeposit = char.Parse(Console.ReadLine());
        if(hasInitialDeposit == 's')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double initialDeposit = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            account = new BankAccount(number, holder, initialDeposit);
        }
        else
        {
            account = new BankAccount(number, holder);
        }

        Console.WriteLine("\nDados da conta:");
        Console.WriteLine(account.ToString());

        Console.Write("Entre um valor para depósito: ");
        account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine("\nDados da conta atualizados:");
        Console.WriteLine(account.ToString());

        Console.Write("\nEntre um valor para saque: ");
        account.WithDrow(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(account.ToString());
    }
}