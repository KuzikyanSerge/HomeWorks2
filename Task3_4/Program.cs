namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье целое число:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int max1 = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            int max = (max1 > thirdNumber) ? max1 : thirdNumber;

            int min1 = (firstNumber < secondNumber) ? firstNumber : secondNumber;
            int min = (min1 < thirdNumber) ? min1 : thirdNumber;

            int mediana = ((firstNumber != max) && (firstNumber != min)) ? firstNumber : (((secondNumber != max) && (secondNumber != min)) ? secondNumber : thirdNumber);

            Console.WriteLine("Медиана {0}", mediana);
            Console.ReadKey();
        }
    }
}
