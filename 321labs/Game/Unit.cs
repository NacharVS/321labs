using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Unit
    {
        public int Armor { get; set; }
        //int Damage { get; set; }
        public int Range { get; set; }
        public int Sight { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        //int Speed { get; set; }
        public Unit(string name, int level, int hp, int armor, int range, int sight)
        {
            this.Armor = armor;
            //this.Damage = damage;
            this.Range = range;
            this.Sight = sight;
            //this.Speed = speed;
            this.Name = name;
            this.Level = level;
            this.Hp = hp;
        }

    }
}
