using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface ILife
    {
        bool flagLive { get; set; }
        int health { get; set; }
    }
}
