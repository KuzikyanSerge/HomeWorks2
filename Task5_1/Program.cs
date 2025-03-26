namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            int number1 = 0;
            int number2 = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 101);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 == 0)
                {
                    ++number2;
                        }
                else
                {
                    ++number1;
                };
            }
            if (number1 > number2)
            {
                Console.WriteLine();
                Console.WriteLine("В массиве больше нечетных чисел = {0}", number1);
            }
            if (number1 < number2)
            {
                Console.WriteLine();
                Console.WriteLine("В массиве больше четных чисел = {0}", number2);
            }
            if (number1 == number2)
            {
                Console.WriteLine();
                Console.WriteLine("В массиве поровну четных и нечетных чисел");
            }

            Console.ReadLine();

        }
    }
}
