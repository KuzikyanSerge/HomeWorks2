namespace Task4_1
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
            int faktorial = 1;
            
            for (int i = 1; i <= number; i++)
            {
                faktorial *= i;
            }
            
            Console.WriteLine();
            Console.WriteLine("{0}! = {1}", number, faktorial);
            Console.ReadKey();
        }
    }
}
