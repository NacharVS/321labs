using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    interface IWorker
    {
        public int WorkPower { get; set; }
        public void Improve(Building building);
    }
}
