using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Mage : Unit, IMage
    {
        public Mage(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void Heal(object obj)
        {
            if(obj is Unit unit)
            {
                unit.Hp += 100;
            }
        }
    }
}
