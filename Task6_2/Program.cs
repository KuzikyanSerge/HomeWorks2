using System;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных
            Console.Write("Введите строку из слов, разделенных пробелами: ");
            string input = Console.ReadLine();

            //Избавляемся от лишних пробелов
            while (input.Contains(" "))
            {
                input = input.Replace(" ", "");
            }
            input = input.Trim();

            //Переводим все символы в нижний регистр
            input = input.ToLower();

            //Меняем порядок символов
            string newString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                newString += input[i];
            }

            //Определение палендрома
            string answer = "Не является палендромом";
            if (input == newString)
                answer = "Является палендромом";

            //Вывод результата
            Console.WriteLine("Результат: " + answer);
            Console.ReadKey();
        }
    }
}
