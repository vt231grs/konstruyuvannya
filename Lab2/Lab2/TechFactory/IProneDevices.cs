using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TechFactory
{
   

    public class IProneLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("IProne Laptop");
    }

    public class IProneNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("IProne Netbook");
    }

    public class IProneEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("IProne E-Book");
    }

    public class IProneSmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("IProne Smartphone");
    }

}
