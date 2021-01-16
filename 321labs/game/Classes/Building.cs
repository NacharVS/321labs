using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Building : Unit
    {
        int volume;
        
        public int Volume { get => volume; set => volume = value; }

        public Building(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {

        }
    }
}
