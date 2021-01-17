using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace _321labs.Threads
{
     public class Laba2
    {
        public static void MainLaba2()
        {
            int[] a = { 1, 2, 3, 4, 6, 5 };
            Laba laba = new Laba(a);
            Thread thread = new Thread(new ParameterizedThreadStart(Summ));
            thread.Start(laba);
            Thread thread01 = new Thread(new ParameterizedThreadStart(Max));
            thread01.Start(laba);
            Thread thread02 = new Thread(new ParameterizedThreadStart(Sort));
            thread02.Start(laba);
        }
        static void Summ(object obj)
        {
            if (obj is Laba laba)
            {
                int summ = 0;
                foreach (var item in laba.a)
                {
                    summ += item;

                }
                Console.WriteLine($"Сумма {summ}");
            }


            
        }
        static void Max(object obj)
        {
            if (obj is Laba laba)
            {
                int x = laba.a[0];
                foreach (var item in laba.a)
                {
                    if (x < item)
                    {
                        x = item;
                    }
                }
                Console.WriteLine($" Max {x}");
            }

        }
        static void Sort(object obj)
        {
            if (obj is Laba laba)
            {
                Array.Sort(laba.a);
                Console.Write("Сортировка ");
                foreach (var item in laba.a)
                {
                    Console.Write(item+" ");
                }
            }
        }
        class Laba
        {
            public int[] a;
            public Laba(int[] a)
            {
                this.a = a;
            }
        }

    }
   
}
