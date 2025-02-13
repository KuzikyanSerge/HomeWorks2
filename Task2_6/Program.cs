namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длину трубы:");

            double L = Convert.ToDouble(Console.ReadLine());

            double t1 = L % 1*4;
            double t2 = L % 1*2;

            double l = Math.Floor(L) + Math.Floor(t1)*0.5 - Math.Floor(t2) * 0.5;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.Write("Округление до 0.5: {0}", l);
            Console.WriteLine();
         }
    }
}
