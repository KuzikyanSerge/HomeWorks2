using System.Text.RegularExpressions;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задаем параметры треуголльников(можно запросить у пользователя)
            //Первый
            double a1 = 8;
            double b1 = 4;
            double c1 = 6;
            //Второй
            double a2 = 3;
            double b2 = 4;
            double c2 = 5;

            //Проверяем существуют ли треугольники(наверное это тоже можно было выделить в отдельный метод)
            if (a1 + b1 <= c1 || a1 + c1 <= b1 || b1 + c1 <= a1)
            {
                Console.WriteLine("Первый треугольник не существует");
                Console.ReadKey();
            }
            else
                if (a2 + b2 <= c2 || a2 + c2 <= b2 || b2 + c2 <= a2)
                {
                    Console.WriteLine("Второй треугольник не существует");
                    Console.ReadKey();
                }
                else
                { 
                //Вычисляем площади треугольников
                double s1 = Square(a1, b1, c1);
                double s2 = Square(a2, b2, c2);

                //Определяем какой треугольник больше по площади
                if (s1 == s2)
                    Console.WriteLine("Треугольники одинаковые");
                else
                    if (s1 > s2)
                    Console.WriteLine("Первый треугольник больше");
                else
                    Console.WriteLine("Второй треугольник больше");
                Console.ReadKey();
                }

        }

        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
