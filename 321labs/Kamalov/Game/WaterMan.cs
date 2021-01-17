using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class WaterMan : Hero, IShoot, IRun, IHeal
    {
        public WaterMan(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine($"Создан персонаж класса WaterMan. Его имя: {Name}");
        }

        public void Heal(Hero hero)
        {
            if (hero.Health < 10)
            {
                Thread.Sleep(5000);
                hero.Health += 30;
            }
        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"{this.Name} утек по координатам {x}:{y}");
        }

        public void Shoot(Hero hero)
        {
            double sum = this.Damage / 2;
            if (this.Damage > sum)
            {
                Console.WriteLine("Использована способность WaterAmmo");
                this.Damage = this.Damage / 2;
                this.Health = this.Health - this.Damage;
                Console.WriteLine($"Врагу было нанесено: {this.Damage} урона водяными пулями. У врага осталось: {this.Health} HP");
            }

            else
            {
                Console.WriteLine("Мои пули ему ни к чему, он и так скоро умрет...");
            }
        }
    }
}
