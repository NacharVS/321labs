using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class WeaponsStorage : IStorage
    {
        public int durability { get; set; }
        public int destroyed { get; set; }
        public int capacity { get; set; }
        public string typeWeapons;
    }
}
