using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Garifullin.Game
{
    abstract class Unit : IUnit
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Position { get; set; }
        public Unit(int phealth, int pexperience, int pposition, string pname)
        {
            this.Health = phealth;
            this.Experience = pexperience;
            this.Name = pname;
            this.Position = pposition;
            Console.WriteLine("Юнит добавлен на поле боя");
        }
    }
}
