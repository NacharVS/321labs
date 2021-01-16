using System;
using System.Threading;
using _321labs.Game;
using _321labs.Koshelev.Thread;

namespace _321labs
{
    class Program
    {
        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] mas3 = new int[10];

        static void Main(string[] args)
        {
            Thread thread = new Thread(() => RandomIntNumForMas1(mas1));
            thread.Start();
            thread = new Thread(() => RandomIntNumForMas1(mas2));
            thread.Start();

        }
        static void RandomIntNumForMas1(int[] mas)
        {
            Random random = new Random();
            lock (new object())
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = random.Next(0, 50);
                }
            }
        }
    }
}
