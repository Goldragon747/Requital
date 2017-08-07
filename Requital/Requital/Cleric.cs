using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class Cleric : Characters
    {
        public void cleric(string name)
        {

            base.CharacterClass = "Cleric";
            base.Name = name;
            base.Experience = 0;
            base.Health = 15;
            base.AttackPower = 1;
            base.SpellPower = 10;
            base.Speed = 40;
            base.MagicDefense = 3;
            base.PhysicalDefense = 1;
            base.Mana = 10;



        }
    }
}
