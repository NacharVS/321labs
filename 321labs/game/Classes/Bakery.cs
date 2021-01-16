using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Bakery : Building
    {
        static int flour;

        public static int Flour { get => flour; set => flour = value; }

        public Bakery(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {

        }

        public static void Bake(int flour)
        {
            Bakery.Flour -= flour;
            Eat.Count += flour * 2;
            Console.WriteLine($"Пекарня испекла: {flour * 2} еды.");
        }
    }
}
