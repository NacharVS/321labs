using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    abstract class Unit
    {
        protected Unit(int LVL, string Name)
        {
            this.LVL = LVL;
            this.Name = Name;
        }
        
        abstract protected int PowerCoef { get; }
        abstract protected int AggilityCoef { get; }
        abstract protected int DefenseCoef { get; }
        abstract protected int MaxHealthCoef { get; }

        abstract public int LVL { get; set; }
        abstract public int Exp { get; set; }
        abstract public string Name { get; set; }
        abstract public int MaxHealth { get; }
        abstract public int Health{get; set;}
        abstract public int Power { get;  }
        abstract public int Aggility { get;  }
        abstract public int Defense { get;  }
        abstract public void GetDamage(int Damage);
    }
}
