using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface ICanAttack : IUnit
    {
        int Damage { get; }
        double TimeBetweenAttacks { get; }
        int AttackRange { get;}

        void Attack(IUnit attacked);
    }
}
