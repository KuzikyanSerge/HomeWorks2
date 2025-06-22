using System;

namespace Task13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 3, -4, 5 };
            Console.WriteLine("Исходный массив");
            Console.WriteLine(string.Join(", ", numbers));
            //Демонстрация работы
            Console.WriteLine("Удвоение всех чисел");
            int[] result1 = Transform(numbers, n => n * 2);//С помощью лямбда выражения и анонимной функции назначаем преобразование
            Console.WriteLine(string.Join(", ", result1));
            Console.WriteLine("Возведение в квадрат");
            int[] result2 = Transform(numbers, n => n * n);//С помощью лямбда выражения и анонимной функции назначаем новое преобразование
            Console.WriteLine(string.Join(", ", result2));
            Console.WriteLine("Замена чисел на их модули");
            int[] result3 = Transform(numbers, n => Math.Abs(n));//С помощью лямбда выражения и анонимной функции назначаем новое преобразование
            Console.WriteLine(string.Join(", ", result3));
            Console.ReadKey();
        }

        public delegate int Transformer(int x);//Создаем делегат для преобразований числа
        public static int[] Transform(int[] numbers, Transformer transformer)//Создаем метод для преобразований массива
        {
            int[] result = new int[numbers.Length];//Создаем массив для итогового результата, размер массива не поменяется поэтому сразу назначаем его размер
            int index = 0;//Задаем первый индекс для массива
            foreach (int number in numbers)//Собираем массив
            {
                result[index] = transformer(number);
                index++; 
            }
            return result;
        }
    }
}
