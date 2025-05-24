using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Zoo
{
    public class ZooWorker
    {
        public string FullName { get; set; }
        public string Position { get; set; }

        public ZooWorker(string fullName, string position)
        {
            FullName = fullName;
            Position = position;
        }
    }
}
