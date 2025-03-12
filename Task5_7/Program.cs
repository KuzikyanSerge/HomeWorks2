using System;

namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 10;
            int[,] array = new int[n, m];
            Random random = new Random();
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(0, 11);
                    Console.Write("{0,2} ", array[i, j]);
                    max = max > array[i, j] ? max: array[i, j];
                }
                Console.Write("  max= {0,2}",max);
                max = 0;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
