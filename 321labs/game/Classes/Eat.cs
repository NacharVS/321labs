using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    static class Eat
    {
        static int count;
        static int increaseHealth;

        public static int Count { get => count; set => count = value; }
        public static int IncreaseHealth { get => increaseHealth; set => increaseHealth = value; }
    }
}
