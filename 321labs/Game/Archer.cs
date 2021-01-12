using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Archer : Unit, IArcher
    {
        public Archer(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void Hike()
        {
            this.Speed += 40;
        }

        public void UpDamage()
        {
            this.Damage += 100;
        }
    }
}
