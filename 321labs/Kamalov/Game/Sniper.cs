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
            Console.WriteLine("Использовано умение <=>Shoot<=>");
            double sum = Damage / 5.0;
            if (hero.Damage > sum )
            {
                hero.Health -= Damage / 5;
                Console.WriteLine($"Теперь у противника: {hero.Health}");
            }

            else
            {
                Console.WriteLine("Ошибка: Очень слабый противник!\n +" +
                    $"Пожалей его...!");
            }
        }

        public void Stop(DynamicHero hero)
        {
            hero.Speed = 0;
            Console.WriteLine($"Персонаж {hero.Name} остановился");
        }
    }
}