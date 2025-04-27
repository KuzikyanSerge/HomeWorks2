namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляры класса
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();
            BankAccount account3 = new BankAccount();

            string separator = new String('-', 20);

            //Изменяем баланс у аккаунтов
            try
            {
            account1.Deposit(500.5m);//Хотел проверить не целое число, оказалось что для decimal надо прописывать суффикс "m"
            account2.Deposit(1500);
            account3.Deposit(15000);
            
            account1.Withdraw(500);
            account2.Withdraw(500);
            account3.Withdraw(1000);
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine(separator);
                Console.WriteLine(separator);
            }

            //Просматриваем состояние аккаунтов
            Console.WriteLine("Состояние аккаунтов");
            Console.WriteLine(separator);
            Console.WriteLine($"Первый аккаунт:\nНомер счета - {account1.AccountNumber}\nБаланс = {account1.Balance:n2}р.");//Решил дополнительно попробовать сработает ли форматирование строк - работает
            Console.WriteLine(separator);
            Console.WriteLine($"Второй аккаунт:\nНомер счета - {account2.AccountNumber}\nБаланс = {account2.Balance:n2}р.");
            Console.WriteLine(separator);
            Console.WriteLine($"Третий аккаунт:\nНомер счета - {account3.AccountNumber}\nБаланс = {account3.Balance:n2}р.");

            //Вызываем статический метод чтобы посмотреть сколько было созданно экземпляров класса
            Console.WriteLine(separator);
            BankAccount.ShowTotalAccounts();
            Console.ReadKey();
        }
    }
    public class BankAccount
    {
        //Поля
        private decimal _balance;
        //Поля только для чтения
        public readonly int AccountNumber;

        //Автосвойства или полное свойство
        public decimal Balance
        {
            get => _balance;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным!");
                _balance = value;
            }
        }

        //Статическое поле
        private static int _totalAccounts = 0;

        //Конструктор
        public BankAccount()
        {
            _totalAccounts++;
            Random random = new Random();
            AccountNumber = random.Next(1000,9999);
        }
        //Методы
        public decimal Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Подаваемое значение в методе Deposit не должно быть отрицательным!");
            return Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Подаваемое значение в методе Withdraw не должно быть отрицательным!");
            return Balance -= amount;
        }
        // Статический метод
        public static void ShowTotalAccounts()
        {
            Console.WriteLine($"Всего аккаунтов создано: {_totalAccounts}");
        }
    }
}
