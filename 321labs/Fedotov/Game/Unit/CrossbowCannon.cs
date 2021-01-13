using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class CrossbowCannon : IUnit, IAttack
    {
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int Durability { get; set; }
        public int Destroyed { get; set; }
        public int Damage { get; set; }

        public void TakeDamage()
        {
            Console.WriteLine("Выстрел из Арбалетной бушки");
        }
    }
}
