using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game
{
    interface IRangeAttacker
    {
        public int Range { get; set; }
        public int Damage { get; set; }
        public void RangedAttack();

    }
}
