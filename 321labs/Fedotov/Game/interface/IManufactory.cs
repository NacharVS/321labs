using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    interface IManufactory : IStructure
    {
        int countWorker { get; set; }
    }
}
