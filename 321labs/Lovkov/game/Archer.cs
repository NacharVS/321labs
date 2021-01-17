using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class Archer : GoUnit, IUnitAttack, IUnitMove
    {

        public int Damage { get; set; }

        public Archer(string name, int level, int damage, int hp, int armor, int range, int sight, int speed) : base(name, level, hp, armor, range, sight, speed)
        {
            this.Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Выстрелил во врага. Сила атакаи равна {Damage}");
        }
        override public void Move()
        {
            base.Move();
        }

        public void FireShot()
        {
            Console.WriteLine("Лучник выстрелил огненой стрелой");
        }
    }
}
