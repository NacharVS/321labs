using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class Builder:DynamicHero, IRun, IHeal
    {
        public Builder(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
                
        }

        public void Heal(Hero hero)
        {
            hero.Health += 10;
        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"Герой класса Sniper переместился по координатам: x - {0}; y - {1}", x, y);
        }
    }
}