namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers);
            PrintNumbers(numbers, true);
            Console.ReadKey();
        }

        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse == false)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
