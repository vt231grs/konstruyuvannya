using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Shield : HeroDecorator
{
    public Shield(Hero hero) : base(hero) { }

    public override int Defense => base.Defense + 4;

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine($"  Equipped: Shield (+4 Defense)");
    }
}
