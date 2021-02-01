using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Weapon
    {
        public string Name { get; set; }
        public int BulletInTheHolder { get; set; }
        public int CountHolder { get; set; }
        public int Durability { get; set; }
        public TimeSpan ReloadTime { get; set; }
        public int Cost { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int bulletInTheHolder, int countHolder, int durability, TimeSpan reloadTime, int cost, int damage)
        {
            Name = name;
            BulletInTheHolder = bulletInTheHolder;
            CountHolder = countHolder;
            Durability = durability;
            ReloadTime = reloadTime;
            Cost = cost;
            Damage = damage;
        }
    }
}
