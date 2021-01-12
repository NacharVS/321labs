using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame
{
    abstract class Unit
    {
        public abstract Vector2 UnitPosition { get; set; }
        public abstract float HealthPoint { get; set; }
        public abstract float Defense { get; set; }
        public abstract float Attack { get; set; }
        public abstract double Range { get; set; }
        public abstract bool InRange(Vector2 position);
    }
}
