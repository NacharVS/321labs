using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IAttack
    {
        Weapon weapon { get; set; }

        void TakeDamage();
    }
}
