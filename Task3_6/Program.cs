namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());

            string answer = (number % 2 == 0) ? "Четное число" : "Нечетное число";
            Console.WriteLine(answer);
            Console.ReadKey();          
        }
    }
}
