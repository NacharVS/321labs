using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Hero
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Visibility { get; set; }

        public Hero(int damage, int health, int speed, int range, int visibility)
        {
            Damage = damage;
            Health = health;
            Speed = speed;
            Range = range;
            Visibility = visibility;
        }

    }
}
