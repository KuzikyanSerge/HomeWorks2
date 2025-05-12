namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива, содержащего объекты обоих типов
            Animal[] animals = new Animal[]
                {
                    new Dog(),
                    new Dog(),
                    new Cat(),
                    new Cat(),
                    new Cat(),
                    new Cat(),
                };
            //Использование полиморфизма (вызовите для каждого элемента в массиве метод ShowInfo())
            foreach (Animal animal in animals)
            {
                animal.ShowInfo();
            }
            Console.ReadKey();
        }
    }

    public abstract class Animal()
    {
        public abstract string Name { get; }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write($"{Name}: ");
            Say();
            Console.WriteLine();
        }
    }
    public class Dog() : Animal
    {
        public override string Name => "Собака";

        public override void Say()
        {
            Console.Write("Гав!");
        }
    }
    public class Cat() : Animal
    {
        public override string Name => "Кошка";

        public override void Say()
        {
            Console.Write("Мяу!");
        }
    }
}
