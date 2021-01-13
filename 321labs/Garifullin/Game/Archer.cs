using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class Archer : Unit
    {
        public int Range { get; set; }

        public Archer(int phealth, int pexperience, int pposition, string pname, int prange) : base(phealth, pexperience, pposition, pname)
        {
            this.Range = prange
        }
    }
}
