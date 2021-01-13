using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IAttack
    {
        int Damage { get; set; }

        void TakeDamage();
    }
}
