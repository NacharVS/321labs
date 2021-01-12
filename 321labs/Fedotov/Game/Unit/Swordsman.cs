using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Swordsman : ILife, IMove, IAttack
    {
        public bool flagLive { get; set; }
        public int health { get; set; }
        public int speedMove { get; set; }
        public int agilityMove { get; set; }
        public int damage { get; set; }

        public void StopMove()
        {
            Console.WriteLine("Стоит");
        }

        public void StartMove()
        {
            Console.WriteLine("Идет");
        }

        public void TakeDamage()
        {
            Console.WriteLine("Удар мечом");
        }
    }
}
