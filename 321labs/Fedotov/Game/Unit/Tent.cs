using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _321labs.Fedotov.Game
{
    class Tent : IBarracks
    {
        public int durability { get; set; }
        public int destroyed { get; set; }
        public int countLife { get; set; }

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
