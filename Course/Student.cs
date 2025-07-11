using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Student
    {
        public string? Name;
        public double Score1;
        public double Score2;
        public double Score3;

        public double FinalScore()
        {
            return Score1 + Score2 + Score3;
        }

        public void IsSuccessful()
        {
            double finalScore = FinalScore();
            if (finalScore > 60)
            {
                Console.WriteLine("\nAPROVADO");
            }
            else
            {
                Console.WriteLine("\nAPROVADO");
                Console.WriteLine($"FALTARAM {(finalScore - 60) * -1} PONTOS");
            }
        }
    }
}
