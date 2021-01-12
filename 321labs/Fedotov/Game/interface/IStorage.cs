using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IStorage : IStructure
    {
        int capacity { get; set; }
    }
}
