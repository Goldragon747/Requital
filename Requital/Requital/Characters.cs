﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
    {
        public class Characters
        {
            
            private string name;
            private int health;
            private int mana;
            private int magicD;
            private int physicalD;
            private int attackP;
            private int spellP;
            private int speed;
            private string characterClass;
            private int experience;
            private int level;

            public int Level { get { return level; } set { level = value;} }
            public int Experience { get { return experience; } set { experience = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int Health { get { return health; } set { health = value; } }
            public int Mana { get { return mana; } set { mana = value; } }
            public int MagicDefense { get { return magicD; } set { magicD = value;  } }
            public int PhysicalDefense { get { return physicalD; } set { physicalD = value;  } }
            public int AttackPower { get { return attackP; } set { attackP = value; } }
            public int SpellPower { get { return spellP; } set { spellP = value; } }
            public int Speed { get { return speed; } set { speed = value; } }
            public string CharacterClass { get { return characterClass; } set { characterClass = value; } }
   
        }
    }



