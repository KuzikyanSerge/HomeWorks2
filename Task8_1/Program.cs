namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор\nВводится 2 целых числа, а затем – код операции:\n1 – сложение,\n2 – вычесть из первого второе,\n3 – произведение,\n4 – деление первого на второе");
            try
            {
                //Ввод данных
                Console.Write("Введите первое число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите код операции:");
                int c = Convert.ToInt32(Console.ReadLine());
                //Проверяем правильный ввод кода операции
                if (c < 1 || c > 4)
                    Console.WriteLine("Код операции не найден");
                //Производим вычисление по коду операции                
                switch (c)
                {
                    case 1:
                        Console.WriteLine($"Результат: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Результат: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Результат: {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"Результат: {a / b}");
                        break;
                }
            }
            catch (FormatException ex)//Выдаем сообщение если ввели не число
            {
                Console.WriteLine($"Введено не число - {ex.Message}");
            }
            catch (InvalidCastException ex)//Выдаем сообщение если ввели значение double вместо int
            {
                Console.WriteLine($"Введено не целое число - {ex.Message}");
            }
            catch (DivideByZeroException ex)//Выдаем сообщение если происходит деление на 0
            {
                Console.WriteLine($"Деление на 0 - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Операция завершена");
                Console.ReadKey();
            }
        }
    }
}
