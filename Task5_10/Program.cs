namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] array = new int[n, n];
            Random random = new Random();
            //Генерируем массив
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            // Проверяем крестики по главной и побочной диагонали
            int a = 0;
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) && (array[i, j] == 1))
                        a++;
                    if ((i == n - 1 - j) && (array[i, j] == 1))
                        b++;
                }
            }
            int d1 = a == n ? 1 : 0;            
            int d2 = b == n ? 1 : 0;
            // Проверяем крестики по горизонтали
            int g = 0;
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x = 0;
                for (int j = 1; j < n; j++)
                {
                    if ((array[i, j] == array[i, j - 1]) && (array[i, j] == 1))
                        x++;
                    if (x == n - 1)
                    {
                        g = 1;
                        break;
                    }
                }
            }
            // Проверяем крестики по вертикали
            int v = 0;
            int y = 0;
            for (int j = 0; j < n; j++)
            {
                y = 0;
                for (int i = 1; i < n; i++)
                {
                    if ((array[i, j] == array[i - 1, j]) && (array[i, j] == 1))
                        y++;
                    if (y == n - 1)
                    {
                        v = 1;
                        break;
                    }
                }
            }
            //Проверяем прошла ли какая то проверка
            string answer = d1 + d2 + g + v > 0 ? "крестики" : "нолики";
            
            //Для проверки какие проверки прошли
            //Console.WriteLine();
            //Console.WriteLine("d1 {0}, d2 {1}, g {2}, v {3}", d1, d2, g, v);
            
            Console.WriteLine("Победили {0} ", answer);
            Console.ReadLine();
        }
    }
}
