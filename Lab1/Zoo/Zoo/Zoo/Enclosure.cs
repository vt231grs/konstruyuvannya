using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using Lab1.Animals;

namespace Lab1.Zoo
{
    public class Enclosure
    {
        public string Type { get; set; }
        public double Area { get; set; }
        public List<Animal> Animals { get; set; }

        public Enclosure(string type, double area)
        {
            Type = type;
            Area = area;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
