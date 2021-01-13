using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class Farm : Unit
    {
        public Farm(int phealth, int pexperience, int pposition, string pname) : base(phealth, pexperience, pposition, pname)
        {
            Console.WriteLine("Ферма построена");
        }

    }
}
