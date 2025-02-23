namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите характеристики угла(целые значения):");
            Console.Write("Градусы=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минуты=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Секунды=");
            int c = Convert.ToInt32(Console.ReadLine());


            double r1 = (double)a * Math.PI / 180.0;
            double r2 = (double)b * Math.PI / 60.0 / 180.0;
            double r3 = (double)c * Math.PI / 60.0 / 60.0 / 180.0;
            double r4 = (double)(a - a / 360 * 360) * Math.PI / 180.0;

            double R1 = r1 + r2 + r3;
            double R2 = r4 + r2 + r3;

            Console.WriteLine("Значение в радианах ={0}", R1);
            Console.WriteLine("Значение в радианах минимальное ={0}", R2);
            Console.ReadKey();
        }
    }
}
