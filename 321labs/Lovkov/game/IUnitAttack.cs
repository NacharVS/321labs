using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    interface IUnitAttack
    {
        public int Damage { get; set; }
        public void Attack();

    }
}
