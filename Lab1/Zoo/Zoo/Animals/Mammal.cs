using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Animals
{
    public class Mammal : Animal
    {
        public bool IsPredator { get; set; }

        public Mammal(string name, int age, string species, bool isPredator)
            : base(name, age, species)
        {
            IsPredator = isPredator;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (мамал) ричить.");
        }
    }
}

