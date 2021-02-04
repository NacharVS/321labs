using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class GoUnit:Unit
    {
        int Speed;

        public GoUnit(string name, int level, int hp, int armor, int range, int sight, int speed) : base(name, level, hp, armor, range, sight,speed)
        {
            int Speed = speed;
        }

        virtual public void Move()
        {
            Console.WriteLine("Персонаж сделал ход");
        }
    }
}
