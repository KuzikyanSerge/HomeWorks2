namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
            Console.ReadKey();
        }

        static int FindMax(params int[] numbers)
        {
            int maxNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                    maxNumber = numbers[i];
            }
            return maxNumber; 
        }
    }
}
