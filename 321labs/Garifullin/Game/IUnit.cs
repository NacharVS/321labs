using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    interface IUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Position { get; set; }
    }
}
