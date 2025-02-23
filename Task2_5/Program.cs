namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы:");

            int l = (int)Math.Ceiling(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Округление с запасом: {0}", l);
            Console.ReadKey();
        }
    }
}
