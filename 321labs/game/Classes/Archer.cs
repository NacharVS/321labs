using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Archer : Hero, IShoot
    {
        int range;

        public Archer(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {

        }

        public void Shoot()
        {
            Console.WriteLine($"{Title}: Стрелял из лука");
        }
    }
}
