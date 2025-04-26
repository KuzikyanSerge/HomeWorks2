namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Война и мир", "Л.Н.Толстой", 1869, 1225);
            book.GetInfo();
            // Попытка задать недопустимый год
            // В задании указано что год и количество страниц должны быть автосвойствами, а не проверяемыми
            // Если это надо было сделать то можно дополнить код тем что закомментировано
            //try
            //{
            //    book.Year = -1869;
            //    book.Pages = -1225;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}
            //book.GetInfo();
            Console.ReadKey();
        }
    }
    public class Book
    {
        //Поля
        private string _title;
        private string _author;
        // В задании указано что год и количество страниц должны быть автосвойствами, а не проверяемыми
        // Если это надо было сделать, то можно дополнить код тем что закомментировано
        //private int _year;
        //private int _pages;

        //Автосвойства
        public int Year { get; set; }
        public int Pages { get; set; }
        // В задании указано что год и количество страниц должны быть автосвойствами, а не проверяемыми
        // Если это надо было сделать, то можно дополнить код тем что закомментировано
        //public int Year 
        //{ 
        //    get => _year; 
            
        //    set
        //    {
        //        if (value <= 0)
        //            throw new ArgumentException("Год не может быть отрицательным или нулевым!");
        //        _year = value;
        //    }
        //}        
        
        //public int Pages
        //{
        //    get => _pages;

        //    set
        //    {
        //        if (value <= 0)
        //            throw new ArgumentException("Количество страниц не может быть отрицательным или нулевым!");
        //        _pages = value;
        //    }
        //}

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
