using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    interface IUnit
    {
        public string Name {get; set;}
        public int Health
        {
            get;
            set;
        }
        public int Vision
        {
            get;
            set;
        }
        public int NightVision
        {
            get;
            set;
        }
        public int Armor
        {
            get;
            set;
        }
        public int Damage
        {
            get;
            set;
        }
        public int AttackRange
        {
            get;
            set;
        }
        

        public void Shoot();
     
    }
}
