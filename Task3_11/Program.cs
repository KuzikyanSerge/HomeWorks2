namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите габариты участка a x b:");
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите габариты первого дома p x q:");
            Console.Write("p=");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("q=");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите габариты второго дома r x s:");
            Console.Write("r=");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("s=");
            int s = Convert.ToInt32(Console.ReadLine());

            string answer = (((p + r <= a) && (q + s <= b)) || ((p + s <= a) && (q + r <= b))) ? "Можно разместить" : "Невозможно разместить";
            
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
