using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Make a program to read the data of two people, then display the name of the older person
        Person person1, person2;
        person1 = new Person();
        person2 = new Person();

        // First person
        Console.Write("Dados da primeira pessoa:\nNome: ");
        person1.Name = Console.ReadLine();

        Console.Write("Idade: ");
        person1.Age = int.Parse(Console.ReadLine());

        // Second person
        Console.Write("Dados da segunda pessoa:\nNome: ");
        person2.Name = Console.ReadLine();

        Console.Write("Idade: ");
        person2.Age = int.Parse(Console.ReadLine());

        if(person1.Age > person2.Age)
            Console.WriteLine($"Pessoa mais velha: {person1.Name}");
        else
            Console.WriteLine($"Pessoa mais velha: {person2.Name}");
    }
}