using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    public interface IUnit
    {
        public void Move();
        public void Attack(object unit);
        public void Teleport();
    }
}
