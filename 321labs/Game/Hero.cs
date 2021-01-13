using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Hero : IHero
    {

        string IUnit.Name { get; set; }
        int IUnit.Health { get; set; }
        int IUnit.Vision { get; set; }
        int IUnit.NightVision { get; set; }
        int IUnit.Armor { get; set; }
        int IUnit.Damage { get; set; }
        int IUnit.AttackRange { get; set; }
        
        int IHero.MoveSpeed { get; set; }

        void IHero.Move()
        {
            Console.WriteLine("Челик ходит");
        }

        void IUnit.Shoot()
        {
            Console.WriteLine("Челик стреляет");
        }
        public Hero()
        {

        }
        public Hero(string Name, int Health, int Vision, int NightVision, int Armor, int Damage, int AttackRange, int MoveSpeed)
        {
            
        }
    }
}
