using System;
using System.Collections.Generic;
using System.Text;

namespace _321labs
{
    class ThreadLocker
    {
        static int[] mas1 = new int[10];
        static int[] mas2 = new int[10];
        static int[] masResult = new int[10];

        public void Filling()
        {
            Random rand = new Random();
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rand.Next(1,10);
            }
            Console.WriteLine(mas1);
            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = rand.Next(1, 10);
            }
            Console.WriteLine(mas2);
        }

        public void Sum()
        {
            for (int i = 0; i < masResult.Length; i++)
            {
                masResult[i] = mas1[i] + mas2[i];
            }
            Console.WriteLine(masResult);
        }
    }
}
