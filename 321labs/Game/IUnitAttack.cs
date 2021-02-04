using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IUnitAttack
    {
        public int Damage { get; set; }
        public void Attack();
    }
}
