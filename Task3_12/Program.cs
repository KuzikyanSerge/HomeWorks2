namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне [100;999]:");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number < 100) || (number > 999))
            {
                Console.WriteLine("Ошибка! Число не находится в диапазоне [100;999]");
                Console.ReadKey();
            }
            else
            {
                int s = number / 100;
                switch (s)
                {
                    case 1:
                        Console.Write("Сто ");
                        break;
                    case 2:
                        Console.Write("Двести ");
                        break;
                    case 3:
                        Console.Write("Триста ");
                        break;
                    case 4:
                        Console.Write("Четыреста ");
                        break;
                    case 5:
                        Console.Write("Пятьсот ");
                        break;
                    case 6:
                        Console.Write("Шестьсот ");
                        break;
                    case 7:
                        Console.Write("Семьсот ");
                        break;
                    case 8:
                        Console.Write("Восемьсот ");
                        break;
                    case 9:
                        Console.Write("Девятьсот ");
                        break;
                }
                int d1 = number % 100;
                int d2 = d1 - d1 % 10;
                int e = d1 % 10;

                if ((d1 > 10) && (d1 < 20))
                {
                    switch (d1)
                    {
                        case 11:
                            Console.Write("одиннадцать");
                            break;
                        case 12:
                            Console.Write("двенадцать");
                            break;
                        case 13:
                            Console.Write("тринадцать");
                            break;
                        case 14:
                            Console.Write("четырнадцать");
                            break;
                        case 15:
                            Console.Write("пятнадцать");
                            break;
                        case 16:
                            Console.Write("шестнадцать");
                            break;
                        case 17:
                            Console.Write("семнадцать");
                            break;
                        case 18:
                            Console.Write("восемнадцать");
                            break;
                        case 19:
                            Console.Write("девятнадцать");
                            break;
                    }
                }
                else
                {
                    if ((d1 >= 20) || (d1 == 10))
                    {
                        switch (d2)
                        {
                            case 10:
                                Console.Write("десять ");
                                break;
                            case 20:
                                Console.Write("двадцать ");
                                break;
                            case 30:
                                Console.Write("тридцать ");
                                break;
                            case 40:
                                Console.Write("сорок ");
                                break;
                            case 50:
                                Console.Write("пятьдесят ");
                                break;
                            case 60:
                                Console.Write("шестьдесят ");
                                break;
                            case 70:
                                Console.Write("семьдесят ");
                                break;
                            case 80:
                                Console.Write("восемьдесят ");
                                break;
                            case 90:
                                Console.Write("девяносто ");
                                break;
                        }
                        if (e > 0)
                        {
                            switch (e)
                            {
                                case 1:
                                    Console.Write("один");
                                    break;
                                case 2:
                                    Console.Write("два");
                                    break;
                                case 3:
                                    Console.Write("три");
                                    break;
                                case 4:
                                    Console.Write("четыре");
                                    break;
                                case 5:
                                    Console.Write("пять");
                                    break;
                                case 6:
                                    Console.Write("шесть");
                                    break;
                                case 7:
                                    Console.Write("семь");
                                    break;
                                case 8:
                                    Console.Write("восемь");
                                    break;
                                case 9:
                                    Console.Write("девять");
                                    break;
                            }
                        }
                    }
                    else 
                    {
                        switch (e)
                        {
                            case 1:
                                Console.Write("один");
                                break;
                            case 2:
                                Console.Write("два");
                                break;
                            case 3:
                                Console.Write("три");
                                break;
                            case 4:
                                Console.Write("четыре");
                                break;
                            case 5:
                                Console.Write("пять");
                                break;
                            case 6:
                                Console.Write("шесть");
                                break;
                            case 7:
                                Console.Write("семь");
                                break;
                            case 8:
                                Console.Write("восемь");
                                break;
                            case 9:
                                Console.Write("девять");
                                break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
