using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных
            Console.Write("Введите телефонный номер ");
            string input = Console.ReadLine();

            //Определяем формат номера телефона
            Regex regex = new Regex(@"^\+[0-9]{1}\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$");

            //Определение номера            
            if (regex.IsMatch(input))
                Console.WriteLine("Является телефонным номером");
            else
                Console.WriteLine("Не является телефонным номером");
            Console.ReadKey();            
        }
    }
}
