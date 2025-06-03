using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeatherArmor : HeroDecorator
{
    public LeatherArmor(Hero hero) : base(hero) { }

    public override int Defense => base.Defense + 3;

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"  Equipped: Leather Armor (+3 Defense)");
    }
}