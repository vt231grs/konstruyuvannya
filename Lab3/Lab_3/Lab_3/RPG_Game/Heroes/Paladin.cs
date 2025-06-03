using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Paladin : Hero
{
    public Paladin(string name)
    {
        Name = name;
        Attack = 7;
        Defense = 7;
        MagicPower = 7;
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"Paladin {Name}: Attack={Attack}, Defense={Defense}, Magic={MagicPower}");
    }
}
