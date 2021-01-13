using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Archer : IUnit, IMove, IShooting
    {
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int SpeedMove { get; set; }
        public int AgilityMove { get; set; }
        public int Damage { get; set; }
        public int Distance { get; set; }
        public int Accuracy { get; set; }

        public void StopMove()
        {
            Console.WriteLine("Стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Идет");
        }

        public void TakeDamage()
        {
            Console.WriteLine("Выстрел из лука");
        }

    }
}
