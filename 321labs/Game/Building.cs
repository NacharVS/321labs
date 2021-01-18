using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Building : Unit, IAttack, IIncreaseInStats
    {
        public void Damage(object obj)
        {
            
            if (obj is Building building)
            {
                HealthPoints -= Math.Max(this.Power * 5 - Defense,0);
            }
        }

        public void IncreaseInStats(object obj)
        {
            if (obj is Building building )
            {

            }
        }
    }
}
