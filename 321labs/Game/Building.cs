using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Building : IBuilding
    {
        string IUnit.Name { get; set; }
        int IUnit.Health { get; set; }
        int IUnit.Vision { get; set; }
        int IUnit.NightVision { get; set; }
        int IUnit.Armor { get; set; }
        int IUnit.Damage { get; set; }
        int IUnit.AttackRange { get; set; }
    

      

        void IUnit.Shoot()
        {
            Console.WriteLine("Строение стреляет");
        }
        public Building(string Name, int Health, int Vision, int NightVision, int Armor, int Damage, int AttackRange)
        {

        }
    }
}
