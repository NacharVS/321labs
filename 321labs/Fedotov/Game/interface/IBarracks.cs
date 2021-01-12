using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IBarracks : IStructure
    {
        int countLife { get; set; }
    }
}
