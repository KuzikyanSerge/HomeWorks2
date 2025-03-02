namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());
            if ((number < 20) || (number > 60))
            {
                Console.WriteLine("Введите другое число:");
                while ((number < 20) || (number > 60))
                {
                    double n = Convert.ToDouble(Console.ReadLine());
                    if ((n < 20) || (n > 60))
                    {
                        Console.WriteLine("Введите другое число:");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Число входит в диапазон [20; 60]");
            Console.ReadKey();
        }
    }
}
