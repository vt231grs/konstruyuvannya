using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Animals
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, string species, double wingSpan)
            : base(name, age, species)
        {
            WingSpan = wingSpan;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (птах) співає.");
        }
    }
}
