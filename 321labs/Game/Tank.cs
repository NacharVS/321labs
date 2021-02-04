using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Tank : Unit, ITank
    {
        public Tank(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void Agressive(Unit unit)
        {
            Console.WriteLine($"{this.ToString()} attracted attencion {unit.ToString()}");
        }

        public void HighDefence()
        {
            this.Defence += this.Defence;
        }
    }
}
