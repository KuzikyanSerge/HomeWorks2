namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задаем исходные данные
            Console.Write("Введите длину стороны куба: ");
            double edgeLength = Convert.ToDouble(Console.ReadLine());

            //Создаем параметры для результатов
            double volume, surfaceArea;
            
            //Запускаем метод
            CalcCube(edgeLength, out volume, out surfaceArea);
            
            //Выводим результаты
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}");
            Console.ReadKey();
        }

        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            //Вычисляем объем куба
            volume = edgeLength * edgeLength * edgeLength;
            //Вычисляем поверхность куба
            surfaceArea = edgeLength * edgeLength * 6;
        }
    }
}
