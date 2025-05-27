using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TechFactory
{
 

    public class BalaxyLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Laptop");
    }

    public class BalaxyNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Netbook");
    }

    public class BalaxyEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("Balaxy E-Book");
    }

    public class BalaxySmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Smartphone");
    }

}
