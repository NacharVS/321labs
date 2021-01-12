using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    public interface IAttacker
    {
        public abstract int Attack { get; set; }
        abstract void AttackToPoint(Vector2 position);

    }
}
