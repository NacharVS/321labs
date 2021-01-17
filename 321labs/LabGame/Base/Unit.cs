using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace _321labs.LabGame.Base
{
    public abstract class Unit
    {
        protected static List<Unit> units = new List<Unit>();
        public abstract Vector2 UnitPosition { get; set; }
        public abstract string Name { get; set; }
        public abstract int MaxHeathPoints { get; set; }
        public abstract int HealthPoints { get; set; }
        public abstract int Defense { get; set; }
        public abstract float Stealth { get; set; }
        public abstract float Range { get; set; }
        public abstract float Size { get; set; }
        public abstract bool InRange(Vector2 position);
        public abstract bool InSize(Vector2 position);
        public abstract void GetDamage(int Damage);
        public abstract void GetHeal(int Heal);
        public abstract string ScanInfo();
    }
}
