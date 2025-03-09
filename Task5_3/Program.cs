namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            int max = 0;
            int min = 50;//можно диапазон значаний массива записать как переменные и тогда это значение будет автоматически подстваляться чтобы в цикле корректно происходило сравнение
            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write("{0} ", array[i]);
                
                if (array[i] >= max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] <= min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }

            Console.WriteLine();
            
            Console.WriteLine("Самое большое число в массиве = {0} с индексом {1}", max,indexMax);

            Console.WriteLine("Самое маленькое число в массиве = {0} с индексом {1}", min, indexMin);

            Console.ReadLine();
        }
    }
}
