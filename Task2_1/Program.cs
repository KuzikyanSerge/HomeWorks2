namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три целых числа:");
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());

            int p;
            p = a;
            a = c;
            c = b;
            b = p;

            Console.WriteLine("Обновленные значения a={0}, b={1} и c={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
