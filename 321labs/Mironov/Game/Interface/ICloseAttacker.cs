using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game
{
    interface ICloseAttacker
    {
        public int Damage { get; set; }

        public void CloseAttack();

    }
}
