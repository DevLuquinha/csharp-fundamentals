internal class Program
{
    private static void Main(string[] args)
    {
        string[] dimensions = Console.ReadLine().Split(" ");
        
        int lineDim = int.Parse(dimensions[0]);
        int coluDim = int.Parse(dimensions[1]);
        int[,] matriz = new int[lineDim, coluDim];

        // Iterate over lines
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            string[] value = Console.ReadLine().Split(" ");
           
            // Iterate over columns
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = int.Parse(value[j]);
            }
        }

        // Choose number to find
        int num = int.Parse(Console.ReadLine()!);

        Console.WriteLine("==============================");
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                double value = matriz[i, j];
                
                if (num == value)
                {
                    // Show the number position
                    Console.WriteLine($"Position [{i},{j}]:");
                    
                    // Show the left number
                    if(j - 1 >= 0)
                    {
                        Console.WriteLine($"Left: {matriz[i, j - 1]}");
                    }
                    
                    // Show the right number
                    if (j + 1 < matriz.GetLength(1))
                    {
                        Console.WriteLine($"Right: {matriz[i, j + 1]}");
                    }

                    // Show the up number
                    if (i - 1 >= 0)
                    {
                        Console.WriteLine($"Up: {matriz[i - 1, j]}");
                    }

                    // Show the up number
                    if (i + 1 < matriz.GetLength(0))
                    {
                        Console.WriteLine($"Down: {matriz[i + 1, j]}");
                    }

                    Console.WriteLine("==============================");
                }
            }
        }
    }
}