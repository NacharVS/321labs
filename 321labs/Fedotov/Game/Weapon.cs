using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Fedotov.Game
{
    class Weapon
    {
        private string Name { get; set; }
        private int BulletInTheHolder { get; set; }
        private int CountHolder { get; set; }
        private int Durability { get; set; }
        private TimeSpan ReloadTime { get; set; }
        private int Cost { get; set; }
        int Damage { get; set; }

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
