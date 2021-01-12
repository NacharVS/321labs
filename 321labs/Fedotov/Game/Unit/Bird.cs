using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Bird : ILife, IFlight
    {
        public bool flagLive { get; set; }
        public int health { get; set; }
        public int speedFlight { get; set; }
        public int agilityFlight { get; set; }
        public int hightFlight { get; set; }
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
