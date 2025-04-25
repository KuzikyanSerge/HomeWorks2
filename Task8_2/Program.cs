namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
            //Ввод данных
            Console.Write("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            //Запускаем метод
            ValidateAge(age);
            Console.WriteLine("Такой возраст возможен");
            }
            catch (InvalidCastException ex)//Выдаем сообщение если ввели значение double вместо int
            {
                Console.WriteLine($"Введено не целое число - {ex.Message}");
            }
            catch (FormatException ex)//Выдаем сообщение если ввели не число
            {
                Console.WriteLine($"Введено не число - {ex.Message}");
            }            
            catch (ArgumentOutOfRangeException ex)//Выдаем сообщение если слишком большой возраст
            {
                Console.WriteLine($"Ошибка значения возраста - {ex.Message}");
            }
            catch (ArgumentException ex)//Выдаем сообщение если ввели отрицательный возраст
            {
                Console.WriteLine($"Ошибка значения возраста - {ex.Message}");
            }            
            finally
            {
                Console.ReadKey();
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 150)
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }
    }
}
