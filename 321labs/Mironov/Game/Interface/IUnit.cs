using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game
{
    interface IUnit
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int RangeVisible { get; set; }
        public int Cost { get; set; }
        public string Description { get; set;}
        public int X { get; set;}
        public int Y { get; set; }
    }
}
