using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace _321labs.game
{
    class Wheat
    {
        static int count;
        int hp = 10;
        int x;
        int y;
        int height; // В сантиметрах

        public int Hp { get => hp; set => hp = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public static int Count { get => count; set => count = value; }

        public Wheat(int hp, int x, int y)
        {
            this.Hp = hp;
            this.X = x;
            this.Y = y;

            Thread growingWheat = new Thread(new ThreadStart(Growing));
            growingWheat.Start();
        }

        void Growing()
        {
            for (this.height = 0; ; this.height++)
            {
                Thread.Sleep(5000);
                if ((this.height > 60) && (this.Hp > 0))
                {
                    this.Hp--;
                }
                if (this.Hp == 0)
                {
                    Console.WriteLine("Пшенница умерла.");
                    return;
                }
            }

        }
    }
}