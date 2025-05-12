namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива, содержащего объекты обоих типов
            try
            {
                IFlyable[] flyables = new IFlyable[]
                    {
                    new Bird(30),
                    new Bird(30),
                    new Bird(30),
                    new Airplane(1000, 0),
                    new Airplane(1000, 100),
                    new Airplane(1000, 150)
                    };
            //Использование полиморфизма (вызовите для каждого элемента в массиве метод Fly())
            foreach (IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }            
            Console.ReadKey();
        }
    }
    public interface IFlyable
    {
        int MaxAltitude { get; }
        void Fly();
    }
    public class Bird : IFlyable
    {
        int _maxAltitude;
        public int MaxAltitude { 
            get => _maxAltitude;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота полета не может быть отрицательной или нулевой!");
                _maxAltitude = value;
            }
        }
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
    public class Airplane : IFlyable
    {
        private int _countPassengers;
        public int CountPassengers
        {
            get => _countPassengers;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество пассажиров не может быть отрицательным!");
                _countPassengers = value;
            }
        }
        int _maxAltitude;
        public int MaxAltitude
        {
            get => _maxAltitude;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Высота полета не может быть отрицательной или нулевой!");
                _maxAltitude = value;
            }
        }
        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
