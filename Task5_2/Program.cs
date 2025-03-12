namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            int number1 = 0;
            int number2 = 0;
            int number0 = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-20, 21);
                Console.Write("{0} ", array[i]);
                if (array[i] > 0)
                {
                    ++number1;
                }
                if (array[i] < 0)
                {
                    ++number2;
                }
                if (array[i] == 0)
                {
                    ++number0;
                }
            }
            
                Console.WriteLine();
                Console.WriteLine("Количество положительных чисел в массиве = {0}", number1);
           
                Console.WriteLine("Количество отрицательных чисел в массиве  = {0}", number2);
            
                Console.WriteLine("Количество чисел равных нулю  = {0}", number0);
            

            Console.ReadLine();
        }
    }
}
