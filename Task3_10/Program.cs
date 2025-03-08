namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number % 10 == 0) || ((number % 10 >= 5) && (number % 10 <= 9)) || ((number > 10) && (number < 20)))
            {
                Console.WriteLine("Мы построили {0} домов", number);
                Console.ReadKey();
            }
            else
            {
                if ((number % 10 > 1) && (number % 10 < 5))
            {
                Console.WriteLine("Мы построили {0} домa", number);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Мы построили {0} дом", number);
                Console.ReadKey();
            }
                
            }
        }
    }
}
