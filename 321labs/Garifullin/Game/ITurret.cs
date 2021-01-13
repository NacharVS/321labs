using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    interface ITurret
    {
        public int Range { get; set; }
        public int Damage { get; set; }
        public void Attack(Unit target);
    }
}
