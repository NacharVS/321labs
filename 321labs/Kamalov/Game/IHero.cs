using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    interface IHero
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
    }
}
