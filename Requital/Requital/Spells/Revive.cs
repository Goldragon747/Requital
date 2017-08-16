using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital.Spells
{
    public class Revive : Spells
    {
        public void reviveSpell()
        {
            base.Damage = 0;
            base.Healing = 1;

        }
    }
}
