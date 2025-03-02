namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int n = 1;
            int s = 0;
            while (number / n > 0)
            {                
                    n *= 10;
                    s++;                
            }
            Console.WriteLine("Количество цифр в числе = {0}", s);
            Console.ReadKey();
        }
    }
}
