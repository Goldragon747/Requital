﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    class Mage : Characters
    {
        public void mage(string name)
        {

            base.CharacterClass = "Mage";
            base.Name = name;
            base.Experience = 0;
            base.Health = 10;
            base.AttackPower = 3;
            base.SpellPower = 10;
            base.Speed = 45;
            base.MagicDefense = 3;
            base.PhysicalDefense = 1;
            base.Mana = 10;


        }
    }
}
