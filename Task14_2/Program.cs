namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте словарь и добавьте в него 3 товара:
            //Ноутбуки("A001") — 10 шт.
            //Смартфоны("B205") — 25 шт.
            //Наушники("C307") — 15 шт.
            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("A001", 10);
            products.Add("B205", 25);
            products.Add("C307", 15);

            //Реализуйте следующие операции:
            //Проверьте наличие товара с артикулом "B205"(ContainsKey).
            Console.WriteLine($"Есть ли товар с артикулом 'B205'? Ответ: {(products.ContainsKey("B205") ? "Да" : "Нет")}.");

            //Обновите количество ноутбуков до 8(продали 2 шт.) через индексатор.
            products["A001"] = 8;

            //Получите количество наушников безопасным способом(TryGetValue).
            Console.WriteLine($"Количество наушников на складе = {(products.TryGetValue("C307", out int value) ? value : "Нет данных")}.");

            //Увеличьте количество смартфонов на 5(новый завоз).
            products["B205"] += 5;

            //Удалите наушники из инвентаря(Remove).
            products.Remove("C307");

            //Выведите текущий инвентарь в формате указанном в задаче
            Console.WriteLine("Текущий состав склада:");
            foreach (KeyValuePair<string, int> product in products)
                Console.WriteLine($"Артикул: {product.Key}, Количество = {product.Value}");

            //Проверьте, пуст ли словарь(Count), затем полностью очистите инвентарь(Clear).
            Console.WriteLine($"Есть ли товары на складе? Ответ: {(products.Count > 0 ? "Да" : "Нет")}.");
            products.Clear();
            Console.WriteLine($"Количество товаров после очистки = {products.Count}.");

            Console.ReadKey();
        }
    }
}
