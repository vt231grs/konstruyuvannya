using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Zoo
{
    public class Food
    {
        public string Name { get; set; }
        public int QuantityKg { get; set; }

        public Food(string name, int quantityKg)
        {
            Name = name;
            QuantityKg = quantityKg;
        }
    }
}

