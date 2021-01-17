using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class Scout: GoUnit
    {
        public Scout(string name, int level, int hp, int armor, int range, int sight, int speed) : base(name, level, hp, armor, range, sight, speed)
        {
           
        }

        public void Scun()
        {
            Console.WriteLine("Разведчик просканировал територию");
        }
    }
}
