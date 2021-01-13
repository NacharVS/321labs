using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class StaticHero : Hero
    {
        public StaticHero(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {

        }
        int speed = 0;
    }
}
