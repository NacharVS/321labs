using System;

namespace _321labs.Kamalov.Game
{
    class Sniper:DynamicHero, IRun, IShoot, IStop
    {
        public Sniper(int health,
            int speed, 
            string name, 
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine($"Создан персонаж класса Sniper. Его имя: {Name}");
        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"Герой класса Sniper переместился по координатам: x - {x}; y - {y} ");
        }

        public void Shoot(Hero hero)
        {
            double sum = this.Damage / 2;
            if (this.Damage > sum)
            {
                Console.WriteLine("Использована способность Shoot");
                this.Damage = this.Damage / 2;
                this.Health = this.Health - this.Damage;
                Console.WriteLine($"Врагу было нанесено: {this.Damage} урона. У врага осталось: {this.Health}");
            }

            else
            {
                Console.WriteLine("Ошибка: Очень слабый противник!");
            }
        }

        public void Stop(DynamicHero hero)
        {
            this.Speed = 0;
            Console.WriteLine($"Персонаж {this.Name} остановился");
        }
    }
}