using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Unit
    {
        string name { get; set; }
        int armor { get; set; }
        int damage { get; set; }

        protected Unit(string name, int armor, int damage)
        {
            this.name = name;
            this.armor = armor;
            this.damage = damage;
        }

    }
}
