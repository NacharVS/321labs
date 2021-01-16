using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Peasant : Hero, IHarvest
    {
        bool powHarvest = false;

        public Peasant(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {

        }

        public void Harvest()
        {
            if (powHarvest)
            {
                powHarvest = false;
                Console.WriteLine("Крестьянин перестал собирать пшеницу");
            }
            else
            {
                Console.WriteLine("Крестьянин начал собирать пшеницу");
                Wheat.Count--;
                Mill.Wheat++;
                powHarvest = true;
            }
        }
    }
}
