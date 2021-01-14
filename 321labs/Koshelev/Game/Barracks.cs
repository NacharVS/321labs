using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Barracks : Structure, ICreateHero
    {
        public void СreateHero()
        {
            Console.WriteLine("Create hero");
        }
    }
}
