using System;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class DefenseTower : Hero, IShoot, IHeal
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

        public void Heal(Hero hero)
        {
            if (hero.Health < 30)
            {
                Thread.Sleep(5000);
                hero.Health += 30;
            }
        }

        public void Shoot(Hero hero)
        {
            double sum = Damage / 10;
            if (hero.Damage > sum)
            {
                hero.Health -= Damage / 10;
                Console.WriteLine(hero.Health);
            }

            else
            {
                Console.WriteLine("Ошибка: Очень слабый противник!\n +" +
                    $"Пожалей его...!");
            }
        }

    }
}