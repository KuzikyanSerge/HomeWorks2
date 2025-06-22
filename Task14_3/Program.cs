using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте HashSet для хранения email - подписчиков с регистронезависимым сравнением
            HashSet<string> emails = new HashSet<string>();

            //Реализуйте следующий функционал:
            //Добавление новых подписчиков:
            //alice @example.com
            //bob@example.com
            //charlie@example.com
            emails.Add("alice@example.com");
            emails.Add("bob@example.com");
            emails.Add("charlie@example.com");

            //Попытку добавления дубликата с выводом результата операции
            Console.WriteLine($"Дубликат alice@example.com добавлен? Ответ: {(emails.Add("alice@example.com") ? "Да" : "Нет")}.");

            //Проверку наличия подписчиков в системе
            Console.WriteLine($"Есть ли подписчики в базе? Ответ: {(emails.Count > 0 ? "Да" : "Нет")}.");
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? Ответ: {(emails.Contains("bob@example.com") ? "Да" : "Нет")}.");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? Ответ: {(emails.Contains("dave@example.com") ? "Да" : "Нет")}.");

            //Создайте второе множество newSubscribers с подписчиками:
            //bob @example.com(существующий)
            //dave @example.com(новый)
            //eve @example.com(новый)
            HashSet<string> newEmails = new HashSet<string>();
            newEmails.Add("bob@example.com");
            newEmails.Add("dave@example.com");
            newEmails.Add("eve@example.com");

            //Выполните операции с множествами:
            //Объединение множеств(добавление новых подписчиков)
            HashSet<string> subscribers = new HashSet<string>(emails);
            subscribers.UnionWith(newEmails);
            Console.WriteLine("Подписчики после объединения:");
            foreach (string subscriber in subscribers)
                Console.WriteLine($"- {subscriber}");

            //Поиск пересечения(общих подписчиков), не понял почему в примере два подписчика показаны как общие,
            //мне кажется должен быть один - bob@example.com, charlie@example.com - только в первом списке есть
            //или я не понял между какими коллекциями надо было произвести поиск общих
            HashSet<string> subscribers1 = new HashSet<string>(emails);
            subscribers1.IntersectWith(newEmails);
            Console.WriteLine("Общие подписчики:");
            foreach (string subscriber in subscribers1)
                Console.WriteLine($"- {subscriber}");

            //Реализуйте:
            //Удаление подписчика, я так понял что нужно из объединенного удалять
            Console.WriteLine($"Удалили charlie@example.com? Ответ: {(subscribers.Remove("charlie@example.com") ? "Да" : "Нет")}.");
            Console.WriteLine($"Всего подписчиков = {subscribers.Count}.");

            //Проверку на подмножество, проверить на подмножество можно только со вторым списком,
            //потому что charlie@example.com удален из объединенного и первый уже не является подмножеством
            Console.WriteLine($"Является первый список подмножеством объединенного: {(emails.IsSubsetOf(subscribers) ? "Да" : "Нет")}.");
            Console.WriteLine($"Является второй список подмножеством объединенного: {(newEmails.IsSubsetOf(subscribers) ? "Да" : "Нет")}.");

            //Очистку всей коллекции
            subscribers.Clear();
            Console.WriteLine($"Количество подписчиков после очистки = {subscribers.Count}.");

            Console.ReadKey();
        }
    }
}
