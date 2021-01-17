using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Ydin321._3Labka
{
    class Locker
    {
        private static object locker = new object();

        static int[] ArrNumbOne = new int[10];
        static int[] ArrNumbTwo = new int[10];
        static int[] sum = new int[10];

        public void First()
        {
            lock (locker)
            {
                Random rand = new Random();

                for (int i = 0; i < ArrNumbOne.Length; i++)
                {
                    ArrNumbOne[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент первого массива {ArrNumbOne[i]}");
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
        }
      
    }
}

