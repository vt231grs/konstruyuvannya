using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TechFactory
{
  

    public class KiaomiLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Laptop");
    }

    public class KiaomiNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Netbook");
    }

    public class KiaomiEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi E-Book");
    }

    public class KiaomiSmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Smartphone");
    }

}
