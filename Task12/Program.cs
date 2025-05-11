namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Первый массив: Code - string (шифр книги), PublicationYear - int
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1234", 1928, "Название1", "Автор1"),
                new Book<string, int>("F-2345", 1938, "Название2", "Автор2"),
                new Book<string, int>("F-3456", 1948, "Название3", "Автор3"),
            };
            //Второй массив: Code - int(инвентарный номер), PublicationYear - string(исторические периоды)
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(41, "1958", "Название1", "Автор1"),
                new Book<int, string>(42, "100 до н.э.", "Название2", "Автор2"),
                new Book<int, string>(43, "1300-1350", "Название3", "Автор3"),
            };
            //Найдите и выведите информацию о книгах:
            Book<string, int> book1 = FindBook<string, int>(books1, "F-1234");
            Console.WriteLine(book1?.ToString() ?? "Книга не найдена");
            Book<int, string> book2 = FindBook<int, string>(books2, 42);
            Console.WriteLine(book2?.ToString() ?? "Книга не найдена");
            //Поиск книги с несуществующим кодом
            Book<int, string> book3 = FindBook<int, string>(books2, 999);
            Console.WriteLine(book3?.ToString() ?? "Книга не найдена");
            Console.ReadKey();
        }
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
        public class Book<T, U>
        {
            public T Code { get; set; }
            public U PublicationYear { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public Book(T code, U year, string title, string author)
            {
                Code = code;
                PublicationYear = year;
                Title = title;
                Author = author;
            }
            public override string ToString()
                => $"{Code}({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
