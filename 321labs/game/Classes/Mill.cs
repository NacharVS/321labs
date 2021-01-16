using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Mill : Building, IGrinding
    {
        static int wheat;

        public static int Wheat { get => wheat; set => wheat = value; }

        public Mill(int hp, int armor, int strenght) : base(hp, armor, strenght)
        {
            this.Strenght = 0;
        }

        public void Grinding(int wheat)
        {
            Mill.Wheat -= wheat;
            if (wheat % 3 == 1)
            {
                wheat--;
            }
            else if (wheat % 3 == 2)
            {
                wheat--;
                wheat--;
            }
            int flour = wheat / 3;

            Bakery.Flour += flour;
            Console.WriteLine($"Мельница {Title} помола пшеницу");
        }
    }
}
