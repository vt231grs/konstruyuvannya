using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mage : Hero
{
    public Mage(string name)
    {
        Name = name;
        Attack = 4;
        Defense = 3;
        MagicPower = 12;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Mage {Name}: Attack={Attack}, Defense={Defense}, Magic={MagicPower}");
    }
}
