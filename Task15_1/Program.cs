using System.Collections.Generic;

namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
                new Computer() {kod = 1, imya = "MSI", processor = "i3", chasota = 1.5, obemOperativki = 4000, obemPamyati = 1, obemVideokarty = 4000, stoimost = 50000, kolochestvo = 25},
                new Computer() {kod = 2, imya = "MSI", processor = "i5", chasota = 2, obemOperativki = 6000, obemPamyati = 2, obemVideokarty = 4000, stoimost = 60000, kolochestvo = 20},
                new Computer() {kod = 3, imya = "MSI", processor = "i5", chasota = 2.5, obemOperativki = 8000, obemPamyati = 2.5, obemVideokarty = 8000, stoimost = 80000, kolochestvo = 15},
                new Computer() {kod = 4, imya = "MSI", processor = "i7", chasota = 3, obemOperativki = 16000, obemPamyati = 2, obemVideokarty = 8000, stoimost = 110000, kolochestvo = 10},
                new Computer() {kod = 5, imya = "MSI", processor = "i9", chasota = 4, obemOperativki = 32000, obemPamyati = 4, obemVideokarty = 16000, stoimost = 180000, kolochestvo = 3},
                new Computer() {kod = 6, imya = "ROG", processor = "i3", chasota = 1.8, obemOperativki = 4000, obemPamyati = 0.5, obemVideokarty = 2000, stoimost = 30000, kolochestvo = 32},
                new Computer() {kod = 7, imya = "ROG", processor = "i3", chasota = 2, obemOperativki = 6000, obemPamyati = 1, obemVideokarty = 4000, stoimost = 60000, kolochestvo = 16},
                new Computer() {kod = 8, imya = "ROG", processor = "i5", chasota = 3, obemOperativki = 16000, obemPamyati = 1.5, obemVideokarty = 6000, stoimost = 70000, kolochestvo = 18},
                new Computer() {kod = 9, imya = "ROG", processor = "i7", chasota = 3.5, obemOperativki = 20000, obemPamyati = 2, obemVideokarty = 8000, stoimost = 130000, kolochestvo = 14},
                new Computer() {kod = 10, imya = "ROG", processor = "i7", chasota = 4, obemOperativki = 24000, obemPamyati = 3, obemVideokarty = 8000, stoimost = 150000, kolochestvo = 8}
            };
            string separator = new String('-', 73);

            //все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.Write("Введите название процессора:");
            string a = Convert.ToString(Console.ReadLine());
            List<Computer> comuters1 = list
                .Where(c=> c.processor == a)
                .ToList();
            if (comuters1.Count == 0)
                Console.WriteLine("По запросу ничего не найдено!");
            foreach (var computer in comuters1)
                Console.WriteLine($"{computer.kod} {computer.imya} {computer.processor} {computer.obemOperativki} {computer.stoimost} {computer.kolochestvo}");
            Console.WriteLine(separator);

            //все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.Write("Введите минимальный объем оперативки:");
            int b = Convert.ToInt32(Console.ReadLine());
            List<Computer> comuters2 = list
                .Where(c => c.obemOperativki >= b)
                .ToList();
            if (comuters2.Count == 0)
                Console.WriteLine("По запросу ничего не найдено!");
            foreach (var computer in comuters2)
                Console.WriteLine($"{computer.kod} {computer.imya} {computer.processor} {computer.obemOperativki} {computer.stoimost} {computer.kolochestvo}");
            Console.WriteLine(separator);

            //вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine("Список компьютеров отсортированный по стоимости:");
            List<Computer> comuters3 = list
                .OrderBy(c => c.stoimost)
                .ToList();
            foreach (var computer in comuters3)
                Console.WriteLine($"{computer.kod} {computer.imya} {computer.processor} {computer.obemOperativki} {computer.stoimost} {computer.kolochestvo}");
            Console.WriteLine(separator);

            //вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Список компьютеров сгруппированный по типу процессора:");
            var comuters4 = list
                .GroupBy(c => c.processor)
                .ToList();
            foreach (var group in comuters4)
            {
                Console.WriteLine($"Процессор: {group.Key}");
                foreach (var computer in group)
                    Console.WriteLine($"{computer.kod} {computer.imya} {computer.processor} {computer.obemOperativki} {computer.stoimost} {computer.kolochestvo}");
            }
            Console.WriteLine(separator);

            //найти самый дорогой и самый бюджетный компьютер;
            var comuterMax = list
                .Max(c => c.stoimost);
            var comuterMin = list
                .Min(c => c.stoimost);
            Console.WriteLine($"Самый дорогой компьютер: {comuterMax}");
            Console.WriteLine($"Самый бюджетный компьютер: {comuterMin}");
            Console.WriteLine(separator);
            
            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            List<Computer> comuters5 = list
                .Where(c => c.kolochestvo>=30)
                .ToList();
            Console.WriteLine($"Есть ли хотя бы один компьютер в количестве не менее 30 штук? Ответ: {(comuters5.Count > 0 ? "Да" : "Нет")}.");
            Console.WriteLine(separator);

            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
    public class Computer
    {
        public int kod { get; set; }
        public string imya { get; set; }
        public string processor { get; set; }
        public double chasota { get; set; }
        public int obemOperativki { get; set; }
        public double obemPamyati { get; set; }
        public int obemVideokarty { get; set; }
        public float stoimost { get; set; }
        public int kolochestvo { get; set; }
    }
}
