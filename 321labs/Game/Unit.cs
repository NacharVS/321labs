using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
     class Unit : IUnit, IAttack
    {
        public int Helth { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; } 
        public int Range { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }

        public void Attack(Unit enemy)
        {

        }
    }
}
