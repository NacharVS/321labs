using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    public interface IMoveable
    {
        public abstract float Speed { get; set; }
        public abstract bool CanMoveToPoint(Vector2 position);
        public abstract void MoveToPoint(Vector2 position);
        public abstract float ToPointDist(Vector2 position); 
    }
}
