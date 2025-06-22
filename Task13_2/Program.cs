namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem smartHomeSystem = new SmartHomeSystem();
            smartHomeSystem.StateChanged1 += (newTemp) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Термостат: Температура {newTemp}°C установлена");
                Console.ResetColor();
            };
            smartHomeSystem.StateChanged2 += (state) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {state}");
                Console.ResetColor();
            };
            try
            {
                smartHomeSystem.UnlockDoor();
                smartHomeSystem.LockDoor();
                smartHomeSystem.TurnOffLight();
                smartHomeSystem.TurnOnLight();
                smartHomeSystem.SetTemperature( 0 );
                smartHomeSystem.SetTemperature( 25 );
                smartHomeSystem.SetTemperature( -5 );
                smartHomeSystem.SetTemperature( -300 );//Попытка назначить невозможную температуру

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
    public delegate void DeviceStateChanged<T>(T state);
    public class SmartHomeSystem
    {
        //Добавляем событие
        public event DeviceStateChanged<int> StateChanged1;
        public event DeviceStateChanged<string> StateChanged2;
        private int _thermostat;
        private bool _light;
        private bool _door;
        private int Thermostat
        {
            get => _thermostat;
            set
            {
                if (value <= -273)
                    throw new ArgumentException("Термостат: Температура не может быть меньше абсолютного нуля вселенной");
                _thermostat = value;
            }
        }
        public SmartHomeSystem(bool light = false, bool door = false, int thermostat = 22)
        {
            _light = light;
            _door = door;
            Thermostat = thermostat;
        }
        //Описываем методы с помощью лямбда выражений
        public void TurnOnLight()
        {
            _light = true;
            StateChanged2?.Invoke("Свет: Включен");
        }
        public void TurnOffLight()
        {
            _light = false;
            StateChanged2?.Invoke("Свет: Отключен");
        }
        public void LockDoor()
        {
            _door = true;
            StateChanged2?.Invoke("Дверь: Заблокирована");
        }
        public void UnlockDoor()
        {
            _door = false;
            StateChanged2?.Invoke("Дверь: Разблокирована");
        }
        public void SetTemperature(int newTemp)
        {
            Thermostat = newTemp;
            StateChanged1?.Invoke(Thermostat);
        }
    }
}
