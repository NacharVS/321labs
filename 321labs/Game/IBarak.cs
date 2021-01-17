using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface  Ibarak
    {
        int CountLife { get; set; }

        public void Decompose()
        {
            Console.WriteLine("разложена");
        }

        public void Fold()
        {
            Console.WriteLine("сложена");
        }
    }
}
