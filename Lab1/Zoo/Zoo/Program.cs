using System;
using Lab1.Animals;
using Lab1.Zoo;

namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var inventory = new Inventory();

            var lion = new Mammal("Сімба", 5, "Лев", true);
            var eagle = new Bird("Грім", 3, "Орел", 2.1);

            var enclosure1 = new Enclosure("Саванна", 500);
            var enclosure2 = new Enclosure("Вольєр для птахів", 150);

            enclosure1.AddAnimal(lion);
            enclosure2.AddAnimal(eagle);

            inventory.Enclosures.Add(enclosure1);
            inventory.Enclosures.Add(enclosure2);

            inventory.Workers.Add(new ZooWorker("Олена Коваленко", "Ветеринар"));
            inventory.Workers.Add(new ZooWorker("Ігор Сидоренко", "Доглядач"));

            inventory.Foods.Add(new Food("М'ясо", 200));
            inventory.Foods.Add(new Food("Зерно", 100));

            inventory.PrintInventory();
        }
    }
}
