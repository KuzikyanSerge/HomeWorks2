using System.Numerics;

namespace Task4_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа для расчета a^b('a' должно быть положительным)");
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Ошибка! 'a' должно быть положительным.");
                Console.ReadKey();
            }
            else
            {
                Console.Write("b=");
                int b = Convert.ToInt32(Console.ReadLine());

                double answer = 1;

                if (b >= 0)
                {
                    for (int i = 1; i <= b; i++)
                    {
                        answer *= a;
                    }
                }
                else
                {

                    for (int i = -1; i >= b; i--)
                    {
                        answer /= a;
                    }
                }
                Console.WriteLine("{0}^{1} = {2}", a, b, answer);
                Console.ReadKey();
            }
        }
    }
}
