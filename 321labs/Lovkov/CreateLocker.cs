using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Lovkov
{
    class CreateLocker
    {
        static int[] mass = new int[10];
        static int[] mass2 = new int[10];
        static int[] mass3 = new int[10];
        private static object locker = new object();
        public void MassSum()
        {
            lock (locker)
            {
                for (int i = 0; i < mass3.Length; i++)
                {
                    mass3[i] = mass[i] + mass2[i];
                    Console.WriteLine($"Сумма {i + 1} элементов равна: {mass3[i]}");
                    Thread.Sleep(50);
                }
            }
        }
        public void RandomMass()
        {
            lock (locker)
            {
                Random rand = new Random();

                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент первого массива равен {mass[i]}");
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
        }
        public void RandomMass2()
        {
            lock (locker)
            {
                Random rand = new Random();

                for (int i = 0; i < mass2.Length; i++)
                {
                    mass2[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент второго массива равен {mass2[i]}");
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }
        }
    }
}

