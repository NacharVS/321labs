using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class CrossbowCannon : IUnit, IAttack
    {
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int Damage { get; set; }

        public Weapon weapon { get; set; }

        public void TakeDamage()
        {
            Console.WriteLine("Выстрел из Арбалетной бушки");
        }
    }
}
