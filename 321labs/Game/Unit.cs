using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Game
{
    class Unit
    {
        private int hp;
        private int defence;
        private int range;
        private int damage;
        private int speed;

        public int Hp { get => hp; set => hp = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Range { get => range; set => range = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Speed { get => speed; set => speed = value; }

        public Unit(int hp, int defence, int range, int damage, int speed)
        {
            this.hp = hp;
            this.defence = defence;
            this.range = range;
            this.damage = damage;
            this.speed = speed;
        }
    }
}
