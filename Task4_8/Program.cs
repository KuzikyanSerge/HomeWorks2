namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое пложительное число:"); // Можно ещё добавить проверку что число положительное или использовать Math.Abs()
            int number = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            int s = 0;            
            while (number / n > 0)
            {
                n *= 10;
                s++;
            }
            int d1 = 1;
            int d2 = (int)Math.Pow(10, s - 1);
            //Если не использовать Math, вместо 17 строки:
            //int d2 = 1;
            //for (int i = 1; i < s; i++)
            //{               
            //    d2 *= 10;
            //}
            int numberMirror = 0;
            for (int i = 1; i <= s; i++)
            {
                numberMirror += number / d1 % 10 * d2;
                d1 *= 10;
                d2 /= 10;
            }
            Console.WriteLine("Отзеркаленное число = {0}", numberMirror);
            Console.ReadKey();
        }
    }
}
