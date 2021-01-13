using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    abstract class Hero
    {
        int Health { get; set; }
        int Speed { get; set; }
        string Name { get; set; }
        int Damage { get; set; }
        

        public Hero(int health, int speed, string name, int damage)
        {
            Health = health;
            Speed = speed;
            Name = name;
            Damage = damage;
        }
    }
}