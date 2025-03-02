namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int n = 1;
            int s = 0;
            while (number != n)
            {                                 
                    n *= 2;
                    s++;
                    if (number < n)
                    {
                        Console.WriteLine("Число нельзя представить как степень 2-ки");
                        break; 
                    }                
            }
            if (number == n) 
                Console.WriteLine("Число можно представить как 2^{0}", s);
            Console.ReadKey();
        }
    }
}
