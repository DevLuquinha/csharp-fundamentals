internal class Program
{
    private static void Main(string[] args)
    {
        int dimension = int.Parse(Console.ReadLine()!);
        double[,] matriz = new double[dimension, dimension];

        // Iterate over lines
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            // Iterate over columns
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                double number = double.Parse(Console.ReadLine()!);
                matriz[i, j] = number;
            }
        }

        // Show main diagonal
        Console.WriteLine("Main Diagonal: ");
        int negativeAmount = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                double number = matriz[i, j];
                if (i == j)
                {
                    Console.Write($"{number} ");
                }

                if (number < 0)
                {
                    negativeAmount++;
                }
            }
        }

        Console.WriteLine($"\nNegative Numbers = {negativeAmount}");
    }
}