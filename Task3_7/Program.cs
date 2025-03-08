using System;

namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            string answer = (Math.Abs(number) > 9) && (Math.Abs(number) < 100) ? "Двухзначное число" : "Не двухзначное число";
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
