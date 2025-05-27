using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab_2.Prototype
{
    class Virus
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        public Virus Clone()
        {
            Virus clone = (Virus)this.MemberwiseClone();
            clone.Children = new List<Virus>();
            foreach (var child in this.Children)
            {
                clone.Children.Add(child.Clone());
            }
            return clone;
        }

        public void Info(int indent = 0)
        {
            string indentStr = new string(' ', indent * 2);
            Console.WriteLine($"{indentStr}Name: {Name}, Type: {Type}, Weight: {Weight.ToString("0.0")}, Age: {Age}");
            foreach (var child in Children)
            {
                child.Info(indent + 1);
            }
        }
    }
}

