namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных
            Console.Write("Введите строку из слов, разделенных пробелами: ");
            string input = Console.ReadLine();

            //Избавляемся от лишних пробелов
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            input = input.Trim();

            //Разделяем строку на слова
            string[] words = input.Split(' ');
                        
            // Обрабатываем каждое слово
            int l = words[0].Length;
            string s = words[0];
            foreach (string word in words)
            {
                if (word.Length > l)
                {
                    l = word.Length;
                    s = word;
                }
            }    

            //Вывод результата
            Console.WriteLine("Самоое длинное слово:");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
