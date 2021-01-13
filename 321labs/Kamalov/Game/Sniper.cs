using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class Sniper:Hero, IRun, IShoot
    {
        public Sniper(int health,
            int speed, 
            string name, 
            int damage) : base(health, speed, name, damage)
        {

        }

        public void Run()
        {
            Console.WriteLine($"Герой класса Sniper переместился по координатам: x - {0}; y - {1} ");
        }

        public void ShootEnemy()
        {
           // if (Hero.)
        }
    }
}
