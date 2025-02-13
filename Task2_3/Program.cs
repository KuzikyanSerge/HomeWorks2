namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длину в дюймах:");

            double D = (double)Convert.ToInt32(Console.ReadLine());

            const double d = 0.0254;

            int m = (int)(D * d);
            int sm = (int)(D * d * 100 % 100);
            double mm = D * d * 1000 % 10;


            Console.WriteLine("В метрической системе {0}м {1}см {2}мм", m, sm, mm);
            Console.WriteLine();
        }
    }
}
