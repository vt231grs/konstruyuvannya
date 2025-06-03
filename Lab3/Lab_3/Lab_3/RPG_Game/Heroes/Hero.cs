using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Hero
{
    public string Name { get; protected set; }
    public virtual int Attack { get; protected set; }
    public virtual int Defense { get; protected set; }
    public virtual int MagicPower { get; protected set; }

    public abstract void DisplayStats();
}
