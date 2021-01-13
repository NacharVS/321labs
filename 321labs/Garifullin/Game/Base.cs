using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class Base : Unit, IBuilding, IBase
    {
        public static int pos;
        public int Defence { get; set; }

        public Base(int phealth, int pexperience, int pposition, string pname, int pdefence) : base(phealth, pexperience, pposition, pname)
        {
            this.Defence = pdefence * 2;
            this.Health = pdefence;
            pos = pposition;
            Console.WriteLine("База построена");
        }
        public void HealUnit()
        {
            int heal = 100;
            Archer archer = new Archer(heal, 0, pos, "", 10);
            this.Health -= heal;
        }
    }
}
