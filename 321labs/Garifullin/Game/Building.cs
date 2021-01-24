using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class Building : Unit
    {
        public int Defence { get; set; }
        public Building(int phealth, int pexperience, int pposition, string pname, int pdefence) : base(phealth, pexperience, pposition, pname)
        {
            this.Defence = pdefence;
            this.Health += pdefence;
        }
    }
}
