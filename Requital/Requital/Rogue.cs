using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class Rogue : Characters
    {
        public void rogue(string name)
        {

            base.CharacterClass = "Rogue";
            base.characterName = name;
            base.Level = 1;
            base.Experience = 0;
            base.Health = 20;
            base.AttackPower = 8;
            base.SpellPower = 0;
            base.Speed = 75;
            base.MagicDefense = 0;
            base.PhysicalDefense = 2;
            base.Mana = 0;
            base.HasDefended = false;

        }
    }
}
