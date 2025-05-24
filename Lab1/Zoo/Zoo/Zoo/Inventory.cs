using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Lab1.Zoo
{
    public class Inventory
    {
        public List<Enclosure> Enclosures { get; set; }
        public List<ZooWorker> Workers { get; set; }
        public List<Food> Foods { get; set; }

        public Inventory()
        {
            Enclosures = new List<Enclosure>();
            Workers = new List<ZooWorker>();
            Foods = new List<Food>();
        }

        public void PrintInventory()
        {
            Console.WriteLine("== Інвентаризація зоопарку ==\n");

            Console.WriteLine("Тварини:");
            foreach (var enclosure in Enclosures)
            {
                Console.WriteLine($"Вольєр типу: {enclosure.Type}, площа: {enclosure.Area} м²");
                foreach (var animal in enclosure.Animals)
                {
                    Console.WriteLine($"  - {animal.Name}, вид: {animal.Species}, вік: {animal.Age}");
                }
            }

            Console.WriteLine("\nПрацівники:");
            foreach (var worker in Workers)
            {
                Console.WriteLine($"  - {worker.FullName}, посада: {worker.Position}");
            }

            Console.WriteLine("\nКорм:");
            foreach (var food in Foods)
            {
                Console.WriteLine($"  - {food.Name}: {food.QuantityKg} кг");
            }
        }
    }
}
