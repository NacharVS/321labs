using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class Hero
    {
        int Health { get; set; }
        int Armor { get; set; }
        int Speed { get; set; }
        string Name { get; set; }

        public Hero(int health, int armor, int speed, string name)
        {
            Health = health;
            Armor = armor;
            Speed = speed;
            Name = name;
        }
    }
}
