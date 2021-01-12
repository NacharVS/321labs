using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class Unit
    {
        string name { get; set; }
        int health { get; set; }
        int armor { get; set; } //броня
        int damage { get; set; } //урон
        int range { get; set; } //диапазон
        int sight { get; set; } //вид
        int speed { get; set; } //скорость
        public Unit(string name, int health, int armor, int damage, int range, int sight, int speed)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            this.damage = damage;
            this.range = range;
            this.sight = sight;
            this.speed = speed;
        }
        public void ToDamage()
        {

        }
        public void ToMove()
        {

        }
        public void ToDefend()
        {

        }

    }

}
