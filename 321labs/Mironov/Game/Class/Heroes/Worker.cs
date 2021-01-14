using _321labs.Mironov.Game.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Mironov.Game
{
    class Worker : IMoveable, ICloseAttacker, IBuilder
    {
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public void CancelBuild()
        {
            throw new NotImplementedException();
        }

        public void CloseAttack()
        {
            throw new NotImplementedException();
        }

        public void Move(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void MoveStop()
        {
            throw new NotImplementedException();
        }
    }
}
