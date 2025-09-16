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
    }
}