using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class CrossbowCannon : ILife, IStructure, IAttack
    {
        public bool flagLive { get; set; }
        public int health { get; set; }
        public int durability { get; set; }
        public int destroyed { get; set; }
        public int damage { get; set; }

        public void TakeDamage()
        {
            Console.WriteLine("Выстрел из Арбалетной бушки");
        }
    }
}
