using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.Lovkov.game
{
    class Mill : StayUnit
    {
        public Mill(string name, int level, int hp, int armor, int range, int sight) : base(name, level, hp, armor, range, sight)
        {

        }

        public void Farm()
        {
            Console.WriteLine("Мельница произвела провизию");
        }
    }
}
