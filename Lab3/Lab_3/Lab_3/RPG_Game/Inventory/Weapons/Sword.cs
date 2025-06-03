using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sword : HeroDecorator
{
    public Sword(Hero hero) : base(hero) { }

    public override int Attack => base.Attack + 5;

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"  Equipped: Sword (+5 Attack)");
    }
}

