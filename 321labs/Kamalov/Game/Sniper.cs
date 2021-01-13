using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class Sniper:DynamicHero, IRun, IShoot, IStop
    {
        public Sniper(int health,
            int speed, 
            string name, 
            int damage) : base(health, speed, name, damage)
        {

        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"Герой класса Sniper переместился по координатам: x - {0}; y - {1} ");
        }

        public void Shoot(DynamicHero hero)
        {
            int sum = Damage / 5;
            if (hero.Damage > sum)
            {
                hero.Health -= Damage / 5;
                Console.WriteLine(hero.Health);
            }
            else
            {
                Console.WriteLine("Ошибка: Очень слабый противник!\n +" +
                    $"так как его здоровье состовляет:{hero.Health}");
            }
        }

        public void Stop(DynamicHero hero)
        {
            Console.WriteLine($"Персонаж {hero.Name} остановился");
        }
    }
}