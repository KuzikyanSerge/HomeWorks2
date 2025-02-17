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

            //Альтернативный вариант 1. В "b" вписать число до которого нужно округлить:
            //const double b = 0.5;
            //double l = Math.Round((L - Math.Floor(L)) * 1 / b) * b + Math.Floor(L);

            //Альтернативный вариант 2. Можно указать число до которого нужно округлить в консоли: 
            //Console.WriteLine("Введите число до которого необходимо округлить в формате 0,01:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //double l = Math.Round((L - Math.Floor(L)) * 1 / b) * b + Math.Floor(L);

            Console.Write("Округление до 0.5: {0}", l);
            Console.ReadKey();
        }
    }
}
