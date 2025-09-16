using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Lucas");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Ana");

        foreach (string s in list)
            Console.WriteLine(s);

        string s1 = list.Find(s => s[0] == 'A');
        Console.WriteLine("First 'A': " + s1);

        string s2 = list.FindLast(s => s[0] == 'A');
        Console.WriteLine("Last 'A': " + s2);

        List<string> listFiltered = list.FindAll(s => s.Length == 5);
        Console.WriteLine("----------------------------------------");
        foreach (string s in listFiltered)
            Console.WriteLine(s);
    }
}