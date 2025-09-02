internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for(int i = 0; i < vect.Length; i++)
        {
            vect[i] = double.Parse(Console.ReadLine());
        }
    }
}