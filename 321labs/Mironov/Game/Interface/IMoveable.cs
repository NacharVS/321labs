using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game
{
    interface IMoveable
    {
        public int Speed { get; set; }
        public void Move(int X,int Y);
        public void MoveStop();
    }
}
