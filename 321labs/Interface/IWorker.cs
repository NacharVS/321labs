using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    interface IWorker : ICommonUnit
    {
        public void Build();
        public void Repair();
    }
}
