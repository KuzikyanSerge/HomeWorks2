namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Перевернутный массив");
           
            for (int i = n-1; i >= 0; i--)            
            {                
                Console.Write("{0} ", array[i]);
            }

            Console.ReadLine();
        }
    }
}
