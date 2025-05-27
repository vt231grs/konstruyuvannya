using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HeroBuilder : ICharacterBuilder
{
    private Character hero = new Character();

    public ICharacterBuilder SetName(string name) { hero.Name = name; return this; }
    public ICharacterBuilder SetHeight(int height) { hero.Height = height; return this; }
    public ICharacterBuilder SetBuild(string build) { hero.Build = build; return this; }
    public ICharacterBuilder SetHairColor(string hairColor) { hero.HairColor = hairColor; return this; }
    public ICharacterBuilder SetEyeColor(string eyeColor) { hero.EyeColor = eyeColor; return this; }
    public ICharacterBuilder SetClothes(string clothes) { hero.Clothes = clothes; return this; }
    public ICharacterBuilder AddInventory(string item) { hero.Inventory.Add(item); return this; }
    public ICharacterBuilder AddAction(string action) { hero.Actions.Add("Good: " + action); return this; }

    public Character Build()
    {
        return hero;
    }
}

