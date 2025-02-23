namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое целое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе целое число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            string simbol = (firstNumber > secondNumber) ? ">" : ((firstNumber < secondNumber) ? "<" : "=");
            Console.WriteLine("Сравнение {0} {1} {2}", firstNumber, simbol, secondNumber);
            Console.ReadKey();
        }
    }
}
