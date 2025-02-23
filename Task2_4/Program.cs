namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое четырехзначное число:");

            int N = Convert.ToInt32(Console.ReadLine());

            int n2 = N / 100 % 10;
            int n4 = N % 10;

            int n = N - n2 * 100 + n4 * 100 - n4  + n2 ;

            Console.Write("Новое число: {0}", n);
            Console.ReadKey();
        }
    }
}
