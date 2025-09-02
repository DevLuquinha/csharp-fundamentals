using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for(int i = 0; i < vect.Length; i++)
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double sum = 0.0;

        for (int i = 0; i < vect.Length; i++)
            sum += vect[i];

        double avg = sum / n;

        Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}