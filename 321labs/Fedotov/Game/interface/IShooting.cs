using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IShooting : IAttack
    {
        int Distance { get; set; }
        int Accuracy { get; set; }
    }
}
