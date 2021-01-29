using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _321labs.AsyncMethods
{
    class AsyncMethodsProgram
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

        public static async void AsyncMain()
        {
            await Task.Run(()=>GenerateRandomToArray(ref args0));
            await Task.Run(()=>GenerateRandomToArray(ref args1));
            await Task.Run(() => ArraySum());
        }

        static void GenerateRandomToArray(ref int[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = rand.Next(1, 10);
                Console.Write(args[i] + " ");
            }
            Console.WriteLine();
        }

        static void ArraySum()
        {
            for (int i = 0; i < args0.Length; i++)
            {
                args2[i] = args0[i] + args1[i];
            }
        }
    }
}
