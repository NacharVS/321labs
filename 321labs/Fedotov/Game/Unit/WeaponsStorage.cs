using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class WeaponsStorage : IUnit, IStorage
    {
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int Capacity { get; set; }
        
    }
}
