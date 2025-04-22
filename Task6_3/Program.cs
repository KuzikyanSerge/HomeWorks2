namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            Console.Write("Общую сумму продаж: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество проданных товаров: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //Расчет средней стоимости товара
            double price = sum / quantity;

            //Вывод отчета(решил попроблвать с переносом строки одной формой)
            //В задании написано что только у суммы нужно тысячи отделять, но в примере во всех значениях тысячи отделены, сделал по заданию чтобы разные форматы были
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Отчёт о продажах за {0} {1}:\n\nОбщая сумма продаж: {2:N2} р.\nКоличество проданных товаров: {3} шт.\nСредняя стоимость товара: {4:N2} р.", month, year, sum, quantity, price);
            Console.WriteLine("--------------------");
            Console.ReadKey();
        }
    }
}