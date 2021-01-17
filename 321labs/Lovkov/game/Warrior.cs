using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class Warrior : GoUnit, IUnitAttack, IUnitMove
    {
        public int Damage { get; set; }

        public Warrior(string name, int level, int damage, int hp, int armor, int range, int sight, int speed) : base(name, level, hp, armor, range, sight, speed)
        {
            this.Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Ударил врага. Сила атакаи равна {Damage}");
        }
        override public void Move()
        {
            base.Move();
        }

        public void DoubleAttack()
        {
            Console.WriteLine("Воин совершил двойную атаку");
        }

    }
}
