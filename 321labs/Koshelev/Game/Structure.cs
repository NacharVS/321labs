using System;
using System.Collections.Generic;
using System.Text;
using _321labs.Koshelev.Game;

namespace _321labs.Game
{
    class Structure : Unit, IStructure
    {
        public void Notification()
        {
            Console.WriteLine("The building has");
        }
    }
}
