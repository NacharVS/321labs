using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class ElectricTower : Hero, IShoot, IHeal
    {
        public ElectricTower(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine("Создан персонаж класса ElectricTower");
        }

        public void Heal(Hero hero1)
        {
            if (this.Health < 50)
            {
                do
                {
                    Thread.Sleep(5000);
                    this.Health += 50;
                    Console.WriteLine($"Здоровье у {this.Name} восстановлена до {this.Health}");
                }
                while (this.Health > 90);
            }
            else
            {
                Console.WriteLine($"Невозможно использовать Heal на {this.Name}, у него HP больше 30");
            }
        }

        public void Shoot(Hero hero)
        {

            for (int i = 0; i < 3; i++)
            {

                double sum = this.Damage / 2;
                if (this.Health == 10)
                    break;
                if (this.Damage > sum)
                {
                    Console.WriteLine("Использована способность Shoot");
                    this.Health -= this.Damage;
                    Console.WriteLine($"Врагу было нанесено: {this.Damage} урона. У врага осталось: {this.Health}");
                    Console.WriteLine($"{this.Name} замедлен из-за напряжения!!");
                    if (this.Health < 0)
                    {
                        Console.WriteLine($"{hero.Name} мертв");
                    }
                }

                else
                {
                    Console.WriteLine("Ошибка: Очень слабый противник!");
                }
            }
        }
    }
}