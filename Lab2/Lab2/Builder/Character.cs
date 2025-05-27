using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    public string Name { get; set; }
    public int Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothes { get; set; }
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Actions { get; set; } = new List<string>();

    public override string ToString()
    {
        return
            $"Name: {Name}\n" +
            $"Height: {Height} cm\n" +
            $"Build: {Build}\n" +
            $"Hair: {HairColor}\n" +
            $"Eyes: {EyeColor}\n" +
            $"Clothes: {Clothes}\n" +
            $"Inventory: {string.Join(", ", Inventory)}\n" +
            $"Actions: {string.Join(", ", Actions)}";
    }
}

