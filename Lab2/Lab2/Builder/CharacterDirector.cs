using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CharacterDirector
{
    public void ConstructHero(ICharacterBuilder builder)
    {
        builder
            .SetName("Kirigaya Kadzuto")
            .SetHeight(172)
            .SetBuild("Athletic")
            .SetHairColor("Dark")
            .SetEyeColor("Dark")
            .SetClothes("Black Armor")
            .AddInventory("Double blades")
            .AddAction("Completed aincrad")
            .AddAction("Saved the world of Аlicization");
    }

    public void ConstructEnemy(ICharacterBuilder builder)
    {
        builder
            .SetName("Kayaba Akihiko")
            .SetHeight(175)
            .SetBuild("Muscular")
            .SetHairColor("Gray")
            .SetEyeColor("Gray")
            .SetClothes("Red armor")
            .AddInventory("Sword")
            .AddInventory("Shield")
            .AddAction("Sealed people in a deadly game");
    }
}

