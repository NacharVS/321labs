using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Sudakov
{
    interface IUnit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public int MoveSpeed { get; set; }

        public void DoDamage();
        public void Move();
    }
}
