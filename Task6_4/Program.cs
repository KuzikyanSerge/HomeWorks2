using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных(можно также отдельно запросить каждую характеристику)
            Console.Write("Введите последовательно имя, возраст и город рождения через пробелы: ");
            string input = Console.ReadLine();

            //Избавляемся от лишних пробелов
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            input = input.Trim();

            //Разделяем строку на слова
            string[] words = input.Split(' ');

            //Собираем строку с помощью StringBuilder
            StringBuilder result = new StringBuilder();
            result.Append("Имя: " + words[0] + ", ");
            result.Append("Возраст: " + words[1] + ", ");
            result.Append("Город рождения: " + words[2]);

            //Вывод
            Console.WriteLine();
            Console.WriteLine("Отформатированная информация:");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
