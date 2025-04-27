namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Война и мир", "Л.Н.Толстой", 1869, 1225);
            try
            {
                book.Year = -1869;
                book.Pages = -1225;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            book.GetInfo();
            Console.ReadKey();
        }
    }
    public class Book
    {
        //Поля
        private string _title;
        private string _author;
        private int _year;
        private int _pages;

        //Автосвойства или полное свойство с проверкой
        public int Year
        {
            get => _year;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Год не может быть отрицательным или нулевым!");
                _year = value;
            }
        }

        public int Pages
        {
            get => _pages;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество страниц не может быть отрицательным или нулевым!");
                _pages = value;
            }
        }

        //Конструктор
        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;

        }
        //Метод
        public void GetInfo()
        {
            Console.WriteLine($"\"{_title}\", {_author}, {Year}г., {Pages} стр.");
        }

    }
}
