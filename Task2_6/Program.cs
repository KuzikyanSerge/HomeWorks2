namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длину трубы:");

            double L = Convert.ToDouble(Console.ReadLine());

            double t1 = L % 1 * 100 / 25;
            double t2 = L % 1 * 100 / 50;

            double l = Math.Floor(L) + Math.Floor(t1) * 0.5 - Math.Floor(t2) * 0.5;

            Console.Write("Округление до 0.5: {0}", l);
            Console.ReadKey();
        }
    }
}
