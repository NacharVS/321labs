using System;
using System.Numerics;

namespace _321labs.LabGame.Base
{
    interface IBlinkeable
    {
        public void Blink(Vector2 position);
        public bool CanBlink(Vector2 position);
    }
}
