using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.Ydin321.AsyncStart
{
    class AsyncStart
    {
        static int[] args0 = new int[10];
        static int[] args1 = new int[10];
        static int[] args2 = new int[10];

        public static void AsyncMethodsMain()
        {
            AsyncMain();
            Thread.Sleep(2000);
            foreach (var item in args2)
            {
                Console.WriteLine(item);
            }
        }
    }
    

