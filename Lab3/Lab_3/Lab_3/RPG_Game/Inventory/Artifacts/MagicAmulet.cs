using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicAmulet : HeroDecorator
{
    public MagicAmulet(Hero hero) : base(hero) { }

    public override int MagicPower => base.MagicPower + 3;
    public override int Defense => base.Defense + 1;

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"  Equipped: Magic Amulet (+3 Magic, +1 Defense)");
    }
}