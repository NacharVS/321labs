using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Bird : IUnit, IFlight
    {
        public Guid id { get; set; }
        public bool FlagLive { get; set; }
        public int Health { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public int SpeedFlight { get; set; }
        public int AgilityFlight { get; set; }
        public int HightFlight { get; set; }
        public void StopFlight()
        {
            Console.WriteLine("Птица взлетела");
        }

        public void StartFlight()
        {
            Console.WriteLine("Птица приземлилась");
        }

        public void Say()
        {
            Console.WriteLine("Kyrlyk Kyrlyk");
        }
    }
}
