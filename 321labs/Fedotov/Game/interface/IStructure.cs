using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IStructure
    {
        int durability { get; set; }
        int destroyed { get; set; }
    }
}
