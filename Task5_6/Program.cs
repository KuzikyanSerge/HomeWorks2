namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            // добавил ввод с клавиатуры для размера массива и это сработало, ошибки не было
            //int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        array[i, j] = j % 2 == 0 ? 1 : 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                    else
                    {
                        array[i, j] = j % 2 == 0 ? 0 : 1;
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
