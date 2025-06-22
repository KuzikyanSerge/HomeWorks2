namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте список для хранения фамилий игроков (тип string)
            List<string> players = new List<string>();
            //Добавление игроков "Иванов", "Петров", "Сидоров" методом Add.
            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            //Вставка игрока "Козлов" на позицию с индексом 1 методом Insert.
            players.Insert(1, "Козлов");

            //Проверка наличия игрока "Петров" в команде методом Contains.
            Console.WriteLine($"Игрок с фамилией Петров есть в команде? Ответ: {(players.Contains("Петров") ? "Да" : "Нет")}.");

            //Удаление игрока "Сидоров" методом Remove.
            players.Remove("Петров");

            //Поиск индекса игрока "Козлов" методом IndexOf.
            Console.WriteLine($"Игрок с фамилией Козлов имеет индекс = {players.IndexOf("Козлов")}.");

            //Сортировка списка по алфавиту методом Sort.
            players.Sort();

            //Выведите текущий состав команды в формате указанном в задании
            Console.WriteLine("Текущий состав команды отсортированный по алфавиту:");
            foreach (string player in players)
                Console.WriteLine($"{players.IndexOf(player) + 1}. {player}");

            //Проверьте, пуст ли список(свойство Count), и очистите его методом Clear.
            Console.WriteLine($"В команде есть игроки? Ответ: {(players.Count > 0 ? "Да" : "Нет")}.");
            players.Clear();
            Console.WriteLine($"Количество игроков после очистки = {players.Count}.");

            Console.ReadKey();
        }
    }
}
