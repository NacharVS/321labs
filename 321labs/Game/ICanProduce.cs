using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface ICanProduce<T> where T : IUnit
    {
        void Produce(T unit);
    }
}
