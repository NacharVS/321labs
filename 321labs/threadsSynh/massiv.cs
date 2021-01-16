using System;
using System.Threading;

namespace _321labs.Synh
{
    class ThreadLocker
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array3 = new int[10];


        static public void Start()
        {
            Thread thread1 = new Thread(() => Randomarray(array1));
            Thread thread2 = new Thread(() => Randomarray(array2));
            Thread thread3 = new Thread(() => Sum(array1, array2, array3));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        static void Randomarray(int[] mass)
        {
            lock (new object())
            {
                Random rnd = new Random();
                Console.WriteLine("Thread");
                for (int i = 0; i < 10; i++)
                {
                    mass[i] = rnd.Next(0, 100);
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
            }
            static void Sum(int[] mass)
            {

                lock (new object()) ;
                {




                }



            }
        }

    }
}





