using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    class Turret : Unit, ITurret 
    {
        public int Range { get; set; }
        public int Damage { get; set; }
        public Turret(int phealth, int pexperience, int pposition, string pname, int prange, int pdamage) : base(phealth, pexperience, pposition, pname)
        {
            this.Range = prange;
            this.Damage = pdamage;
            Console.WriteLine("Турель построена");
        }
        public void Attack(Unit target)
        {
            if(Survey(target))
            {
                target.Health -= Damage;
                
            }
            else
            {
                Console.WriteLine("Цель далеко");
            }
        }
        private bool Survey(Unit unit)
        {
            int distance = Position - unit.Position;
            if (distance > Range)
            {
                return false;
            }
            return true;
        }
    }
}
