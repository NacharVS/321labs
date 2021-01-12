using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IShooting : IAttack
    {
        int distance { get; set; }
        int accuracy { get; set; }
    }
}
