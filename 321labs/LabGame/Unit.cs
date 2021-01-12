using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame
{
    abstract class Unit
    {
        public abstract position UnitPosition { get; set; }
        public abstract float HealthPoint { get; set; }
        public abstract float Defense { get; set; }
        public abstract float Attack { get; set; }

        public abstract float Range { get; set; }

        public abstract bool InRange(position position);
    }
}
