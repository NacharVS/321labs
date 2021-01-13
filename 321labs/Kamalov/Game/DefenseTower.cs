using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class DefenseTower:StaticHero, IShoot
    {
        public DefenseTower(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {

        }

        public void Shoot(DynamicHero hero, StaticHero hero1)
        {
            int sum = Damage / 10;
            if (hero.Damage > sum)
            {
                hero.Health -= Damage / 10;
                Console.WriteLine(hero.Health);
            }

            else if (hero1.Damage > sum)
            {
                hero1.Health -= Damage / 10;
                Console.WriteLine(hero1.Health);
            }

            else
            {
                Console.WriteLine("Ошибка: Очень слабый противник!\n +" +
                    $"Пожалей его...!");
            }
        }
    }
}
