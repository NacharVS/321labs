using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Kamalov.Game
{
    class Courier:DynamicHero, IFly, IStop
    {
        public Courier(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {

        }

        public void Fly(int x, int y)
        {
            Speed += 30;
            Console.WriteLine("Увеличена скорость");
            Console.WriteLine("Курьер прибыл на заданное место\n"+
            $"Теперь он находится в x - {x}, y - {y}");
        }


        public void Stop(DynamicHero hero1)
        {
            hero1.Speed = 0;
            Console.WriteLine($"Персонаж {hero1.Name} остановился");
        }
    }
}
