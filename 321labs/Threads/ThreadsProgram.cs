﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _321labs.Threads
{
    class ThreadsProgram
    {
        static void Main(string[] args)
        {
            int[] a =  {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        }
        class Class2
        {
            public int[] a;
            public Class2(int [] a)
            {
                this.a = a;
            }
        }
        static void Tr()
        {
            Thread Thread1 = new Thread(new ParameterizedThreadStart(Summ));
            Thread1.Start();
            Thread Thread2 = new Thread(new ParameterizedThreadStart(Max));
            Thread2.Start();
            Thread Thread3 = new Thread(new ParameterizedThreadStart(Sort));
            Thread3.Start();
        }
        static void Summ(object obj)
        {
            if (obj is  Class2 class2 )
            {
                int summ = class2.a[0];
                foreach (var item in class2.a)
                {
                    summ += item;
                }
                Console.WriteLine($"Сумма: {summ}");
            }
        }
        static void Max(object obj)
        {
            if (obj is Class2 class2)
            {
                int max = class2.a[0];
                foreach (var item in class2.a )
                {
                    max = item;
                }
                Console.WriteLine($"Сумма: {max}");
            }
        }
        static void Sort(object obj)
        {
            if (obj is Class2 class2)
            {
                Array.Sort(class2.a);

                foreach (var item in class2.a)
                {
                    Console.WriteLine($"Сортировка: {item + " "}");
                }
               
            }
        }

    }
}
