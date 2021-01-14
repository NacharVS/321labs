using System;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class DefenseTower:StaticHero, IShoot, IHeal
    {
        public DefenseTower(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
        }

        public void Heal(StaticHero hero1)
        {
            if (hero1.Health<30)
            {
                Thread.Sleep(5000);
                hero1.Health += 30;
            }
        }

        public void Shoot(DynamicHero hero, StaticHero hero1)
        {
            double sum = Damage / 10;
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