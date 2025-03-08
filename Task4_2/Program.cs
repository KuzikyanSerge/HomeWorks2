namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1)
            {
                Console.WriteLine("Ошибка! Число не является натуральным.");
                Console.ReadKey();
            }
            double antiFaktorial = 0;

            for (double i = 1; i <= number; i++)
            {
                antiFaktorial += 1 / i;
            }

            Console.WriteLine(antiFaktorial);
            Console.ReadKey();
        }
    }
}
