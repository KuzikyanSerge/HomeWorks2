namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа:");
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine("Обновленные значения a={0} и b={1}", a, b);
            Console.ReadKey();
        }
    }
}
