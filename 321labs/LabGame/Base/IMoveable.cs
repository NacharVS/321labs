using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    public interface IMoveable
    {
        abstract bool CanMoveToPoint(Vector2 position);

        abstract void MoveToPoint(Vector2 position);
    }
}
