using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Fedotov
{
    class ThreadLocker
    {
        static int[] array1;
        static int[] array2;
        static int[] array3;

        static public void Start()
        {
            Thread thread1 = new Thread(() => GenericArray(array1)); 
            Thread thread2 = new Thread(() => GenericArray(array2));
            Thread thread3 = new Thread(() => Summ(array1, array2));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        void GenericArray(int[] mass)
        {
            lock (new object())
            {
                Random rnd = new Random();
                mass = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    mass[i] = rnd.Next(0, 100);
                }
            }
        }

        
    }
}
