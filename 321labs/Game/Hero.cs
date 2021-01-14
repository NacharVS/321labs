using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Hero : Unit, IMove, ITeleport
    {
        public void Move()
        {
            Console.WriteLine("I running");
        }

        public void Teleport()
        {
            Console.WriteLine("Teleport");
        }
    }
}
