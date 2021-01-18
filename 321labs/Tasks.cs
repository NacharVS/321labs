using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs
{
    class Tasks
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
                    Console.WriteLine($"Сумма {i + 1} элементов равны: {mass3[i]}");
                    
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
                    
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            object locker = new object();

            Task task = new Task(() =>
            {
                lock (locker)
                {
                    Random rand = new Random();

                    for (int i = 0; i < mass.Length; i++)
                    {
                        mass[i] = rand.Next(0, 20);
                        Console.WriteLine($"{i + 1} элемент первого массива равен {mass[i]}");

                    }
                }
            });

            Task task2 = new Task(() =>
            {

                Random rand = new Random();

                for (int i = 0; i < mass2.Length; i++)
                {
                    mass2[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i + 1} элемент второго массива равен {mass2[i]}");

                }
                Console.WriteLine();

            });

            Task task3 = new Task(() =>
            {

                for (int i = 0; i < mass3.Length; i++)
                {
                    mass3[i] = mass[i] + mass2[i];
                    Console.WriteLine($"Сумма {i + 1} элементов равны: {mass3[i]}");

                }

            });

            task.Start();
            task2.Start();
            task3.Start();
            task.Wait();
            task2.Wait();
            task3.Wait();
        }
    }
}
