using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _321labs.Game
{
    class Archer : Unit, IArcher
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public int Dexterity { get; set; }
        public Archer(int hp, int defence, int range, int damage, int speed) : base(hp, defence, range, damage, speed)
        {

        }

        public void Hike()
        {
            this.Speed += 40;
        }

        public void UpDamage()
        {
            this.Damage += 100;
        }
    }
}
