using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class FireTower:StaticHero, IShoot, IHeal
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

        public void Heal(Hero hero1)
        {
            if (hero1.Health < 30)
            {
                Thread.Sleep(5000);
                hero1.Health += 30;
                Console.WriteLine($"Здоровье у {Name} восстановлена до {hero1.Health}");
            }
            else
            {
                Console.WriteLine($"Невозможно использовать Heal на {hero1.Name}, у него HP больше 30");
            }
        }

        public void Shoot(Hero hero)
        {
            {
                double sum = this.Damage / 2;

                if (this.Damage > sum)
                {
                    Console.WriteLine("Использована способность Shoot");
                    this.Damage = this.Damage / 8;
                    this.Health = this.Health - this.Damage;
                    Console.WriteLine($"Врагу было нанесено: {this.Damage} урона. У врага осталось: {this.Health}");
                }

                else
                {
                    Console.WriteLine("Ошибка: Очень слабый противник!");
                }

            }
        }
    }
}
   

