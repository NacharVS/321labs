using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Fedotov
{
    class ThreadLocker
    {
        static int[] array1 = new int[10];
        static int[] array2 = new int[10];
        static int[] array3 = new int[10];
            

        static public void Start()
        {
            Thread thread1 = new Thread(() => GenericArray(array1)); 
            Thread thread2 = new Thread(() => GenericArray(array2));
            Thread thread3 = new Thread(() => Summ(array1, array2, array3));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        static void GenericArray(int[] mass)
        {
            lock(new object())
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
        }

        static void Summ(int[] mass1, int[] mass2, int[] mass3)
        {
            for (int i = 0; i < 10; i++)
            {
                array3[i] = array1[i] + array2[2];
                Console.Write(mass3[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
