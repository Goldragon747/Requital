using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Warrior : Characters
    {
        public void warrior(string name)
        {
            
            base.CharacterClass = "Warrior";
            base.characterName = name;
            base.Level = 1;
            base.Experience = 0;
            base.Health = 30;
            base.MaxHealth = 30;
            base.AttackPower = 10;
            base.SpellPower = 0;
            base.Speed = 20;
            base.MagicDefense = 0;
            base.PhysicalDefense = 3;
            base.Mana = 0;
            base.HasDefended = false;
            base.IsDead = false;
            
        }
    }
}
