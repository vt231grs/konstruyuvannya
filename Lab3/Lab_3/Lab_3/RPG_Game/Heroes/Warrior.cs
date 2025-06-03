using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Warrior : Hero
{
    public Warrior(string name)
    {
        Name = name;
        Attack = 10;
        Defense = 8;
        MagicPower = 2;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Warrior {Name}: Attack={Attack}, Defense={Defense}, Magic={MagicPower}");
    }
}


