using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnemyBuilder : ICharacterBuilder
{
    private Character enemy = new Character();

    public ICharacterBuilder SetName(string name) { enemy.Name = name; return this; }
    public ICharacterBuilder SetHeight(int height) { enemy.Height = height; return this; }
    public ICharacterBuilder SetBuild(string build) { enemy.Build = build; return this; }
    public ICharacterBuilder SetHairColor(string hairColor) { enemy.HairColor = hairColor; return this; }
    public ICharacterBuilder SetEyeColor(string eyeColor) { enemy.EyeColor = eyeColor; return this; }
    public ICharacterBuilder SetClothes(string clothes) { enemy.Clothes = clothes; return this; }
    public ICharacterBuilder AddInventory(string item) { enemy.Inventory.Add(item); return this; }
    public ICharacterBuilder AddAction(string action) { enemy.Actions.Add("Evil: " + action); return this; }

    public Character Build()
    {
        return enemy;
    }
}

