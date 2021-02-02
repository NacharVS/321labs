using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _321labs.Fedotov.Game
{
    class Tent : IUnit, IBarracks
    {
        public string NickName { get; set; }
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int CountLife { get; set; }

        public void Decompose()
        {
            Console.WriteLine("Палатка разложена");
        }

        public void Fold()
        {
            Console.WriteLine("Палатка сложена");
        }

        
    }
}
