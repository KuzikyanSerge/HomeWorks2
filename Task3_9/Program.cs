namespace Task3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            string answer = (Math.Abs(number) >= 10) ? "Число попадает в диапазон (-∞; -10] или [10; +∞)" : "Число вне диапазона";
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
