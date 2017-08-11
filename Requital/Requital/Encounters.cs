using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requital
{
    public class Encounters
    {
        Random r = new Random();
        public void pickEncounter()
        {
            r.Next(100);

        }
    }
}
