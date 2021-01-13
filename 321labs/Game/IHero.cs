using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IHero : IUnit
    {
        public int MoveSpeed
        {
            get;
            set;
        }
        public void Move();
    }
}
