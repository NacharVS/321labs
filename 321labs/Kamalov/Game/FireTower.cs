using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class FireTower:StaticHero, IShoot
    {
        public FireTower(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
        }

        public void Shoot(DynamicHero hero, StaticHero hero1)
        {
            
        }
    }
}
