using System;

namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int n = 10;
            const int m = 10;
            int[,] array = new int[n, m];
            int number = 1;
            int n1 = n;
            int m1 = m;
            int j1 = 1;
            int i1 = 1;
            int i2 = 0;
            int j2 = 0;
            //Формирование массива
            while (number <= n * m)
            {

                //Формирование первой строки
                for (int j = j2; j <= m1; j++)
                {
                    array[i2, j] = number;
                    number++;
                    if (number > n * m)
                        break;
                }
                if (number > n * m)
                    break;
                //Формирование последнего столбца 
                for (int i = i1; i <= n1 - i1+1; i++)
                {
                    array[i, m1 - j1] = number;
                    number++;
                    if (number > n * m)
                        break;
                }
                if (number > n * m)
                    break;
                //Формирование последней строки
                for (int j = m1 - j1; j > j2; j--)
                {
                    array[n1 - i1, j] = number;
                    number++;
                    if (number > n * m)
                        break;
                }
                if (number > n * m)
                    break;
                //Формирование первого столбца
                for (int i = n1 - i1; i > i2; i--)
                {
                    array[i, j2] = number;
                    number++;
                    if (number > n * m)
                        break;
                }
                if (number > n * m)
                    break;

                n1 -= 2;
                if (n1 <= 0)
                    n1 = 1;
                m1 -= 2;
                if (m1 <= 0)
                    m1 = 1;

                if (i2 <= n / 2)
                    i2 += 1;
                if (j2 <= m / 2)
                    j2 += 1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0,3} ", array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            //Вывод массива            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
