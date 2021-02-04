using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Farmer:GoUnit
    {
        public Farmer(string name, int level, int hp, int armor, int range, int sight, int speed) : base(name, level, hp, armor, range, sight, speed)
        {

        }

        public void Farm()
        {
            Console.WriteLine("Фермер собрал уражай");
        }
    }
}

