namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new String('-', 45);
            Console.WriteLine("Процесс запущен");
            Console.WriteLine(separator);
            
            Console.WriteLine("Метод задач продолжения");

            Task<int[]> task1 = Task.Run(() => GenerateArray(10));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] array = t.Result;
                return CalculateArithmeticMean(array);
            });
            Console.WriteLine($"Среднее арифметическое = {task2.Result}");
            Console.WriteLine(separator);

            Console.WriteLine("Метод ассинхронности");
            int[] array = GenerateArrayAsync(10).Result;
            double num = CalculateArithmeticMeanAsync(array).Result;

            Console.WriteLine($"Среднее арифметическое = {num}");
            Console.WriteLine(separator);


            Console.WriteLine("Процесс завершен");
            Console.ReadKey();
        }
        static int[] GenerateArray(int size)
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(500);
            }

            Console.WriteLine("Массив сгенерирован!");
            return array;
        }

        static double CalculateArithmeticMean(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического...");
            int sum = 0;
            int n = array.Length;
            foreach (int num in array)
            {
                sum += num;
                Console.Write($"{n} ");
                Thread.Sleep(200);
                n -= 1;
            }
            double arithmeticMean = sum / array.Length;
            Console.WriteLine();
            Console.WriteLine("Вычисление среднего арифметического завершено");
            return arithmeticMean;
        }
        static async Task<int[]> GenerateArrayAsync(int n)
        {
            Console.WriteLine("Генерация массива асинхронно...");
            int [] array = await Task.Run(() => GenerateArray(n));
            Console.WriteLine("Массив сгенерирован асинхронно!");
            return array;
        }

        static async Task<double> CalculateArithmeticMeanAsync(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического асинхронно...");
            double result = await Task.Run(() => CalculateArithmeticMean(array));
            Console.WriteLine("Вычисление среднего арифметического асинхронно завершено");
            return result;
        }
    }
}
