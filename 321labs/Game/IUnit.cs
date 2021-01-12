using System;

namespace _321labs.Game
{
    interface IUnit
    {
        public int Helth { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
    }
}
