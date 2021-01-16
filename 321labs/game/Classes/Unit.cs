using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Unit : IDied
    {
        string title;
        int hp;
        int armor;
        int strenght;
        int x;
        int y;

        public string Title { get => title; set => title = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Strenght { get => strenght; set => strenght = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Unit(int hp, int armor, int strenght)
        {
            this.Hp = hp;
            this.Armor = armor;
            this.Strenght = strenght;

            Thread threadCheck = new Thread(new ThreadStart(Checking));
            threadCheck.Start();
        }

        public void Died()
        {
            this.Hp = 0;
        }

        void Checking()
        {
            while (true)
            {
                if (this.Hp <= 0)
                {
                    Console.WriteLine($"{this.Title} уничтожен");
                }
            }
        }
    }
}
