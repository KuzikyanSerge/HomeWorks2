namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separator = new String('-', 20);
            try
            {
            //Создание объектов обоих типов
            Building building = new Building("г.Москва", 1500, 1988);
            MultiBuilding multiBuilding = new MultiBuilding("г.Москва", 10000, 2000, 10, true);
            building.DisplayInfo();
            Console.WriteLine(separator);
            multiBuilding.DisplayInfo();
            Console.WriteLine(separator);

            //Upcasting (приведение производного класса к базовому)
            Building building1 = multiBuilding;

            //Downcasting (обратное приведение с проверкой типа)
            MultiBuilding multiBuilding1 = building1 as MultiBuilding;

            //Вызов переопределенных методов
            Console.WriteLine($"Налог многоэтажного здания = {multiBuilding.CalculateTax()}");
            Console.WriteLine(separator);
            Console.WriteLine($"Налог здания = {building1.CalculateTax()}");//Срабатывает переопределенный метод хотя объект класса Building
            Console.WriteLine(separator);
            Console.WriteLine($"Налог многоэтажного здания = {multiBuilding1.CalculateTax()}");
            Console.WriteLine(separator);
            Console.WriteLine($"Налог здания = {building.CalculateTax()}");
            Console.WriteLine(separator);
            building1.DisplayInfo();//Срабатывает переопределенный метод хотя объект класса Building
            Console.WriteLine(separator);

            //Использование уникальных методов производного класса
            //Не понял как продемонстировать, но если убрать комментарии в строках ниже, то выдаст ошибку уже после запуска.
            //При этом в коде красным не будет подкрашено
            //MultiBuilding multiBuilding2 = building as MultiBuilding;
            Console.WriteLine($"Площадь одного этажа = {multiBuilding.AreaPerFloor}");
            Console.WriteLine(separator);
            //Console.WriteLine($"Площадь одного этажа = {multiBuilding2.AreaPerFloor}");
            //Console.WriteLine(separator);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
    Console.ReadKey();
        }
    }
    public class Building
    {
        //Поля
        protected string _address;
        protected double _area;
        protected int _yearBuilt;

        //Поля только для чтения
        public readonly int BuildingAge;

        //Автосвойства или полное свойство с проверкой
        public int YearBuilt
        {
            get => _yearBuilt;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Год не может быть отрицательным или нулевым!");
                _yearBuilt = value;
            }
        }

        public double Area
        {
            get => _area;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Площадь не может быть отрицательной или нулевой!");
                _area = value;
            }
        }

        //Конструктор
        public Building(string address, double area, int year)
        {
            _address = address;
            Area = area;
            YearBuilt = year;
            BuildingAge = DateTime.Now.Year - YearBuilt;
        }
        //Методы
        public virtual double CalculateTax()
        {
            return Area * 1000;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Информация о здании:");
            Console.WriteLine($"Адрес: {_address},\nПлощадь = {Area}кв.м,\nГод постройки: {YearBuilt}г.,\nВозраст здания: {BuildingAge},\nНалог = {CalculateTax()}");
        }
    }
    sealed public class MultiBuilding : Building
    {
        //Поля
        int _floors;
        bool _hasElevator;

        //Поля только для чтения
        public readonly double AreaPerFloor;

        //Автосвойства или полное свойство с проверкой
        public int Floors
        {
            get => _floors;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество этажей не может быть отрицательным или нулевым!");
                _floors = value;
            }
        }
        public bool HasElevator { get; set; }

        //Конструктор           
        public MultiBuilding(string address, double area, int year, int floors, bool hasElevator)
            : base(address, area, year)
        {
            Floors = floors;
            HasElevator = hasElevator;
            AreaPerFloor = Area / Floors;
        }

        //Методы
        public override double CalculateTax()
        {
            int L = HasElevator == true ? 5000 : 0;
            return Area * 1000 * (1 + (_floors - 1) * 0.05) + L;
        }
        public override void DisplayInfo()
        {
            string answer = HasElevator == true ? "Есть лифт" : "Нет лифта";
            Console.WriteLine("Информация о многоэтажном здании:");
            Console.WriteLine($"Адрес: {_address},\nПлощадь = {Area}кв.м,\nГод постройки: {YearBuilt}г.,\nВозраст здания: {BuildingAge},\nНалог = {CalculateTax()}");
            Console.WriteLine($"Количество этажей = {Floors},\nПлощадь одного этажа = {AreaPerFloor},\nНаличие лифта: {answer}");
        }
    }
}
