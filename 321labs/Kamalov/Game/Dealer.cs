using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Kamalov.Game
{
    class Dealer:Hero,IBuy
    {
        public Dealer(int health,
            int speed,
            string name,
            int damage) : base(health, speed, name, damage)
        {
            this.Health = health;
            this.Speed = speed;
            this.Name = name;
            this.Damage = damage;
            Console.WriteLine($"Создан персонаж класса Dealer. Его имя: {Name}");
        }

        public void Buy(Hero hero)
        {
            Console.WriteLine($"{Name} продал вещи {this.Name}");
        }
    }
}
