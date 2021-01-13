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
            
        }

        public void Run(int x, int y)
        {
            Console.WriteLine($"Герой класса Sniper переместился по координатам: x - {0}; y - {1} ");
        }

        public void Shoot(DynamicHero hero, StaticHero hero1)
        {
            double sum = Damage / 5.0;
            if (hero.Damage > sum )
            {
                hero.Health -= Damage / 5;
                Console.WriteLine(hero.Health);
            }

            else if(hero1.Damage > sum)
            {
                hero1.Health -= Damage / 5;
                Console.WriteLine(hero1.Health);
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