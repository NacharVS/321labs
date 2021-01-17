using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class ArcherTower : StayUnit, IUnitAttack
    {
        public int Damage { get; set; }
        public ArcherTower(string name, int level, int hp, int damage, int armor, int range, int sight) : base(name, level, hp, armor, range, sight)
        {
            this.Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine($"Выстрелил во врага. Сила атакаи равна {Damage}");

        }
        public void DoubleRange()
        {
            Console.WriteLine("Дальность башни увеличилась в двое");
        }
    }
}
