using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Tian : Characters
    {
        
            public void goblin()
            {
                base.CharacterClass = "Boss";
                base.characterName = "Tian";
                base.Experience = 10000;
                base.Health = 100;
                base.AttackPower = 10;
                base.SpellPower = 20;
                base.Speed = 200;
                base.MagicDefense = 5;
                base.PhysicalDefense = 5;
                string[] spells = { "Fireball" };
                base.Spells = spells;
                base.Mana = 100;
            }
        
    }
}
