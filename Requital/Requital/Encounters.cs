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
            
            int ranEncounter = r.Next(100);
            if (ranEncounter >= 0 && ranEncounter < 11)
            {
                caveEncounter1();
            }
            else if (ranEncounter >= 11 && ranEncounter < 21)
            {
                caveEncounter2();
            }
            else if (ranEncounter >= 21 && ranEncounter < 31)
            {
                encounter3();
            }
            else if (ranEncounter >= 31 && ranEncounter < 41)
            {
                encounter4();
            }
            else if (ranEncounter >= 41 && ranEncounter < 51)
            {
                encounter5();
            }
            else if (ranEncounter >= 51 && ranEncounter < 61)
            {
                encounter6();
            }
            else if (ranEncounter >= 61 && ranEncounter < 71)
            {
                encounter7();
            }
            else if (ranEncounter >= 71 && ranEncounter < 81)
            {
                encounter8();
            }
            else if (ranEncounter >= 81 && ranEncounter < 91)
            {
                encounter9();
            }
            else
            {
                encounter10();
            }
        }

        private void caveEncounter1()
        {
            List<Characters> Encounter1 = new List<Characters>();
            Goblin g1 = new Goblin();
            Goblin g2 = new Goblin();
            Goblin g3 = new Goblin();
            Encounter1.Add(g1);
            Encounter1.Add(g2);
            Encounter1.Add(g3);
        }

        private void caveEncounter2()
        {
            List<Characters> Encounter2 = new List<Characters>();
            Skeleton s1 = new Skeleton();
            Skeleton s2 = new Skeleton();
            Skeleton s3 = new Skeleton();
            Encounter2.Add(s1);
            Encounter2.Add(s2);
            Encounter2.Add(s3);
        }

        private void encounter8()
        {
            throw new NotImplementedException();
        }

        private void encounter7()
        {
            throw new NotImplementedException();
        }

        private void encounter6()
        {
            throw new NotImplementedException();
        }

        private void encounter5()
        {
            throw new NotImplementedException();
        }

        private void encounter4()
        {
            throw new NotImplementedException();
        }

        private void encounter3()
        {
            throw new NotImplementedException();
        }

        private void encounter9()
        {
            throw new NotImplementedException();
        }

        private void encounter10()
        {
            throw new NotImplementedException();
        }
        public void initialTianEncounter()
        {
            Tian tian = new Tian();
        }
        public void endTianEncounter()
        {

        }
    }
}
