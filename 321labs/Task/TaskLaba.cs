using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _321labs.TaskLaba3
{
    class TaskLaba
    {
         public static void MainTask()
        {
            int[] a = { 1, 2, 3, 4, 6, 5 };
            Laba3 laba = new Laba3(a);
            Task t1 = new Task(()=>Summ(laba));
            t1.Start();
            t1.Wait();
            Task t2 = new Task(()=>Max(laba));
            t2.Start();
            t2.Wait();
            Task t3 = new Task(()=>Sort(laba));
            t3.Start();
            t3.Wait();

        }
        static void Summ(object obj)
        {
            if (obj is Laba3 laba)
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
            if (obj is Laba3 laba)
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
            if (obj is Laba3 laba)
            {
                Array.Sort(laba.a);
                Console.Write("Сортировка ");
                foreach (var item in laba.a)
                {
                    Console.Write(item + " ");
                }
            }
        }
        class Laba3
        {
            public int[] a;
            public Laba3(int[] a)
            {
                this.a = a;
            }
        }
    }
}
