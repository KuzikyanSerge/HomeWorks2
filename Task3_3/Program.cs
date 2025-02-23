namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое целое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе целое число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите третье целое число:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите четвертое целое число:");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            int max1 = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            int max2 = (thirdNumber > fourthNumber) ? thirdNumber : fourthNumber;
            int max = (max1 > max2) ? max1 : max2;

            Console.WriteLine("Самое большое число: {0}", max);
            Console.ReadKey();
        }
    }
}
