using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Barbarian : Unit, IBarbarian
    {
        public Barbarian(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void DoubleHit(Unit unit)
        {
            unit.Hp -= this.Damage * 2;
        }
    }
}
