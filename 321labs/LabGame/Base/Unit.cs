using System;
using System.Numerics;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame.Base
{
    public abstract class Unit
    {
        protected static List<Unit> units = new List<Unit>();
        public abstract string Name { get; set; }
        public abstract Vector2 UnitPosition { get; set; }
        public abstract int HealthPoint { get; set; }
        public abstract int Defense { get; set; }

        public abstract int Stealth { get; set; }
        public abstract double Range { get; set; }
        
        public abstract double Size { get; set; }
        public abstract Color Color { get; set; }
        public abstract bool InRange(Vector2 position);
        public abstract bool InSize(Vector2 position);
    }
}
