using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class Courier : Hero, IFly, IStop
    {
        public Courier(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine("Создан персонаж класса Courier");
        }

        public void Fly(int x, int y)
        {
            Speed += 30;
            Console.WriteLine("Увеличена скорость");
            Console.WriteLine("Курьер прибыл на заданное место\n" +
            $"Теперь он находится в x - {x}, y - {y}");
        }


        public void Stop(Hero hero1)
        {
            hero1.Speed = 0;
            Console.WriteLine($"Персонаж {hero1.Name} остановился");
        }
    }
}
